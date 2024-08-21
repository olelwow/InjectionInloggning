using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InjectionInloggning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Inloggning()
        {
            
            string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SqlInjectionExample";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Regex som kontrollerar att endast siffror och bokstäver förekommer i användarnamnet.
                Regex r = new Regex("^[a-zA-Z0-9]+$");

                string user = txtUser.Text;
                string pass = txtPass.Text;
                if (!r.IsMatch(user))
                {
                    MessageBox.Show("Username contains unallowed characters.", "Unallowed characters in string", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Query som innehåller parametrar istället för direkta strängar i queryn.
                string sqlQuery = "SELECT * FROM users WHERE username = @username AND password = @password;";
                lblQuerry.Text = sqlQuery;  
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    // Lägger till parametrar och deras värden.
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pass);

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                        lblStatus.Text = "You have logged in.";
                    else
                        lblStatus.Text = "Login failed.";
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inloggning();
        }
    }
}