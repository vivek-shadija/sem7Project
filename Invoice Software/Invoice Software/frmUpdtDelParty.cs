using System;
using System.Data;
using System.Windows.Forms;

namespace Invoice_Software
{
    public partial class frmUpdtDelParty : Form
    {
        Connection con;
        DataTable dt;
        int partyID = 0;
        public frmUpdtDelParty()
        {
            InitializeComponent();
        }

        private void frmUpdtDelParty_Load(object sender, EventArgs e)
        {
            con = new Connection();
            clear();
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sel = "select * from MST_Party where PartyName='" + cbName.SelectedItem.ToString() + "'";
            DataTable dt = con.fetchData(sel);
            if(dt.Rows.Count>0)
            {
                partyID = Convert.ToInt32(dt.Rows[0][0].ToString());
                txtName.Text = dt.Rows[0][1].ToString();
                txtGST.Text = dt.Rows[0][2].ToString();
                address.Text = dt.Rows[0][3].ToString();
                txtCity.Text = dt.Rows[0][4].ToString();
                txtState.Text = dt.Rows[0][5].ToString();
                nStateCode.Text = dt.Rows[0][6].ToString();
            }

        }

        private void clear()
        {
            String que = "select * from MST_Party";
            dt = con.fetchData(que);

            cbName.Items.Clear();
            cbName.SelectedText = "";
            txtName.Text = txtCity.Text = txtGST.Text = txtState.Text = address.Text = nStateCode.Text = "";

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbName.Items.Add(dt.Rows[i][1].ToString());
                }
            }
        }

        private void btnUpdtParty_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtGST.Text == "" || address.Text == "" || txtCity.Text == "" || txtState.Text == "" || nStateCode.Text == "")
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {
                int pname = 0;
                string partyName, mDate;
                partyName = txtName.Text;
                mDate = DateTime.Now.ToString();

                //check if party name already exists
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (partyName == dt.Rows[i][1].ToString())
                        {
                            pname = 1;
                            break;
                        }
                    }
                }
                if (pname == 1 || cbName.SelectedItem.ToString()==txtName.Text)
                {
                    MessageBox.Show("Party name already exists");

                }
                else
                {
                    String update = "update MST_party set PartyName='" + txtName.Text + "', PartyGSTNumber='" + txtGST.Text + "', PartyAddress='" + address.Text + "', PartyCity='" + txtCity.Text + "', PartyState='" + txtState.Text + "', PartyStateCode=" + nStateCode.Text + ", tModifiedDate='" + mDate + "' where PartyID=" + partyID;
                    if (con.performDML(update))
                    {
                        MessageBox.Show("Party updated successfully");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error try again");
                    }
                }
            }
        }

        private void btnDelParty_Click(object sender, EventArgs e)
        {
            String delete = "delete from MST_Party where PartyName='" + cbName.SelectedItem.ToString() + "'";
            if (con.performDML(delete))
            {
                MessageBox.Show("Party deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Error try again");
            }
        }
    }
}
