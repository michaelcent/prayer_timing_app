using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.Linq;
using System.Media;

namespace prayer_timing_app
{
    public partial class MainForm : Form
    {
        private string excelFilePath = "C:\\Users\\M.Centeno\\Desktop\\prayer_timing_app\\worldcities.xlsx";
        private string audioFilePath = "C:\\Users\\M.Centeno\\Desktop\\prayer_timing_app\\PrayerAlarm.wma";

        private ExcelPackage excelPackage;
        private ExcelWorksheet worksheet;
        private bool isMuted = false;
        private SoundPlayer alarmSoundPlayer;

        public MainForm()
        {
            InitializeComponent();

            excelPackage = new ExcelPackage(new FileInfo(excelFilePath));
            worksheet = excelPackage.Workbook.Worksheets[0];
            PopulateCountryComboBox();
            datePicker.ValueChanged += DateTimePicker_ValueChanged;
            countryCombo.SelectedIndexChanged += CountryCombo_SelectedIndexChanged;
            cityCombo.SelectedIndexChanged += CityCombo_SelectedIndexChanged;
            muteButton.Click += MuteButton_Click;
            this.FormClosing += windowLabel_FormClosing;

            //load alarm
            alarmSoundPlayer = new SoundPlayer(audioFilePath);

            // Set the default values for country and city
            countryCombo.SelectedItem = "Canada";
            cityCombo.SelectedItem = "Calgary";

            
            PerformCalculation();
        }

        private void PopulateCountryComboBox()
        {
            var countries = worksheet.Cells[2, 5, worksheet.Dimension.Rows, 5]
                .Select(cell => cell.Value.ToString())
                .Distinct()
                .OrderBy(country => country)
                .ToList();
            countryCombo.Items.AddRange(countries.ToArray());
        }

        private void CountryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = countryCombo.SelectedItem.ToString();
            var cities = worksheet.Cells[2, 1, worksheet.Dimension.Rows, 1]
                .Where(cell => cell.Offset(0, 4).Value.ToString() == selectedCountry)
                .Select(cell => cell.Value.ToString())
                .Distinct()
                .OrderBy(city => city)
                .ToList();
            cityCombo.Items.Clear();
            cityCombo.Items.AddRange(cities.ToArray());

            // Updating city ny user
            if (cities.Contains(cityCombo.SelectedItem))
            {
                // deafult city whenever program is restarted
                cityCombo.SelectedItem = cityCombo.SelectedItem;
            }
            else
            {
                // default the city for calgary to be called
                cityCombo.SelectedItem = cities.FirstOrDefault();
            }

            //restart
            PerformCalculation();
        }

        private void CityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           //restart 
            PerformCalculation();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //restart
            PerformCalculation();
        }

        private void PerformCalculation()
        {
            DateTime selectedDate = datePicker.Value;
            string selectedCountry = countryCombo.SelectedItem.ToString();
            string selectedCity = cityCombo.SelectedItem.ToString();
            double longitude = GetLongitude(selectedCountry, selectedCity);
            double latitude = GetLatitude(selectedCountry, selectedCity);

            string apiUrl = $"https://api.aladhan.com/v1/timings/{selectedDate.Date:yyyy-MM-dd}?latitude={latitude}&longitude={longitude}&method=12";

            string apiResponse;
            using (WebClient client = new WebClient())
            {
                apiResponse = client.DownloadString(apiUrl);
            }

            JObject json = JObject.Parse(apiResponse);
            JToken timings = json["data"]["timings"];
            string fajr = timings["Fajr"].ToString();
            string sunrise = timings["Sunrise"].ToString();
            string dhuhr = timings["Dhuhr"].ToString();
            string asr = timings["Asr"].ToString();
            string maghrib = timings["Maghrib"].ToString();
            string isha = timings["Isha"].ToString();

            fajrLabel.Text = fajr;
            dhuhrLabel.Text = dhuhr;
            asrLabel.Text = asr;
            maghribLabel.Text = maghrib;
            ishaLabel.Text = isha;

            // Play the alarm 
            string currentTime = DateTime.Now.ToString("HH:mm");
            if (!isMuted && (currentTime == fajr || currentTime == dhuhr || currentTime == asr || currentTime == maghrib || currentTime == isha))
            {
                alarmSoundPlayer.Play();
            }
        }

        private double GetLongitude(string country, string city)
        {
            return GetCoordinateValue(country, city, 4);
        }

        private double GetLatitude(string country, string city)
        {
            return GetCoordinateValue(country, city, 3);
        }

        private double GetCoordinateValue(string country, string city, int column)
        {
            int rowIndex = 2;

            while (worksheet.Cells[rowIndex, 5].Value != null)
            {
                string cellCountry = worksheet.Cells[rowIndex, 5].Value.ToString();
                string cellCity = worksheet.Cells[rowIndex, 1].Value.ToString();

                if (cellCountry == country && cellCity == city)
                {
                    double coordinate;
                    if (double.TryParse(worksheet.Cells[rowIndex, column].Value.ToString(), out coordinate))
                    {
                        return coordinate;
                    }
                }
                rowIndex++;
            }
            throw new Exception("Coordinate not found.");
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            isMuted = !isMuted;
            muteButton.Text = isMuted ? "Unmute" : "Mute";
        }

        private void windowLabel_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelPackage.Dispose();
            alarmSoundPlayer.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // setting up the default city and country 
            countryCombo.SelectedItem = "Canada";
            cityCombo.SelectedItem = "Calgary";

            // restet
            PerformCalculation();
        }
    }
}
