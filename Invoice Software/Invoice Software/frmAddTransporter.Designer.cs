
namespace Invoice_Software
{
    partial class frmAddTransporter
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
            this.btnAddTrans = new System.Windows.Forms.Button();
            this.txtLR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVehicalNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.Location = new System.Drawing.Point(253, 124);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(80, 34);
            this.btnAddTrans.TabIndex = 30;
            this.btnAddTrans.Text = "Add";
            this.btnAddTrans.UseVisualStyleBackColor = true;
            this.btnAddTrans.Click += new System.EventHandler(this.btnAddTrans_Click);
            // 
            // txtLR
            // 
            this.txtLR.Location = new System.Drawing.Point(200, 96);
            this.txtLR.Name = "txtLR";
            this.txtLR.Size = new System.Drawing.Size(369, 22);
            this.txtLR.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Transporter LR Number : ";
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(200, 66);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(369, 22);
            this.txtGST.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Transporter GST Number : ";
            // 
            // txtVehicalNo
            // 
            this.txtVehicalNo.Location = new System.Drawing.Point(200, 38);
            this.txtVehicalNo.Multiline = true;
            this.txtVehicalNo.Name = "txtVehicalNo";
            this.txtVehicalNo.Size = new System.Drawing.Size(369, 22);
            this.txtVehicalNo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Vehical Number : ";
            // 
            // txtTransName
            // 
            this.txtTransName.Location = new System.Drawing.Point(200, 10);
            this.txtTransName.Name = "txtTransName";
            this.txtTransName.Size = new System.Drawing.Size(369, 22);
            this.txtTransName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Transporter name : ";
            // 
            // frmAddTransporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 169);
            this.Controls.Add(this.btnAddTrans);
            this.Controls.Add(this.txtLR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVehicalNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTransName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddTransporter";
            this.Text = "frmAddTransporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTrans;
        private System.Windows.Forms.TextBox txtLR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVehicalNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTransName;
        private System.Windows.Forms.Label label1;
    }
}