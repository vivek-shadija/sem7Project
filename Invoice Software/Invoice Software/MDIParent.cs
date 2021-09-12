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
            frmAddParty frm = new frmAddParty();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdtDelParty frm = new frmUpdtDelParty();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddCompany frm = new frmAddCompany();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUpdtDelProduct frm = new frmUpdtDelProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAddTransporter frm = new frmAddTransporter();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUpdtDelTrans frm = new frmUpdtDelTrans();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
