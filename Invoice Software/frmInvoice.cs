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
    public partial class frmInvoice : Form
    {
        Connection con;
        DataTable party;
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            dtpInvoiceDate.Text = DateTime.Today.ToString();
            con = new Connection();
            party = con.fetchData("select * from MST_Party");
            if(party.Rows.Count>0)
            {
                for (int i = 0; i < party.Rows.Count; i++)
                {
                    cbPartyName.Items.Add(party.Rows[i][1]);
                }
            }

        }

        private void btnAddParty_Click(object sender, EventArgs e)
        {
            AddParty frm = new AddParty();
            frm.Show();
        }

        private void cbPartyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            party = con.fetchData("select * from MST_Party where PartyName='" + cbPartyName.SelectedItem + "'");
            txtPartyGSTIN.Text = party.Rows[0][2].ToString();
            txtPartyAddress.Text = party.Rows[0][3].ToString();
            txtPartyCity.Text = party.Rows[0][4].ToString();
            txtPartyState.Text = party.Rows[0][5].ToString();
            txtPartyStateCode.Text = party.Rows[0][6].ToString();
        }
    }
}
