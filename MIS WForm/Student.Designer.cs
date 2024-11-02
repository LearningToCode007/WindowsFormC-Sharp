namespace MIS_WForm
{
    partial class Student
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
            this.txtclgemail = new System.Windows.Forms.TextBox();
            this.txtcollegeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtstphone = new System.Windows.Forms.TextBox();
            this.txtstEmail = new System.Windows.Forms.TextBox();
            this.txtstName = new System.Windows.Forms.TextBox();
            this.txtstid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcollegeAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtstrength = new System.Windows.Forms.TextBox();
            this.txtdeptName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.db_new_misDataSet = new MIS_WForm.db_new_misDataSet();
            this.studentGetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentGetTableAdapter = new MIS_WForm.db_new_misDataSetTableAdapters.StudentGetTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAllGetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_new_misDataSet1 = new MIS_WForm.db_new_misDataSet1();
            this.studentAllGetTableAdapter = new MIS_WForm.db_new_misDataSet1TableAdapters.StudentAllGetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_new_misDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAllGetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_new_misDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtclgemail
            // 
            this.txtclgemail.Location = new System.Drawing.Point(665, 186);
            this.txtclgemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtclgemail.Name = "txtclgemail";
            this.txtclgemail.Size = new System.Drawing.Size(276, 22);
            this.txtclgemail.TabIndex = 7;
            // 
            // txtcollegeName
            // 
            this.txtcollegeName.Location = new System.Drawing.Point(156, 186);
            this.txtcollegeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtcollegeName.Name = "txtcollegeName";
            this.txtcollegeName.Size = new System.Drawing.Size(360, 22);
            this.txtcollegeName.TabIndex = 6;
            this.txtcollegeName.TextChanged += new System.EventHandler(this.txtcollegeName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "College Email ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "College Name";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(344, 350);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(147, 28);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(692, 350);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(523, 350);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 28);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtstphone
            // 
            this.txtstphone.Location = new System.Drawing.Point(588, 96);
            this.txtstphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtstphone.Name = "txtstphone";
            this.txtstphone.Size = new System.Drawing.Size(353, 22);
            this.txtstphone.TabIndex = 5;
            this.txtstphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstphone_KeyPress);
            // 
            // txtstEmail
            // 
            this.txtstEmail.Location = new System.Drawing.Point(122, 96);
            this.txtstEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtstEmail.Name = "txtstEmail";
            this.txtstEmail.Size = new System.Drawing.Size(339, 22);
            this.txtstEmail.TabIndex = 4;
            // 
            // txtstName
            // 
            this.txtstName.Location = new System.Drawing.Point(588, 53);
            this.txtstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtstName.Name = "txtstName";
            this.txtstName.Size = new System.Drawing.Size(353, 22);
            this.txtstName.TabIndex = 3;
            // 
            // txtstid
            // 
            this.txtstid.Location = new System.Drawing.Point(122, 59);
            this.txtstid.Margin = new System.Windows.Forms.Padding(4);
            this.txtstid.Name = "txtstid";
            this.txtstid.Size = new System.Drawing.Size(135, 22);
            this.txtstid.TabIndex = 1;
            this.txtstid.TextChanged += new System.EventHandler(this.txtstid_TextChanged);
            this.txtstid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstid_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Student Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(51, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "College Details";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtcollegeAddress
            // 
            this.txtcollegeAddress.Location = new System.Drawing.Point(156, 229);
            this.txtcollegeAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtcollegeAddress.Name = "txtcollegeAddress";
            this.txtcollegeAddress.Size = new System.Drawing.Size(555, 22);
            this.txtcollegeAddress.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "College Address";
            // 
            // txtstrength
            // 
            this.txtstrength.Location = new System.Drawing.Point(680, 306);
            this.txtstrength.Margin = new System.Windows.Forms.Padding(4);
            this.txtstrength.Name = "txtstrength";
            this.txtstrength.Size = new System.Drawing.Size(261, 22);
            this.txtstrength.TabIndex = 10;
            this.txtstrength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstrength_KeyPress);
            // 
            // txtdeptName
            // 
            this.txtdeptName.Location = new System.Drawing.Point(161, 306);
            this.txtdeptName.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeptName.Name = "txtdeptName";
            this.txtdeptName.Size = new System.Drawing.Size(360, 22);
            this.txtdeptName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 315);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Strength";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 310);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Department Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(51, 276);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Department Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // db_new_misDataSet
            // 
            this.db_new_misDataSet.DataSetName = "db_new_misDataSet";
            this.db_new_misDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentGetBindingSource
            // 
            this.studentGetBindingSource.DataMember = "StudentGet";
            this.studentGetBindingSource.DataSource = this.db_new_misDataSet;
            // 
            // studentGetTableAdapter
            // 
            this.studentGetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentEmailDataGridViewTextBoxColumn,
            this.collegeNameDataGridViewTextBoxColumn,
            this.collegeEmailDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentAllGetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(88, 463);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(803, 170);
            this.dataGridView1.TabIndex = 45;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "Student Email";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "Student Email";
            this.studentEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            this.studentEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // collegeNameDataGridViewTextBoxColumn
            // 
            this.collegeNameDataGridViewTextBoxColumn.DataPropertyName = "College Name";
            this.collegeNameDataGridViewTextBoxColumn.HeaderText = "College Name";
            this.collegeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collegeNameDataGridViewTextBoxColumn.Name = "collegeNameDataGridViewTextBoxColumn";
            this.collegeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // collegeEmailDataGridViewTextBoxColumn
            // 
            this.collegeEmailDataGridViewTextBoxColumn.DataPropertyName = "College Email";
            this.collegeEmailDataGridViewTextBoxColumn.HeaderText = "College Email";
            this.collegeEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.collegeEmailDataGridViewTextBoxColumn.Name = "collegeEmailDataGridViewTextBoxColumn";
            this.collegeEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentAllGetBindingSource
            // 
            this.studentAllGetBindingSource.DataMember = "StudentAllGet";
            this.studentAllGetBindingSource.DataSource = this.db_new_misDataSet1;
            // 
            // db_new_misDataSet1
            // 
            this.db_new_misDataSet1.DataSetName = "db_new_misDataSet1";
            this.db_new_misDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentAllGetTableAdapter
            // 
            this.studentAllGetTableAdapter.ClearBeforeFill = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1312, 662);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtstrength);
            this.Controls.Add(this.txtdeptName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcollegeAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtclgemail);
            this.Controls.Add(this.txtcollegeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtstphone);
            this.Controls.Add(this.txtstEmail);
            this.Controls.Add(this.txtstName);
            this.Controls.Add(this.txtstid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_new_misDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAllGetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_new_misDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtclgemail;
        private System.Windows.Forms.TextBox txtcollegeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtstphone;
        private System.Windows.Forms.TextBox txtstEmail;
        private System.Windows.Forms.TextBox txtstName;
        private System.Windows.Forms.TextBox txtstid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcollegeAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtstrength;
        private System.Windows.Forms.TextBox txtdeptName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource studentGetBindingSource;
        private db_new_misDataSet db_new_misDataSet;
        private db_new_misDataSetTableAdapters.StudentGetTableAdapter studentGetTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_new_misDataSet1 db_new_misDataSet1;
        private System.Windows.Forms.BindingSource studentAllGetBindingSource;
        private db_new_misDataSet1TableAdapters.StudentAllGetTableAdapter studentAllGetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}