
namespace Invoice_Software
{
    partial class frmAddParty
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nStateCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddParty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party name : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(369, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(110, 34);
            this.txtGST.MaxLength = 15;
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(369, 22);
            this.txtGST.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "GST No. : ";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(110, 62);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(369, 127);
            this.address.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address : ";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(110, 199);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(369, 22);
            this.txtCity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "City : ";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(110, 227);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(369, 22);
            this.txtState.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "State : ";
            // 
            // nStateCode
            // 
            this.nStateCode.Location = new System.Drawing.Point(110, 255);
            this.nStateCode.Name = "nStateCode";
            this.nStateCode.Size = new System.Drawing.Size(369, 22);
            this.nStateCode.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "State code : ";
            // 
            // btnAddParty
            // 
            this.btnAddParty.Location = new System.Drawing.Point(206, 283);
            this.btnAddParty.Name = "btnAddParty";
            this.btnAddParty.Size = new System.Drawing.Size(80, 34);
            this.btnAddParty.TabIndex = 7;
            this.btnAddParty.Text = "Add";
            this.btnAddParty.UseVisualStyleBackColor = true;
            this.btnAddParty.Click += new System.EventHandler(this.btnAddParty_Click);
            // 
            // AddParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 329);
            this.Controls.Add(this.btnAddParty);
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
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddParty";
            this.Text = "Add Party";
            this.Load += new System.EventHandler(this.AddParty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nStateCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddParty;
    }
}