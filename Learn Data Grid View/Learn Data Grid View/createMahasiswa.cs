using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_Data_Grid_View
{
    public partial class createMahasiswa : Form
    {
        public createMahasiswa()
        {
            InitializeComponent();
        }

        private void createMahasiswa_Load(object sender, EventArgs e) //ini kepencet bang oawkaokaw
        {

        }

        public Mahasiswa GetMahasiswa()
        {
            // Parse semester to int
            int semester;
            int.TryParse(textBox3.Text, out semester);

            // Create and return Mahasiswa object
            return new Mahasiswa(textBox1.Text, textBox2.Text, semester, textBox4.Text);
        }

        // Helper method to parse TextBox input to an integer
        private int intParse(TextBox textBox)
        {
            int result;
            if (int.TryParse(textBox.Text, out result))
            {
                return result;
            }
            else
            {
                MessageBox.Show("Invalid semester value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Default to 0 if parsing fails
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mahasiswa mahasiswa = GetMahasiswa();

            // Pass the Mahasiswa object back to Form1
            Form1 mainForm = (Form1)this.Owner; // Assuming Form1 is the owner of this form
            mainForm.AddMahasiswa(mahasiswa);

            // Close the current form
            this.Close();
        }
    }
}
