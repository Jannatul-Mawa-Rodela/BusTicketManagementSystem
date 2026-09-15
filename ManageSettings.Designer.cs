
namespace BusTicketManagementSystem
{
    partial class ManageSettings
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.cmbSystemStatus = new System.Windows.Forms.ComboBox();
            this.lblSystemStatus = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.lblSystemSettings = new System.Windows.Forms.Label();
            this.btnChangeLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.labelLoginSettings = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelPageTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(958, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitle.Location = new System.Drawing.Point(0, 0);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(958, 60);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Settings";
            this.labelPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPageTitle.Click += new System.EventHandler(this.labelPageTitle_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.btnResetSettings);
            this.panelSettings.Controls.Add(this.btnSaveSettings);
            this.panelSettings.Controls.Add(this.cmbSystemStatus);
            this.panelSettings.Controls.Add(this.lblSystemStatus);
            this.panelSettings.Controls.Add(this.txtAppName);
            this.panelSettings.Controls.Add(this.lblApplicationName);
            this.panelSettings.Controls.Add(this.lblSystemSettings);
            this.panelSettings.Controls.Add(this.btnChangeLogin);
            this.panelSettings.Controls.Add(this.txtPassword);
            this.panelSettings.Controls.Add(this.txtUsername);
            this.panelSettings.Controls.Add(this.lblPassword);
            this.panelSettings.Controls.Add(this.lblUsername);
            this.panelSettings.Controls.Add(this.labelLoginSettings);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 60);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Padding = new System.Windows.Forms.Padding(27, 16, 27, 16);
            this.panelSettings.Size = new System.Drawing.Size(958, 415);
            this.panelSettings.TabIndex = 1;
            this.panelSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSettings_Paint);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSettings.Location = new System.Drawing.Point(256, 369);
            this.btnResetSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(155, 37);
            this.btnResetSettings.TabIndex = 12;
            this.btnResetSettings.Text = "Reset Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(17, 369);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(133, 37);
            this.btnSaveSettings.TabIndex = 11;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // cmbSystemStatus
            // 
            this.cmbSystemStatus.FormattingEnabled = true;
            this.cmbSystemStatus.Items.AddRange(new object[] {
            "Active",
            "Maintenance"});
            this.cmbSystemStatus.Location = new System.Drawing.Point(168, 340);
            this.cmbSystemStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSystemStatus.Name = "cmbSystemStatus";
            this.cmbSystemStatus.Size = new System.Drawing.Size(108, 24);
            this.cmbSystemStatus.TabIndex = 10;
            // 
            // lblSystemStatus
            // 
            this.lblSystemStatus.AutoSize = true;
            this.lblSystemStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemStatus.Location = new System.Drawing.Point(12, 339);
            this.lblSystemStatus.Name = "lblSystemStatus";
            this.lblSystemStatus.Size = new System.Drawing.Size(116, 20);
            this.lblSystemStatus.TabIndex = 9;
            this.lblSystemStatus.Text = "System Status: ";
            this.lblSystemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(168, 307);
            this.txtAppName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(243, 22);
            this.txtAppName.TabIndex = 8;
            this.txtAppName.Text = "BusGo";
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.Location = new System.Drawing.Point(12, 306);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(139, 20);
            this.lblApplicationName.TabIndex = 7;
            this.lblApplicationName.Text = "Application Name:";
            this.lblApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSystemSettings
            // 
            this.lblSystemSettings.AutoSize = true;
            this.lblSystemSettings.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemSettings.Location = new System.Drawing.Point(11, 270);
            this.lblSystemSettings.Name = "lblSystemSettings";
            this.lblSystemSettings.Size = new System.Drawing.Size(216, 30);
            this.lblSystemSettings.TabIndex = 6;
            this.lblSystemSettings.Text = "System Information";
            this.lblSystemSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSystemSettings.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChangeLogin
            // 
            this.btnChangeLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLogin.Location = new System.Drawing.Point(16, 143);
            this.btnChangeLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeLogin.Name = "btnChangeLogin";
            this.btnChangeLogin.Size = new System.Drawing.Size(303, 35);
            this.btnChangeLogin.TabIndex = 5;
            this.btnChangeLogin.Text = "Change Login Information";
            this.btnChangeLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 118);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(138, 71);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 67);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // labelLoginSettings
            // 
            this.labelLoginSettings.AutoSize = true;
            this.labelLoginSettings.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginSettings.Location = new System.Drawing.Point(11, 16);
            this.labelLoginSettings.Name = "labelLoginSettings";
            this.labelLoginSettings.Size = new System.Drawing.Size(161, 30);
            this.labelLoginSettings.TabIndex = 0;
            this.labelLoginSettings.Text = "Login Settings";
            this.labelLoginSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 475);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ManageSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Settings";
            this.panelHeader.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelLoginSettings;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnChangeLogin;
        private System.Windows.Forms.Label lblSystemSettings;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label lblSystemStatus;
        private System.Windows.Forms.ComboBox cmbSystemStatus;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}