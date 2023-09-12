
namespace RentACarDemo
{
    partial class BranchUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchUI));
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBranches = new System.Windows.Forms.Button();
            this.btnCarSettings = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.pbxSidebar = new System.Windows.Forms.PictureBox();
            this.dgwBranches = new System.Windows.Forms.DataGridView();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxEmployees = new System.Windows.Forms.TextBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.tbxEndorsement = new System.Windows.Forms.TextBox();
            this.lblEndorsement = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranches)).BeginInit();
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
            this.btnPersonnel.TabIndex = 34;
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
            this.btnCustomers.TabIndex = 33;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnBranches
            // 
            this.btnBranches.BackColor = System.Drawing.Color.White;
            this.btnBranches.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBranches.BackgroundImage")));
            this.btnBranches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBranches.Location = new System.Drawing.Point(12, 326);
            this.btnBranches.Name = "btnBranches";
            this.btnBranches.Size = new System.Drawing.Size(126, 94);
            this.btnBranches.TabIndex = 32;
            this.btnBranches.UseVisualStyleBackColor = false;
            // 
            // btnCarSettings
            // 
            this.btnCarSettings.BackColor = System.Drawing.Color.White;
            this.btnCarSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarSettings.BackgroundImage")));
            this.btnCarSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarSettings.Location = new System.Drawing.Point(12, 205);
            this.btnCarSettings.Name = "btnCarSettings";
            this.btnCarSettings.Size = new System.Drawing.Size(126, 94);
            this.btnCarSettings.TabIndex = 31;
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
            this.btnRent.TabIndex = 29;
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // pbxSidebar
            // 
            this.pbxSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbxSidebar.Location = new System.Drawing.Point(1, -12);
            this.pbxSidebar.Name = "pbxSidebar";
            this.pbxSidebar.Size = new System.Drawing.Size(148, 776);
            this.pbxSidebar.TabIndex = 30;
            this.pbxSidebar.TabStop = false;
            // 
            // dgwBranches
            // 
            this.dgwBranches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwBranches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBranches.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgwBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBranches.Location = new System.Drawing.Point(714, 118);
            this.dgwBranches.Name = "dgwBranches";
            this.dgwBranches.RowHeadersWidth = 51;
            this.dgwBranches.RowTemplate.Height = 24;
            this.dgwBranches.Size = new System.Drawing.Size(515, 302);
            this.dgwBranches.TabIndex = 36;
            this.dgwBranches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBranches_CellClick);
            // 
            // tbxId
            // 
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(797, 471);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 22);
            this.tbxId.TabIndex = 38;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(711, 476);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 37;
            this.lblId.Text = "ID";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(797, 531);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 40;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(711, 536);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name";
            // 
            // tbxEmployees
            // 
            this.tbxEmployees.Location = new System.Drawing.Point(1129, 473);
            this.tbxEmployees.Name = "tbxEmployees";
            this.tbxEmployees.Size = new System.Drawing.Size(100, 22);
            this.tbxEmployees.TabIndex = 42;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(1009, 461);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(77, 34);
            this.lblEmployees.TabIndex = 41;
            this.lblEmployees.Text = "Number of\r\nEmployees\r\n";
            // 
            // tbxEndorsement
            // 
            this.tbxEndorsement.Location = new System.Drawing.Point(1129, 533);
            this.tbxEndorsement.Name = "tbxEndorsement";
            this.tbxEndorsement.Size = new System.Drawing.Size(100, 22);
            this.tbxEndorsement.TabIndex = 44;
            // 
            // lblEndorsement
            // 
            this.lblEndorsement.AutoSize = true;
            this.lblEndorsement.Location = new System.Drawing.Point(1009, 538);
            this.lblEndorsement.Name = "lblEndorsement";
            this.lblEndorsement.Size = new System.Drawing.Size(92, 17);
            this.lblEndorsement.TabIndex = 43;
            this.lblEndorsement.Text = "Endorsement";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(1180, 595);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 43);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(1100, 595);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(49, 43);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoEllipsis = true;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(1019, 595);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 43);
            this.btnSave.TabIndex = 45;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BranchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1279, 757);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxEndorsement);
            this.Controls.Add(this.lblEndorsement);
            this.Controls.Add(this.tbxEmployees);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgwBranches);
            this.Controls.Add(this.btnPersonnel);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnBranches);
            this.Controls.Add(this.btnCarSettings);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbxSidebar);
            this.Name = "BranchUI";
            this.Text = "BranchUI";
            this.Load += new System.EventHandler(this.BranchUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBranches)).EndInit();
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
        private System.Windows.Forms.DataGridView dgwBranches;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.TextBox tbxEndorsement;
        private System.Windows.Forms.Label lblEndorsement;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}