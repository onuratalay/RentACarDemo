
namespace RentACarDemo
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnRent = new System.Windows.Forms.Button();
            this.pbxSidebar = new System.Windows.Forms.PictureBox();
            this.btnCarSettings = new System.Windows.Forms.Button();
            this.btnBranches = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.White;
            this.btnRent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRent.BackgroundImage")));
            this.btnRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRent.Location = new System.Drawing.Point(12, 85);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(126, 94);
            this.btnRent.TabIndex = 0;
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // pbxSidebar
            // 
            this.pbxSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbxSidebar.Location = new System.Drawing.Point(1, -5);
            this.pbxSidebar.Name = "pbxSidebar";
            this.pbxSidebar.Size = new System.Drawing.Size(148, 776);
            this.pbxSidebar.TabIndex = 1;
            this.pbxSidebar.TabStop = false;
            // 
            // btnCarSettings
            // 
            this.btnCarSettings.BackColor = System.Drawing.Color.White;
            this.btnCarSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarSettings.BackgroundImage")));
            this.btnCarSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarSettings.Location = new System.Drawing.Point(12, 205);
            this.btnCarSettings.Name = "btnCarSettings";
            this.btnCarSettings.Size = new System.Drawing.Size(126, 94);
            this.btnCarSettings.TabIndex = 2;
            this.btnCarSettings.UseVisualStyleBackColor = false;
            this.btnCarSettings.Click += new System.EventHandler(this.btnCarSettings_Click);
            // 
            // btnBranches
            // 
            this.btnBranches.BackColor = System.Drawing.Color.White;
            this.btnBranches.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBranches.BackgroundImage")));
            this.btnBranches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBranches.Location = new System.Drawing.Point(12, 326);
            this.btnBranches.Name = "btnBranches";
            this.btnBranches.Size = new System.Drawing.Size(126, 94);
            this.btnBranches.TabIndex = 3;
            this.btnBranches.UseVisualStyleBackColor = false;
            this.btnBranches.Click += new System.EventHandler(this.btnBranches_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.BackgroundImage")));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.Location = new System.Drawing.Point(12, 447);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(126, 94);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.White;
            this.btnPersonnel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.BackgroundImage")));
            this.btnPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonnel.Location = new System.Drawing.Point(12, 569);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(126, 94);
            this.btnPersonnel.TabIndex = 5;
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1281, 757);
            this.Controls.Add(this.btnPersonnel);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnBranches);
            this.Controls.Add(this.btnCarSettings);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbxSidebar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.PictureBox pbxSidebar;
        private System.Windows.Forms.Button btnCarSettings;
        private System.Windows.Forms.Button btnBranches;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPersonnel;
    }
}