namespace ColorDetectionUsingSlider
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBar_HueLow = new System.Windows.Forms.TrackBar();
            this.tBar_HueHigh = new System.Windows.Forms.TrackBar();
            this.tBar_saturationLow = new System.Windows.Forms.TrackBar();
            this.tBar_saturationHigh = new System.Windows.Forms.TrackBar();
            this.tBar_valueHigh = new System.Windows.Forms.TrackBar();
            this.tBar_valueLow = new System.Windows.Forms.TrackBar();
            this.pb_colorDisplay = new System.Windows.Forms.PictureBox();
            this.tBar_Red = new System.Windows.Forms.TrackBar();
            this.tBar_Green = new System.Windows.Forms.TrackBar();
            this.tBar_Blue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_blue = new System.Windows.Forms.TextBox();
            this.tb_green = new System.Windows.Forms.TextBox();
            this.tb_red = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_cHue = new System.Windows.Forms.TextBox();
            this.tb_cSaturation = new System.Windows.Forms.TextBox();
            this.tb_cValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_valuelow = new System.Windows.Forms.TextBox();
            this.tb_saturationlow = new System.Windows.Forms.TextBox();
            this.tb_huelow = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_valuehigh = new System.Windows.Forms.TextBox();
            this.tb_saturationhigh = new System.Windows.Forms.TextBox();
            this.tb_huehigh = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_pickColor = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_bgrPicked = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_HueLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_HueHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_saturationLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_saturationHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_valueHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_valueLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_colorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Blue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1287, 925);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // tBar_HueLow
            // 
            this.tBar_HueLow.Location = new System.Drawing.Point(63, 32);
            this.tBar_HueLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_HueLow.Maximum = 179;
            this.tBar_HueLow.Name = "tBar_HueLow";
            this.tBar_HueLow.Size = new System.Drawing.Size(637, 56);
            this.tBar_HueLow.TabIndex = 1;
            this.tBar_HueLow.Scroll += new System.EventHandler(this.tBar_HueLow_Scroll);
            // 
            // tBar_HueHigh
            // 
            this.tBar_HueHigh.Location = new System.Drawing.Point(47, 32);
            this.tBar_HueHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_HueHigh.Maximum = 179;
            this.tBar_HueHigh.Name = "tBar_HueHigh";
            this.tBar_HueHigh.Size = new System.Drawing.Size(637, 56);
            this.tBar_HueHigh.TabIndex = 2;
            this.tBar_HueHigh.Scroll += new System.EventHandler(this.tBar_HueHigh_Scroll);
            // 
            // tBar_saturationLow
            // 
            this.tBar_saturationLow.Location = new System.Drawing.Point(63, 95);
            this.tBar_saturationLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_saturationLow.Maximum = 255;
            this.tBar_saturationLow.Name = "tBar_saturationLow";
            this.tBar_saturationLow.Size = new System.Drawing.Size(637, 56);
            this.tBar_saturationLow.TabIndex = 3;
            this.tBar_saturationLow.Scroll += new System.EventHandler(this.tBar_saturationLow_Scroll);
            // 
            // tBar_saturationHigh
            // 
            this.tBar_saturationHigh.Location = new System.Drawing.Point(47, 95);
            this.tBar_saturationHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_saturationHigh.Maximum = 255;
            this.tBar_saturationHigh.Name = "tBar_saturationHigh";
            this.tBar_saturationHigh.Size = new System.Drawing.Size(637, 56);
            this.tBar_saturationHigh.TabIndex = 4;
            this.tBar_saturationHigh.Scroll += new System.EventHandler(this.tBar_saturationHigh_Scroll);
            // 
            // tBar_valueHigh
            // 
            this.tBar_valueHigh.Location = new System.Drawing.Point(47, 158);
            this.tBar_valueHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_valueHigh.Maximum = 255;
            this.tBar_valueHigh.Name = "tBar_valueHigh";
            this.tBar_valueHigh.Size = new System.Drawing.Size(637, 56);
            this.tBar_valueHigh.TabIndex = 6;
            this.tBar_valueHigh.Scroll += new System.EventHandler(this.tBar_valueHigh_Scroll);
            // 
            // tBar_valueLow
            // 
            this.tBar_valueLow.Location = new System.Drawing.Point(63, 158);
            this.tBar_valueLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_valueLow.Maximum = 255;
            this.tBar_valueLow.Name = "tBar_valueLow";
            this.tBar_valueLow.Size = new System.Drawing.Size(637, 56);
            this.tBar_valueLow.TabIndex = 5;
            this.tBar_valueLow.Scroll += new System.EventHandler(this.tBar_valueLow_Scroll);
            // 
            // pb_colorDisplay
            // 
            this.pb_colorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_colorDisplay.Location = new System.Drawing.Point(64, 226);
            this.pb_colorDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_colorDisplay.Name = "pb_colorDisplay";
            this.pb_colorDisplay.Size = new System.Drawing.Size(107, 82);
            this.pb_colorDisplay.TabIndex = 7;
            this.pb_colorDisplay.TabStop = false;
            // 
            // tBar_Red
            // 
            this.tBar_Red.Location = new System.Drawing.Point(57, 170);
            this.tBar_Red.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_Red.Maximum = 255;
            this.tBar_Red.Name = "tBar_Red";
            this.tBar_Red.Size = new System.Drawing.Size(637, 56);
            this.tBar_Red.TabIndex = 12;
            this.tBar_Red.Scroll += new System.EventHandler(this.tBar_Red_Scroll);
            // 
            // tBar_Green
            // 
            this.tBar_Green.Location = new System.Drawing.Point(57, 107);
            this.tBar_Green.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_Green.Maximum = 255;
            this.tBar_Green.Name = "tBar_Green";
            this.tBar_Green.Size = new System.Drawing.Size(637, 56);
            this.tBar_Green.TabIndex = 11;
            this.tBar_Green.Scroll += new System.EventHandler(this.tBar_Green_Scroll);
            // 
            // tBar_Blue
            // 
            this.tBar_Blue.Location = new System.Drawing.Point(57, 44);
            this.tBar_Blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBar_Blue.Maximum = 255;
            this.tBar_Blue.Name = "tBar_Blue";
            this.tBar_Blue.Size = new System.Drawing.Size(637, 56);
            this.tBar_Blue.TabIndex = 10;
            this.tBar_Blue.Scroll += new System.EventHandler(this.tBar_Blue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "H";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "S";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "H";
            // 
            // tb_blue
            // 
            this.tb_blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_blue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_blue.Location = new System.Drawing.Point(704, 46);
            this.tb_blue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(91, 35);
            this.tb_blue.TabIndex = 22;
            this.tb_blue.Text = "0";
            this.tb_blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_blue.TextChanged += new System.EventHandler(this.tb_blue_TextChanged);
            // 
            // tb_green
            // 
            this.tb_green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_green.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_green.Location = new System.Drawing.Point(704, 105);
            this.tb_green.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(91, 35);
            this.tb_green.TabIndex = 23;
            this.tb_green.Text = "0";
            this.tb_green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_green.TextChanged += new System.EventHandler(this.tb_green_TextChanged);
            // 
            // tb_red
            // 
            this.tb_red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_red.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_red.Location = new System.Drawing.Point(703, 161);
            this.tb_red.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(91, 35);
            this.tb_red.TabIndex = 24;
            this.tb_red.Text = "0";
            this.tb_red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_red.TextChanged += new System.EventHandler(this.tb_red_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(197, 241);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 26);
            this.label12.TabIndex = 25;
            this.label12.Text = "Hue:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(364, 241);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 26);
            this.label13.TabIndex = 26;
            this.label13.Text = "Saturation:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(593, 241);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 26);
            this.label14.TabIndex = 27;
            this.label14.Text = "Value:";
            // 
            // tb_cHue
            // 
            this.tb_cHue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cHue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cHue.Location = new System.Drawing.Point(264, 239);
            this.tb_cHue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cHue.Name = "tb_cHue";
            this.tb_cHue.Size = new System.Drawing.Size(63, 35);
            this.tb_cHue.TabIndex = 28;
            this.tb_cHue.Text = "0";
            this.tb_cHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cSaturation
            // 
            this.tb_cSaturation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cSaturation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cSaturation.Location = new System.Drawing.Point(507, 239);
            this.tb_cSaturation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cSaturation.Name = "tb_cSaturation";
            this.tb_cSaturation.Size = new System.Drawing.Size(63, 35);
            this.tb_cSaturation.TabIndex = 29;
            this.tb_cSaturation.Text = "0";
            this.tb_cSaturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_cValue
            // 
            this.tb_cValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cValue.Location = new System.Drawing.Point(681, 239);
            this.tb_cValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cValue.Name = "tb_cValue";
            this.tb_cValue.Size = new System.Drawing.Size(63, 35);
            this.tb_cValue.TabIndex = 30;
            this.tb_cValue.Text = "0";
            this.tb_cValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_valuelow);
            this.groupBox1.Controls.Add(this.tb_saturationlow);
            this.groupBox1.Controls.Add(this.tb_huelow);
            this.groupBox1.Controls.Add(this.tBar_valueLow);
            this.groupBox1.Controls.Add(this.tBar_HueLow);
            this.groupBox1.Controls.Add(this.tBar_saturationLow);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1319, 516);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(796, 231);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lower HSV";
            // 
            // tb_valuelow
            // 
            this.tb_valuelow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_valuelow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valuelow.Location = new System.Drawing.Point(696, 158);
            this.tb_valuelow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_valuelow.Name = "tb_valuelow";
            this.tb_valuelow.Size = new System.Drawing.Size(91, 35);
            this.tb_valuelow.TabIndex = 41;
            this.tb_valuelow.Text = "0";
            this.tb_valuelow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_valuelow.TextChanged += new System.EventHandler(this.tb_valuelow_TextChanged);
            // 
            // tb_saturationlow
            // 
            this.tb_saturationlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_saturationlow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_saturationlow.Location = new System.Drawing.Point(696, 92);
            this.tb_saturationlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_saturationlow.Name = "tb_saturationlow";
            this.tb_saturationlow.Size = new System.Drawing.Size(91, 35);
            this.tb_saturationlow.TabIndex = 40;
            this.tb_saturationlow.Text = "0";
            this.tb_saturationlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_saturationlow.TextChanged += new System.EventHandler(this.tb_saturationlow_TextChanged);
            // 
            // tb_huelow
            // 
            this.tb_huelow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_huelow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_huelow.Location = new System.Drawing.Point(696, 31);
            this.tb_huelow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_huelow.Name = "tb_huelow";
            this.tb_huelow.Size = new System.Drawing.Size(91, 35);
            this.tb_huelow.TabIndex = 39;
            this.tb_huelow.Text = "0";
            this.tb_huelow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_huelow.TextChanged += new System.EventHandler(this.tb_huelow_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_valuehigh);
            this.groupBox2.Controls.Add(this.tb_saturationhigh);
            this.groupBox2.Controls.Add(this.tBar_valueHigh);
            this.groupBox2.Controls.Add(this.tb_huehigh);
            this.groupBox2.Controls.Add(this.tBar_HueHigh);
            this.groupBox2.Controls.Add(this.tBar_saturationHigh);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1319, 754);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(796, 223);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upper HSV";
            // 
            // tb_valuehigh
            // 
            this.tb_valuehigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_valuehigh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valuehigh.Location = new System.Drawing.Point(696, 155);
            this.tb_valuehigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_valuehigh.Name = "tb_valuehigh";
            this.tb_valuehigh.Size = new System.Drawing.Size(91, 35);
            this.tb_valuehigh.TabIndex = 44;
            this.tb_valuehigh.Text = "0";
            this.tb_valuehigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_valuehigh.TextChanged += new System.EventHandler(this.tb_valuehigh_TextChanged);
            // 
            // tb_saturationhigh
            // 
            this.tb_saturationhigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_saturationhigh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_saturationhigh.Location = new System.Drawing.Point(696, 90);
            this.tb_saturationhigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_saturationhigh.Name = "tb_saturationhigh";
            this.tb_saturationhigh.Size = new System.Drawing.Size(91, 35);
            this.tb_saturationhigh.TabIndex = 43;
            this.tb_saturationhigh.Text = "0";
            this.tb_saturationhigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_saturationhigh.TextChanged += new System.EventHandler(this.tb_saturationhigh_TextChanged);
            // 
            // tb_huehigh
            // 
            this.tb_huehigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_huehigh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_huehigh.Location = new System.Drawing.Point(696, 28);
            this.tb_huehigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_huehigh.Name = "tb_huehigh";
            this.tb_huehigh.Size = new System.Drawing.Size(91, 35);
            this.tb_huehigh.TabIndex = 42;
            this.tb_huehigh.Text = "0";
            this.tb_huehigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_huehigh.TextChanged += new System.EventHandler(this.tb_huehigh_TextChanged);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Image = ((System.Drawing.Image)(resources.GetObject("btn_Browse.Image")));
            this.btn_Browse.Location = new System.Drawing.Point(1405, 985);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(93, 74);
            this.btn_Browse.TabIndex = 33;
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_pickColor
            // 
            this.btn_pickColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pickColor.Image = ((System.Drawing.Image)(resources.GetObject("btn_pickColor.Image")));
            this.btn_pickColor.Location = new System.Drawing.Point(1507, 985);
            this.btn_pickColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pickColor.Name = "btn_pickColor";
            this.btn_pickColor.Size = new System.Drawing.Size(93, 74);
            this.btn_pickColor.TabIndex = 34;
            this.btn_pickColor.UseVisualStyleBackColor = true;
            this.btn_pickColor.Click += new System.EventHandler(this.btn_pickColor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1608, 1008);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "The BGR values of the picked points are:";
            // 
            // lbl_bgrPicked
            // 
            this.lbl_bgrPicked.AutoSize = true;
            this.lbl_bgrPicked.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bgrPicked.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_bgrPicked.Location = new System.Drawing.Point(1787, 1036);
            this.lbl_bgrPicked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bgrPicked.Name = "lbl_bgrPicked";
            this.lbl_bgrPicked.Size = new System.Drawing.Size(112, 35);
            this.lbl_bgrPicked.TabIndex = 36;
            this.lbl_bgrPicked.Text = "(0, 0, 0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1350, 90);
            this.label2.TabIndex = 37;
            this.label2.Text = "COLOR PICKER AND DETECTION";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1497, 436);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(427, 53);
            this.label15.TabIndex = 38;
            this.label15.Text = "Check Range Below";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1348, 485);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(705, 26);
            this.label16.TabIndex = 39;
            this.label16.Text = "by varying upper and lower hsv values based on the reference above";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tBar_Red);
            this.groupBox4.Controls.Add(this.pb_colorDisplay);
            this.groupBox4.Controls.Add(this.tBar_Blue);
            this.groupBox4.Controls.Add(this.tBar_Green);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tb_blue);
            this.groupBox4.Controls.Add(this.tb_green);
            this.groupBox4.Controls.Add(this.tb_red);
            this.groupBox4.Controls.Add(this.tb_cValue);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tb_cSaturation);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tb_cHue);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1312, 123);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(811, 314);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BGR-HSV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2139, 1084);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_bgrPicked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pickColor);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_HueLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_HueHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_saturationLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_saturationHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_valueHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_valueLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_colorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_Blue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tBar_HueLow;
        private System.Windows.Forms.TrackBar tBar_HueHigh;
        private System.Windows.Forms.TrackBar tBar_saturationLow;
        private System.Windows.Forms.TrackBar tBar_saturationHigh;
        private System.Windows.Forms.TrackBar tBar_valueHigh;
        private System.Windows.Forms.TrackBar tBar_valueLow;
        private System.Windows.Forms.PictureBox pb_colorDisplay;
        private System.Windows.Forms.TrackBar tBar_Red;
        private System.Windows.Forms.TrackBar tBar_Green;
        private System.Windows.Forms.TrackBar tBar_Blue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_blue;
        private System.Windows.Forms.TextBox tb_green;
        private System.Windows.Forms.TextBox tb_red;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cHue;
        private System.Windows.Forms.TextBox tb_cSaturation;
        private System.Windows.Forms.TextBox tb_cValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_pickColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_bgrPicked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_valuelow;
        private System.Windows.Forms.TextBox tb_saturationlow;
        private System.Windows.Forms.TextBox tb_huelow;
        private System.Windows.Forms.TextBox tb_valuehigh;
        private System.Windows.Forms.TextBox tb_saturationhigh;
        private System.Windows.Forms.TextBox tb_huehigh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

