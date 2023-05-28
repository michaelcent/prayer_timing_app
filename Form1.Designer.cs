using System;

namespace prayer_timing_app
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
 /*       private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the default values for country and city
            countryCombo.SelectedItem = "Canada";
            cityCombo.SelectedItem = "Calgary";

            // Perform the initial calculation
            PerformCalculation();
        }
 */
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.fajrLabel = new System.Windows.Forms.Label();
            this.dhuhrLabel = new System.Windows.Forms.Label();
            this.asrLabel = new System.Windows.Forms.Label();
            this.maghribLabel = new System.Windows.Forms.Label();
            this.ishaLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laptopDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_Tick = new System.Windows.Forms.Timer(this.components);
            this.muteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryCombo
            // 
            this.countryCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countryCombo.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Location = new System.Drawing.Point(470, 93);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(136, 27);
            this.countryCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sunrise";
            // 
            // cityCombo
            // 
            this.cityCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityCombo.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(624, 93);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.Size = new System.Drawing.Size(136, 27);
            this.cityCombo.TabIndex = 3;
            // 
            // fajrLabel
            // 
            this.fajrLabel.AutoSize = true;
            this.fajrLabel.BackColor = System.Drawing.Color.Transparent;
            this.fajrLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fajrLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fajrLabel.Location = new System.Drawing.Point(48, 351);
            this.fajrLabel.Name = "fajrLabel";
            this.fajrLabel.Size = new System.Drawing.Size(48, 42);
            this.fajrLabel.TabIndex = 5;
            this.fajrLabel.Text = "---";
            // 
            // dhuhrLabel
            // 
            this.dhuhrLabel.AutoSize = true;
            this.dhuhrLabel.BackColor = System.Drawing.Color.Transparent;
            this.dhuhrLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhuhrLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dhuhrLabel.Location = new System.Drawing.Point(210, 351);
            this.dhuhrLabel.Name = "dhuhrLabel";
            this.dhuhrLabel.Size = new System.Drawing.Size(48, 42);
            this.dhuhrLabel.TabIndex = 6;
            this.dhuhrLabel.Text = "---";
            // 
            // asrLabel
            // 
            this.asrLabel.AutoSize = true;
            this.asrLabel.BackColor = System.Drawing.Color.Transparent;
            this.asrLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asrLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.asrLabel.Location = new System.Drawing.Point(357, 351);
            this.asrLabel.Name = "asrLabel";
            this.asrLabel.Size = new System.Drawing.Size(48, 42);
            this.asrLabel.TabIndex = 7;
            this.asrLabel.Text = "---";
            // 
            // maghribLabel
            // 
            this.maghribLabel.AutoSize = true;
            this.maghribLabel.BackColor = System.Drawing.Color.Transparent;
            this.maghribLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maghribLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maghribLabel.Location = new System.Drawing.Point(513, 351);
            this.maghribLabel.Name = "maghribLabel";
            this.maghribLabel.Size = new System.Drawing.Size(48, 42);
            this.maghribLabel.TabIndex = 8;
            this.maghribLabel.Text = "---";
            // 
            // ishaLabel
            // 
            this.ishaLabel.AutoSize = true;
            this.ishaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ishaLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ishaLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ishaLabel.Location = new System.Drawing.Point(672, 351);
            this.ishaLabel.Name = "ishaLabel";
            this.ishaLabel.Size = new System.Drawing.Size(48, 42);
            this.ishaLabel.TabIndex = 9;
            this.ishaLabel.Text = "---";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(24, 93);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(234, 29);
            this.datePicker.TabIndex = 10;
            this.datePicker.Value = new System.DateTime(2023, 5, 25, 12, 43, 41, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(815, 29);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mobileToolStripMenuItem,
            this.ipadToolStripMenuItem,
            this.laptopDesktopToolStripMenuItem});
            this.optionToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // mobileToolStripMenuItem
            // 
            this.mobileToolStripMenuItem.Name = "mobileToolStripMenuItem";
            this.mobileToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.mobileToolStripMenuItem.Text = "Mobile";
            // 
            // ipadToolStripMenuItem
            // 
            this.ipadToolStripMenuItem.Name = "ipadToolStripMenuItem";
            this.ipadToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ipadToolStripMenuItem.Text = "tablet";
            // 
            // laptopDesktopToolStripMenuItem
            // 
            this.laptopDesktopToolStripMenuItem.Name = "laptopDesktopToolStripMenuItem";
            this.laptopDesktopToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.laptopDesktopToolStripMenuItem.Text = "Laptop / desktop";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // muteButton
            // 
            this.muteButton.Location = new System.Drawing.Point(312, 435);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(153, 26);
            this.muteButton.TabIndex = 12;
            this.muteButton.Text = "Mute Alarm";
            this.muteButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fajr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 42);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dhuhr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "Asr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "Maghrib";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(659, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "Isha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 42);
            this.label8.TabIndex = 18;
            this.label8.Text = "Prayers Today";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.BackColor = System.Drawing.Color.Transparent;
            this.currentTime.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(319, 148);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(135, 30);
            this.currentTime.TabIndex = 19;
            this.currentTime.Text = "CurrentTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(309, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "C urrent Time";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 20F;
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.AutoSize = true;
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sunriseLabel.Location = new System.Drawing.Point(64, 224);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(48, 42);
            this.sunriseLabel.TabIndex = 21;
            this.sunriseLabel.Text = "---";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 598);
            this.Controls.Add(this.sunriseLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.ishaLabel);
            this.Controls.Add(this.maghribLabel);
            this.Controls.Add(this.asrLabel);
            this.Controls.Add(this.dhuhrLabel);
            this.Controls.Add(this.fajrLabel);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryCombo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderStyle = Krypton.Toolkit.HeaderStyle.Primary;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "Prayer Times";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cityCombo;
        private System.Windows.Forms.Label fajrLabel;
        private System.Windows.Forms.Label dhuhrLabel;
        private System.Windows.Forms.Label asrLabel;
        private System.Windows.Forms.Label maghribLabel;
        private System.Windows.Forms.Label ishaLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ipadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laptopDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer Timer_Tick;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label sunriseLabel;
    }
}

