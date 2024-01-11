using Models.Personel;
using SampleData;
using Email = Models.Personel_Adv.Email;
using Person = Models.Personel_Adv.Person;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            var person = Personel.GetPeopleYasamin();
            dgvUser.DataSource = person;
        }


        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            var selectedUserId = (int)dgvUser.SelectedCells[0].Value; // Get id of selected Cell
            var GridViewDataSource = (List<Person>)dgvUser.DataSource; // Email list of seleced person
            List<Email> emails = new List<Email>();

            foreach (var person in GridViewDataSource)
            {
                if (person.ID == selectedUserId)
                {
                    if (person.Emails.Count > 0)
                    {
                        foreach (var email in person.Emails)
                        {
                            emails.Add(email);
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no email for selected user!","No Email",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

            }

            dgvEmail.DataSource = emails;
            dgvEmail.AutoResizeColumns();
            dgvEmail.AutoResizeRows();
        }

        private void dgvEmails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}