using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Fragen an Markus:
 * Soll es möglich sein Niederlassungen anzulegen bzw. zu entfernen?
 * Antwort Markus:
 * Nein
 * 
 * Bitte die Namensgebung der Form Elemente überdenken. 
 * z.B.: Statt DeleteBtn lieber btnDeleteUser etc.
 */

namespace Carsharing
{
    public partial class Form1 : Form, IUi
    {
        private CarsharingSystem carsharinginstance;//Deklaration
        public DataSet dataImage;
        private BindingSource bindingSourceLender = new BindingSource();
        private BindingSource bindingSourceCar = new BindingSource();


        public void show()
        {   //Initialisiere Form Elemente
            InitializeComponent();
            carsharinginstance = new CarsharingSystem(); //Testinstanz
            loadDatasets();
        }
        private void loadDatasets()
        {
            //Custom stuff
            carsharinginstance.LoadData();//Lade Daten in's DataSet der Klasse Carsharing
            dataImage = this.carsharinginstance.GetDataSet();//Speichert das DataSet der Klasse Carsharing in einem eigenem DataSet

            //DataBindings an Steuerelemente
            SetBindings();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NameTbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteLenderBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetBindings()
        {
            //vorher unbedingt das dataImage laden, da sonst nicht die aktuellsten Daten angezeigt werden
            dataImage = this.carsharinginstance.GetDataSet();
            //DataSet via Binding Source Laden
            BranchCbx.DisplayMember = "name";//Anzuzeigende Spalte...
            bindingSourceDataSetBranchBox.DataSource = this.dataImage.Tables["T_Carsharing"];//Binden der Tabelle an die BindingSource
            BranchCbx.DataSource = bindingSourceDataSetBranchBox; //Binden der BindingSource an die ComboBox
            bindingSourceDataSetBranchBox.ResetBindings(true); //Resette Bindings

            //LenderDataGrid
            //Binding Source füllen
            bindingSourceLender.DataSource = this.dataImage.Tables["T_Lender"];
            //LenderDataGrid.AutoGenerateColumns = false;
            LenderDataGrid.DataSource = bindingSourceLender;
            LenderDataGrid.RowHeadersVisible = false;
            //Spalten benennen
            LenderDataGrid.Columns[0].HeaderText = "Mitarbeiter ID";
            LenderDataGrid.Columns[1].HeaderText = "Name";
            LenderDataGrid.Columns[2].HeaderText = "Alter";
            LenderDataGrid.Columns[3].HeaderText = "Adresse";
            LenderDataGrid.MultiSelect = false;
            LenderDataGrid.ReadOnly = true;
            //Spalten automatisch anzeigen
            bindingSourceLender.ResetBindings(true);

            //CarDataGrid
            //Binding Source füllen
            bindingSourceCar.DataSource = this.dataImage.Tables["T_Car"];
            //LenderDataGrid.AutoGenerateColumns = false;
            CarDataGridView.DataSource = bindingSourceCar;
            CarDataGridView.RowHeadersVisible = false;
            //Spalten benennen
            CarDataGridView.Columns[0].HeaderText = "Kennzeichen";
            CarDataGridView.Columns[1].HeaderText = "Modell";
            CarDataGridView.Columns[2].HeaderText = "Hersteller";
            CarDataGridView.Columns[3].HeaderText = "Preis pro Tag";
            CarDataGridView.Columns[4].Visible = false;
            CarDataGridView.MultiSelect = false;
            CarDataGridView.ReadOnly = true;
            //Spalten automatisch anzeigen
            bindingSourceCar.ResetBindings(true);
        }

        private void btnLenderCreate_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Bitte Namen eintragen." + System.Environment.NewLine + "Verarbeitung unterbrochen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(tbxAdress.Text))
            {
                MessageBox.Show("Bitte Adresse angeben." + System.Environment.NewLine + "Verarbeitung unterbrochen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(tbxAge.Text))
            {
                MessageBox.Show("Bitte Alter eintragen." + System.Environment.NewLine + "Verarbeitung unterbrochen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
        }

            carsharinginstance.CreateLender(tbxName.Text, Convert.ToInt32(tbxAge.Text), tbxAdress.Text);
            tbxName.Text = "";
            tbxAdress.Text = "";
            tbxAge.Text = "";
            loadDatasets();
        }

        private void btnLenderDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = LenderDataGrid.CurrentRow;
            int lenderID = Convert.ToInt32(row.Cells[0].Value);
            if (MessageBox.Show("Wollen Sie wirklich den Mieter mit der Nummer " + Convert.ToString(lenderID) + " löschen?", "Löschen bestätigen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                carsharinginstance.RemoveLender(lenderID);
                loadDatasets();
            }
        }
    }
}
