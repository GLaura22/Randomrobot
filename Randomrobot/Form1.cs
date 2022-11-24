using Newtonsoft.Json;

namespace Randomrobot
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

        private async void Button1_Click(object sender, EventArgs e)
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
                    cimke2.Text = String.Join(" ", "E-mail: ", rawdata.results[0].email, " ", "Gender: ", rawdata.results[0].gender);
                    pictureBox1.Load(rawdata.results[0].picture.large.ToString());
                    robotPicBox.Load("https://robohash.org/" + rawdata.results[0].name.first);

                    
                }

                catch (Exception ex)
                {
                    cimke1.Text = "wrong data";
                    cimke2.Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox("Who would have thought?");
        }
    }
}