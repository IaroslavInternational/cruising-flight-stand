namespace CruisingFlightStand
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.settingsBtn = new FontAwesome.Sharp.IconButton();
            this.manageBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.panelMenu.Controls.Add(this.settingsBtn);
            this.panelMenu.Controls.Add(this.manageBtn);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 566);
            this.panelMenu.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingsBtn.IconChar = FontAwesome.Sharp.IconChar.ShareNodes;
            this.settingsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.settingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsBtn.IconSize = 36;
            this.settingsBtn.Location = new System.Drawing.Point(0, 127);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(217, 60);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.Text = "Настройки";
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // manageBtn
            // 
            this.manageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageBtn.FlatAppearance.BorderSize = 0;
            this.manageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manageBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageBtn.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.manageBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.manageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manageBtn.IconSize = 36;
            this.manageBtn.Location = new System.Drawing.Point(0, 67);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.Size = new System.Drawing.Size(217, 60);
            this.manageBtn.TabIndex = 2;
            this.manageBtn.Text = "Управление";
            this.manageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageBtn.UseVisualStyleBackColor = true;
            this.manageBtn.Click += new System.EventHandler(this.manageBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 67);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "FLYTUSE";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(217, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(668, 566);
            this.panelDesktop.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 566);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Cruising Flight Stand";
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton settingsBtn;
        private FontAwesome.Sharp.IconButton manageBtn;
        private System.Windows.Forms.Label label1;
    }
}

