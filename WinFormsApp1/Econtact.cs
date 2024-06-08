using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp1.econtactClasses;

namespace WinFormsApp1
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }
        ContactClass c = new ContactClass();

        //add button function
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textFirstName.Text) && !string.IsNullOrEmpty(textBoxLastName.Text) && !string.IsNullOrEmpty(textBoxContactNo.Text))
            {
                //Get the value from the input fields
                c.FirstName = textFirstName.Text;
                c.LastName = textBoxLastName.Text;
                c.ContactNo = textBoxContactNo.Text;
                c.Address = textBoxAddress.Text;
                c.Gender = comboBoxGender.Text;

                //Insert data into database
                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("New Contact Successfully Inserted");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add New Contact. Try again.");
                }

                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
            }
        }

        //display contact info in grid view
        private void Econtact_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        //close the app when close icon is click
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clear function
        private void Clear()
        { 
            textBoxContactID.Text = "";
            textFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.SelectedIndex = -1;
        }

        //update button function
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            if (!string.IsNullOrEmpty(textBoxContactID.Text))
            {
                c.ContactID = int.Parse(textBoxContactID.Text);
                c.FirstName = textFirstName.Text;
                c.LastName = textBoxLastName.Text;
                c.ContactNo = textBoxContactNo.Text;
                c.Address = textBoxAddress.Text;
                c.Gender = comboBoxGender.Text;


                //update data into database
                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Contact Has Been Update Successfully.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add update Contact. Try again.");
                }

                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
            }
        }

        //grid view row click function
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxContactID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textFirstName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContactNo.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
        }

        //clear button function
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //delete button function
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxContactID.Text))
            {
                c.ContactID = Convert.ToInt32(textBoxContactID.Text);
                bool success = c.Delete(c);
                if (success == true)
                {
                    MessageBox.Show("Contact Successfully Deleted.");
                    Clear();
                    DataTable dt = c.Select();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed to add delete Contact. Try again.");
                }
            }
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TableContact WHERE ContactID LIKE '%" + keyword + "%' OR FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
