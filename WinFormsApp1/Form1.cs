namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SampleData.Personel.GetPeople();
            dataGridView1.DataSource = SampleData.Personel.GetPeople();
        }
    }
}