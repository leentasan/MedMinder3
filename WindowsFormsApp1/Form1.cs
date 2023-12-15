using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Database1DataSet;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);

        }

        private void initial_TimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Dapatkan nilai dari kontrol input
            DateTime initialTime = initial_TimeDateTimePicker.Value;

            // Dapatkan objek data dari BindingSource
            Table1Row medicineRow = (Table1Row)table1BindingSource.Current;

            // Set nilai data
            medicineRow.Table1.InitialTime = initialTime;

            // Perbarui data dalam database
            table1TableAdapter.Update(medicineRow);
        }

        private void consumption_TimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Dapatkan nilai dari kontrol input
            int consumptionTime = consumption_TimeNumericUpDown.Value;

            // Dapatkan objek data dari BindingSource
            Table1Row medicineRow = (Table1Row)table1BindingSource.Current;

            // Set nilai data
            medicineRow.ConsumptionTime = consumptionTime;

            // Perbarui data dalam database
            table1TableAdapter.Update(medicineRow);

        }

        private void medicine_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Dapatkan nilai dari kontrol input
            string medicineName = medicine_NameTextBox.Text;

            // Dapatkan objek data dari BindingSource
            Table1Row medicineRow = (Table1Row)table1BindingSource.Current;

            // Set nilai data
            medicineRow.MedicineName = medicineName;

            // Perbarui data dalam database
            table1TableAdapter.Update(medicineRow);
        }
    }
}
