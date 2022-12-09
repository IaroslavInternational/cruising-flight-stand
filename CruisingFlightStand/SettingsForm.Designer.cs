namespace CruisingFlightStand
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.portList = new System.Windows.Forms.ListBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudRateList = new System.Windows.Forms.ListBox();
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.baudRateList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.portList);
            this.panel2.Controls.Add(this.portLabel);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(24, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 187);
            this.panel2.TabIndex = 24;
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
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Usb;
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
            this.label18.Size = new System.Drawing.Size(187, 37);
            this.label18.TabIndex = 0;
            this.label18.Text = "Подключение";
            // 
            // portList
            // 
            this.portList.BackColor = System.Drawing.Color.White;
            this.portList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portList.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portList.FormattingEnabled = true;
            this.portList.ItemHeight = 25;
            this.portList.Items.AddRange(new object[] {
            "COM1"});
            this.portList.Location = new System.Drawing.Point(72, 112);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(85, 25);
            this.portList.TabIndex = 25;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portLabel.Location = new System.Drawing.Point(8, 111);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(58, 25);
            this.portLabel.TabIndex = 15;
            this.portLabel.Text = "Порт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Скорость:";
            // 
            // baudRateList
            // 
            this.baudRateList.BackColor = System.Drawing.Color.White;
            this.baudRateList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.baudRateList.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baudRateList.FormattingEnabled = true;
            this.baudRateList.ItemHeight = 25;
            this.baudRateList.Items.AddRange(new object[] {
            "9600"});
            this.baudRateList.Location = new System.Drawing.Point(109, 147);
            this.baudRateList.Name = "baudRateList";
            this.baudRateList.Size = new System.Drawing.Size(118, 25);
            this.baudRateList.TabIndex = 27;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.saveBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.IconSize = 36;
            this.saveBtn.Location = new System.Drawing.Point(459, 444);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(170, 60);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(652, 527);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox portList;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.ListBox baudRateList;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton saveBtn;
    }
}