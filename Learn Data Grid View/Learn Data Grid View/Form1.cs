using System.Collections.Generic;

namespace Learn_Data_Grid_View
{
    public partial class Form1 : Form
    {
        private List<Mahasiswa> list = new List<Mahasiswa>();
        public Form1()
        {
            InitializeComponent();
            List<Mahasiswa> list = new List<Mahasiswa>();
            Mahasiswa mahasiswa = new Mahasiswa("Alex", "232410101099", 5, "alex@gmail.com");

            list.Add(mahasiswa);
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createMahasiswa createMahasiswaForm = new createMahasiswa();
            createMahasiswaForm.Owner = this; // Set the owner to the current Form1
            createMahasiswaForm.ShowDialog();
        }

        public void AddMahasiswa(Mahasiswa mahasiswa)
        {
            List<Mahasiswa> list = (List<Mahasiswa>)dataGridView1.DataSource;

            // If DataSource is null, create a new list
            if (list == null)
            {
                list = new List<Mahasiswa>();
                dataGridView1.DataSource = list;
            }

            // Add the new Mahasiswa to the list
            list.Add(mahasiswa);

            // Refresh the DataGridView
            dataGridView1.DataSource = null; // Reset DataSource
            dataGridView1.DataSource = list; // Reassign DataSource
        }
    }
}
