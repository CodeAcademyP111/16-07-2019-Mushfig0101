using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Task
{
    public partial class Form1 : Form
    {
        private Depo gldepo; 
        private DataGridView dgvID;
        public Form1()
        {
            InitializeComponent();
            Depo depo = new Depo("Med_Depo");
            gldepo = depo;
            dgvID = dataGridViewID;
            dgvID.DataSource = gldepo.GetMedicines();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string type = txtType.Text.Trim();
            string price = txtPrice.Text.Trim();
            if (name == null || type == null || price == null) {
                MessageBox.Show("Zehmet olmasa xanalari doldurun","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Medicine medicine = new Medicine() { Name = name, Type = type, Price = price };

            gldepo.AddMedicine(medicine);
            dgvID.DataSource = null;
            dgvID.DataSource = gldepo.GetMedicines();
            txtname.Text = null;
            txtType.Text = null;
            txtPrice.Text = null;


        }

        private void TxtDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(gldepo, dgvID);
            delete.Show();
        }

        private int globalupID;
        private void DataGridViewID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
           int upID = int.Parse(dgvID.Rows[e.RowIndex].Cells[0].Value.ToString());
            globalupID = upID;
            Medicine medicine = gldepo.ChosenMedicine(upID);
            txtname.Text = medicine.Name;
            txtType.Text = medicine.Type;
            txtPrice.Text = medicine.Price;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            string name = txtname.Text.Trim();
            string type = txtType.Text.Trim();
            string price = txtPrice.Text.Trim();
            if (name == null || type == null || price == null)
            {
                MessageBox.Show("Zehmet olmasa xanalari doldurun", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            gldepo.UpdateMedicine(globalupID, name, type, price);
            dgvID.DataSource = null;
            dgvID.DataSource = gldepo.GetMedicines();


        }

        private void Stripmenuadd_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
        }
        
        private void Stripmenuupdate_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
        }
    }
}

