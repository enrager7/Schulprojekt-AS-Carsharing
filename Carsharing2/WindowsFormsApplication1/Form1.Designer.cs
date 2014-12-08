namespace Carsharing
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Container = new System.Windows.Forms.TabControl();
            this.DataPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CarDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxManufacturer = new System.Windows.Forms.TextBox();
            this.tbxLicenseTag = new System.Windows.Forms.TextBox();
            this.modelLbl = new System.Windows.Forms.Label();
            this.ManufacturerLbl = new System.Windows.Forms.Label();
            this.LicenseIDLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LenderDataGrid = new System.Windows.Forms.DataGridView();
            this.btnLenderDelete = new System.Windows.Forms.Button();
            this.btnLenderCreate = new System.Windows.Forms.Button();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.AdressLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.RentPage = new System.Windows.Forms.TabPage();
            this.LenderCarDataGrid = new System.Windows.Forms.DataGridView();
            this.RentCarDataGrid = new System.Windows.Forms.DataGridView();
            this.RentLenderDataGrid = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CarLbl = new System.Windows.Forms.Label();
            this.LenderLbl = new System.Windows.Forms.Label();
            this.RentBtn = new System.Windows.Forms.Button();
            this.bindingSourceDataSetBranchBox = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Branchlbl = new System.Windows.Forms.Label();
            this.BranchCbx = new System.Windows.Forms.ComboBox();
            this.Container.SuspendLayout();
            this.DataPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenderDataGrid)).BeginInit();
            this.RentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenderCarDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentCarDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentLenderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataSetBranchBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container.Controls.Add(this.DataPage);
            this.Container.Controls.Add(this.RentPage);
            this.Container.Location = new System.Drawing.Point(0, 67);
            this.Container.Name = "Container";
            this.Container.SelectedIndex = 0;
            this.Container.Size = new System.Drawing.Size(885, 370);
            this.Container.TabIndex = 0;
            // 
            // DataPage
            // 
            this.DataPage.Controls.Add(this.groupBox3);
            this.DataPage.Controls.Add(this.groupBox2);
            this.DataPage.Location = new System.Drawing.Point(4, 22);
            this.DataPage.Name = "DataPage";
            this.DataPage.Size = new System.Drawing.Size(877, 344);
            this.DataPage.TabIndex = 2;
            this.DataPage.Text = "Stammdaten";
            this.DataPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.CarDataGridView);
            this.groupBox3.Controls.Add(this.btnDeleteCar);
            this.groupBox3.Controls.Add(this.btnCreateCar);
            this.groupBox3.Controls.Add(this.tbxPrice);
            this.groupBox3.Controls.Add(this.priceLbl);
            this.groupBox3.Controls.Add(this.tbxModel);
            this.groupBox3.Controls.Add(this.tbxManufacturer);
            this.groupBox3.Controls.Add(this.tbxLicenseTag);
            this.groupBox3.Controls.Add(this.modelLbl);
            this.groupBox3.Controls.Add(this.ManufacturerLbl);
            this.groupBox3.Controls.Add(this.LicenseIDLbl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(443, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 344);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // CarDataGridView
            // 
            this.CarDataGridView.AllowUserToAddRows = false;
            this.CarDataGridView.AllowUserToDeleteRows = false;
            this.CarDataGridView.AllowUserToOrderColumns = true;
            this.CarDataGridView.AllowUserToResizeColumns = false;
            this.CarDataGridView.AllowUserToResizeRows = false;
            this.CarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CarDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDataGridView.Location = new System.Drawing.Point(3, 176);
            this.CarDataGridView.MultiSelect = false;
            this.CarDataGridView.Name = "CarDataGridView";
            this.CarDataGridView.ReadOnly = true;
            this.CarDataGridView.RowHeadersVisible = false;
            this.CarDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarDataGridView.Size = new System.Drawing.Size(426, 150);
            this.CarDataGridView.TabIndex = 17;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(353, 76);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteCar.TabIndex = 16;
            this.btnDeleteCar.Text = "Löschen";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(353, 31);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(75, 39);
            this.btnCreateCar.TabIndex = 15;
            this.btnCreateCar.Text = "Erstellen";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(156, 125);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(176, 20);
            this.tbxPrice.TabIndex = 14;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(74, 128);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(30, 13);
            this.priceLbl.TabIndex = 13;
            this.priceLbl.Text = "Preis";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(156, 99);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(176, 20);
            this.tbxModel.TabIndex = 12;
            // 
            // tbxManufacturer
            // 
            this.tbxManufacturer.Location = new System.Drawing.Point(156, 68);
            this.tbxManufacturer.Name = "tbxManufacturer";
            this.tbxManufacturer.Size = new System.Drawing.Size(176, 20);
            this.tbxManufacturer.TabIndex = 11;
            // 
            // tbxLicenseTag
            // 
            this.tbxLicenseTag.Location = new System.Drawing.Point(156, 36);
            this.tbxLicenseTag.Name = "tbxLicenseTag";
            this.tbxLicenseTag.Size = new System.Drawing.Size(176, 20);
            this.tbxLicenseTag.TabIndex = 10;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(74, 102);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(38, 13);
            this.modelLbl.TabIndex = 9;
            this.modelLbl.Text = "Modell";
            // 
            // ManufacturerLbl
            // 
            this.ManufacturerLbl.AutoSize = true;
            this.ManufacturerLbl.Location = new System.Drawing.Point(74, 71);
            this.ManufacturerLbl.Name = "ManufacturerLbl";
            this.ManufacturerLbl.Size = new System.Drawing.Size(51, 13);
            this.ManufacturerLbl.TabIndex = 8;
            this.ManufacturerLbl.Text = "Hersteller";
            // 
            // LicenseIDLbl
            // 
            this.LicenseIDLbl.AutoSize = true;
            this.LicenseIDLbl.Location = new System.Drawing.Point(74, 39);
            this.LicenseIDLbl.Name = "LicenseIDLbl";
            this.LicenseIDLbl.Size = new System.Drawing.Size(69, 13);
            this.LicenseIDLbl.TabIndex = 7;
            this.LicenseIDLbl.Text = "Kennzeichen";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.LenderDataGrid);
            this.groupBox2.Controls.Add(this.btnLenderDelete);
            this.groupBox2.Controls.Add(this.btnLenderCreate);
            this.groupBox2.Controls.Add(this.tbxAge);
            this.groupBox2.Controls.Add(this.tbxAdress);
            this.groupBox2.Controls.Add(this.tbxName);
            this.groupBox2.Controls.Add(this.AgeLbl);
            this.groupBox2.Controls.Add(this.AdressLbl);
            this.groupBox2.Controls.Add(this.NameLbl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 344);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mieter";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LenderDataGrid
            // 
            this.LenderDataGrid.AllowUserToAddRows = false;
            this.LenderDataGrid.AllowUserToDeleteRows = false;
            this.LenderDataGrid.AllowUserToOrderColumns = true;
            this.LenderDataGrid.AllowUserToResizeColumns = false;
            this.LenderDataGrid.AllowUserToResizeRows = false;
            this.LenderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LenderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LenderDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.LenderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LenderDataGrid.Location = new System.Drawing.Point(5, 176);
            this.LenderDataGrid.MultiSelect = false;
            this.LenderDataGrid.Name = "LenderDataGrid";
            this.LenderDataGrid.ReadOnly = true;
            this.LenderDataGrid.RowHeadersVisible = false;
            this.LenderDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LenderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LenderDataGrid.Size = new System.Drawing.Size(423, 150);
            this.LenderDataGrid.TabIndex = 9;
            // 
            // btnLenderDelete
            // 
            this.btnLenderDelete.Location = new System.Drawing.Point(334, 76);
            this.btnLenderDelete.Name = "btnLenderDelete";
            this.btnLenderDelete.Size = new System.Drawing.Size(75, 43);
            this.btnLenderDelete.TabIndex = 8;
            this.btnLenderDelete.Text = "Löschen";
            this.btnLenderDelete.UseVisualStyleBackColor = true;
            this.btnLenderDelete.Click += new System.EventHandler(this.btnLenderDelete_Click);
            // 
            // btnLenderCreate
            // 
            this.btnLenderCreate.Location = new System.Drawing.Point(334, 31);
            this.btnLenderCreate.Name = "btnLenderCreate";
            this.btnLenderCreate.Size = new System.Drawing.Size(75, 39);
            this.btnLenderCreate.TabIndex = 7;
            this.btnLenderCreate.Text = "Erstellen";
            this.btnLenderCreate.UseVisualStyleBackColor = true;
            this.btnLenderCreate.Click += new System.EventHandler(this.btnLenderCreate_Click);
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(105, 99);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(176, 20);
            this.tbxAge.TabIndex = 6;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(105, 68);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(176, 20);
            this.tbxAdress.TabIndex = 5;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(105, 36);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(176, 20);
            this.tbxName.TabIndex = 4;
            this.tbxName.TextChanged += new System.EventHandler(this.NameTbx_TextChanged);
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(23, 102);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(28, 13);
            this.AgeLbl.TabIndex = 3;
            this.AgeLbl.Text = "Alter";
            // 
            // AdressLbl
            // 
            this.AdressLbl.AutoSize = true;
            this.AdressLbl.Location = new System.Drawing.Point(23, 71);
            this.AdressLbl.Name = "AdressLbl";
            this.AdressLbl.Size = new System.Drawing.Size(45, 13);
            this.AdressLbl.TabIndex = 2;
            this.AdressLbl.Text = "Adresse";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(23, 39);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // RentPage
            // 
            this.RentPage.Controls.Add(this.LenderCarDataGrid);
            this.RentPage.Controls.Add(this.RentCarDataGrid);
            this.RentPage.Controls.Add(this.RentLenderDataGrid);
            this.RentPage.Controls.Add(this.DeleteBtn);
            this.RentPage.Controls.Add(this.CarLbl);
            this.RentPage.Controls.Add(this.LenderLbl);
            this.RentPage.Controls.Add(this.RentBtn);
            this.RentPage.Location = new System.Drawing.Point(4, 22);
            this.RentPage.Name = "RentPage";
            this.RentPage.Size = new System.Drawing.Size(877, 344);
            this.RentPage.TabIndex = 1;
            this.RentPage.Text = "Vermietung";
            this.RentPage.UseVisualStyleBackColor = true;
            // 
            // LenderCarDataGrid
            // 
            this.LenderCarDataGrid.AllowUserToAddRows = false;
            this.LenderCarDataGrid.AllowUserToDeleteRows = false;
            this.LenderCarDataGrid.AllowUserToOrderColumns = true;
            this.LenderCarDataGrid.AllowUserToResizeColumns = false;
            this.LenderCarDataGrid.AllowUserToResizeRows = false;
            this.LenderCarDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LenderCarDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.LenderCarDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.LenderCarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LenderCarDataGrid.Location = new System.Drawing.Point(202, 134);
            this.LenderCarDataGrid.Name = "LenderCarDataGrid";
            this.LenderCarDataGrid.ReadOnly = true;
            this.LenderCarDataGrid.RowHeadersVisible = false;
            this.LenderCarDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LenderCarDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LenderCarDataGrid.Size = new System.Drawing.Size(486, 94);
            this.LenderCarDataGrid.TabIndex = 19;
            // 
            // RentCarDataGrid
            // 
            this.RentCarDataGrid.AllowUserToAddRows = false;
            this.RentCarDataGrid.AllowUserToDeleteRows = false;
            this.RentCarDataGrid.AllowUserToOrderColumns = true;
            this.RentCarDataGrid.AllowUserToResizeColumns = false;
            this.RentCarDataGrid.AllowUserToResizeRows = false;
            this.RentCarDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentCarDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RentCarDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.RentCarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentCarDataGrid.Location = new System.Drawing.Point(443, 16);
            this.RentCarDataGrid.Name = "RentCarDataGrid";
            this.RentCarDataGrid.ReadOnly = true;
            this.RentCarDataGrid.RowHeadersVisible = false;
            this.RentCarDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RentCarDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentCarDataGrid.Size = new System.Drawing.Size(426, 94);
            this.RentCarDataGrid.TabIndex = 18;
            // 
            // RentLenderDataGrid
            // 
            this.RentLenderDataGrid.AllowUserToAddRows = false;
            this.RentLenderDataGrid.AllowUserToDeleteRows = false;
            this.RentLenderDataGrid.AllowUserToOrderColumns = true;
            this.RentLenderDataGrid.AllowUserToResizeColumns = false;
            this.RentLenderDataGrid.AllowUserToResizeRows = false;
            this.RentLenderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentLenderDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RentLenderDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.RentLenderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentLenderDataGrid.Location = new System.Drawing.Point(12, 16);
            this.RentLenderDataGrid.Name = "RentLenderDataGrid";
            this.RentLenderDataGrid.ReadOnly = true;
            this.RentLenderDataGrid.RowHeadersVisible = false;
            this.RentLenderDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RentLenderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RentLenderDataGrid.Size = new System.Drawing.Size(412, 94);
            this.RentLenderDataGrid.TabIndex = 10;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(595, 261);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(152, 62);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Zurückgeben";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CarLbl
            // 
            this.CarLbl.AutoSize = true;
            this.CarLbl.Location = new System.Drawing.Point(659, 0);
            this.CarLbl.Name = "CarLbl";
            this.CarLbl.Size = new System.Drawing.Size(29, 13);
            this.CarLbl.TabIndex = 2;
            this.CarLbl.Text = "Auto";
            // 
            // LenderLbl
            // 
            this.LenderLbl.AutoSize = true;
            this.LenderLbl.Location = new System.Drawing.Point(199, 0);
            this.LenderLbl.Name = "LenderLbl";
            this.LenderLbl.Size = new System.Drawing.Size(36, 13);
            this.LenderLbl.TabIndex = 1;
            this.LenderLbl.Text = "Mieter";
            this.LenderLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RentBtn
            // 
            this.RentBtn.Location = new System.Drawing.Point(154, 261);
            this.RentBtn.Name = "RentBtn";
            this.RentBtn.Size = new System.Drawing.Size(159, 62);
            this.RentBtn.TabIndex = 0;
            this.RentBtn.Text = "Vermieten";
            this.RentBtn.UseVisualStyleBackColor = true;
            this.RentBtn.Click += new System.EventHandler(this.RentBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Branchlbl);
            this.groupBox1.Controls.Add(this.BranchCbx);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filiale";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Branchlbl
            // 
            this.Branchlbl.AutoSize = true;
            this.Branchlbl.Location = new System.Drawing.Point(10, 26);
            this.Branchlbl.Name = "Branchlbl";
            this.Branchlbl.Size = new System.Drawing.Size(33, 13);
            this.Branchlbl.TabIndex = 1;
            this.Branchlbl.Text = "Filiale";
            this.Branchlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // BranchCbx
            // 
            this.BranchCbx.FormattingEnabled = true;
            this.BranchCbx.Location = new System.Drawing.Point(49, 23);
            this.BranchCbx.Name = "BranchCbx";
            this.BranchCbx.Size = new System.Drawing.Size(236, 21);
            this.BranchCbx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Container);
            this.MinimumSize = new System.Drawing.Size(901, 472);
            this.Name = "Form1";
            this.Text = "Auto-Vermietung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.Container.ResumeLayout(false);
            this.DataPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenderDataGrid)).EndInit();
            this.RentPage.ResumeLayout(false);
            this.RentPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenderCarDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentCarDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentLenderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDataSetBranchBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Container;
        private System.Windows.Forms.TabPage DataPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage RentPage;
        private System.Windows.Forms.Label Branchlbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxManufacturer;
        private System.Windows.Forms.TextBox tbxLicenseTag;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label ManufacturerLbl;
        private System.Windows.Forms.Label LicenseIDLbl;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label AdressLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Button btnLenderDelete;
        private System.Windows.Forms.Button btnLenderCreate;
        private System.Windows.Forms.Label CarLbl;
        private System.Windows.Forms.Label LenderLbl;
        private System.Windows.Forms.Button RentBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView CarDataGridView;
        private System.Windows.Forms.DataGridView LenderDataGrid;
        private System.Windows.Forms.BindingSource bindingSourceDataSetBranchBox;
        private System.Windows.Forms.DataGridView RentLenderDataGrid;
        private System.Windows.Forms.DataGridView RentCarDataGrid;
        private System.Windows.Forms.DataGridView LenderCarDataGrid;
        private System.Windows.Forms.ComboBox BranchCbx;
    }
}

