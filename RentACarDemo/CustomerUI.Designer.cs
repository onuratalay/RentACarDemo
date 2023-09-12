
namespace RentACarDemo
{
    partial class CustomerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUI));
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBranches = new System.Windows.Forms.Button();
            this.btnCarSettings = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.pbxSidebar = new System.Windows.Forms.PictureBox();
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.tbxDepozit = new System.Windows.Forms.TextBox();
            this.lblDepozit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxBudget = new System.Windows.Forms.TextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbxCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.tbxBranchId = new System.Windows.Forms.TextBox();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.White;
            this.btnPersonnel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.BackgroundImage")));
            this.btnPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonnel.Location = new System.Drawing.Point(12, 569);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(126, 94);
            this.btnPersonnel.TabIndex = 11;
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.BackgroundImage")));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.Location = new System.Drawing.Point(12, 447);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(126, 94);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnBranches
            // 
            this.btnBranches.BackColor = System.Drawing.Color.White;
            this.btnBranches.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBranches.BackgroundImage")));
            this.btnBranches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBranches.Location = new System.Drawing.Point(12, 326);
            this.btnBranches.Name = "btnBranches";
            this.btnBranches.Size = new System.Drawing.Size(126, 94);
            this.btnBranches.TabIndex = 9;
            this.btnBranches.UseVisualStyleBackColor = false;
            this.btnBranches.Click += new System.EventHandler(this.btnBranches_Click);
            // 
            // btnCarSettings
            // 
            this.btnCarSettings.BackColor = System.Drawing.Color.White;
            this.btnCarSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarSettings.BackgroundImage")));
            this.btnCarSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarSettings.Location = new System.Drawing.Point(12, 205);
            this.btnCarSettings.Name = "btnCarSettings";
            this.btnCarSettings.Size = new System.Drawing.Size(126, 94);
            this.btnCarSettings.TabIndex = 8;
            this.btnCarSettings.UseVisualStyleBackColor = false;
            this.btnCarSettings.Click += new System.EventHandler(this.btnCarSettings_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.White;
            this.btnRent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRent.BackgroundImage")));
            this.btnRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRent.Location = new System.Drawing.Point(12, 85);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(126, 94);
            this.btnRent.TabIndex = 6;
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // pbxSidebar
            // 
            this.pbxSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbxSidebar.Location = new System.Drawing.Point(1, -9);
            this.pbxSidebar.Name = "pbxSidebar";
            this.pbxSidebar.Size = new System.Drawing.Size(148, 776);
            this.pbxSidebar.TabIndex = 7;
            this.pbxSidebar.TabStop = false;
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwCustomers.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Location = new System.Drawing.Point(210, 140);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.RowHeadersWidth = 51;
            this.dgwCustomers.RowTemplate.Height = 24;
            this.dgwCustomers.Size = new System.Drawing.Size(1009, 292);
            this.dgwCustomers.TabIndex = 12;
            this.dgwCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomers_CellClick);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bebas", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(201, 85);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(383, 52);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "CUSTOMER MANAGEMENT";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(1137, 447);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(82, 28);
            this.btnList.TabIndex = 62;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // tbxDepozit
            // 
            this.tbxDepozit.Location = new System.Drawing.Point(1092, 519);
            this.tbxDepozit.Name = "tbxDepozit";
            this.tbxDepozit.Size = new System.Drawing.Size(100, 22);
            this.tbxDepozit.TabIndex = 82;
            // 
            // lblDepozit
            // 
            this.lblDepozit.AutoSize = true;
            this.lblDepozit.Location = new System.Drawing.Point(1006, 524);
            this.lblDepozit.Name = "lblDepozit";
            this.lblDepozit.Size = new System.Drawing.Size(56, 17);
            this.lblDepozit.TabIndex = 81;
            this.lblDepozit.Text = "Depozit";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(1170, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 43);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(1090, 567);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(49, 43);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoEllipsis = true;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(1009, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 43);
            this.btnSave.TabIndex = 78;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxBudget
            // 
            this.tbxBudget.Location = new System.Drawing.Point(852, 572);
            this.tbxBudget.Name = "tbxBudget";
            this.tbxBudget.Size = new System.Drawing.Size(100, 22);
            this.tbxBudget.TabIndex = 77;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(766, 577);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(53, 17);
            this.lblBudget.TabIndex = 76;
            this.lblBudget.Text = "Budget";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(852, 519);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 22);
            this.tbxAge.TabIndex = 75;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(766, 524);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 74;
            this.lblAge.Text = "Age";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(573, 572);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(100, 22);
            this.tbxPhone.TabIndex = 73;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(487, 577);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 72;
            this.lblPhone.Text = "Phone";
            // 
            // tbxFullName
            // 
            this.tbxFullName.Location = new System.Drawing.Point(573, 519);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(100, 22);
            this.tbxFullName.TabIndex = 71;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(487, 524);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 17);
            this.lblFullName.TabIndex = 70;
            this.lblFullName.Text = "Full Name";
            // 
            // tbxCustomerId
            // 
            this.tbxCustomerId.Enabled = false;
            this.tbxCustomerId.Location = new System.Drawing.Point(293, 519);
            this.tbxCustomerId.Name = "tbxCustomerId";
            this.tbxCustomerId.Size = new System.Drawing.Size(100, 22);
            this.tbxCustomerId.TabIndex = 69;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(207, 524);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(85, 17);
            this.lblCustomerId.TabIndex = 68;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // tbxBranchId
            // 
            this.tbxBranchId.Location = new System.Drawing.Point(293, 572);
            this.tbxBranchId.Name = "tbxBranchId";
            this.tbxBranchId.Size = new System.Drawing.Size(100, 22);
            this.tbxBranchId.TabIndex = 67;
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Location = new System.Drawing.Point(207, 577);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(70, 17);
            this.lblBranchId.TabIndex = 66;
            this.lblBranchId.Text = "Branch ID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1009, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 28);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1279, 759);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxDepozit);
            this.Controls.Add(this.lblDepozit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbxFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.tbxCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.tbxBranchId);
            this.Controls.Add(this.lblBranchId);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgwCustomers);
            this.Controls.Add(this.btnPersonnel);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnBranches);
            this.Controls.Add(this.btnCarSettings);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbxSidebar);
            this.Name = "CustomerUI";
            this.Text = "CustomerUI";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnBranches;
        private System.Windows.Forms.Button btnCarSettings;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.PictureBox pbxSidebar;
        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox tbxDepozit;
        private System.Windows.Forms.Label lblDepozit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxBudget;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox tbxCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox tbxBranchId;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.Button btnClear;
    }
}