namespace CruisingFlightStand
{
    partial class ManageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tenzo_sum = new System.Windows.Forms.Label();
            this.tenzo5_DataMain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tenzo5_Data = new System.Windows.Forms.Label();
            this.tenzo4_Data = new System.Windows.Forms.Label();
            this.tenzo3_Data = new System.Windows.Forms.Label();
            this.tenzo1_Data = new System.Windows.Forms.Label();
            this.tenzo2_Data = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resist_Data = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.logBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.airDensity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kTenzo5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kTenzo4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kTenzo3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kTenzo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kTenzo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.current_Data = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.voltage_Data = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tenzo_sum);
            this.panel1.Controls.Add(this.tenzo5_DataMain);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 183);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Тензо 5:";
            // 
            // tenzo_sum
            // 
            this.tenzo_sum.AutoSize = true;
            this.tenzo_sum.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenzo_sum.Location = new System.Drawing.Point(126, 111);
            this.tenzo_sum.Name = "tenzo_sum";
            this.tenzo_sum.Size = new System.Drawing.Size(79, 25);
            this.tenzo_sum.TabIndex = 24;
            this.tenzo_sum.Text = "5500 гр.";
            // 
            // tenzo5_DataMain
            // 
            this.tenzo5_DataMain.AutoSize = true;
            this.tenzo5_DataMain.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenzo5_DataMain.Location = new System.Drawing.Point(101, 138);
            this.tenzo5_DataMain.Name = "tenzo5_DataMain";
            this.tenzo5_DataMain.Size = new System.Drawing.Size(79, 25);
            this.tenzo5_DataMain.TabIndex = 25;
            this.tenzo5_DataMain.Text = "5500 гр.";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Сумма 1-4:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ScaleBalanced;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 73;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(75, 73);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тензодтчики";
            // 
            // tenzo5_Data
            // 
            this.tenzo5_Data.AutoSize = true;
            this.tenzo5_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenzo5_Data.Location = new System.Drawing.Point(358, 139);
            this.tenzo5_Data.Name = "tenzo5_Data";
            this.tenzo5_Data.Size = new System.Drawing.Size(79, 25);
            this.tenzo5_Data.TabIndex = 23;
            this.tenzo5_Data.Text = "5500 гр.";
            // 
            // tenzo4_Data
            // 
            this.tenzo4_Data.AutoSize = true;
            this.tenzo4_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenzo4_Data.Location = new System.Drawing.Point(358, 110);
            this.tenzo4_Data.Name = "tenzo4_Data";
            this.tenzo4_Data.Size = new System.Drawing.Size(79, 25);
            this.tenzo4_Data.TabIndex = 20;
            this.tenzo4_Data.Text = "5500 гр.";
            // 
            // tenzo3_Data
            // 
            this.tenzo3_Data.AutoSize = true;
            this.tenzo3_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenzo3_Data.Location = new System.Drawing.Point(86, 169);
            this.tenzo3_Data.Name = "tenzo3_Data";
            this.tenzo3_Data.Size = new System.Drawing.Size(79, 25);
            this.tenzo3_Data.TabIndex = 19;
            this.tenzo3_Data.Text = "5500 гр.";
            // 
            // tenzo1_Data
            // 
            this.tenzo1_Data.AutoSize = true;
            this.tenzo1_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenzo1_Data.Location = new System.Drawing.Point(86, 111);
            this.tenzo1_Data.Name = "tenzo1_Data";
            this.tenzo1_Data.Size = new System.Drawing.Size(79, 25);
            this.tenzo1_Data.TabIndex = 15;
            this.tenzo1_Data.Text = "5500 гр.";
            // 
            // tenzo2_Data
            // 
            this.tenzo2_Data.AutoSize = true;
            this.tenzo2_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenzo2_Data.Location = new System.Drawing.Point(86, 140);
            this.tenzo2_Data.Name = "tenzo2_Data";
            this.tenzo2_Data.Size = new System.Drawing.Size(79, 25);
            this.tenzo2_Data.TabIndex = 16;
            this.tenzo2_Data.Text = "5500 гр.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.resist_Data);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(344, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 183);
            this.panel2.TabIndex = 23;
            // 
            // resist_Data
            // 
            this.resist_Data.AutoSize = true;
            this.resist_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resist_Data.Location = new System.Drawing.Point(112, 111);
            this.resist_Data.Name = "resist_Data";
            this.resist_Data.Size = new System.Drawing.Size(83, 25);
            this.resist_Data.TabIndex = 15;
            this.resist_Data.Text = "120 км/ч";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpRightDots;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 73;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(75, 73);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(84, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 37);
            this.label18.TabIndex = 0;
            this.label18.Text = "Скорость";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.logBtn.FlatAppearance.BorderSize = 0;
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.logBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            this.logBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.logBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logBtn.IconSize = 36;
            this.logBtn.Location = new System.Drawing.Point(473, 485);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(170, 60);
            this.logBtn.TabIndex = 26;
            this.logBtn.Text = "Запись";
            this.logBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.airDensity);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.kTenzo5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.kTenzo4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.kTenzo3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.kTenzo2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.kTenzo1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.tenzo5_Data);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tenzo1_Data);
            this.panel3.Controls.Add(this.tenzo4_Data);
            this.panel3.Controls.Add(this.tenzo3_Data);
            this.panel3.Controls.Add(this.tenzo2_Data);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.iconPictureBox3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(24, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 231);
            this.panel3.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(429, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 37;
            this.label14.Text = "кг/м3";
            // 
            // airDensity
            // 
            this.airDensity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airDensity.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airDensity.Location = new System.Drawing.Point(383, 169);
            this.airDensity.Name = "airDensity";
            this.airDensity.Size = new System.Drawing.Size(54, 26);
            this.airDensity.TabIndex = 36;
            this.airDensity.Text = "1.225";
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(319, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 25);
            this.label12.TabIndex = 35;
            this.label12.Text = "Air ρ:";
            // 
            // kTenzo5
            // 
            this.kTenzo5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kTenzo5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTenzo5.Location = new System.Drawing.Point(495, 138);
            this.kTenzo5.Name = "kTenzo5";
            this.kTenzo5.Size = new System.Drawing.Size(51, 26);
            this.kTenzo5.TabIndex = 34;
            this.kTenzo5.Text = "5.3";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(452, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "К5:";
            // 
            // kTenzo4
            // 
            this.kTenzo4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kTenzo4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTenzo4.Location = new System.Drawing.Point(495, 109);
            this.kTenzo4.Name = "kTenzo4";
            this.kTenzo4.Size = new System.Drawing.Size(51, 26);
            this.kTenzo4.TabIndex = 32;
            this.kTenzo4.Text = "5.3";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(452, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "К4:";
            // 
            // kTenzo3
            // 
            this.kTenzo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kTenzo3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTenzo3.Location = new System.Drawing.Point(223, 168);
            this.kTenzo3.Name = "kTenzo3";
            this.kTenzo3.Size = new System.Drawing.Size(51, 26);
            this.kTenzo3.TabIndex = 30;
            this.kTenzo3.Text = "5.3";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(180, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "К3:";
            // 
            // kTenzo2
            // 
            this.kTenzo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kTenzo2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTenzo2.Location = new System.Drawing.Point(223, 139);
            this.kTenzo2.Name = "kTenzo2";
            this.kTenzo2.Size = new System.Drawing.Size(51, 26);
            this.kTenzo2.TabIndex = 28;
            this.kTenzo2.Text = "5.3";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(180, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "К2:";
            // 
            // kTenzo1
            // 
            this.kTenzo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kTenzo1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTenzo1.Location = new System.Drawing.Point(223, 110);
            this.kTenzo1.Name = "kTenzo1";
            this.kTenzo1.Size = new System.Drawing.Size(51, 26);
            this.kTenzo1.TabIndex = 26;
            this.kTenzo1.Text = "5.3";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(180, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "К1:";
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(280, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 25);
            this.label15.TabIndex = 23;
            this.label15.Text = "Тензо 5:";
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(280, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 25);
            this.label17.TabIndex = 21;
            this.label17.Text = "Тензо 4:";
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Тензо 3:";
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Тензо 2:";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Тензо 1:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(591, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 73;
            this.iconPictureBox3.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(75, 73);
            this.iconPictureBox3.TabIndex = 2;
            this.iconPictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(84, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Все данные";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.saveBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.IconSize = 36;
            this.saveBtn.Location = new System.Drawing.Point(291, 485);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 60);
            this.saveBtn.TabIndex = 28;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.voltage_Data);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.current_Data);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(24, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 87);
            this.panel4.TabIndex = 26;
            // 
            // current_Data
            // 
            this.current_Data.AutoSize = true;
            this.current_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.current_Data.Location = new System.Drawing.Point(56, 3);
            this.current_Data.Name = "current_Data";
            this.current_Data.Size = new System.Drawing.Size(39, 25);
            this.current_Data.TabIndex = 24;
            this.current_Data.Text = "2 А";
            // 
            // label21
            // 
            this.label21.AutoEllipsis = true;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(8, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 25);
            this.label21.TabIndex = 24;
            this.label21.Text = "Ток:";
            // 
            // voltage_Data
            // 
            this.voltage_Data.AutoSize = true;
            this.voltage_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voltage_Data.Location = new System.Drawing.Point(141, 28);
            this.voltage_Data.Name = "voltage_Data";
            this.voltage_Data.Size = new System.Drawing.Size(48, 25);
            this.voltage_Data.TabIndex = 25;
            this.voltage_Data.Text = "50 В";
            // 
            // label20
            // 
            this.label20.AutoEllipsis = true;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(8, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 25);
            this.label20.TabIndex = 26;
            this.label20.Text = "Напряжение:";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(668, 566);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tenzo4_Data;
        private System.Windows.Forms.Label tenzo3_Data;
        private System.Windows.Forms.Label tenzo1_Data;
        private System.Windows.Forms.Label tenzo2_Data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resist_Data;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label18;
        private System.IO.Ports.SerialPort serialPort;
        private FontAwesome.Sharp.IconButton logBtn;
        private System.Windows.Forms.Label tenzo5_Data;
        private System.Windows.Forms.Label tenzo_sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tenzo5_DataMain;
        private System.Windows.Forms.TextBox kTenzo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kTenzo5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kTenzo4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kTenzo3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kTenzo2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton saveBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox airDensity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label voltage_Data;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label current_Data;
    }
}