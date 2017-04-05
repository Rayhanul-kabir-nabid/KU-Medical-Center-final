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
    public partial class Execution : Form
    {
        public Execution()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Execution_Load(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
          

        private void textBox_preId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                SqlDataAdapter sd = new SqlDataAdapter("Select Prescription.Std_Id, Student.Name, Prescription.Doc_Id, Doctor.Name, Description, Date from Student, Doctor, Prescription  where Prescription.Std_Id=Student.Std_Id and Prescription.Doc_Id=Doctor.Doc_Id and Prescription.Presp_id= '" + textBox_preId.Text + "'", con);
                DataSet dt1 = new DataSet();
                sd.Fill(dt1);
                dataGridView2.DataSource = dt1.Tables[0];
                textBox_Std_Id.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                textBox_Name.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                textBox_Doc_Id.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                textBox_DocName.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
                textBox_Description.Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
                label3.Text = dataGridView2.Rows[0].Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                textBox_Std_Id.Clear();
                textBox_Name.Clear();
                textBox_Doc_Id.Clear();
                textBox_DocName.Clear();
                textBox_Description.Clear();
                



            }
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                SqlDataAdapter sd = new SqlDataAdapter("Select Med_pres.Med_id, Medicine.Name, Med_pres.Quantity from Medicine, Prescription, Med_pres where  Prescription.Presp_id= '" + textBox_preId.Text + "'and Prescription.Presp_id=Med_pres.Pres_id and Med_pres.Med_id=Medicine.Med_id", con);
                DataSet dt2 = new DataSet();
                sd.Fill(dt2);
                dataGridView1.DataSource = dt2.Tables[0];

               

            }
            catch(Exception ex)
            {
                dataGridView1.Rows.Clear();
            }
            //try
            //{
            //    string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
            //    SqlConnection con = new SqlConnection(conString);
            //    SqlDataAdapter sd1 = new SqlDataAdapter("Select  Med_pres.Med_id, Medicine.Name, Med_pres.Quantity, Doc_Id, Description, Date from Medicine, Prescription, Med_pres where  Prescription.Std_Id= '" + textBox_Std_Id.Text + "'and Prescription.Presp_id=Med_pres.Pres_id and Med_pres.Med_id=Medicine.Med_id", con);
            //    DataSet dt3 = new DataSet();
            //    sd1.Fill(dt3);
            //    dataGridView3.DataSource = dt3.Tables[0];
            //}
            ////SqlCommand cmd = new SqlCommand("Select Medicine.Name, Med_pres.Quantity from Medicine, Prescription, Med_pres where Med_pres.Med_id=Medicine.Med_id and Prescription.Presp_id=Med_pres.Pres_id and Prescription.Presp_id= '" +textBox_preId.Text + "'",con);
            ////con.Open();
            //catch(Exception ex)
            //{
            //    dataGridView3.Rows.Clear();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
            this.Hide();
        }

        private void TextBox_Std_Id_testChaned(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                SqlDataAdapter sd1 = new SqlDataAdapter("Select  Med_pres.Med_id, Medicine.Name, Med_pres.Quantity, Doc_Id, Description, Date from Medicine, Prescription, Med_pres where  Prescription.Std_Id= '" + textBox_Std_Id.Text + "'and Prescription.Presp_id=Med_pres.Pres_id and Med_pres.Med_id=Medicine.Med_id", con);
                DataSet dt3 = new DataSet();
                sd1.Fill(dt3);
                dataGridView3.DataSource = dt3.Tables[0];
            }
            //SqlCommand cmd = new SqlCommand("Select Medicine.Name, Med_pres.Quantity from Medicine, Prescription, Med_pres where Med_pres.Med_id=Medicine.Med_id and Prescription.Presp_id=Med_pres.Pres_id and Prescription.Presp_id= '" +textBox_preId.Text + "'",con);
            //con.Open();
            catch(Exception ex)
            {
                dataGridView3.Rows.Clear();
            }
        
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
            
        
        
    }
}
