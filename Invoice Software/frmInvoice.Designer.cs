
namespace Invoice_Software
{
    partial class frmInvoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTriplicate = new System.Windows.Forms.RadioButton();
            this.rbtnDuplicate = new System.Windows.Forms.RadioButton();
            this.rbtnOriginal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddTrasnporter = new System.Windows.Forms.Button();
            this.txtTarnGSTNo = new System.Windows.Forms.TextBox();
            this.txtTarnLRNo = new System.Windows.Forms.TextBox();
            this.txtTarnVehicalNo = new System.Windows.Forms.TextBox();
            this.cbTransporterID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPartyCity = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtPartyStateCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddParty = new System.Windows.Forms.Button();
            this.txtPartyState = new System.Windows.Forms.TextBox();
            this.txtPartyGSTIN = new System.Windows.Forms.TextBox();
            this.txtPartyAddress = new System.Windows.Forms.TextBox();
            this.cbPartyName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtDPartyID = new System.Windows.Forms.TextBox();
            this.txtDStateCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDState = new System.Windows.Forms.TextBox();
            this.txtDGSTIN = new System.Windows.Forms.TextBox();
            this.txtDAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label29 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtPIGST = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPSGST = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtPCGST = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPackingCharge = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddParticular = new System.Windows.Forms.Button();
            this.btnAddOther = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmProduct = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTriplicate);
            this.groupBox1.Controls.Add(this.rbtnDuplicate);
            this.groupBox1.Controls.Add(this.rbtnOriginal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpInvoiceDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(428, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Details";
            // 
            // rbtnTriplicate
            // 
            this.rbtnTriplicate.AutoSize = true;
            this.rbtnTriplicate.Location = new System.Drawing.Point(332, 92);
            this.rbtnTriplicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnTriplicate.Name = "rbtnTriplicate";
            this.rbtnTriplicate.Size = new System.Drawing.Size(87, 21);
            this.rbtnTriplicate.TabIndex = 4;
            this.rbtnTriplicate.Text = "Triplicate";
            this.rbtnTriplicate.UseVisualStyleBackColor = true;
            // 
            // rbtnDuplicate
            // 
            this.rbtnDuplicate.AutoSize = true;
            this.rbtnDuplicate.Location = new System.Drawing.Point(219, 92);
            this.rbtnDuplicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnDuplicate.Name = "rbtnDuplicate";
            this.rbtnDuplicate.Size = new System.Drawing.Size(88, 21);
            this.rbtnDuplicate.TabIndex = 3;
            this.rbtnDuplicate.Text = "Duplicate";
            this.rbtnDuplicate.UseVisualStyleBackColor = true;
            // 
            // rbtnOriginal
            // 
            this.rbtnOriginal.AutoSize = true;
            this.rbtnOriginal.Checked = true;
            this.rbtnOriginal.Location = new System.Drawing.Point(115, 92);
            this.rbtnOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnOriginal.Name = "rbtnOriginal";
            this.rbtnOriginal.Size = new System.Drawing.Size(78, 21);
            this.rbtnOriginal.TabIndex = 2;
            this.rbtnOriginal.TabStop = true;
            this.rbtnOriginal.Text = "Original";
            this.rbtnOriginal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Invoice Type : ";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(115, 57);
            this.dtpInvoiceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(132, 22);
            this.dtpInvoiceDate.TabIndex = 1;
            this.dtpInvoiceDate.Value = new System.DateTime(2021, 8, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice Date : ";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(115, 22);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(132, 22);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No. : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddTrasnporter);
            this.groupBox2.Controls.Add(this.txtTarnGSTNo);
            this.groupBox2.Controls.Add(this.txtTarnLRNo);
            this.groupBox2.Controls.Add(this.txtTarnVehicalNo);
            this.groupBox2.Controls.Add(this.cbTransporterID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(428, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transporter";
            // 
            // btnAddTrasnporter
            // 
            this.btnAddTrasnporter.Location = new System.Drawing.Point(332, 21);
            this.btnAddTrasnporter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTrasnporter.Name = "btnAddTrasnporter";
            this.btnAddTrasnporter.Size = new System.Drawing.Size(88, 28);
            this.btnAddTrasnporter.TabIndex = 6;
            this.btnAddTrasnporter.Text = "Add";
            this.btnAddTrasnporter.UseVisualStyleBackColor = true;
            // 
            // txtTarnGSTNo
            // 
            this.txtTarnGSTNo.Location = new System.Drawing.Point(115, 118);
            this.txtTarnGSTNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarnGSTNo.Name = "txtTarnGSTNo";
            this.txtTarnGSTNo.ReadOnly = true;
            this.txtTarnGSTNo.Size = new System.Drawing.Size(132, 22);
            this.txtTarnGSTNo.TabIndex = 7;
            // 
            // txtTarnLRNo
            // 
            this.txtTarnLRNo.Location = new System.Drawing.Point(115, 86);
            this.txtTarnLRNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarnLRNo.Name = "txtTarnLRNo";
            this.txtTarnLRNo.ReadOnly = true;
            this.txtTarnLRNo.Size = new System.Drawing.Size(132, 22);
            this.txtTarnLRNo.TabIndex = 6;
            // 
            // txtTarnVehicalNo
            // 
            this.txtTarnVehicalNo.Location = new System.Drawing.Point(115, 54);
            this.txtTarnVehicalNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarnVehicalNo.Name = "txtTarnVehicalNo";
            this.txtTarnVehicalNo.ReadOnly = true;
            this.txtTarnVehicalNo.Size = new System.Drawing.Size(132, 22);
            this.txtTarnVehicalNo.TabIndex = 5;
            // 
            // cbTransporterID
            // 
            this.cbTransporterID.FormattingEnabled = true;
            this.cbTransporterID.Location = new System.Drawing.Point(115, 21);
            this.cbTransporterID.Margin = new System.Windows.Forms.Padding(4);
            this.cbTransporterID.Name = "cbTransporterID";
            this.cbTransporterID.Size = new System.Drawing.Size(132, 24);
            this.cbTransporterID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "GST No. : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "LR No. : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vehical No. : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Transporter : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPartyCity);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.txtPartyStateCode);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnAddParty);
            this.groupBox3.Controls.Add(this.txtPartyState);
            this.groupBox3.Controls.Add(this.txtPartyGSTIN);
            this.groupBox3.Controls.Add(this.txtPartyAddress);
            this.groupBox3.Controls.Add(this.cbPartyName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 319);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(428, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bill to Party";
            // 
            // txtPartyCity
            // 
            this.txtPartyCity.Location = new System.Drawing.Point(115, 116);
            this.txtPartyCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartyCity.Name = "txtPartyCity";
            this.txtPartyCity.ReadOnly = true;
            this.txtPartyCity.Size = new System.Drawing.Size(132, 22);
            this.txtPartyCity.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(61, 119);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 17);
            this.label30.TabIndex = 11;
            this.label30.Text = "City : ";
            // 
            // txtPartyStateCode
            // 
            this.txtPartyStateCode.Location = new System.Drawing.Point(115, 178);
            this.txtPartyStateCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartyStateCode.Name = "txtPartyStateCode";
            this.txtPartyStateCode.ReadOnly = true;
            this.txtPartyStateCode.Size = new System.Drawing.Size(132, 22);
            this.txtPartyStateCode.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "State Code : ";
            // 
            // btnAddParty
            // 
            this.btnAddParty.Location = new System.Drawing.Point(332, 21);
            this.btnAddParty.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddParty.Name = "btnAddParty";
            this.btnAddParty.Size = new System.Drawing.Size(88, 28);
            this.btnAddParty.TabIndex = 8;
            this.btnAddParty.Text = "Add";
            this.btnAddParty.UseVisualStyleBackColor = true;
            this.btnAddParty.Click += new System.EventHandler(this.btnAddParty_Click);
            // 
            // txtPartyState
            // 
            this.txtPartyState.Location = new System.Drawing.Point(115, 146);
            this.txtPartyState.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartyState.Name = "txtPartyState";
            this.txtPartyState.ReadOnly = true;
            this.txtPartyState.Size = new System.Drawing.Size(132, 22);
            this.txtPartyState.TabIndex = 7;
            // 
            // txtPartyGSTIN
            // 
            this.txtPartyGSTIN.Location = new System.Drawing.Point(115, 86);
            this.txtPartyGSTIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartyGSTIN.Name = "txtPartyGSTIN";
            this.txtPartyGSTIN.ReadOnly = true;
            this.txtPartyGSTIN.Size = new System.Drawing.Size(132, 22);
            this.txtPartyGSTIN.TabIndex = 6;
            // 
            // txtPartyAddress
            // 
            this.txtPartyAddress.Location = new System.Drawing.Point(115, 54);
            this.txtPartyAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartyAddress.Name = "txtPartyAddress";
            this.txtPartyAddress.ReadOnly = true;
            this.txtPartyAddress.Size = new System.Drawing.Size(132, 22);
            this.txtPartyAddress.TabIndex = 5;
            // 
            // cbPartyName
            // 
            this.cbPartyName.FormattingEnabled = true;
            this.cbPartyName.Location = new System.Drawing.Point(115, 21);
            this.cbPartyName.Margin = new System.Windows.Forms.Padding(4);
            this.cbPartyName.Name = "cbPartyName";
            this.cbPartyName.Size = new System.Drawing.Size(132, 24);
            this.cbPartyName.TabIndex = 7;
            this.cbPartyName.SelectedIndexChanged += new System.EventHandler(this.cbPartyName_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "State : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "GSTIN : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Address : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Party : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.txtDPartyID);
            this.groupBox4.Controls.Add(this.txtDStateCode);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtDState);
            this.groupBox4.Controls.Add(this.txtDGSTIN);
            this.groupBox4.Controls.Add(this.txtDAddress);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(12, 541);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(428, 233);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delivered At";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Same as Bill to Party";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDPartyID
            // 
            this.txtDPartyID.Location = new System.Drawing.Point(115, 62);
            this.txtDPartyID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPartyID.Name = "txtDPartyID";
            this.txtDPartyID.Size = new System.Drawing.Size(132, 22);
            this.txtDPartyID.TabIndex = 10;
            // 
            // txtDStateCode
            // 
            this.txtDStateCode.Location = new System.Drawing.Point(115, 190);
            this.txtDStateCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtDStateCode.Name = "txtDStateCode";
            this.txtDStateCode.Size = new System.Drawing.Size(132, 22);
            this.txtDStateCode.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 193);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "State Code : ";
            // 
            // txtDState
            // 
            this.txtDState.Location = new System.Drawing.Point(115, 158);
            this.txtDState.Margin = new System.Windows.Forms.Padding(4);
            this.txtDState.Name = "txtDState";
            this.txtDState.Size = new System.Drawing.Size(132, 22);
            this.txtDState.TabIndex = 13;
            // 
            // txtDGSTIN
            // 
            this.txtDGSTIN.Location = new System.Drawing.Point(115, 126);
            this.txtDGSTIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtDGSTIN.Name = "txtDGSTIN";
            this.txtDGSTIN.Size = new System.Drawing.Size(132, 22);
            this.txtDGSTIN.TabIndex = 12;
            // 
            // txtDAddress
            // 
            this.txtDAddress.Location = new System.Drawing.Point(115, 94);
            this.txtDAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtDAddress.Name = "txtDAddress";
            this.txtDAddress.Size = new System.Drawing.Size(132, 22);
            this.txtDAddress.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 161);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "State : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 129);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "GSTIN : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 97);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Address : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 64);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Party : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.txtTotalAmount);
            this.groupBox5.Controls.Add(this.txtIGST);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.txtPIGST);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtSGST);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.txtPSGST);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtCGST);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtSubTotal);
            this.groupBox5.Controls.Add(this.txtPCGST);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.txtPackingCharge);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.btnAddParticular);
            this.groupBox5.Controls.Add(this.btnAddOther);
            this.groupBox5.Controls.Add(this.txtRate);
            this.groupBox5.Controls.Add(this.txtQty);
            this.groupBox5.Controls.Add(this.cmProduct);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(12, 781);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 380);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Invoice Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 116);
            this.dataGridView1.TabIndex = 30;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(22, 336);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(104, 17);
            this.label29.TabIndex = 29;
            this.label29.Text = "Total Amount : ";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(132, 331);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAmount.TabIndex = 28;
            // 
            // txtIGST
            // 
            this.txtIGST.Location = new System.Drawing.Point(132, 303);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.ReadOnly = true;
            this.txtIGST.Size = new System.Drawing.Size(100, 22);
            this.txtIGST.TabIndex = 27;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(94, 308);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 17);
            this.label27.TabIndex = 26;
            this.label27.Text = "% : ";
            // 
            // txtPIGST
            // 
            this.txtPIGST.Location = new System.Drawing.Point(59, 305);
            this.txtPIGST.Name = "txtPIGST";
            this.txtPIGST.Size = new System.Drawing.Size(29, 22);
            this.txtPIGST.TabIndex = 23;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 308);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 17);
            this.label28.TabIndex = 24;
            this.label28.Text = "IGST";
            // 
            // txtSGST
            // 
            this.txtSGST.Location = new System.Drawing.Point(132, 275);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.ReadOnly = true;
            this.txtSGST.Size = new System.Drawing.Size(100, 22);
            this.txtSGST.TabIndex = 23;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(94, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 17);
            this.label25.TabIndex = 22;
            this.label25.Text = "% : ";
            // 
            // txtPSGST
            // 
            this.txtPSGST.Location = new System.Drawing.Point(59, 277);
            this.txtPSGST.Name = "txtPSGST";
            this.txtPSGST.Size = new System.Drawing.Size(29, 22);
            this.txtPSGST.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 280);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 17);
            this.label26.TabIndex = 20;
            this.label26.Text = "SGST";
            // 
            // txtCGST
            // 
            this.txtCGST.Location = new System.Drawing.Point(132, 247);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.ReadOnly = true;
            this.txtCGST.Size = new System.Drawing.Size(100, 22);
            this.txtCGST.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(94, 252);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 17);
            this.label24.TabIndex = 18;
            this.label24.Text = "% : ";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(132, 219);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubTotal.TabIndex = 17;
            // 
            // txtPCGST
            // 
            this.txtPCGST.Location = new System.Drawing.Point(59, 249);
            this.txtPCGST.Name = "txtPCGST";
            this.txtPCGST.Size = new System.Drawing.Size(29, 22);
            this.txtPCGST.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 252);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 17);
            this.label23.TabIndex = 12;
            this.label23.Text = "CGST";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(45, 219);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "Sub Total : ";
            // 
            // txtPackingCharge
            // 
            this.txtPackingCharge.Location = new System.Drawing.Point(132, 191);
            this.txtPackingCharge.Name = "txtPackingCharge";
            this.txtPackingCharge.Size = new System.Drawing.Size(100, 22);
            this.txtPackingCharge.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 191);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 17);
            this.label21.TabIndex = 9;
            this.label21.Text = "Packing Charge : ";
            // 
            // btnAddParticular
            // 
            this.btnAddParticular.Location = new System.Drawing.Point(332, 18);
            this.btnAddParticular.Name = "btnAddParticular";
            this.btnAddParticular.Size = new System.Drawing.Size(90, 28);
            this.btnAddParticular.TabIndex = 19;
            this.btnAddParticular.Text = "Add";
            this.btnAddParticular.UseVisualStyleBackColor = true;
            // 
            // btnAddOther
            // 
            this.btnAddOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOther.Location = new System.Drawing.Point(276, 38);
            this.btnAddOther.Name = "btnAddOther";
            this.btnAddOther.Size = new System.Drawing.Size(30, 23);
            this.btnAddOther.TabIndex = 18;
            this.btnAddOther.Text = "+";
            this.btnAddOther.UseVisualStyleBackColor = true;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(216, 39);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(54, 22);
            this.txtRate.TabIndex = 17;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(148, 40);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(61, 22);
            this.txtQty.TabIndex = 16;
            // 
            // cmProduct
            // 
            this.cmProduct.FormattingEnabled = true;
            this.cmProduct.Location = new System.Drawing.Point(7, 39);
            this.cmProduct.Name = "cmProduct";
            this.cmProduct.Size = new System.Drawing.Size(134, 24);
            this.cmProduct.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(213, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 17);
            this.label20.TabIndex = 2;
            this.label20.Text = "Rate";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(145, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Qty";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Particular";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1130, 895);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInvoice";
            this.Text = " New Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnTriplicate;
        private System.Windows.Forms.RadioButton rbtnDuplicate;
        private System.Windows.Forms.RadioButton rbtnOriginal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTrasnporter;
        private System.Windows.Forms.TextBox txtTarnGSTNo;
        private System.Windows.Forms.TextBox txtTarnLRNo;
        private System.Windows.Forms.TextBox txtTarnVehicalNo;
        private System.Windows.Forms.ComboBox cbTransporterID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPartyStateCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddParty;
        private System.Windows.Forms.TextBox txtPartyState;
        private System.Windows.Forms.TextBox txtPartyGSTIN;
        private System.Windows.Forms.TextBox txtPartyAddress;
        private System.Windows.Forms.ComboBox cbPartyName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtDPartyID;
        private System.Windows.Forms.TextBox txtDStateCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDState;
        private System.Windows.Forms.TextBox txtDGSTIN;
        private System.Windows.Forms.TextBox txtDAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtPIGST;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPSGST;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtPCGST;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPackingCharge;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAddParticular;
        private System.Windows.Forms.Button btnAddOther;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmProduct;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPartyCity;
        private System.Windows.Forms.Label label30;
    }
}