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
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }
        
        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

       
        public static string EmployeeNumber;
        public static string RequestorName;
        public static string RequestorEmail;
        public static string Section;
        public static string LocalNumber;

        private void btnEditData_Click(object sender, EventArgs e)
        {
               EmployeeNumber = dtgMasterData.CurrentRow.Cells["EmployeeNumber"].Value.ToString();
               RequestorName = dtgMasterData.CurrentRow.Cells["RequestorName"].Value.ToString();
                RequestorEmail = dtgMasterData.CurrentRow.Cells["RequestorEmail"].Value.ToString();
                Section = dtgMasterData.CurrentRow.Cells["Section"].Value.ToString();
                LocalNumber = dtgMasterData.CurrentRow.Cells["LocalNumber"].Value.ToString();


            frmAddEmployee frmAddEmployee = new frmAddEmployee();
                frmAddEmployee.ShowDialog();

            if (dtg_addrequestor == true)
            {
                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exists.", "Not found.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";

                if (result == DialogResult.Yes)
                {
                    string update = "update [tblEmployeeData] set [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' where [EmployeeNumber] = '" + txtEmpID.Text + "'";
                    CRUD.CRUD.CUD(update);

                }

            }

    }
}

