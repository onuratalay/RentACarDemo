
namespace RentACarDemo
{
    partial class CarUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarUI));
            this.dgwCars = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxPlate = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxEngine = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.tbxGear = new System.Windows.Forms.TextBox();
            this.lblGear = new System.Windows.Forms.Label();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbxBranchId = new System.Windows.Forms.TextBox();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBranches = new System.Windows.Forms.Button();
            this.btnCarSettings = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.pbxSidebar = new System.Windows.Forms.PictureBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.pbxMercedes = new System.Windows.Forms.PictureBox();
            this.pbxAudi = new System.Windows.Forms.PictureBox();
            this.pbxBmw = new System.Windows.Forms.PictureBox();
            this.pbxToyota = new System.Windows.Forms.PictureBox();
            this.pbxNissan = new System.Windows.Forms.PictureBox();
            this.pbxSuzuki = new System.Windows.Forms.PictureBox();
            this.pbxFiat = new System.Windows.Forms.PictureBox();
            this.pbxFord = new System.Windows.Forms.PictureBox();
            this.pbxPeugeot = new System.Windows.Forms.PictureBox();
            this.pbxRenault = new System.Windows.Forms.PictureBox();
            this.pbxVolvo = new System.Windows.Forms.PictureBox();
            this.pbxVolkswagen = new System.Windows.Forms.PictureBox();
            this.pbxHyundai = new System.Windows.Forms.PictureBox();
            this.pbxMitsubishi = new System.Windows.Forms.PictureBox();
            this.pbxTogg = new System.Windows.Forms.PictureBox();
            this.pbxTesla = new System.Windows.Forms.PictureBox();
            this.cbBranchNames = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMercedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAudi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBmw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxToyota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNissan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSuzuki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPeugeot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRenault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVolvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVolkswagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHyundai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMitsubishi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTogg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTesla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCars
            // 
            this.dgwCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwCars.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCars.Location = new System.Drawing.Point(216, 121);
            this.dgwCars.Name = "dgwCars";
            this.dgwCars.RowHeadersWidth = 51;
            this.dgwCars.RowTemplate.Height = 24;
            this.dgwCars.Size = new System.Drawing.Size(1009, 292);
            this.dgwCars.TabIndex = 0;
            this.dgwCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCars_CellClick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(479, 483);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(479, 533);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(40, 17);
            this.lblPlate.TabIndex = 2;
            this.lblPlate.Text = "Plate";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(743, 481);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(46, 17);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(743, 533);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(1013, 483);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(1013, 533);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(52, 17);
            this.lblEngine.TabIndex = 6;
            this.lblEngine.Text = "Engine";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(565, 478);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 22);
            this.tbxPrice.TabIndex = 7;
            // 
            // tbxPlate
            // 
            this.tbxPlate.Location = new System.Drawing.Point(565, 528);
            this.tbxPlate.Name = "tbxPlate";
            this.tbxPlate.Size = new System.Drawing.Size(100, 22);
            this.tbxPlate.TabIndex = 8;
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(829, 478);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(100, 22);
            this.tbxBrand.TabIndex = 9;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(829, 528);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 22);
            this.tbxModel.TabIndex = 10;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(1099, 478);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 22);
            this.tbxYear.TabIndex = 11;
            // 
            // tbxEngine
            // 
            this.tbxEngine.Location = new System.Drawing.Point(1099, 528);
            this.tbxEngine.Name = "tbxEngine";
            this.tbxEngine.Size = new System.Drawing.Size(100, 22);
            this.tbxEngine.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.AutoEllipsis = true;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(1015, 597);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(1096, 597);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(49, 43);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(1176, 597);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 43);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(1143, 419);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(82, 28);
            this.btnList.TabIndex = 16;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // tbxGear
            // 
            this.tbxGear.Location = new System.Drawing.Point(299, 581);
            this.tbxGear.Name = "tbxGear";
            this.tbxGear.Size = new System.Drawing.Size(100, 22);
            this.tbxGear.TabIndex = 18;
            // 
            // lblGear
            // 
            this.lblGear.AutoSize = true;
            this.lblGear.Location = new System.Drawing.Point(213, 586);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(40, 17);
            this.lblGear.TabIndex = 17;
            this.lblGear.Text = "Gear";
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(829, 581);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(100, 22);
            this.tbxColor.TabIndex = 20;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(743, 586);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "Color";
            // 
            // tbxBranchId
            // 
            this.tbxBranchId.Location = new System.Drawing.Point(299, 528);
            this.tbxBranchId.Name = "tbxBranchId";
            this.tbxBranchId.Size = new System.Drawing.Size(100, 22);
            this.tbxBranchId.TabIndex = 22;
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Location = new System.Drawing.Point(213, 533);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(70, 17);
            this.lblBranchId.TabIndex = 21;
            this.lblBranchId.Text = "Branch ID";
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.White;
            this.btnPersonnel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.BackgroundImage")));
            this.btnPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonnel.Location = new System.Drawing.Point(12, 569);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(126, 94);
            this.btnPersonnel.TabIndex = 28;
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
            this.btnCustomers.TabIndex = 27;
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
            this.btnBranches.TabIndex = 26;
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
            this.btnCarSettings.TabIndex = 25;
            this.btnCarSettings.UseVisualStyleBackColor = false;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.White;
            this.btnRent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRent.BackgroundImage")));
            this.btnRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRent.Location = new System.Drawing.Point(12, 85);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(126, 94);
            this.btnRent.TabIndex = 23;
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // pbxSidebar
            // 
            this.pbxSidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbxSidebar.Location = new System.Drawing.Point(1, -12);
            this.pbxSidebar.Name = "pbxSidebar";
            this.pbxSidebar.Size = new System.Drawing.Size(148, 769);
            this.pbxSidebar.TabIndex = 24;
            this.pbxSidebar.TabStop = false;
            // 
            // tbxId
            // 
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(299, 478);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 22);
            this.tbxId.TabIndex = 30;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(213, 483);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "ID";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(565, 581);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(100, 22);
            this.tbxStockAmount.TabIndex = 32;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(479, 569);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(56, 34);
            this.lblStockAmount.TabIndex = 31;
            this.lblStockAmount.Text = "Stock\r\nAmount";
            // 
            // pbxMercedes
            // 
            this.pbxMercedes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMercedes.BackgroundImage")));
            this.pbxMercedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMercedes.Location = new System.Drawing.Point(1120, 12);
            this.pbxMercedes.Name = "pbxMercedes";
            this.pbxMercedes.Size = new System.Drawing.Size(105, 103);
            this.pbxMercedes.TabIndex = 33;
            this.pbxMercedes.TabStop = false;
            this.pbxMercedes.Visible = false;
            // 
            // pbxAudi
            // 
            this.pbxAudi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAudi.BackgroundImage")));
            this.pbxAudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAudi.Location = new System.Drawing.Point(993, 12);
            this.pbxAudi.Name = "pbxAudi";
            this.pbxAudi.Size = new System.Drawing.Size(232, 86);
            this.pbxAudi.TabIndex = 34;
            this.pbxAudi.TabStop = false;
            this.pbxAudi.Visible = false;
            // 
            // pbxBmw
            // 
            this.pbxBmw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBmw.BackgroundImage")));
            this.pbxBmw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxBmw.Location = new System.Drawing.Point(1120, 12);
            this.pbxBmw.Name = "pbxBmw";
            this.pbxBmw.Size = new System.Drawing.Size(105, 103);
            this.pbxBmw.TabIndex = 35;
            this.pbxBmw.TabStop = false;
            this.pbxBmw.Visible = false;
            // 
            // pbxToyota
            // 
            this.pbxToyota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxToyota.BackgroundImage")));
            this.pbxToyota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxToyota.Location = new System.Drawing.Point(1120, 12);
            this.pbxToyota.Name = "pbxToyota";
            this.pbxToyota.Size = new System.Drawing.Size(105, 103);
            this.pbxToyota.TabIndex = 36;
            this.pbxToyota.TabStop = false;
            this.pbxToyota.Visible = false;
            // 
            // pbxNissan
            // 
            this.pbxNissan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxNissan.BackgroundImage")));
            this.pbxNissan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxNissan.Location = new System.Drawing.Point(1120, 12);
            this.pbxNissan.Name = "pbxNissan";
            this.pbxNissan.Size = new System.Drawing.Size(105, 103);
            this.pbxNissan.TabIndex = 37;
            this.pbxNissan.TabStop = false;
            this.pbxNissan.Visible = false;
            // 
            // pbxSuzuki
            // 
            this.pbxSuzuki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSuzuki.BackgroundImage")));
            this.pbxSuzuki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxSuzuki.Location = new System.Drawing.Point(964, 12);
            this.pbxSuzuki.Name = "pbxSuzuki";
            this.pbxSuzuki.Size = new System.Drawing.Size(261, 86);
            this.pbxSuzuki.TabIndex = 38;
            this.pbxSuzuki.TabStop = false;
            this.pbxSuzuki.Visible = false;
            // 
            // pbxFiat
            // 
            this.pbxFiat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxFiat.BackgroundImage")));
            this.pbxFiat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxFiat.Location = new System.Drawing.Point(1120, 12);
            this.pbxFiat.Name = "pbxFiat";
            this.pbxFiat.Size = new System.Drawing.Size(105, 103);
            this.pbxFiat.TabIndex = 39;
            this.pbxFiat.TabStop = false;
            this.pbxFiat.Visible = false;
            // 
            // pbxFord
            // 
            this.pbxFord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxFord.BackgroundImage")));
            this.pbxFord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxFord.Location = new System.Drawing.Point(1120, 12);
            this.pbxFord.Name = "pbxFord";
            this.pbxFord.Size = new System.Drawing.Size(105, 103);
            this.pbxFord.TabIndex = 40;
            this.pbxFord.TabStop = false;
            this.pbxFord.Visible = false;
            // 
            // pbxPeugeot
            // 
            this.pbxPeugeot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxPeugeot.BackgroundImage")));
            this.pbxPeugeot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPeugeot.Location = new System.Drawing.Point(1120, 12);
            this.pbxPeugeot.Name = "pbxPeugeot";
            this.pbxPeugeot.Size = new System.Drawing.Size(105, 103);
            this.pbxPeugeot.TabIndex = 41;
            this.pbxPeugeot.TabStop = false;
            this.pbxPeugeot.Visible = false;
            // 
            // pbxRenault
            // 
            this.pbxRenault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxRenault.BackgroundImage")));
            this.pbxRenault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRenault.Location = new System.Drawing.Point(1120, 12);
            this.pbxRenault.Name = "pbxRenault";
            this.pbxRenault.Size = new System.Drawing.Size(105, 103);
            this.pbxRenault.TabIndex = 42;
            this.pbxRenault.TabStop = false;
            this.pbxRenault.Visible = false;
            // 
            // pbxVolvo
            // 
            this.pbxVolvo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxVolvo.BackgroundImage")));
            this.pbxVolvo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxVolvo.Location = new System.Drawing.Point(1051, 12);
            this.pbxVolvo.Name = "pbxVolvo";
            this.pbxVolvo.Size = new System.Drawing.Size(174, 103);
            this.pbxVolvo.TabIndex = 43;
            this.pbxVolvo.TabStop = false;
            this.pbxVolvo.Visible = false;
            // 
            // pbxVolkswagen
            // 
            this.pbxVolkswagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxVolkswagen.BackgroundImage")));
            this.pbxVolkswagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxVolkswagen.Location = new System.Drawing.Point(1120, 12);
            this.pbxVolkswagen.Name = "pbxVolkswagen";
            this.pbxVolkswagen.Size = new System.Drawing.Size(105, 103);
            this.pbxVolkswagen.TabIndex = 44;
            this.pbxVolkswagen.TabStop = false;
            this.pbxVolkswagen.Visible = false;
            // 
            // pbxHyundai
            // 
            this.pbxHyundai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxHyundai.BackgroundImage")));
            this.pbxHyundai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxHyundai.Location = new System.Drawing.Point(927, 12);
            this.pbxHyundai.Name = "pbxHyundai";
            this.pbxHyundai.Size = new System.Drawing.Size(298, 103);
            this.pbxHyundai.TabIndex = 45;
            this.pbxHyundai.TabStop = false;
            this.pbxHyundai.Visible = false;
            // 
            // pbxMitsubishi
            // 
            this.pbxMitsubishi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMitsubishi.BackgroundImage")));
            this.pbxMitsubishi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMitsubishi.Location = new System.Drawing.Point(1120, 12);
            this.pbxMitsubishi.Name = "pbxMitsubishi";
            this.pbxMitsubishi.Size = new System.Drawing.Size(105, 103);
            this.pbxMitsubishi.TabIndex = 46;
            this.pbxMitsubishi.TabStop = false;
            this.pbxMitsubishi.Visible = false;
            // 
            // pbxTogg
            // 
            this.pbxTogg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxTogg.BackgroundImage")));
            this.pbxTogg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTogg.Location = new System.Drawing.Point(1120, 12);
            this.pbxTogg.Name = "pbxTogg";
            this.pbxTogg.Size = new System.Drawing.Size(105, 103);
            this.pbxTogg.TabIndex = 47;
            this.pbxTogg.TabStop = false;
            this.pbxTogg.Visible = false;
            // 
            // pbxTesla
            // 
            this.pbxTesla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxTesla.BackgroundImage")));
            this.pbxTesla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTesla.Location = new System.Drawing.Point(1120, 12);
            this.pbxTesla.Name = "pbxTesla";
            this.pbxTesla.Size = new System.Drawing.Size(105, 103);
            this.pbxTesla.TabIndex = 48;
            this.pbxTesla.TabStop = false;
            this.pbxTesla.Visible = false;
            // 
            // cbBranchNames
            // 
            this.cbBranchNames.FormattingEnabled = true;
            this.cbBranchNames.Location = new System.Drawing.Point(1016, 423);
            this.cbBranchNames.Name = "cbBranchNames";
            this.cbBranchNames.Size = new System.Drawing.Size(109, 24);
            this.cbBranchNames.TabIndex = 49;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bebas", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(207, 63);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(285, 52);
            this.lblHeader.TabIndex = 61;
            this.lblHeader.Text = "CAR MANAGEMENT";
            // 
            // CarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1278, 759);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cbBranchNames);
            this.Controls.Add(this.pbxHyundai);
            this.Controls.Add(this.pbxTesla);
            this.Controls.Add(this.pbxTogg);
            this.Controls.Add(this.pbxMitsubishi);
            this.Controls.Add(this.pbxVolkswagen);
            this.Controls.Add(this.pbxVolvo);
            this.Controls.Add(this.pbxRenault);
            this.Controls.Add(this.pbxPeugeot);
            this.Controls.Add(this.pbxFord);
            this.Controls.Add(this.pbxFiat);
            this.Controls.Add(this.pbxSuzuki);
            this.Controls.Add(this.pbxNissan);
            this.Controls.Add(this.pbxToyota);
            this.Controls.Add(this.pbxBmw);
            this.Controls.Add(this.pbxAudi);
            this.Controls.Add(this.pbxMercedes);
            this.Controls.Add(this.tbxStockAmount);
            this.Controls.Add(this.lblStockAmount);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnPersonnel);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnBranches);
            this.Controls.Add(this.btnCarSettings);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbxSidebar);
            this.Controls.Add(this.tbxBranchId);
            this.Controls.Add(this.lblBranchId);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbxGear);
            this.Controls.Add(this.lblGear);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxEngine);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.tbxPlate);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dgwCars);
            this.Name = "CarUI";
            this.Text = "CarUI";
            this.Load += new System.EventHandler(this.CarUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMercedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAudi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBmw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxToyota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNissan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSuzuki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFiat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPeugeot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRenault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVolvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVolkswagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHyundai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMitsubishi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTogg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTesla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCars;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxPlate;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxEngine;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox tbxGear;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbxBranchId;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnBranches;
        private System.Windows.Forms.Button btnCarSettings;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.PictureBox pbxSidebar;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.PictureBox pbxMercedes;
        private System.Windows.Forms.PictureBox pbxAudi;
        private System.Windows.Forms.PictureBox pbxBmw;
        private System.Windows.Forms.PictureBox pbxToyota;
        private System.Windows.Forms.PictureBox pbxNissan;
        private System.Windows.Forms.PictureBox pbxSuzuki;
        private System.Windows.Forms.PictureBox pbxFiat;
        private System.Windows.Forms.PictureBox pbxFord;
        private System.Windows.Forms.PictureBox pbxPeugeot;
        private System.Windows.Forms.PictureBox pbxRenault;
        private System.Windows.Forms.PictureBox pbxVolvo;
        private System.Windows.Forms.PictureBox pbxVolkswagen;
        private System.Windows.Forms.PictureBox pbxHyundai;
        private System.Windows.Forms.PictureBox pbxMitsubishi;
        private System.Windows.Forms.PictureBox pbxTogg;
        private System.Windows.Forms.PictureBox pbxTesla;
        private System.Windows.Forms.ComboBox cbBranchNames;
        private System.Windows.Forms.Label lblHeader;
    }
}