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
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        
        private void MDIParent_Load(object sender, EventArgs e)
        {

        }

        private void f5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectCompany f1 = new frmSelectCompany();
            f1.MdiParent = this;
            f1.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice frm = new frmInvoice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddParty frm = new AddParty();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdtDelParty frm = new frmUpdtDelParty();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
