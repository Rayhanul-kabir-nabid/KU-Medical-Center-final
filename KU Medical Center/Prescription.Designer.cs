namespace KU_Medical_Center
{
    partial class Prescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Std_Id = new System.Windows.Forms.TextBox();
            this.textBox_Doc_Id = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalCenterDataSet = new KU_Medical_Center.MedicalCenterDataSet();
            this.medicineTableAdapter = new KU_Medical_Center.MedicalCenterDataSetTableAdapters.MedicineTableAdapter();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_BloodGrp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Gender = new System.Windows.Forms.TextBox();
            this.textBox_Discipline = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_ContactNo = new System.Windows.Forms.TextBox();
            this.textBox_Desination = new System.Windows.Forms.TextBox();
            this.textBox_DocName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Av_Quantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.list_med_box = new System.Windows.Forms.ListBox();
            this.medicineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalCenterDataSet1 = new KU_Medical_Center.MedicalCenterDataSet1();
            this.medicineTableAdapter1 = new KU_Medical_Center.MedicalCenterDataSet1TableAdapters.MedicineTableAdapter();
            this.checkOut_button = new System.Windows.Forms.Button();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_preId = new System.Windows.Forms.TextBox();
            this.button_logOut = new System.Windows.Forms.Button();
            this.button_viewpres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCenterDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCenterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logged in as : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medicine:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(662, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Se Quantity: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox_Std_Id
            // 
            this.textBox_Std_Id.Location = new System.Drawing.Point(106, 21);
            this.textBox_Std_Id.Name = "textBox_Std_Id";
            this.textBox_Std_Id.Size = new System.Drawing.Size(251, 20);
            this.textBox_Std_Id.TabIndex = 9;
            this.textBox_Std_Id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Doc_Id
            // 
            this.textBox_Doc_Id.Location = new System.Drawing.Point(111, 20);
            this.textBox_Doc_Id.Name = "textBox_Doc_Id";
            this.textBox_Doc_Id.Size = new System.Drawing.Size(251, 20);
            this.textBox_Doc_Id.TabIndex = 9;
            this.textBox_Doc_Id.TextChanged += new System.EventHandler(this.textBox_Doc_Id_TextChanged);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(748, 114);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(173, 23);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(651, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine ID";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column3
            // 
            this.column3.DataPropertyName = "Name";
            this.column3.HeaderText = "Medicine Name";
            this.column3.Name = "column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.medicalCenterDataSet;
            // 
            // medicalCenterDataSet
            // 
            this.medicalCenterDataSet.DataSetName = "MedicalCenterDataSet";
            this.medicalCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineTableAdapter
            // 
            this.medicineTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(748, 83);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(173, 20);
            this.textBox_Quantity.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox_BloodGrp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_Age);
            this.groupBox1.Controls.Add(this.textBox_Gender);
            this.groupBox1.Controls.Add(this.textBox_Discipline);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.textBox_Std_Id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 218);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Blood Group:";
            // 
            // textBox_BloodGrp
            // 
            this.textBox_BloodGrp.Location = new System.Drawing.Point(106, 177);
            this.textBox_BloodGrp.Name = "textBox_BloodGrp";
            this.textBox_BloodGrp.Size = new System.Drawing.Size(251, 20);
            this.textBox_BloodGrp.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Age:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Discipline:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name:";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(106, 145);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(251, 20);
            this.textBox_Age.TabIndex = 9;
            // 
            // textBox_Gender
            // 
            this.textBox_Gender.Location = new System.Drawing.Point(106, 114);
            this.textBox_Gender.Name = "textBox_Gender";
            this.textBox_Gender.Size = new System.Drawing.Size(251, 20);
            this.textBox_Gender.TabIndex = 9;
            // 
            // textBox_Discipline
            // 
            this.textBox_Discipline.Location = new System.Drawing.Point(106, 83);
            this.textBox_Discipline.Name = "textBox_Discipline";
            this.textBox_Discipline.Size = new System.Drawing.Size(251, 20);
            this.textBox_Discipline.TabIndex = 9;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(106, 52);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(251, 20);
            this.textBox_Name.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_ContactNo);
            this.groupBox2.Controls.Add(this.textBox_Desination);
            this.groupBox2.Controls.Add(this.textBox_DocName);
            this.groupBox2.Controls.Add(this.textBox_Doc_Id);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 153);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_ContactNo
            // 
            this.textBox_ContactNo.Location = new System.Drawing.Point(111, 110);
            this.textBox_ContactNo.Name = "textBox_ContactNo";
            this.textBox_ContactNo.Size = new System.Drawing.Size(251, 20);
            this.textBox_ContactNo.TabIndex = 9;
            // 
            // textBox_Desination
            // 
            this.textBox_Desination.Location = new System.Drawing.Point(111, 80);
            this.textBox_Desination.Name = "textBox_Desination";
            this.textBox_Desination.Size = new System.Drawing.Size(251, 20);
            this.textBox_Desination.TabIndex = 9;
            // 
            // textBox_DocName
            // 
            this.textBox_DocName.Location = new System.Drawing.Point(111, 50);
            this.textBox_DocName.Name = "textBox_DocName";
            this.textBox_DocName.Size = new System.Drawing.Size(251, 20);
            this.textBox_DocName.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Contact No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Designation:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Doctor Name:";
            // 
            // textBox_Av_Quantity
            // 
            this.textBox_Av_Quantity.Location = new System.Drawing.Point(748, 50);
            this.textBox_Av_Quantity.Name = "textBox_Av_Quantity";
            this.textBox_Av_Quantity.Size = new System.Drawing.Size(173, 20);
            this.textBox_Av_Quantity.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(662, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Av Quantity: ";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(451, 7);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(163, 20);
            this.textBox_search.TabIndex = 18;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_textChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(404, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Search";
            // 
            // list_med_box
            // 
            this.list_med_box.DataSource = this.medicineBindingSource1;
            this.list_med_box.DisplayMember = "Name";
            this.list_med_box.FormattingEnabled = true;
            this.list_med_box.Location = new System.Drawing.Point(451, 33);
            this.list_med_box.Name = "list_med_box";
            this.list_med_box.Size = new System.Drawing.Size(163, 121);
            this.list_med_box.TabIndex = 20;
            this.list_med_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_med_box_MouseClick);
            // 
            // medicineBindingSource1
            // 
            this.medicineBindingSource1.DataMember = "Medicine";
            this.medicineBindingSource1.DataSource = this.medicalCenterDataSet1;
            // 
            // medicalCenterDataSet1
            // 
            this.medicalCenterDataSet1.DataSetName = "MedicalCenterDataSet1";
            this.medicalCenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineTableAdapter1
            // 
            this.medicineTableAdapter1.ClearBeforeFill = true;
            // 
            // checkOut_button
            // 
            this.checkOut_button.Location = new System.Drawing.Point(726, 506);
            this.checkOut_button.Name = "checkOut_button";
            this.checkOut_button.Size = new System.Drawing.Size(138, 23);
            this.checkOut_button.TabIndex = 21;
            this.checkOut_button.Text = "Check Out";
            this.checkOut_button.UseVisualStyleBackColor = true;
            this.checkOut_button.Click += new System.EventHandler(this.checkOut_button_Click);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(423, 214);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(163, 112);
            this.textBox_Description.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(420, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Description:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(20, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Prescription Id:";
            // 
            // textBox_preId
            // 
            this.textBox_preId.Enabled = false;
            this.textBox_preId.Location = new System.Drawing.Point(123, 70);
            this.textBox_preId.Name = "textBox_preId";
            this.textBox_preId.Size = new System.Drawing.Size(100, 20);
            this.textBox_preId.TabIndex = 26;
            // 
            // button_logOut
            // 
            this.button_logOut.Location = new System.Drawing.Point(916, 7);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(75, 23);
            this.button_logOut.TabIndex = 27;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // button_viewpres
            // 
            this.button_viewpres.Location = new System.Drawing.Point(451, 370);
            this.button_viewpres.Name = "button_viewpres";
            this.button_viewpres.Size = new System.Drawing.Size(75, 23);
            this.button_viewpres.TabIndex = 28;
            this.button_viewpres.Text = "View";
            this.button_viewpres.UseVisualStyleBackColor = true;
            this.button_viewpres.Click += new System.EventHandler(this.button_viewpres_Click);
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1049, 541);
            this.Controls.Add(this.button_viewpres);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.textBox_preId);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.checkOut_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.list_med_box);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.textBox_Av_Quantity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCenterDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalCenterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_Std_Id;
        private System.Windows.Forms.TextBox textBox_Doc_Id;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicalCenterDataSet medicalCenterDataSet;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private MedicalCenterDataSetTableAdapters.MedicineTableAdapter medicineTableAdapter;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_BloodGrp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_Gender;
        private System.Windows.Forms.TextBox textBox_Discipline;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ContactNo;
        private System.Windows.Forms.TextBox textBox_Desination;
        private System.Windows.Forms.TextBox textBox_DocName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Av_Quantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox list_med_box;
        private MedicalCenterDataSet1 medicalCenterDataSet1;
        private System.Windows.Forms.BindingSource medicineBindingSource1;
        private MedicalCenterDataSet1TableAdapters.MedicineTableAdapter medicineTableAdapter1;
        private System.Windows.Forms.Button checkOut_button;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_preId;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Button button_viewpres;
    }
}