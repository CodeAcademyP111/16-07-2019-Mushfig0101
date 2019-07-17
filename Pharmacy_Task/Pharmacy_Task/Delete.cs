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
    public partial class Delete : Form
    {
        private Depo deldepo;
        private DataGridView deldgvID;
        public Delete(Depo djepo, DataGridView dgv)
        {
            InitializeComponent();
             deldepo = djepo;
             deldgvID = dgv;
            txtcomboBox.DataSource = deldepo.GetMedicines();


        }

        private void TxtDelete_Click(object sender, EventArgs e)
        {
          
            int delid = int.Parse(txtcomboBox.SelectedValue.ToString().Substring(0,2).Trim());

            deldepo.DeleteMedicine(delid);
            txtcomboBox.DataSource = null;
            deldgvID.DataSource = null;
            txtcomboBox.DataSource = deldepo.GetMedicines();
            deldgvID.DataSource = deldepo.GetMedicines();
        }
    }
}
