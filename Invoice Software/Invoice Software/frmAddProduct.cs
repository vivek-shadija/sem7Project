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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
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
                if(name==1)
                {
                    String insert = "insert into MST_Product values('" + txtProductName.Text + "','" + description.Text + "','" + txtRemarks.Text + "'," + txtHSSNCode.Text + ",'" + DateTime.Now.ToString() + "')";
                    if(con.performDML(insert))
                    {
                        MessageBox.Show("Product added successfully");
                        txtProductName.Text = description.Text = txtRemarks.Text = txtHSSNCode.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error adding product, Try again");
                    }
                }
                else
                {
                    MessageBox.Show("Product name already exits!");
                }
            }
        }
    }
}
