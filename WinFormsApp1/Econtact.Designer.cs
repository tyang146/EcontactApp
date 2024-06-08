namespace WinFormsApp1
{
    partial class Econtact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            pictureBoxLogo = new PictureBox();
            labelContactID = new Label();
            textBoxContactID = new TextBox();
            textFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxContactNo = new TextBox();
            labelContactNo = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            comboBoxGender = new ComboBox();
            labelGender = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(337, 21);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(315, 71);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelContactID
            // 
            labelContactID.AutoSize = true;
            labelContactID.BackColor = Color.Transparent;
            labelContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactID.Location = new Point(60, 115);
            labelContactID.Name = "labelContactID";
            labelContactID.Size = new Size(82, 21);
            labelContactID.TabIndex = 1;
            labelContactID.Text = "Contact ID";
            // 
            // textBoxContactID
            // 
            textBoxContactID.Font = new Font("Segoe UI", 12F);
            textBoxContactID.Location = new Point(200, 112);
            textBoxContactID.Name = "textBoxContactID";
            textBoxContactID.ReadOnly = true;
            textBoxContactID.Size = new Size(186, 29);
            textBoxContactID.TabIndex = 2;
            // 
            // textFirstName
            // 
            textFirstName.Font = new Font("Segoe UI", 12F);
            textFirstName.Location = new Point(200, 160);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(186, 29);
            textFirstName.TabIndex = 4;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(60, 163);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(86, 21);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F);
            textBoxLastName.Location = new Point(200, 210);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(186, 29);
            textBoxLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(60, 213);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(84, 21);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            // 
            // textBoxContactNo
            // 
            textBoxContactNo.Font = new Font("Segoe UI", 12F);
            textBoxContactNo.Location = new Point(200, 261);
            textBoxContactNo.Name = "textBoxContactNo";
            textBoxContactNo.Size = new Size(186, 29);
            textBoxContactNo.TabIndex = 8;
            // 
            // labelContactNo
            // 
            labelContactNo.AutoSize = true;
            labelContactNo.BackColor = Color.Transparent;
            labelContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactNo.Location = new Point(60, 264);
            labelContactNo.Name = "labelContactNo";
            labelContactNo.Size = new Size(88, 21);
            labelContactNo.TabIndex = 7;
            labelContactNo.Text = "Contact No";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F);
            textBoxAddress.Location = new Point(200, 307);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(186, 70);
            textBoxAddress.TabIndex = 10;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(60, 310);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(66, 21);
            labelAddress.TabIndex = 9;
            labelAddress.Text = "Address";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(200, 394);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(186, 23);
            comboBoxGender.TabIndex = 11;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.Transparent;
            labelGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(60, 396);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(61, 21);
            labelGender.TabIndex = 12;
            labelGender.Text = "Gender";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkGreen;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(170, 445);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(103, 41);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.SteelBlue;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(310, 445);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(103, 41);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Orange;
            buttonClear.Font = new Font("Segoe UI", 12F);
            buttonClear.Location = new Point(582, 445);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(103, 41);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Crimson;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(442, 445);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 41);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(422, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(522, 254);
            dataGridView1.TabIndex = 17;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(485, 118);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(459, 29);
            textBoxSearch.TabIndex = 19;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(422, 121);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(57, 21);
            labelSearch.TabIndex = 18;
            labelSearch.Text = "Search";
            labelSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(938, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1006, 531);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(dataGridView1);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(labelGender);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxContactNo);
            Controls.Add(labelContactNo);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxContactID);
            Controls.Add(labelContactID);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            Text = "Form1";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelContactID;
        private TextBox textBoxContactID;
        private TextBox textFirstName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxContactNo;
        private Label labelContactNo;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private ComboBox comboBoxGender;
        private Label labelGender;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonClear;
        private Button buttonDelete;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private PictureBox pictureBox2;
    }
}
