
namespace Invoice_Software
{
    partial class frmUpdtDelParty
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
            this.btnUpdtParty = new System.Windows.Forms.Button();
            this.nStateCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelParty = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdtParty
            // 
            this.btnUpdtParty.Location = new System.Drawing.Point(133, 321);
            this.btnUpdtParty.Name = "btnUpdtParty";
            this.btnUpdtParty.Size = new System.Drawing.Size(74, 33);
            this.btnUpdtParty.TabIndex = 7;
            this.btnUpdtParty.Text = "Update";
            this.btnUpdtParty.UseVisualStyleBackColor = true;
            this.btnUpdtParty.Click += new System.EventHandler(this.btnUpdtParty_Click);
            // 
            // nStateCode
            // 
            this.nStateCode.Location = new System.Drawing.Point(111, 293);
            this.nStateCode.Name = "nStateCode";
            this.nStateCode.Size = new System.Drawing.Size(369, 22);
            this.nStateCode.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "State code : ";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(111, 265);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(369, 22);
            this.txtState.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "State : ";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(111, 237);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(369, 22);
            this.txtCity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "City : ";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(111, 100);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(369, 127);
            this.address.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address : ";
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(111, 72);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(369, 22);
            this.txtGST.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "GST No. : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Party name : ";
            // 
            // btnDelParty
            // 
            this.btnDelParty.Location = new System.Drawing.Point(289, 321);
            this.btnDelParty.Name = "btnDelParty";
            this.btnDelParty.Size = new System.Drawing.Size(74, 33);
            this.btnDelParty.TabIndex = 8;
            this.btnDelParty.Text = "Delete";
            this.btnDelParty.UseVisualStyleBackColor = true;
            this.btnDelParty.Click += new System.EventHandler(this.btnDelParty_Click);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(111, 12);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(369, 24);
            this.cbName.TabIndex = 1;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(369, 22);
            this.txtName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Party Name : ";
            // 
            // frmUpdtDelParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 361);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.btnDelParty);
            this.Controls.Add(this.btnUpdtParty);
            this.Controls.Add(this.nStateCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdtDelParty";
            this.Text = "Update or Delete a Party";
            this.Load += new System.EventHandler(this.frmUpdtDelParty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdtParty;
        private System.Windows.Forms.TextBox nStateCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelParty;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
    }
}