namespace ContactBook
{
	partial class Form1
	{

		private System.ComponentModel.IContainer components = null;


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnShowAll = new Button();
            lblDetails = new Label();
            lstContacts = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя:";
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Телефон:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(100, 67);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 27);
            txtPhone.TabIndex = 3;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Категория:";
            // 
            // cmbCategory
            // 
         cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Семья", "Работа", "Друзья", "Другое" });
            cmbCategory.Location = new Point(100, 107);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 28);
            cmbCategory.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(140, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(250, 160);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(120, 30);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Показать всех";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(400, 210);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(0, 20);
            lblDetails.TabIndex = 10;
            // 
            // lstContacts
            // 
            lstContacts.FormattingEnabled = true;
            lstContacts.Location = new Point(30, 210);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(340, 144);
            lstContacts.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 403);
            Controls.Add(lstContacts);
            Controls.Add(lblDetails);
            Controls.Add(btnShowAll);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Книга контактов";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TextBox txtName;
		private TextBox textBox1;
		private Label label2;
		private TextBox txtPhone;
		private TextBox textBox2;
		private Label label3;
		private ComboBox cmbCategory;
		private Button btnAdd;
		private Button btnDelete;
		private ComboBox comboBox1;
		private Button button1;
		private Button button2;
		private Button btnShowAll;
		private Label lblDetails;
		private ListBox lstContacts;
	}
}
