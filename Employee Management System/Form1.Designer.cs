namespace Employee_Management_System
{
    partial class frmMotherForm
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
            pnlSideMenu = new Panel();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            btnMaximize = new Button();
            pnlStage = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = SystemColors.ActiveCaption;
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 46);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(251, 517);
            pnlSideMenu.TabIndex = 0;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Dock = DockStyle.Top;
            btnAddEmp.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmp.Location = new Point(0, 57);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(251, 57);
            btnAddEmp.TabIndex = 2;
            btnAddEmp.Text = "Add Employee";
            btnAddEmp.UseVisualStyleBackColor = true;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.AutoEllipsis = true;
            btnMasterData.Dock = DockStyle.Top;
            btnMasterData.Font = new Font("Sitka Subheading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterData.Location = new Point(0, 0);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(251, 57);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = "Master Data";
            btnMasterData.UseVisualStyleBackColor = true;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = SystemColors.MenuHighlight;
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(946, 46);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.Paint += pnlTitleBar_Paint;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.LightCoral;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(903, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 33);
            btnClose.TabIndex = 3;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = SystemColors.ActiveCaption;
            btnMinimize.ForeColor = SystemColors.ButtonHighlight;
            btnMinimize.Location = new Point(811, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 33);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "➖";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = SystemColors.ActiveCaption;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = SystemColors.ButtonHighlight;
            btnMaximize.ImageAlign = ContentAlignment.TopCenter;
            btnMaximize.Location = new Point(857, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 33);
            btnMaximize.TabIndex = 0;
            btnMaximize.Text = "⬜";
            btnMaximize.TextAlign = ContentAlignment.TopCenter;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // pnlStage
            // 
            pnlStage.BackColor = SystemColors.ControlLight;
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.ForeColor = SystemColors.AppWorkspace;
            pnlStage.Location = new Point(251, 46);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(695, 517);
            pnlStage.TabIndex = 2;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 563);
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmMotherForm";
            Text = "frmMotherForm";
            Load += frmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnAddEmp;
        private Button btnMasterData;
        private Panel pnlStage;
    }
}
