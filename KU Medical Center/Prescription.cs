using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KU_Medical_Center
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                        
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con5 = new SqlConnection(conString);
                SqlDataAdapter sd5 = new SqlDataAdapter("select * from Prescription", con5);
                DataSet dt5 = new DataSet();
                sd5.Fill(dt5);

                int a = Convert.ToInt32(dt5.Tables[0].Rows.Count.ToString());
                a++;
                textBox_preId.Text = a.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // TODO: This line of code loads data into the 'medicalCenterDataSet1.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter1.Fill(this.medicalCenterDataSet1.Medicine);
            // TODO: This line of code loads data into the 'medicalCenterDataSet.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.medicalCenterDataSet.Medicine);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("Select * from Student where Std_Id = '"+textBox_Std_Id.Text+"'",con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textBox_Name.Text = (string)reader["Name"];
                textBox_Discipline.Text = (string)reader["Discipline"];
                textBox_Gender.Text = (string)reader["Gender"];
                textBox_Age.Text =Convert.ToString( (Int32)reader["Age"]);
                textBox_BloodGrp.Text = (string)reader["Blood_Group"];
                reader.Close();
                con.Close();      
            }
            catch
            {
                clear();
            }
        }
        void clear()
        {
            textBox_Age.Clear();
            textBox_BloodGrp.Clear();
            textBox_Discipline.Clear();
            textBox_Name.Clear();
            textBox_Gender.Clear();

        }









        int i = 0;
        private void textBox_Doc_Id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                        
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("Select * from Doctor where Doc_Id = '" + textBox_Doc_Id.Text + "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textBox_DocName.Text = (string)reader["Name"];
                textBox_Desination.Text = (string)reader["Designation"];
                textBox_ContactNo.Text = (string)reader["Contact_no"];
                reader.Close();
                con.Close();
            }
            catch
            {
                clearDoc();
            }
        }
        void clearDoc()
        {
            textBox_DocName.Clear();
            textBox_Desination.Clear();
            textBox_ContactNo.Clear();

        }




        int med_ID;
        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                string a = list_med_box.Text;

                SqlCommand cmd = new SqlCommand("Select * from Medicine where Name = '" +a+ "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int existing_Qn = (Int32)reader["Quantity"];
                med_ID = (Int32)reader["Med_id"];
                int select_Qn = Convert.ToInt32(textBox_Quantity.Text);
                int dif = existing_Qn - select_Qn;
                reader.Close();
                con.Close();
                if (dif >= 0)
                {
                    SqlCommand cmd1 = new SqlCommand("Update Medicine Set Quantity = '" + dif + "' where Med_id = '" + med_ID + "'", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i].Cells[0].Value = med_ID.ToString();
                    dataGridView1.Rows[i].Cells[1].Value = a;
                    dataGridView1.Rows[i].Cells[2].Value = textBox_Quantity.Text;
                    
                    i++;
                   // MessageBox.Show("Entry Succsessful!!!");
                    
                        
                    
                    textBox_Quantity.Clear();
                    textBox_Av_Quantity.Clear();
                }
                else
                {
                    MessageBox.Show("Qunatity is not available");
                }  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


          
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox_search_textChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con5 = new SqlConnection(conString);
                SqlDataAdapter sd5 = new SqlDataAdapter("select Name from Medicine where '" + textBox_search.Text + " ' is null or Name like CONCAT('%','"+textBox_search.Text+"','%')", con5);
                DataSet dt5 = new DataSet();
                sd5.Fill(dt5);
                list_med_box.DataSource = dt5.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void list_med_box_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                      
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                SqlCommand cmd1 = new SqlCommand("select Quantity from Medicine where Name = '" + list_med_box.Text+ "'", con);
                con.Open();

                SqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                int existing_Qn = (Int32)reader["Quantity"];
                textBox_Av_Quantity.Text = existing_Qn.ToString();
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Execution exe = new Execution();

        private void checkOut_button_Click(object sender, EventArgs e)
        {
            try
            { //insert into prescription table
                if (string.IsNullOrEmpty(textBox_Doc_Id.Text) | string.IsNullOrEmpty(textBox_Std_Id.Text) | string.IsNullOrEmpty(textBox_Description.Text)|dataGridView1.Rows.Count<=1)
                {
                    MessageBox.Show("Complete Input fully.");
                }
                else
                {
                    string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                    
                    //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Prescription  (Std_Id,Doc_Id,Date,Description) values (@Std_Id,@Doc_Id,@Date,@Description)", con);
                    cmd.Parameters.AddWithValue("@Std_Id", (textBox_Std_Id.Text));
                    cmd.Parameters.AddWithValue("@Doc_Id", (textBox_Doc_Id.Text));
                    cmd.Parameters.AddWithValue("@Date", (dateTimePicker1.Value));
                    cmd.Parameters.AddWithValue("Description", (textBox_Description.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Entry Succsessful");
                    textBox_Std_Id.Clear();
                    textBox_Doc_Id.Clear();
                    clear();
                    clearDoc();

                    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                    {
                        string conString1 = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                    
                        //string conString1 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                        SqlConnection con1 = new SqlConnection(conString1);
                        con1.Open();
                        SqlCommand cmd2 = new SqlCommand("insert into Med_pres (Pres_id,Med_id,Quantity)values(@Pres_id,@Med_id,@Quantity)", con1);
                        cmd2.Parameters.AddWithValue("@Pres_id", (textBox_preId.Text));
                        cmd2.Parameters.AddWithValue("@Med_id", (dataGridView1.Rows[j].Cells[0].Value));
                        cmd2.Parameters.AddWithValue("@Quantity", (dataGridView1.Rows[j].Cells[2].Value));
                        cmd2.ExecuteNonQuery();
                        con1.Close();

                    }
                
                }
                    //med_pres insert
                   
                   
                
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
 
            }
            //MessageBox.Show(dataGridView1.Rows.Count.ToString());
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
            this.Hide();
        }

        private void button_viewpres_Click(object sender, EventArgs e)
        {
            exe.Show();
           
        }
        
            


        
    }
}
