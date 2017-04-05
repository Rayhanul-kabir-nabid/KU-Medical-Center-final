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
    public partial class Work : Form
    {
        public Work()
        {
            InitializeComponent();
        }

        private void Work_Load(object sender, EventArgs e)
        {
            name_label.Text = name;
            type_label.Text = type;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Age.Text != null && textBox_contact.Text != null && textBox_SearchID.Text != null && textBox_stdName.Text != null && textbox_discipline.Text != null && comboBox1.Text != null && textBox_Nationality.Text != null && comboBox2.Text != null)
                {
                    
                    string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                    //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    
                    //SqlCommand cmd = new SqlCommand("insert into Student  (Std_Id,Name,Discipline,Gender,Age,Nationality,Blood_Group,Contact_no) values("+ textBox_SearchID.Text+" ,'"+textBox_stdName.Text+"','"+textbox_discipline.Text+"','"+comboBox1.Text+ "'," + textBox_Age.Text + ",'" + textBox_Nationality.Text + "','" + comboBox2.Text + "','" + textBox_contact.Text + "' ", con);
                    //SqlDataReader red = cmd.ExecuteReader();
                    //red.Close();
                    SqlCommand cmd = new SqlCommand("insert into Student  (Std_Id,Name,Discipline,Gender,Age,Nationality,Blood_Group,Contact_no) values (@textBox_SearchID,@Name,@Discipline,@Gender,@Age,@Nationality,@Blood_Group,@Contact_no)", con);
                    cmd.Parameters.AddWithValue("@textBox_SearchID", (textBox_SearchID.Text));
                    cmd.Parameters.AddWithValue("@Name", (textBox_stdName.Text));
                    cmd.Parameters.AddWithValue("@Discipline", (textbox_discipline.Text));
                    cmd.Parameters.AddWithValue("@Gender", (comboBox1.Text));
                    cmd.Parameters.AddWithValue("@Age", textBox_Age.Text);
                    cmd.Parameters.AddWithValue("@Nationality", (textBox_Nationality.Text));
                    cmd.Parameters.AddWithValue("@Blood_Group", (comboBox2.Text));
                    cmd.Parameters.AddWithValue("@Contact_no", (textBox_contact.Text));
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Entry Succsessful!!!");
                    clear();
                }
                else
                {
                    MessageBox.Show("Insert Data & then click save!!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        string name;
        string type;
        public void giveData(string n, string t)
        {
            name=n;
            type=t;
        }

    
    
        void clear()
        {
            textBox_Age.Clear();
            textBox_contact.Clear();
            textbox_discipline.Clear();
            textBox_Nationality.Clear();
            textBox_stdName.Clear();
            comboBox2.ResetText();
            comboBox1.ResetText();
        }

        //student search
        private void textBox_SearchID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                           
                // conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                SqlDataAdapter sd = new SqlDataAdapter("select * from Student where Std_Id='" + textBox_SearchID.Text + " ' ", con);
                DataSet dt = new DataSet();
                sd.Fill(dt);
                dataGridView1.DataSource = dt.Tables[0];
                textBox_stdName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                textbox_discipline.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                textBox_Age.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                textBox_Nationality.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                textBox_contact.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                con.Close();
                
            }
            catch
            {
                clear();
            }
        }

        public string text { get; set; }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }



        //doctor
        private void button_DocSave_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                           
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                //SqlCommand cmd = new SqlCommand("insert into Student (Std_Id,Name,Discipline,Gender,Age,Nationality,Blood_Group,Contact_no) values("+ textBox_SearchID.Text+" ,'"+textBox_stdName.Text+"','"+textbox_discipline.Text+"','"+comboBox1.Text+ "'," + textBox_Age.Text + ",'" + textBox_Nationality.Text + "','" + comboBox2.Text + "','" + textBox_contact.Text + "' )" ,con);
                //SqlDataReader red = cmd.ExecuteReader();
                //red.Close();
                SqlCommand cmd = new SqlCommand("insert into Doctor  (Doc_Id,Name,Designation,Contact_no) values (@DocId,@Name,@Designation,@Contact_no)", con);
                cmd.Parameters.AddWithValue("@DocId", (textBox_DocId.Text));
                cmd.Parameters.AddWithValue("@Name", (textBox_DocName.Text));
                cmd.Parameters.AddWithValue("@Designation", (textBox_DocDes.Text));
                cmd.Parameters.AddWithValue("@Contact_no", (textBox_DocCont.Text));
                cmd.ExecuteNonQuery();


                MessageBox.Show("Entry Succsessful!!!");
                clearDoctor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clearDoctor()
        {
            textBox_DocName.Clear();
            textBox_DocDes.Clear();
            textBox_DocCont.Clear();
        }
        private void textBox_DocID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                        
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con1 = new SqlConnection(conString);
                SqlDataAdapter sd1 = new SqlDataAdapter("select * from Doctor where Doc_Id='" + textBox_DocId.Text + " ' ", con1);
                DataSet dt1 = new DataSet();
                sd1.Fill(dt1);
                dataGridView2.DataSource = dt1.Tables[0];
                textBox_DocName.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                textBox_DocDes.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                textBox_DocCont.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
                con1.Close();

            }
            catch
            {
                clearDoctor();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //medicine
        private void btn_MedEntry_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                        
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                //SqlCommand cmd = new SqlCommand("insert into Student (Std_Id,Name,Discipline,Gender,Age,Nationality,Blood_Group,Contact_no) values("+ textBox_SearchID.Text+" ,'"+textBox_stdName.Text+"','"+textbox_discipline.Text+"','"+comboBox1.Text+ "'," + textBox_Age.Text + ",'" + textBox_Nationality.Text + "','" + comboBox2.Text + "','" + textBox_contact.Text + "' )" ,con);
                //SqlDataReader red = cmd.ExecuteReader();
                //red.Close();
                SqlCommand cmd = new SqlCommand("insert into Medicine  (Med_id,Name,Quantity,Entry_Date) values (@Med_id,@Name,@Quantity,@Entry_Date)", con);
                cmd.Parameters.AddWithValue("@Med_id", (textBox_MedId.Text));
                cmd.Parameters.AddWithValue("@Name", (textBox_MedName.Text));
                cmd.Parameters.AddWithValue("@Quantity", (textBox_MedQuantity.Text));
                cmd.Parameters.AddWithValue("@Entry_Date", (dateTimePicker_Med.Value.Date));
                cmd.ExecuteNonQuery();


                MessageBox.Show("Entry Succsessful!!!");
                clearMed();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void clearMed()
        {
            textBox_MedName.Clear();
            textBox_MedQuantity.Clear();
          
        }
        private void textBox_MedId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con3 = new SqlConnection(conString);
                SqlDataAdapter sd3 = new SqlDataAdapter("select * from Medicine where Med_id='" + textBox_MedId.Text + " ' ", con3);
                DataSet dt3 = new DataSet();
                sd3.Fill(dt3);
                dataGridView3.DataSource = dt3.Tables[0];
                textBox_MedName.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
                textBox_MedQuantity.Text = dataGridView3.Rows[0].Cells[2].Value.ToString();
                dateTimePicker_Med.Text = dataGridView3.Rows[0].Cells[3].Value.ToString();
               con3.Close();

            }
            catch
            {
                clearMed();
            }
        }
        //Equipment
        private void btn_Equipment_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                        
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                //SqlCommand cmd = new SqlCommand("insert into Student (Std_Id,Name,Discipline,Gender,Age,Nationality,Blood_Group,Contact_no) values("+ textBox_SearchID.Text+" ,'"+textBox_stdName.Text+"','"+textbox_discipline.Text+"','"+comboBox1.Text+ "'," + textBox_Age.Text + ",'" + textBox_Nationality.Text + "','" + comboBox2.Text + "','" + textBox_contact.Text + "' )" ,con);
                //SqlDataReader red = cmd.ExecuteReader();
                //red.Close();
                SqlCommand cmd = new SqlCommand("insert into Equipment  (Eq_Id,Name,Quantity,Entry_Date) values (@Eq_Id,@Name,@Quantity,@Entry_Date)", con);
                cmd.Parameters.AddWithValue("@Eq_Id", (textBox_EquId.Text));
                cmd.Parameters.AddWithValue("@Name", (textBox_EquName.Text));
                cmd.Parameters.AddWithValue("@Quantity", (textBox_EquQuantity.Text));
                cmd.Parameters.AddWithValue("@Entry_Date", (dateTimePicker_Equ.Value.Date));
                cmd.ExecuteNonQuery();


                MessageBox.Show("Entry Succsessful!!!");
                clearEqu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void clearEqu()
        {
            textBox_EquName.Clear();
            textBox_EquQuantity.Clear();

        }
        private void textBox_EquId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                        
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con4 = new SqlConnection(conString);
                SqlDataAdapter sd4 = new SqlDataAdapter("select * from Equipment where Eq_Id='" + textBox_EquId.Text + " ' ", con4);
                DataSet dt4 = new DataSet();
                sd4.Fill(dt4);
                dataGridView4.DataSource = dt4.Tables[0];
                textBox_EquName.Text = dataGridView4.Rows[0].Cells[1].Value.ToString();
                textBox_EquQuantity.Text = dataGridView4.Rows[0].Cells[2].Value.ToString();
                dateTimePicker_Equ.Text = dataGridView4.Rows[0].Cells[3].Value.ToString();
                con4.Close();

            }
            catch
            {
                clearEqu();
            }
        }

        Prescription pre = new Prescription();
        private void button1_Click(object sender, EventArgs e)
        {
            pre.Show();
        }

        //Stuff Entry
        private void btn_stuff_Click(object sender, EventArgs e)
        {
            try 
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                       
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Staff  (Staff_id,Name,Designation,Contact) values (@Staff_id,@Name,@Designation,@Contact)", con);
                cmd.Parameters.AddWithValue("@Staff_id", (textBox_StaffId.Text));
                cmd.Parameters.AddWithValue("@Name", (textBox_stName.Text));
                cmd.Parameters.AddWithValue("@Designation", (textBox_stDes.Text));
                cmd.Parameters.AddWithValue("@Contact", (textBox_stCon.Text));
                cmd.ExecuteNonQuery();


                MessageBox.Show("Entry Succsessful!!!");
                clearStaff();
            }
            catch
            {

            }
        }
        void clearStaff()
        {
            textBox_stName.Clear();
            textBox_stDes.Clear();
            textBox_stCon.Clear();

        }
        private void textBox_StaffId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=(localdb)\v11.0;Initial Catalog=E:\CODE\C# PRACTICE\KU MEDICAL CENTER\KU MEDICAL CENTER\BIN\DEBUG\MEDICALCENTER.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                        
                //string conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\SE final1\KU Medical Center\KU Medical Center\MedicalCenter.mdf;Integrated Security=True";
                SqlConnection con5 = new SqlConnection(conString);
                SqlDataAdapter sd5 = new SqlDataAdapter("select * from Staff where Staff_id='" + textBox_StaffId.Text + " ' ", con5);
                DataSet dt5 = new DataSet();
                sd5.Fill(dt5);
                //dataGridView1.DataSource = dt5.Tables[0];
                dataGridView6.DataSource = dt5.Tables[0];
                textBox_stName.Text = dataGridView6.Rows[0].Cells[1].Value.ToString();
                textBox_stDes.Text = dataGridView6.Rows[0].Cells[2].Value.ToString();
                textBox_stCon.Text = dataGridView6.Rows[0].Cells[3].Value.ToString();
                con5.Close();

            }
            catch
            {
                clearStaff();
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
            this.Hide();
        }






    }
}
