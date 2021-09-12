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
    public partial class frmUpdtDelTrans : Form
    {
        Connection con;
        DataTable dt;
        int transID = 0;
        public frmUpdtDelTrans()
        {
            InitializeComponent();
        }
        private void frmUpdtDelTrans_Load(object sender, EventArgs e)
        {
            con = new Connection();
            clear();
        }
        private void clear()
        {
            String que = "select * from MST_Transporter";
            dt = con.fetchData(que);

            cbTransName.Items.Clear();
            cbTransName.SelectedText = "";
            txtTransName.Text = txtGST.Text = txtLR.Text = txtVehicalNo.Text = "";

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbTransName.Items.Add(dt.Rows[i][1].ToString());
                }
            }
        }
        private void cbTransName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sel = "select * from MST_Transporter where TransporterName='" + cbTransName.SelectedItem.ToString() + "'";
            DataTable dt = con.fetchData(sel);
            if (dt.Rows.Count > 0)
            {
                transID = Convert.ToInt16(dt.Rows[0][0].ToString());
                txtTransName.Text = dt.Rows[0][1].ToString();
                txtVehicalNo.Text = dt.Rows[0][2].ToString();
                txtGST.Text = dt.Rows[0][3].ToString();
                txtLR.Text = dt.Rows[0][4].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                if (name == 1 || cbTransName.SelectedItem.ToString()==txtTransName.Text)
                {
                    String update = "update MST_Transporter set TransporterName='" + txtTransName.Text + "', VehicalNumber='" + txtVehicalNo.Text + "', TransporterGSTNumber='" + txtGST.Text + "', TransporterLRNumber='" + txtLR.Text + "', tModifiedDate='" + DateTime.Now.ToString() + "' where TransporterID=" + transID;
                    if (con.performDML(update))
                    {
                        MessageBox.Show("Transporter updated successfully");
                        txtTransName.Text = txtVehicalNo.Text = txtGST.Text = txtLR.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error updating transporter, Try again");
                    }
                }
                else
                {
                    MessageBox.Show("Transporter name already exits!");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String delete = "delete from MST_Transporter where TransporterID=" + transID;
            if (con.performDML(delete))
            {
                MessageBox.Show("Transporter deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Error try again");
            }
        }
    }
}