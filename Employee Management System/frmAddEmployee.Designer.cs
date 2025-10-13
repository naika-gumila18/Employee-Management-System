namespace Employee_Management_System
{
    partial class frmAddEmployee
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmpID = new TextBox();
            txtRequestorName = new TextBox();
            txtEmailAddress = new TextBox();
            txtLocalNumber = new TextBox();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            cmbSection = new ComboBox();
            btnInsertUpdate = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 88);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(139, 29);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 3);
            label2.Name = "label2";
            label2.Size = new Size(391, 24);
            label2.TabIndex = 1;
            label2.Text = "Employee Details Manual Insert and Update:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 48);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 2;
            label3.Text = "Employee Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 105);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 3;
            label4.Text = "Requestor Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 165);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 4;
            label5.Text = "Email Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 224);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 5;
            label6.Text = "Local Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(78, 279);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 6;
            label7.Text = "Section:";
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(141, 44);
            txtEmpID.Margin = new Padding(3, 4, 3, 4);
            txtEmpID.Multiline = true;
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(337, 39);
            txtEmpID.TabIndex = 7;
            // 
            // txtRequestorName
            // 
            txtRequestorName.Location = new Point(141, 101);
            txtRequestorName.Margin = new Padding(3, 4, 3, 4);
            txtRequestorName.Multiline = true;
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(337, 39);
            txtRequestorName.TabIndex = 8;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(141, 161);
            txtEmailAddress.Margin = new Padding(3, 4, 3, 4);
            txtEmailAddress.Multiline = true;
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(337, 39);
            txtEmailAddress.TabIndex = 9;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.Location = new Point(141, 220);
            txtLocalNumber.Margin = new Padding(3, 4, 3, 4);
            txtLocalNumber.Multiline = true;
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(337, 39);
            txtLocalNumber.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cmbSection);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLocalNumber);
            groupBox1.Controls.Add(txtEmailAddress);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtRequestorName);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(5, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(907, 407);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(347, 279);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbSection
            // 
            cmbSection.BackColor = SystemColors.ActiveCaption;
            cmbSection.DropDownHeight = 110;
            cmbSection.ForeColor = SystemColors.ButtonHighlight;
            cmbSection.FormattingEnabled = true;
            cmbSection.IntegralHeight = false;
            cmbSection.Location = new Point(141, 279);
            cmbSection.Margin = new Padding(3, 4, 3, 4);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(199, 28);
            cmbSection.TabIndex = 11;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.BackColor = SystemColors.ActiveCaption;
            btnInsertUpdate.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertUpdate.Location = new Point(141, 319);
            btnInsertUpdate.Margin = new Padding(3, 4, 3, 4);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(162, 48);
            btnInsertUpdate.TabIndex = 12;
            btnInsertUpdate.Text = "INSERT/UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = false;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(485, 44);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(99, 40);
            button2.TabIndex = 13;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button btnInsertUpdate;
        private TextBox txtEmpID;
        private TextBox txtRequestorName;
        private TextBox txtEmailAddress;
        private TextBox txtLocalNumber;
        private ComboBox cmbSection;
        private Button btnDelete;
    }
}