using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KU_Medical_Center
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                //SqlDataAdapter sda = new SqlDataAdapter("select Type from Authority where UserId=' " + textboxUserId.Text + "' and Password='" + textBoxPassword.Text + "'", con);
               // DataTable dt = new DataTable();
                //sda.Fill(dt);
                SqlCommand cmd = new SqlCommand("select Type from Authority where UserId=' " + textboxUserId.Text + "' and Password='" + textBoxPassword.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                string type = null;
                for (int i = 0; reader.Read(); i++)
                {
                   type = reader[0].ToString();
                
                }
                reader.Close();
                if (string.IsNullOrEmpty(textboxUserId.Text) | string.IsNullOrEmpty(textBoxPassword.Text))
                    MessageBox.Show("provide ID and Password");
                 
                else if(type == "Admin")
                {
                    Work ss = new Work();
                    ss.giveData(this.label1.Text="Sonam", this.label2.Text="Administrative");
                    ss.Show();
                    this.Hide();
                }
                else if (type == "SubAdmin")
                {
                    Prescription pre=new Prescription();
                    pre.Show();
                    this.Hide();
                }
                
                else
                {
                    MessageBox.Show("access Denied");
                }
            }
        catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void bill_button_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
        }
    }
}
