using System;
using System.Data;
using System.Windows.Forms;

namespace Invoice_Software
{
    public partial class AddParty : Form
    {
        DataTable data;
        Connection con;
        public AddParty()
        {
            InitializeComponent();
        }

        private void AddParty_Load(object sender, EventArgs e)
        {
            con = new Connection();
            data = con.fetchData("select PartyName from MST_Party");
        }

        private void btnAddParty_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtGST.Text == "" || address.Text == "" || txtCity.Text == "" || txtState.Text == "" || nStateCode.Text == "")
            {
                MessageBox.Show("Please enter all details");
            }
            else
            {
                int pname = 0;
                string partyName, gst, add, city, state, mDate;
                partyName = txtName.Text;
                gst = txtGST.Text;
                add = address.Text;
                city = txtCity.Text;
                state = txtState.Text;
                int stateCode = int.Parse(nStateCode.Text);
                mDate = DateTime.Now.ToString();

                if (data.Rows.Count > 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (partyName == data.Rows[i][0].ToString())
                        {
                            pname = 1;
                            break;
                        }
                    }
                }
                if (pname == 1)
                {
                    MessageBox.Show("Party name already exists");

                }
                else
                {
                    String insert = "insert into MST_Party values('" + partyName + "','" + gst + "','" + add + "','" + city + "','" + state + "'," + stateCode + ",'" + mDate + "')";
                    if (con.performDML(insert))
                    {
                        MessageBox.Show("Party added successfully");
                        txtName.Text = txtGST.Text = address.Text = txtCity.Text = txtState.Text = nStateCode.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error try again");
                    }
                }
            }
        }
    }
}
