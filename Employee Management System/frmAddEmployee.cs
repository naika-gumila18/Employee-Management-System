using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text) || string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please fill up all the fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (txtEmailAddress.Text.Contains("@firstasia.edu.ph"))
            //{
            //    frmAddEmployee frmAddEmployee = new frmAddEmployee();
            //    frmAddEmployee.ShowDialog();
            //}

            //else
            //{
            //    MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "Select * from [tblEmployeeData] where [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

           

            if (dtg_addrequestor == true)
            {
                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exists.", "Not found.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";

                if (result == DialogResult.Yes)
                {
                    string update = "update [tblEmployeeData] set [RequestorName] = '"+ txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' where [EmployeeNumber] = '" + txtEmpID.Text + "'";
                    CRUD.CRUD.CUD(update);
                   
                }
            }
            else
            {
                string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName], [RequestorEmail], [Section], [LocalNumber]) values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = frmMasterData.EmployeeNumber;
            txtEmailAddress.Text = frmMasterData.RequestorEmail;
            txtRequestorName.Text = frmMasterData.RequestorName;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);  
            if (dialogResult == DialogResult.Yes)
            {
                string delete_requestor = "Delete from [tblEmployeeData] where [EmployeeNumber] = '" + txtEmpID.Text + "'";
                CRUD.CRUD.CUD(delete_requestor);
                MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string update = "update [tblEmployeeData] set [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' where [EmployeeNumber] = '" + txtEmpID.Text + "'";
                CRUD.CRUD.CUD(update);
                frmMasterData frmMasterData = new frmMasterData();
                frmMasterData.ShowDialog();
                this.Close();

            }
        }
    }
}
