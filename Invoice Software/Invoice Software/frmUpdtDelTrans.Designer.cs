
namespace Invoice_Software
{
    partial class frmUpdtDelTrans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVehicalNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTransName = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 162);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 34);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtLR
            // 
            this.txtLR.Location = new System.Drawing.Point(200, 128);
            this.txtLR.Name = "txtLR";
            this.txtLR.Size = new System.Drawing.Size(369, 22);
            this.txtLR.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Transporter LR Number : ";
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(200, 98);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(369, 22);
            this.txtGST.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Transporter GST Number : ";
            // 
            // txtVehicalNo
            // 
            this.txtVehicalNo.Location = new System.Drawing.Point(200, 70);
            this.txtVehicalNo.Multiline = true;
            this.txtVehicalNo.Name = "txtVehicalNo";
            this.txtVehicalNo.Size = new System.Drawing.Size(369, 22);
            this.txtVehicalNo.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vehical Number : ";
            // 
            // txtTransName
            // 
            this.txtTransName.Location = new System.Drawing.Point(200, 42);
            this.txtTransName.Name = "txtTransName";
            this.txtTransName.Size = new System.Drawing.Size(369, 22);
            this.txtTransName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Transporter name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Transporter name : ";
            // 
            // cbTransName
            // 
            this.cbTransName.FormattingEnabled = true;
            this.cbTransName.Location = new System.Drawing.Point(200, 12);
            this.cbTransName.Name = "cbTransName";
            this.cbTransName.Size = new System.Drawing.Size(369, 24);
            this.cbTransName.TabIndex = 42;
            this.cbTransName.SelectedIndexChanged += new System.EventHandler(this.cbTransName_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(356, 162);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 34);
            this.btnDel.TabIndex = 43;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmUpdtDelTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 208);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cbTransName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVehicalNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTransName);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdtDelTrans";
            this.Text = "frmUpdtDelTrans";
            this.Load += new System.EventHandler(this.frmUpdtDelTrans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVehicalNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTransName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTransName;
        private System.Windows.Forms.Button btnDel;
    }
}