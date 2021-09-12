using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Software
{
    public partial class frmAddTransporter : Form
    {
        public frmAddTransporter()
        {
            InitializeComponent();
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            if (txtTransName.Text == "" || txtVehicalNo.Text == "" || txtGST.Text == "" || txtLR.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                int name = 1;
                Connection con = new Connection();
                DataTable dt = con.fetchData("select TransporterName from MST_Transporter");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (txtTransName.Text == dt.Rows[i][0].ToString())
                        {
                            name = 0;
                        }
                    }
                }
                if (name == 1)
                {
                    String insert = "insert into MST_Transporter values('" + txtTransName.Text + "', '" + txtVehicalNo.Text + "', '" + txtGST.Text + "', '" + txtLR.Text + "','" + DateTime.Now.ToString() + "')";
                    if (con.performDML(insert))
                    {
                        MessageBox.Show("Transporter added successfully");
                        txtTransName.Text = txtVehicalNo.Text = txtGST.Text = txtLR.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error adding transporter, Try again");
                    }
                }
                else
                {
                    MessageBox.Show("Transporter name already exits!");
                }
            }
        }
    }
}
