using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Database
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Database.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        //Show Date and Frequency if you search someone.
        private void ShowDateFreq()
        {
            nameTextBox.ResetText();
            frequency.ResetText();
            MostRecentVisitText.ResetText();
            nameTextBox.AppendText(textSearch.Text);
            string query = "SELECT a.MostRecentVisit , a.Frequency FROM Person a " +
                "WHERE a.Name = @Name";
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", textSearch.Text);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    MostRecentVisitText.AppendText(reader.GetDateTime(0).ToString());
                    frequency.AppendText(reader.GetInt32(1).ToString() + " times");
                }
                else
                {
                    AddPerson();
                }
            }
        }
        //Add if not existed
        private void AddPerson()
        {
            string query = "INSERT INTO Person VALUES (@Name, @Date, 0)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textSearch.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                MostRecentVisitText.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"));
                frequency.AppendText("0");
                command.ExecuteReader();
            }
        }
        //Frequency++, MostRecentVisit Updated
        private void IncFreqSetRecentDate()
        {
            string query = "UPDATE Person SET Frequency = Frequency + 1, " +
                "MostRecentVisit = @Date WHERE Name = @Name";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textSearch.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.ExecuteReader();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDateFreq();
            IncFreqSetRecentDate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt");
        }

























        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulatePerson();
        }

        private void PopulatePerson()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Person", connection))
            {
                DataTable personTable = new DataTable();
                adapter.Fill(personTable);

                lstPerson.DisplayMember = "Name";
                lstPerson.ValueMember = "Id";
                lstPerson.DataSource = personTable;
            }
        }

        private void PopulateDiet()
        {
            string query = "SELECT a.Diet FROM Dietary a " +
                "INNER JOIN PersonDiet b ON a.Id = b.DietaryId " +
            "WHERE b.PersonId = @PersonId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PersonId", lstPerson.SelectedValue);
                DataTable dietTable = new DataTable();
                adapter.Fill(dietTable);

                lstDiet.DisplayMember = "Diet";
                lstDiet.ValueMember = "Id";
                lstDiet.DataSource = dietTable;
            }
        }

        private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDiet();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Person VALUES (@Name, '2017-11-23', 0)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textPersonName.Text);
                command.ExecuteScalar();
            }
            PopulatePerson();
        }

        private void updatePerson_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Person SET Name = @Name WHERE Id = @PersonId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Name", textPersonName.Text);
                command.Parameters.AddWithValue("@PersonId", lstPerson.SelectedValue);
                command.ExecuteScalar();
            }
            PopulatePerson();
        }
    }
}
