
namespace Opration
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enrollmantnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editing = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deletes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FirstN = new System.Windows.Forms.Label();
            this.SFN = new System.Windows.Forms.TextBox();
            this.LastN = new System.Windows.Forms.Label();
            this.Enrollmantnum = new System.Windows.Forms.Label();
            this.EnrollNo = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.ContNo = new System.Windows.Forms.TextBox();
            this.SLN = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.Label();
            this.SCN = new System.Windows.Forms.TextBox();
            this.addres = new System.Windows.Forms.Label();
            this.Saddress = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.Enrollmantnumber,
            this.FirstName,
            this.LastName,
            this.ClassName,
            this.ContactNumber,
            this.Address,
            this.Editing,
            this.Deletes});
            this.dataGridView1.Location = new System.Drawing.Point(3, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(923, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "ID";
            this.StudentID.Name = "StudentID";
            // 
            // Enrollmantnumber
            // 
            this.Enrollmantnumber.DataPropertyName = "Enrollmantnumber";
            this.Enrollmantnumber.HeaderText = "Enroll No.";
            this.Enrollmantnumber.Name = "Enrollmantnumber";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.Name = "ClassName";
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "Contact No.";
            this.ContactNumber.Name = "ContactNumber";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Editing
            // 
            this.Editing.HeaderText = "Edit";
            this.Editing.Name = "Editing";
            this.Editing.Text = "Edit";
            this.Editing.UseColumnTextForButtonValue = true;
            // 
            // Deletes
            // 
            this.Deletes.HeaderText = "Delete";
            this.Deletes.Name = "Deletes";
            this.Deletes.Text = "Delete";
            this.Deletes.UseColumnTextForButtonValue = true;
            // 
            // FirstN
            // 
            this.FirstN.AutoSize = true;
            this.FirstN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstN.Location = new System.Drawing.Point(52, 18);
            this.FirstN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(92, 21);
            this.FirstN.TabIndex = 1;
            this.FirstN.Text = "First Name";
            // 
            // SFN
            // 
            this.SFN.Location = new System.Drawing.Point(254, 18);
            this.SFN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SFN.Name = "SFN";
            this.SFN.Size = new System.Drawing.Size(177, 20);
            this.SFN.TabIndex = 8;
            // 
            // LastN
            // 
            this.LastN.AutoSize = true;
            this.LastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastN.Location = new System.Drawing.Point(514, 20);
            this.LastN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(95, 20);
            this.LastN.TabIndex = 9;
            this.LastN.Text = "Last Name";
            // 
            // Enrollmantnum
            // 
            this.Enrollmantnum.AutoSize = true;
            this.Enrollmantnum.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollmantnum.Location = new System.Drawing.Point(52, 49);
            this.Enrollmantnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enrollmantnum.Name = "Enrollmantnum";
            this.Enrollmantnum.Size = new System.Drawing.Size(162, 21);
            this.Enrollmantnum.TabIndex = 10;
            this.Enrollmantnum.Text = "Enrollmant Number";
            // 
            // EnrollNo
            // 
            this.EnrollNo.Location = new System.Drawing.Point(254, 50);
            this.EnrollNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnrollNo.Name = "EnrollNo";
            this.EnrollNo.Size = new System.Drawing.Size(177, 20);
            this.EnrollNo.TabIndex = 11;
            this.EnrollNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(514, 50);
            this.contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(139, 20);
            this.contact.TabIndex = 12;
            this.contact.Text = "Contact Number";
            // 
            // ContNo
            // 
            this.ContNo.Location = new System.Drawing.Point(696, 46);
            this.ContNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContNo.Name = "ContNo";
            this.ContNo.Size = new System.Drawing.Size(200, 20);
            this.ContNo.TabIndex = 13;
            this.ContNo.TextChanged += new System.EventHandler(this.ContNo_TextChanged);
            // 
            // SLN
            // 
            this.SLN.Location = new System.Drawing.Point(696, 19);
            this.SLN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SLN.Name = "SLN";
            this.SLN.Size = new System.Drawing.Size(200, 20);
            this.SLN.TabIndex = 14;
            this.SLN.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(52, 78);
            this.Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(104, 20);
            this.Class.TabIndex = 15;
            this.Class.Text = "Class Name";
            // 
            // SCN
            // 
            this.SCN.Location = new System.Drawing.Point(254, 80);
            this.SCN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SCN.Name = "SCN";
            this.SCN.Size = new System.Drawing.Size(177, 20);
            this.SCN.TabIndex = 16;
            // 
            // addres
            // 
            this.addres.AutoSize = true;
            this.addres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addres.Location = new System.Drawing.Point(514, 76);
            this.addres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(75, 20);
            this.addres.TabIndex = 17;
            this.addres.Text = "Address";
            // 
            // Saddress
            // 
            this.Saddress.Location = new System.Drawing.Point(696, 76);
            this.Saddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Saddress.Name = "Saddress";
            this.Saddress.Size = new System.Drawing.Size(200, 20);
            this.Saddress.TabIndex = 18;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(327, 108);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 41);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(485, 108);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 41);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Saddress);
            this.Controls.Add(this.addres);
            this.Controls.Add(this.SCN);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.SLN);
            this.Controls.Add(this.ContNo);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.EnrollNo);
            this.Controls.Add(this.Enrollmantnum);
            this.Controls.Add(this.LastN);
            this.Controls.Add(this.SFN);
            this.Controls.Add(this.FirstN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enrollmantnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn Editing;
        private System.Windows.Forms.DataGridViewButtonColumn Deletes;
        private System.Windows.Forms.Label FirstN;
        private System.Windows.Forms.TextBox SFN;
        private System.Windows.Forms.Label LastN;
        private System.Windows.Forms.Label Enrollmantnum;
        private System.Windows.Forms.TextBox EnrollNo;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.TextBox ContNo;
        private System.Windows.Forms.TextBox SLN;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.TextBox SCN;
        private System.Windows.Forms.Label addres;
        private System.Windows.Forms.TextBox Saddress;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
    }
}

