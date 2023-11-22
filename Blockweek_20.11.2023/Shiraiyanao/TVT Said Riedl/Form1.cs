using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVT_Said_Riedl
{
    public partial class TVT : Form
    {

        patients patient = new patients();
        addresses address = new addresses();

        public TVT()
        {
            InitializeComponent();
        }

        private void textBox_patient_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_patient_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_patient_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_savePatient_Click(object sender, EventArgs e)
        {
            patient.firstname = textBox_patient_firstName.Text.Trim();
            patient.lastname = textBox_patient_lastName.Text.Trim();
            patient.phone = texBox_patient_phone.Text.Trim();

            using (Database1Entities dbe = new Database1Entities())
            {
                dbe.patients.Add(patient);
                dbe.SaveChanges();
            }

            dgvPatient.AutoGenerateColumns = false;
            using (Database1Entities db = new Database1Entities())
            {
                dgvPatient.DataSource = db.patients.ToList<patients>();
            }

            MessageBox.Show("Submitted successfully!");

            if (patient.address_id == null)
            {
                DialogResult result = MessageBox.Show("This patient has no address, do you want to add a new address?","Address missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                switch (result) 
                {
                    case DialogResult.Yes:
                        tabControl1.SelectedTab = tab_addresses;
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPatientsInAddressTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ConnectAddressWithPatient_Click(object sender, EventArgs e)
        {
            int selected_patID = Convert.ToInt32(dgvPatient.CurrentRow.Cells["pat_id"].Value);
            int selected_addID = Convert.ToInt32(dgvAddress.CurrentRow.Cells["add_id"].Value);

            using (Database1Entities dbe = new Database1Entities())
            {
                patient = dbe.patients.Where(x => x.pat_id == selected_patID).FirstOrDefault();
                patient.address_id = selected_addID;

                dgvPatient.AutoGenerateColumns = false;
                dgvPatient.DataSource = dbe.patients.ToList<patients>();
                dbe.SaveChanges();
            }
        }

        private void button_saveAddress_Click(object sender, EventArgs e)
        {
            address.street = textBox_street.Text.Trim();
            address.nr = textBox_nr.Text.Trim();
            address.postal = textBox_postal.Text.Trim();
            address.city = textBox_city.Text.Trim();

            using (Database1Entities dbe = new Database1Entities())
            {
                dbe.addresses.Add(address);
                dbe.SaveChanges();
            }

            dgvAddress.AutoGenerateColumns = false;
            using (Database1Entities db = new Database1Entities())
            {
                dgvAddress.DataSource = db.addresses.ToList<addresses>();
            }

            MessageBox.Show("Submitted successfully!");
        }

        private void button_overrideAddress_Click(object sender, EventArgs e)
        {
            int selected_addID = Convert.ToInt32(dgvAddress.CurrentRow.Cells["add_id"].Value);

            using (Database1Entities dbe = new Database1Entities())
            {
                address = dbe.addresses.Where(x => x.add_id == selected_addID).FirstOrDefault();
                address.street = textBox_street.Text.Trim();
                address.nr = textBox_nr.Text.Trim();
                address.postal = textBox_postal.Text.Trim();
                address.city = textBox_city.Text.Trim();

                dgvAddress.AutoGenerateColumns = false;
                dgvAddress.DataSource = dbe.patients.ToList<patients>();
                dbe.SaveChanges();
            }

            dgvAddress.AutoGenerateColumns = false;
            using (Database1Entities db = new Database1Entities())
            {
                dgvAddress.DataSource = db.addresses.ToList<addresses>();
            }
        }
    }
}
