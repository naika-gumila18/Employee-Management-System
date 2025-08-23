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
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            btnMaximize = new Button();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(251, 563);
            pnlSideMenu.TabIndex = 0;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(251, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(695, 113);
            pnlTitleBar.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(652, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 26);
            btnClose.TabIndex = 3;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(560, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 26);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "➖";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(606, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 26);
            btnMaximize.TabIndex = 0;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 563);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlSideMenu);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmMotherForm";
            Text = "frmMotherForm";
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
    }
}
