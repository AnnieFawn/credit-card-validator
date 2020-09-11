namespace Task01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GBCardType = new System.Windows.Forms.GroupBox();
            this.RBAmex = new System.Windows.Forms.RadioButton();
            this.RBDiscovery = new System.Windows.Forms.RadioButton();
            this.RBMasterCard = new System.Windows.Forms.RadioButton();
            this.RBVisa = new System.Windows.Forms.RadioButton();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.CBYear = new System.Windows.Forms.ComboBox();
            this.CBMonth = new System.Windows.Forms.ComboBox();
            this.lblED = new System.Windows.Forms.Label();
            this.txtbCardNumber = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.GBCardType.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCardType
            // 
            this.GBCardType.Controls.Add(this.RBAmex);
            this.GBCardType.Controls.Add(this.RBDiscovery);
            this.GBCardType.Controls.Add(this.RBMasterCard);
            this.GBCardType.Controls.Add(this.RBVisa);
            this.GBCardType.Location = new System.Drawing.Point(13, 17);
            this.GBCardType.Name = "GBCardType";
            this.GBCardType.Size = new System.Drawing.Size(260, 92);
            this.GBCardType.TabIndex = 0;
            this.GBCardType.TabStop = false;
            this.GBCardType.Text = "Card Type";
            // 
            // RBAmex
            // 
            this.RBAmex.AutoSize = true;
            this.RBAmex.Image = ((System.Drawing.Image)(resources.GetObject("RBAmex.Image")));
            this.RBAmex.Location = new System.Drawing.Point(128, 56);
            this.RBAmex.Name = "RBAmex";
            this.RBAmex.Size = new System.Drawing.Size(66, 17);
            this.RBAmex.TabIndex = 3;
            this.RBAmex.TabStop = true;
            this.RBAmex.Text = "Amex";
            this.RBAmex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RBAmex.UseVisualStyleBackColor = true;
            // 
            // RBDiscovery
            // 
            this.RBDiscovery.AutoSize = true;
            this.RBDiscovery.Image = ((System.Drawing.Image)(resources.GetObject("RBDiscovery.Image")));
            this.RBDiscovery.Location = new System.Drawing.Point(128, 33);
            this.RBDiscovery.Name = "RBDiscovery";
            this.RBDiscovery.Size = new System.Drawing.Size(96, 17);
            this.RBDiscovery.TabIndex = 2;
            this.RBDiscovery.TabStop = true;
            this.RBDiscovery.Text = "Discovery";
            this.RBDiscovery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBDiscovery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RBDiscovery.UseVisualStyleBackColor = true;
            // 
            // RBMasterCard
            // 
            this.RBMasterCard.AutoSize = true;
            this.RBMasterCard.Image = ((System.Drawing.Image)(resources.GetObject("RBMasterCard.Image")));
            this.RBMasterCard.Location = new System.Drawing.Point(6, 56);
            this.RBMasterCard.Name = "RBMasterCard";
            this.RBMasterCard.Size = new System.Drawing.Size(104, 17);
            this.RBMasterCard.TabIndex = 1;
            this.RBMasterCard.TabStop = true;
            this.RBMasterCard.Text = "MasterCard";
            this.RBMasterCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RBMasterCard.UseVisualStyleBackColor = true;
            this.RBMasterCard.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RBVisa
            // 
            this.RBVisa.AutoSize = true;
            this.RBVisa.Image = ((System.Drawing.Image)(resources.GetObject("RBVisa.Image")));
            this.RBVisa.Location = new System.Drawing.Point(6, 33);
            this.RBVisa.Name = "RBVisa";
            this.RBVisa.Size = new System.Drawing.Size(68, 17);
            this.RBVisa.TabIndex = 0;
            this.RBVisa.TabStop = true;
            this.RBVisa.Text = "Visa";
            this.RBVisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RBVisa.UseVisualStyleBackColor = true;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(17, 120);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number";
            this.lblCardNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // CBYear
            // 
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.CBYear.Location = new System.Drawing.Point(20, 192);
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(109, 21);
            this.CBYear.TabIndex = 2;
            this.CBYear.SelectedIndexChanged += new System.EventHandler(this.CBYear_SelectedIndexChanged);
            // 
            // CBMonth
            // 
            this.CBMonth.FormattingEnabled = true;
            this.CBMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CBMonth.Location = new System.Drawing.Point(135, 192);
            this.CBMonth.Name = "CBMonth";
            this.CBMonth.Size = new System.Drawing.Size(91, 21);
            this.CBMonth.TabIndex = 3;
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(17, 172);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(79, 13);
            this.lblED.TabIndex = 4;
            this.lblED.Text = "Expiration Date";
            // 
            // txtbCardNumber
            // 
            this.txtbCardNumber.Location = new System.Drawing.Point(19, 142);
            this.txtbCardNumber.Name = "txtbCardNumber";
            this.txtbCardNumber.Size = new System.Drawing.Size(207, 20);
            this.txtbCardNumber.TabIndex = 5;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(18, 229);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(253, 52);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 304);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtbCardNumber);
            this.Controls.Add(this.lblED);
            this.Controls.Add(this.CBMonth);
            this.Controls.Add(this.CBYear);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.GBCardType);
            this.Name = "Form1";
            this.Text = "Payment Details";
            this.GBCardType.ResumeLayout(false);
            this.GBCardType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCardType;
        private System.Windows.Forms.RadioButton RBAmex;
        private System.Windows.Forms.RadioButton RBDiscovery;
        private System.Windows.Forms.RadioButton RBMasterCard;
        private System.Windows.Forms.RadioButton RBVisa;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.ComboBox CBYear;
        private System.Windows.Forms.ComboBox CBMonth;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.TextBox txtbCardNumber;
        private System.Windows.Forms.Button btnValidate;
    }
}

