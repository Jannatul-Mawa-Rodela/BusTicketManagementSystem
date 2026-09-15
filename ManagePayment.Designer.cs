
namespace BusTicketManagementSystem
{
    partial class ManagePayments
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnShowPayments = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.colPaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPaymentDetails = new System.Windows.Forms.Panel();
            this.btnClearr = new System.Windows.Forms.Button();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.dptPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtOperatorName = new System.Windows.Forms.TextBox();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.panelPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblPageTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(958, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(958, 60);
            this.lblPageTitle.TabIndex = 2;
            this.lblPageTitle.Text = "Manage Payments";
            this.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPageTitle.Click += new System.EventHandler(this.lblPageTitle_Click);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnClear);
            this.panelActions.Controls.Add(this.btnViewDetails);
            this.panelActions.Controls.Add(this.btnShowPayments);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 60);
            this.panelActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(958, 52);
            this.panelActions.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(766, 10);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 33);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(388, 10);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(181, 33);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // btnShowPayments
            // 
            this.btnShowPayments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPayments.Location = new System.Drawing.Point(11, 5);
            this.btnShowPayments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPayments.Name = "btnShowPayments";
            this.btnShowPayments.Size = new System.Drawing.Size(181, 33);
            this.btnShowPayments.TabIndex = 0;
            this.btnShowPayments.Text = "Show Payments";
            this.btnShowPayments.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 112);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(958, 44);
            this.panelSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(482, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(142, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(28, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 28);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentID,
            this.colOperatorName,
            this.colCompanyName,
            this.colPaymentType,
            this.colAmount,
            this.colPaymentMethod,
            this.colPaymentDate,
            this.colPaymentStatus});
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(0, 156);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 62;
            this.dgvPayments.RowTemplate.Height = 28;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(958, 319);
            this.dgvPayments.TabIndex = 4;
            // 
            // colPaymentID
            // 
            this.colPaymentID.HeaderText = "Payment ID";
            this.colPaymentID.MinimumWidth = 8;
            this.colPaymentID.Name = "colPaymentID";
            this.colPaymentID.ReadOnly = true;
            // 
            // colOperatorName
            // 
            this.colOperatorName.HeaderText = "Operator Name";
            this.colOperatorName.MinimumWidth = 8;
            this.colOperatorName.Name = "colOperatorName";
            this.colOperatorName.ReadOnly = true;
            // 
            // colCompanyName
            // 
            this.colCompanyName.HeaderText = "Company Name";
            this.colCompanyName.MinimumWidth = 8;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colPaymentType
            // 
            this.colPaymentType.HeaderText = "Payment Type";
            this.colPaymentType.MinimumWidth = 8;
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 8;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.HeaderText = "Payment Method";
            this.colPaymentMethod.MinimumWidth = 8;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.HeaderText = "Payment Date";
            this.colPaymentDate.MinimumWidth = 8;
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;
            // 
            // colPaymentStatus
            // 
            this.colPaymentStatus.HeaderText = "Payment Status";
            this.colPaymentStatus.MinimumWidth = 8;
            this.colPaymentStatus.Name = "colPaymentStatus";
            this.colPaymentStatus.ReadOnly = true;
            // 
            // panelPaymentDetails
            // 
            this.panelPaymentDetails.Controls.Add(this.btnClearr);
            this.panelPaymentDetails.Controls.Add(this.cmbPaymentStatus);
            this.panelPaymentDetails.Controls.Add(this.lblPaymentStatus);
            this.panelPaymentDetails.Controls.Add(this.dptPaymentDate);
            this.panelPaymentDetails.Controls.Add(this.lblPaymentDate);
            this.panelPaymentDetails.Controls.Add(this.cmbPaymentMethod);
            this.panelPaymentDetails.Controls.Add(this.lblPaymentMethod);
            this.panelPaymentDetails.Controls.Add(this.txtAmount);
            this.panelPaymentDetails.Controls.Add(this.lblAmount);
            this.panelPaymentDetails.Controls.Add(this.cmbPaymentType);
            this.panelPaymentDetails.Controls.Add(this.lblPaymentType);
            this.panelPaymentDetails.Controls.Add(this.txtCompanyName);
            this.panelPaymentDetails.Controls.Add(this.lblCompanyName);
            this.panelPaymentDetails.Controls.Add(this.txtOperatorName);
            this.panelPaymentDetails.Controls.Add(this.lblOperatorName);
            this.panelPaymentDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPaymentDetails.Location = new System.Drawing.Point(0, 323);
            this.panelPaymentDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPaymentDetails.Name = "panelPaymentDetails";
            this.panelPaymentDetails.Size = new System.Drawing.Size(958, 152);
            this.panelPaymentDetails.TabIndex = 5;
            this.panelPaymentDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaymentDetails_Paint);
            // 
            // btnClearr
            // 
            this.btnClearr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearr.Location = new System.Drawing.Point(807, 90);
            this.btnClearr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearr.Name = "btnClearr";
            this.btnClearr.Size = new System.Drawing.Size(140, 46);
            this.btnClearr.TabIndex = 14;
            this.btnClearr.Text = "Clear";
            this.btnClearr.UseVisualStyleBackColor = true;
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Failed"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(569, 100);
            this.cmbPaymentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(108, 24);
            this.cmbPaymentStatus.TabIndex = 13;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(404, 100);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(155, 25);
            this.lblPaymentStatus.TabIndex = 12;
            this.lblPaymentStatus.Text = "Payment Status:";
            // 
            // dptPaymentDate
            // 
            this.dptPaymentDate.Location = new System.Drawing.Point(195, 103);
            this.dptPaymentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dptPaymentDate.Name = "dptPaymentDate";
            this.dptPaymentDate.Size = new System.Drawing.Size(178, 22);
            this.dptPaymentDate.TabIndex = 11;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(28, 103);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(141, 25);
            this.lblPaymentDate.TabIndex = 10;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Bank Transfer",
            "Mobile Banking",
            "Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(766, 62);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(108, 24);
            this.cmbPaymentMethod.TabIndex = 9;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(575, 59);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(170, 25);
            this.lblPaymentMethod.TabIndex = 8;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(428, 59);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(142, 22);
            this.txtAmount.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(332, 59);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 25);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Commission",
            "Ticket Sale",
            "Refund",
            "Other"});
            this.cmbPaymentType.Location = new System.Drawing.Point(195, 59);
            this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(108, 24);
            this.cmbPaymentType.TabIndex = 5;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(28, 58);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(142, 25);
            this.lblPaymentType.TabIndex = 4;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(637, 19);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(247, 22);
            this.txtCompanyName.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(468, 15);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(159, 25);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtOperatorName
            // 
            this.txtOperatorName.Location = new System.Drawing.Point(195, 15);
            this.txtOperatorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOperatorName.Name = "txtOperatorName";
            this.txtOperatorName.Size = new System.Drawing.Size(224, 22);
            this.txtOperatorName.TabIndex = 1;
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorName.Location = new System.Drawing.Point(28, 11);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(155, 25);
            this.lblOperatorName.TabIndex = 0;
            this.lblOperatorName.Text = "Operator Name:";
            // 
            // ManagePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 475);
            this.Controls.Add(this.panelPaymentDetails);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ManagePayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Payments";
            this.Load += new System.EventHandler(this.ManagePayments_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.panelPaymentDetails.ResumeLayout(false);
            this.panelPaymentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnShowPayments;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentStatus;
        private System.Windows.Forms.Panel panelPaymentDetails;
        private System.Windows.Forms.TextBox txtOperatorName;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dptPaymentDate;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Button btnClearr;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
    }
}