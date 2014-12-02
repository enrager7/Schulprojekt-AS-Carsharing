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
            this.Container = new System.Windows.Forms.TabControl();
            this.DataPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteCarBtn = new System.Windows.Forms.Button();
            this.CreateCarBtn = new System.Windows.Forms.Button();
            this.pricetbx = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.modelLbl = new System.Windows.Forms.Label();
            this.ManufacturerLbl = new System.Windows.Forms.Label();
            this.LicenseIDLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteLenderBtn = new System.Windows.Forms.Button();
            this.CreateLenderBtn = new System.Windows.Forms.Button();
            this.AgeTbx = new System.Windows.Forms.TextBox();
            this.AdressTbx = new System.Windows.Forms.TextBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.AdressLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.RentPage = new System.Windows.Forms.TabPage();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CarLbl = new System.Windows.Forms.Label();
            this.LenderLbl = new System.Windows.Forms.Label();
            this.RentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Branchlbl = new System.Windows.Forms.Label();
            this.BranchCbx = new System.Windows.Forms.ComboBox();
            this.LenderDataGrid = new System.Windows.Forms.DataGridView();
            this.CarDataGridView = new System.Windows.Forms.DataGridView();
            this.Container.SuspendLayout();
            this.DataPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RentPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
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
            this.groupBox3.Controls.Add(this.CarDataGridView);
            this.groupBox3.Controls.Add(this.DeleteCarBtn);
            this.groupBox3.Controls.Add(this.CreateCarBtn);
            this.groupBox3.Controls.Add(this.pricetbx);
            this.groupBox3.Controls.Add(this.priceLbl);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.modelLbl);
            this.groupBox3.Controls.Add(this.ManufacturerLbl);
            this.groupBox3.Controls.Add(this.LicenseIDLbl);
            this.groupBox3.Location = new System.Drawing.Point(440, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 338);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // DeleteCarBtn
            // 
            this.DeleteCarBtn.Location = new System.Drawing.Point(353, 73);
            this.DeleteCarBtn.Name = "DeleteCarBtn";
            this.DeleteCarBtn.Size = new System.Drawing.Size(75, 43);
            this.DeleteCarBtn.TabIndex = 16;
            this.DeleteCarBtn.Text = "Löschen";
            this.DeleteCarBtn.UseVisualStyleBackColor = true;
            // 
            // CreateCarBtn
            // 
            this.CreateCarBtn.Location = new System.Drawing.Point(353, 28);
            this.CreateCarBtn.Name = "CreateCarBtn";
            this.CreateCarBtn.Size = new System.Drawing.Size(75, 39);
            this.CreateCarBtn.TabIndex = 15;
            this.CreateCarBtn.Text = "Erstellen";
            this.CreateCarBtn.UseVisualStyleBackColor = true;
            // 
            // pricetbx
            // 
            this.pricetbx.Location = new System.Drawing.Point(156, 122);
            this.pricetbx.Name = "pricetbx";
            this.pricetbx.Size = new System.Drawing.Size(176, 20);
            this.pricetbx.TabIndex = 14;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(74, 125);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(30, 13);
            this.priceLbl.TabIndex = 13;
            this.priceLbl.Text = "Preis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 10;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(74, 99);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(38, 13);
            this.modelLbl.TabIndex = 9;
            this.modelLbl.Text = "Modell";
            // 
            // ManufacturerLbl
            // 
            this.ManufacturerLbl.AutoSize = true;
            this.ManufacturerLbl.Location = new System.Drawing.Point(74, 68);
            this.ManufacturerLbl.Name = "ManufacturerLbl";
            this.ManufacturerLbl.Size = new System.Drawing.Size(51, 13);
            this.ManufacturerLbl.TabIndex = 8;
            this.ManufacturerLbl.Text = "Hersteller";
            // 
            // LicenseIDLbl
            // 
            this.LicenseIDLbl.AutoSize = true;
            this.LicenseIDLbl.Location = new System.Drawing.Point(74, 36);
            this.LicenseIDLbl.Name = "LicenseIDLbl";
            this.LicenseIDLbl.Size = new System.Drawing.Size(69, 13);
            this.LicenseIDLbl.TabIndex = 7;
            this.LicenseIDLbl.Text = "Kennzeichen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LenderDataGrid);
            this.groupBox2.Controls.Add(this.DeleteLenderBtn);
            this.groupBox2.Controls.Add(this.CreateLenderBtn);
            this.groupBox2.Controls.Add(this.AgeTbx);
            this.groupBox2.Controls.Add(this.AdressTbx);
            this.groupBox2.Controls.Add(this.NameTbx);
            this.groupBox2.Controls.Add(this.AgeLbl);
            this.groupBox2.Controls.Add(this.AdressLbl);
            this.groupBox2.Controls.Add(this.NameLbl);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 338);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mieter";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DeleteLenderBtn
            // 
            this.DeleteLenderBtn.Location = new System.Drawing.Point(334, 73);
            this.DeleteLenderBtn.Name = "DeleteLenderBtn";
            this.DeleteLenderBtn.Size = new System.Drawing.Size(75, 43);
            this.DeleteLenderBtn.TabIndex = 8;
            this.DeleteLenderBtn.Text = "Löschen";
            this.DeleteLenderBtn.UseVisualStyleBackColor = true;
            this.DeleteLenderBtn.Click += new System.EventHandler(this.DeleteLenderBtn_Click);
            // 
            // CreateLenderBtn
            // 
            this.CreateLenderBtn.Location = new System.Drawing.Point(334, 28);
            this.CreateLenderBtn.Name = "CreateLenderBtn";
            this.CreateLenderBtn.Size = new System.Drawing.Size(75, 39);
            this.CreateLenderBtn.TabIndex = 7;
            this.CreateLenderBtn.Text = "Erstellen";
            this.CreateLenderBtn.UseVisualStyleBackColor = true;
            // 
            // AgeTbx
            // 
            this.AgeTbx.Location = new System.Drawing.Point(105, 96);
            this.AgeTbx.Name = "AgeTbx";
            this.AgeTbx.Size = new System.Drawing.Size(176, 20);
            this.AgeTbx.TabIndex = 6;
            // 
            // AdressTbx
            // 
            this.AdressTbx.Location = new System.Drawing.Point(105, 65);
            this.AdressTbx.Name = "AdressTbx";
            this.AdressTbx.Size = new System.Drawing.Size(176, 20);
            this.AdressTbx.TabIndex = 5;
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(105, 33);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(176, 20);
            this.NameTbx.TabIndex = 4;
            this.NameTbx.TextChanged += new System.EventHandler(this.NameTbx_TextChanged);
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Location = new System.Drawing.Point(23, 99);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(28, 13);
            this.AgeLbl.TabIndex = 3;
            this.AgeLbl.Text = "Alter";
            // 
            // AdressLbl
            // 
            this.AdressLbl.AutoSize = true;
            this.AdressLbl.Location = new System.Drawing.Point(23, 68);
            this.AdressLbl.Name = "AdressLbl";
            this.AdressLbl.Size = new System.Drawing.Size(45, 13);
            this.AdressLbl.TabIndex = 2;
            this.AdressLbl.Text = "Adresse";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(23, 36);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // RentPage
            // 
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
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 262);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Löschen";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // CarLbl
            // 
            this.CarLbl.AutoSize = true;
            this.CarLbl.Location = new System.Drawing.Point(540, 31);
            this.CarLbl.Name = "CarLbl";
            this.CarLbl.Size = new System.Drawing.Size(29, 13);
            this.CarLbl.TabIndex = 2;
            this.CarLbl.Text = "Auto";
            // 
            // LenderLbl
            // 
            this.LenderLbl.AutoSize = true;
            this.LenderLbl.Location = new System.Drawing.Point(217, 31);
            this.LenderLbl.Name = "LenderLbl";
            this.LenderLbl.Size = new System.Drawing.Size(36, 13);
            this.LenderLbl.TabIndex = 1;
            this.LenderLbl.Text = "Mieter";
            this.LenderLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RentBtn
            // 
            this.RentBtn.Location = new System.Drawing.Point(12, 103);
            this.RentBtn.Name = "RentBtn";
            this.RentBtn.Size = new System.Drawing.Size(75, 23);
            this.RentBtn.TabIndex = 0;
            this.RentBtn.Text = "Vermieten";
            this.RentBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            // LenderDataGrid
            // 
            this.LenderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LenderDataGrid.Location = new System.Drawing.Point(5, 182);
            this.LenderDataGrid.Name = "LenderDataGrid";
            this.LenderDataGrid.Size = new System.Drawing.Size(423, 150);
            this.LenderDataGrid.TabIndex = 9;
            // 
            // CarDataGridView
            // 
            this.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDataGridView.Location = new System.Drawing.Point(3, 182);
            this.CarDataGridView.Name = "CarDataGridView";
            this.CarDataGridView.Size = new System.Drawing.Size(426, 150);
            this.CarDataGridView.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Container);
            this.Name = "Form1";
            this.Text = "Auto-Vermietung";
            this.Container.ResumeLayout(false);
            this.DataPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RentPage.ResumeLayout(false);
            this.RentPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LenderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Container;
        private System.Windows.Forms.TabPage DataPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage RentPage;
        private System.Windows.Forms.Label Branchlbl;
        private System.Windows.Forms.ComboBox BranchCbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pricetbx;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label ManufacturerLbl;
        private System.Windows.Forms.Label LicenseIDLbl;
        private System.Windows.Forms.TextBox AgeTbx;
        private System.Windows.Forms.TextBox AdressTbx;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label AdressLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button DeleteCarBtn;
        private System.Windows.Forms.Button CreateCarBtn;
        private System.Windows.Forms.Button DeleteLenderBtn;
        private System.Windows.Forms.Button CreateLenderBtn;
        private System.Windows.Forms.Label CarLbl;
        private System.Windows.Forms.Label LenderLbl;
        private System.Windows.Forms.Button RentBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView CarDataGridView;
        private System.Windows.Forms.DataGridView LenderDataGrid;
    }
}

