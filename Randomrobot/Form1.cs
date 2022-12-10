using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
//using System.Drawing;

namespace Randomrobot
{
    public partial class Form1 : Form
    {
        SQLiteConnection con;
        public SQLiteCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source = Robot.db");
            con.Open();

            cmd = new SQLiteCommand(con);
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            using (con = new SQLiteConnection("Data Source = Robot.db"))
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("https://api.randomuser.me");
                        var response = await client.GetAsync("https://api.randomuser.me");
                        response.EnsureSuccessStatusCode();

                        var stringResult = await response.Content.ReadAsStringAsync();
                        var rawdata = JsonConvert.DeserializeObject<Rootobject>(stringResult);
                        cimke1.Text = String.Join(" ", "Name:", rawdata.results[0].name.first, rawdata.results[0].name.last);
                        cimke2.Text = String.Join(" ", "E-mail: ", rawdata.results[0].email);
                        genderCimke.Text = String.Join(" ", "Gender: ", rawdata.results[0].gender);
                        pictureBox1.Load(rawdata.results[0].picture.large.ToString());
                        robotPicBox.Load("https://robohash.org/" + rawdata.results[0].name.first);

                        String name = rawdata.results[0].name.first + ' ' + rawdata.results[0].name.last;
                        String gender = rawdata.results[0].gender;
                        String email = rawdata.results[0].email;

                        cmd.CommandText = "INSERT INTO veletlenfelh(nev, nem, email) VALUES(@name, @gender, @email)";
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@email", email); 
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        cimke1.Text = "*****";
                        cimke2.Text = "*****";
                        genderCimke.Text = "*****";
                    }
                    con.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nice");
        }
    }
}