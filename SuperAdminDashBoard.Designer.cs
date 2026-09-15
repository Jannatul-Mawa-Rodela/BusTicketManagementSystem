
namespace BusTicketManagementSystem
{
    partial class SuperAdminDashBoard
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBuses = new System.Windows.Forms.Button();
            this.btnOperators = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.cardTotalSales = new System.Windows.Forms.Panel();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.lblTotalSalesTitle = new System.Windows.Forms.Label();
            this.cardTicketSold = new System.Windows.Forms.Panel();
            this.lblTicketsSoldValue = new System.Windows.Forms.Label();
            this.lblTicketsSoldTitle = new System.Windows.Forms.Label();
            this.cardTotalBuses = new System.Windows.Forms.Panel();
            this.lblTotalBusesValue = new System.Windows.Forms.Label();
            this.lblTotalBusesTitle = new System.Windows.Forms.Label();
            this.cardPendingOperators = new System.Windows.Forms.Panel();
            this.lblPendingOperatorsValue = new System.Windows.Forms.Label();
            this.lblPendingOperatorsTitle = new System.Windows.Forms.Label();
            this.cardActiveOperators = new System.Windows.Forms.Panel();
            this.lblActiveOperatorsValue = new System.Windows.Forms.Label();
            this.lblActiveOperatorsTitle = new System.Windows.Forms.Label();
            this.cardTotalOperators = new System.Windows.Forms.Panel();
            this.lblTotalOperatorsValue = new System.Windows.Forms.Label();
            this.lblTotalOperatorsTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardTotalSales.SuspendLayout();
            this.cardTicketSold.SuspendLayout();
            this.cardTotalBuses.SuspendLayout();
            this.cardPendingOperators.SuspendLayout();
            this.cardActiveOperators.SuspendLayout();
            this.cardTotalOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnBuses);
            this.panelSidebar.Controls.Add(this.btnOperators);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.lblRole);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Location = new System.Drawing.Point(23, 23);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(249, 474);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(31, 396);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(31, 334);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(131, 32);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(31, 274);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(131, 32);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // btnBuses
            // 
            this.btnBuses.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuses.Location = new System.Drawing.Point(31, 210);
            this.btnBuses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.Size = new System.Drawing.Size(131, 32);
            this.btnBuses.TabIndex = 3;
            this.btnBuses.Text = "Buses";
            this.btnBuses.UseVisualStyleBackColor = true;
            this.btnBuses.Click += new System.EventHandler(this.btnBuses_Click_1);
            // 
            // btnOperators
            // 
            this.btnOperators.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperators.Location = new System.Drawing.Point(31, 148);
            this.btnOperators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.Size = new System.Drawing.Size(131, 32);
            this.btnOperators.TabIndex = 2;
            this.btnOperators.Text = "Operators";
            this.btnOperators.UseVisualStyleBackColor = true;
            this.btnOperators.Click += new System.EventHandler(this.btnOperators_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(31, 85);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(131, 32);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(27, 46);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(115, 22);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Super Admin";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(14, 10);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(115, 38);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "BusGo";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblDashboardTitle);
            this.panelHeader.Location = new System.Drawing.Point(270, 23);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(766, 117);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(432, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(307, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Super Admin";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(7, 10);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(330, 31);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Super Admin Dashboard";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.cardTotalSales);
            this.panelContent.Controls.Add(this.cardTicketSold);
            this.panelContent.Controls.Add(this.cardTotalBuses);
            this.panelContent.Controls.Add(this.cardPendingOperators);
            this.panelContent.Controls.Add(this.cardActiveOperators);
            this.panelContent.Controls.Add(this.cardTotalOperators);
            this.panelContent.Controls.Add(this.lblDescription);
            this.panelContent.Controls.Add(this.lblWelcomeMessage);
            this.panelContent.Location = new System.Drawing.Point(270, 108);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(766, 389);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // cardTotalSales
            // 
            this.cardTotalSales.BackColor = System.Drawing.Color.White;
            this.cardTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalSales.Controls.Add(this.lblTotalSalesValue);
            this.cardTotalSales.Controls.Add(this.lblTotalSalesTitle);
            this.cardTotalSales.Location = new System.Drawing.Point(536, 250);
            this.cardTotalSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardTotalSales.Name = "cardTotalSales";
            this.cardTotalSales.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cardTotalSales.Size = new System.Drawing.Size(178, 106);
            this.cardTotalSales.TabIndex = 9;
            // 
            // lblTotalSalesValue
            // 
            this.lblTotalSalesValue.AutoSize = true;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSalesValue.Location = new System.Drawing.Point(12, 53);
            this.lblTotalSalesValue.Name = "lblTotalSalesValue";
            this.lblTotalSalesValue.Size = new System.Drawing.Size(160, 46);
            this.lblTotalSalesValue.TabIndex = 5;
            this.lblTotalSalesValue.Text = "$250000";
            // 
            // lblTotalSalesTitle
            // 
            this.lblTotalSalesTitle.AutoSize = true;
            this.lblTotalSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalSalesTitle.Location = new System.Drawing.Point(44, 27);
            this.lblTotalSalesTitle.Name = "lblTotalSalesTitle";
            this.lblTotalSalesTitle.Size = new System.Drawing.Size(94, 23);
            this.lblTotalSalesTitle.TabIndex = 4;
            this.lblTotalSalesTitle.Text = "Total Sales";
            this.lblTotalSalesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardTicketSold
            // 
            this.cardTicketSold.BackColor = System.Drawing.Color.White;
            this.cardTicketSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTicketSold.Controls.Add(this.lblTicketsSoldValue);
            this.cardTicketSold.Controls.Add(this.lblTicketsSoldTitle);
            this.cardTicketSold.Location = new System.Drawing.Point(292, 250);
            this.cardTicketSold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardTicketSold.Name = "cardTicketSold";
            this.cardTicketSold.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cardTicketSold.Size = new System.Drawing.Size(178, 106);
            this.cardTicketSold.TabIndex = 8;
            // 
            // lblTicketsSoldValue
            // 
            this.lblTicketsSoldValue.AutoSize = true;
            this.lblTicketsSoldValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsSoldValue.ForeColor = System.Drawing.Color.Black;
            this.lblTicketsSoldValue.Location = new System.Drawing.Point(31, 53);
            this.lblTicketsSoldValue.Name = "lblTicketsSoldValue";
            this.lblTicketsSoldValue.Size = new System.Drawing.Size(100, 46);
            this.lblTicketsSoldValue.TabIndex = 5;
            this.lblTicketsSoldValue.Text = "1240";
            // 
            // lblTicketsSoldTitle
            // 
            this.lblTicketsSoldTitle.AutoSize = true;
            this.lblTicketsSoldTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketsSoldTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsSoldTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTicketsSoldTitle.Location = new System.Drawing.Point(35, 26);
            this.lblTicketsSoldTitle.Name = "lblTicketsSoldTitle";
            this.lblTicketsSoldTitle.Size = new System.Drawing.Size(107, 23);
            this.lblTicketsSoldTitle.TabIndex = 4;
            this.lblTicketsSoldTitle.Text = "Tickets Sold";
            // 
            // cardTotalBuses
            // 
            this.cardTotalBuses.BackColor = System.Drawing.Color.White;
            this.cardTotalBuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalBuses.Controls.Add(this.lblTotalBusesValue);
            this.cardTotalBuses.Controls.Add(this.lblTotalBusesTitle);
            this.cardTotalBuses.Location = new System.Drawing.Point(22, 250);
            this.cardTotalBuses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardTotalBuses.Name = "cardTotalBuses";
            this.cardTotalBuses.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cardTotalBuses.Size = new System.Drawing.Size(178, 106);
            this.cardTotalBuses.TabIndex = 7;
            // 
            // lblTotalBusesValue
            // 
            this.lblTotalBusesValue.AutoSize = true;
            this.lblTotalBusesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBusesValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalBusesValue.Location = new System.Drawing.Point(53, 53);
            this.lblTotalBusesValue.Name = "lblTotalBusesValue";
            this.lblTotalBusesValue.Size = new System.Drawing.Size(60, 46);
            this.lblTotalBusesValue.TabIndex = 5;
            this.lblTotalBusesValue.Text = "35";
            this.lblTotalBusesValue.Click += new System.EventHandler(this.lblTotalBusesValue_Click);
            // 
            // lblTotalBusesTitle
            // 
            this.lblTotalBusesTitle.AutoSize = true;
            this.lblTotalBusesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBusesTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalBusesTitle.Location = new System.Drawing.Point(23, 18);
            this.lblTotalBusesTitle.Name = "lblTotalBusesTitle";
            this.lblTotalBusesTitle.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.lblTotalBusesTitle.Size = new System.Drawing.Size(116, 39);
            this.lblTotalBusesTitle.TabIndex = 4;
            this.lblTotalBusesTitle.Text = "Total Buses";
            this.lblTotalBusesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardPendingOperators
            // 
            this.cardPendingOperators.BackColor = System.Drawing.Color.White;
            this.cardPendingOperators.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPendingOperators.Controls.Add(this.lblPendingOperatorsValue);
            this.cardPendingOperators.Controls.Add(this.lblPendingOperatorsTitle);
            this.cardPendingOperators.Location = new System.Drawing.Point(536, 94);
            this.cardPendingOperators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardPendingOperators.Name = "cardPendingOperators";
            this.cardPendingOperators.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cardPendingOperators.Size = new System.Drawing.Size(178, 106);
            this.cardPendingOperators.TabIndex = 6;
            // 
            // lblPendingOperatorsValue
            // 
            this.lblPendingOperatorsValue.AutoSize = true;
            this.lblPendingOperatorsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOperatorsValue.ForeColor = System.Drawing.Color.Black;
            this.lblPendingOperatorsValue.Location = new System.Drawing.Point(72, 53);
            this.lblPendingOperatorsValue.Name = "lblPendingOperatorsValue";
            this.lblPendingOperatorsValue.Size = new System.Drawing.Size(40, 46);
            this.lblPendingOperatorsValue.TabIndex = 5;
            this.lblPendingOperatorsValue.Text = "2";
            // 
            // lblPendingOperatorsTitle
            // 
            this.lblPendingOperatorsTitle.AutoSize = true;
            this.lblPendingOperatorsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOperatorsTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblPendingOperatorsTitle.Location = new System.Drawing.Point(10, 16);
            this.lblPendingOperatorsTitle.Name = "lblPendingOperatorsTitle";
            this.lblPendingOperatorsTitle.Size = new System.Drawing.Size(160, 23);
            this.lblPendingOperatorsTitle.TabIndex = 4;
            this.lblPendingOperatorsTitle.Text = "Pending Operators";
            this.lblPendingOperatorsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardActiveOperators
            // 
            this.cardActiveOperators.BackColor = System.Drawing.Color.White;
            this.cardActiveOperators.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardActiveOperators.Controls.Add(this.lblActiveOperatorsValue);
            this.cardActiveOperators.Controls.Add(this.lblActiveOperatorsTitle);
            this.cardActiveOperators.Location = new System.Drawing.Point(292, 94);
            this.cardActiveOperators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardActiveOperators.Name = "cardActiveOperators";
            this.cardActiveOperators.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cardActiveOperators.Size = new System.Drawing.Size(178, 106);
            this.cardActiveOperators.TabIndex = 6;
            // 
            // lblActiveOperatorsValue
            // 
            this.lblActiveOperatorsValue.AutoSize = true;
            this.lblActiveOperatorsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveOperatorsValue.Location = new System.Drawing.Point(59, 53);
            this.lblActiveOperatorsValue.Name = "lblActiveOperatorsValue";
            this.lblActiveOperatorsValue.Size = new System.Drawing.Size(60, 46);
            this.lblActiveOperatorsValue.TabIndex = 5;
            this.lblActiveOperatorsValue.Text = "10";
            // 
            // lblActiveOperatorsTitle
            // 
            this.lblActiveOperatorsTitle.AutoSize = true;
            this.lblActiveOperatorsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveOperatorsTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblActiveOperatorsTitle.Location = new System.Drawing.Point(11, 16);
            this.lblActiveOperatorsTitle.Name = "lblActiveOperatorsTitle";
            this.lblActiveOperatorsTitle.Size = new System.Drawing.Size(145, 23);
            this.lblActiveOperatorsTitle.TabIndex = 4;
            this.lblActiveOperatorsTitle.Text = "Active Operators";
            // 
            // cardTotalOperators
            // 
            this.cardTotalOperators.BackColor = System.Drawing.Color.White;
            this.cardTotalOperators.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalOperators.Controls.Add(this.lblTotalOperatorsValue);
            this.cardTotalOperators.Controls.Add(this.lblTotalOperatorsTitle);
            this.cardTotalOperators.Location = new System.Drawing.Point(22, 94);
            this.cardTotalOperators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardTotalOperators.Name = "cardTotalOperators";
            this.cardTotalOperators.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cardTotalOperators.Size = new System.Drawing.Size(178, 106);
            this.cardTotalOperators.TabIndex = 2;
            // 
            // lblTotalOperatorsValue
            // 
            this.lblTotalOperatorsValue.AutoSize = true;
            this.lblTotalOperatorsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperatorsValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalOperatorsValue.Location = new System.Drawing.Point(53, 53);
            this.lblTotalOperatorsValue.Name = "lblTotalOperatorsValue";
            this.lblTotalOperatorsValue.Size = new System.Drawing.Size(60, 46);
            this.lblTotalOperatorsValue.TabIndex = 5;
            this.lblTotalOperatorsValue.Text = "12";
            // 
            // lblTotalOperatorsTitle
            // 
            this.lblTotalOperatorsTitle.AutoSize = true;
            this.lblTotalOperatorsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperatorsTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalOperatorsTitle.Location = new System.Drawing.Point(23, 16);
            this.lblTotalOperatorsTitle.Name = "lblTotalOperatorsTitle";
            this.lblTotalOperatorsTitle.Size = new System.Drawing.Size(134, 23);
            this.lblTotalOperatorsTitle.TabIndex = 4;
            this.lblTotalOperatorsTitle.Text = "Total Operators";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(1, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(557, 28);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Manage operators, buses, payments and reports from here.";
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(3, 6);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(438, 29);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welcome BusGo Super Admin Panel";
            // 
            // SuperAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 515);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SuperAdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusGo - Super Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuperAdminDashBoard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.cardTotalSales.ResumeLayout(false);
            this.cardTotalSales.PerformLayout();
            this.cardTicketSold.ResumeLayout(false);
            this.cardTicketSold.PerformLayout();
            this.cardTotalBuses.ResumeLayout(false);
            this.cardTotalBuses.PerformLayout();
            this.cardPendingOperators.ResumeLayout(false);
            this.cardPendingOperators.PerformLayout();
            this.cardActiveOperators.ResumeLayout(false);
            this.cardActiveOperators.PerformLayout();
            this.cardTotalOperators.ResumeLayout(false);
            this.cardTotalOperators.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBuses;
        private System.Windows.Forms.Button btnOperators;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel cardTotalOperators;
        private System.Windows.Forms.Label lblTotalOperatorsTitle;
        private System.Windows.Forms.Label lblTotalOperatorsValue;
        private System.Windows.Forms.Panel cardPendingOperators;
        private System.Windows.Forms.Label lblPendingOperatorsValue;
        private System.Windows.Forms.Label lblPendingOperatorsTitle;
        private System.Windows.Forms.Panel cardActiveOperators;
        private System.Windows.Forms.Label lblActiveOperatorsValue;
        private System.Windows.Forms.Label lblActiveOperatorsTitle;
        private System.Windows.Forms.Panel cardTotalBuses;
        private System.Windows.Forms.Label lblTotalBusesValue;
        private System.Windows.Forms.Label lblTotalBusesTitle;
        private System.Windows.Forms.Panel cardTicketSold;
        private System.Windows.Forms.Label lblTicketsSoldValue;
        private System.Windows.Forms.Label lblTicketsSoldTitle;
        private System.Windows.Forms.Panel cardTotalSales;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.Label lblTotalSalesTitle;
    }
}