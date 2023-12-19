using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Student\\source\\repos\\WindowsFormsApp2\\Database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT name, address_ID FROM locations", con);
            SqlDataAdapter sda = new SqlDataAdapter();
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string data = reader.GetString(0);
                this.comboBox1.Items.Add(data.Replace(" ", ""));
            }
            string currentCombo = this.comboBox1.SelectedItem as string;
            // TODO: Diese Codezeile lädt Daten in die Tabelle "databaseData.locations". Sie können sie bei Bedarf verschieben oder entfernen.
            this.patientsTableAdapter.Fill(this.databaseData.patients);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if firstNameBox, lastNameBox and phoneBox is defined
            if(String.IsNullOrEmpty(this.firstNameBox.Text.ToString()) || String.IsNullOrEmpty(this.lastNameBox.Text.ToString()) || String.IsNullOrEmpty(this.phoneTextBox.Text.ToString()))
            {
                // Send error Message
            } else
            {
                // Create the Database Connection
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Student\\source\\repos\\WindowsFormsApp2\\Database.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                int combBox = this.comboBox1.SelectedIndex + 1;
                SqlCommand insertPatient = new SqlCommand("INSERT INTO patients (phone, firstname, lastname, address_ID) VALUES (@phoneNumb, @firstname, @lastname , "+combBox+")", con);
                insertPatient.Parameters.AddWithValue("@phoneNumb", this.phoneTextBox.Text);
                insertPatient.Parameters.AddWithValue("@firstname", this.firstNameBox.Text);
                insertPatient.Parameters.AddWithValue("@lastname", this.firstNameBox.Text);
                Console.WriteLine(this.comboBox1.SelectedIndex);
                int i = insertPatient.ExecuteNonQuery();
                con.Close();
                // Update the database
                this.patientsTableAdapter.Update(this.databaseData.patients);

                // Refresh the DataGridView
                this.patientsTableAdapter.Fill(this.databaseData.patients);
            }
        }
    }
}
