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
    public partial class frmUpdtDelProduct : Form
    {
        Connection con;
        DataTable dt;
        int productID = 0;
        public frmUpdtDelProduct()
        {
            InitializeComponent();
        }

        private void frmUpdtSelProduct_Load(object sender, EventArgs e)
        {
            con = new Connection();
            clear();
        }
        private void clear()
        {
            String que = "select * from MST_Product";
            dt = con.fetchData(que);

            cbProductName.Items.Clear();
            cbProductName.SelectedText = "";
            txtProductName.Text = description.Text = txtRemarks.Text = txtHSSNCode.Text = "";

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbProductName.Items.Add(dt.Rows[i][1].ToString());
                }
            }
        }

        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sel = "select * from MST_Product where ProductName='" + cbProductName.SelectedItem.ToString() + "'";
            DataTable dt = con.fetchData(sel);
            if (dt.Rows.Count > 0)
            {
                productID = Convert.ToInt16(dt.Rows[0][0].ToString());
                txtProductName.Text = dt.Rows[0][1].ToString();
                description.Text = dt.Rows[0][2].ToString();
                txtRemarks.Text = dt.Rows[0][3].ToString();
                txtHSSNCode.Text = dt.Rows[0][4].ToString();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || description.Text == "" || txtRemarks.Text == "" || txtHSSNCode.Text == "")
            {
                MessageBox.Show("Enter required details");
            }
            else
            {
                int name = 1;
                Connection con = new Connection();
                DataTable dt = con.fetchData("select ProductName from MST_Product");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (txtProductName.Text == dt.Rows[i][0].ToString())
                        {
                            name = 0;
                        }
                    }
                }
                if (name == 1 || cbProductName.SelectedItem.ToString()==txtProductName.Text)
                {
                    String update = "update MST_Product set ProductName='" + txtProductName.Text + "', ProductDescription='" + description.Text + "', Remarks='" + txtRemarks.Text + "', HSSNCode=" + txtHSSNCode.Text + ", tModifiedDate='" + DateTime.Now.ToString() + "' where ProductID=" + productID;
                    if (con.performDML(update))
                    {
                        MessageBox.Show("Product updated successfully");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error updating product, Try again");
                    }
                }
                else
                {
                    MessageBox.Show("Product name already exits!");
                }
            }
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            String delete = "delete from MST_Product where ProductID=" + productID;
            if (con.performDML(delete))
            {
                MessageBox.Show("Product deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Error try again");
            }
        }
    }
}
