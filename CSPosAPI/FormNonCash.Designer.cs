namespace CSPosAPI
{
    partial class FormNonCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNonCash));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewNonCash = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNonCashAmount = new System.Windows.Forms.TextBox();
            this.labelNonCashAmount = new System.Windows.Forms.Label();
            this.RRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AquireBankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNonCash)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(496, 162);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(629, 162);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Болих";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewNonCash
            // 
            this.dataGridViewNonCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNonCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RRN,
            this.BankId,
            this.BankName,
            this.TerminalId,
            this.Approval,
            this.Amount,
            this.AquireBankId});
            this.dataGridViewNonCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNonCash.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNonCash.Name = "dataGridViewNonCash";
            this.dataGridViewNonCash.Size = new System.Drawing.Size(720, 125);
            this.dataGridViewNonCash.TabIndex = 0;
            this.dataGridViewNonCash.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNonCash_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewNonCash);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Картаар";
            // 
            // textBoxNonCashAmount
            // 
            this.textBoxNonCashAmount.Location = new System.Drawing.Point(301, 164);
            this.textBoxNonCashAmount.Name = "textBoxNonCashAmount";
            this.textBoxNonCashAmount.Size = new System.Drawing.Size(146, 20);
            this.textBoxNonCashAmount.TabIndex = 4;
            // 
            // labelNonCashAmount
            // 
            this.labelNonCashAmount.AutoSize = true;
            this.labelNonCashAmount.Location = new System.Drawing.Point(181, 167);
            this.labelNonCashAmount.Name = "labelNonCashAmount";
            this.labelNonCashAmount.Size = new System.Drawing.Size(92, 13);
            this.labelNonCashAmount.TabIndex = 5;
            this.labelNonCashAmount.Text = "Нийт мөнгөн дүн";
            // 
            // RRN
            // 
            this.RRN.HeaderText = "RRN";
            this.RRN.Name = "RRN";
            // 
            // BankId
            // 
            this.BankId.HeaderText = "Банк ID";
            this.BankId.Name = "BankId";
            // 
            // BankName
            // 
            this.BankName.HeaderText = "Банкны нэр";
            this.BankName.Name = "BankName";
            // 
            // TerminalId
            // 
            this.TerminalId.HeaderText = "Терминал ID";
            this.TerminalId.Name = "TerminalId";
            // 
            // Approval
            // 
            this.Approval.HeaderText = "Approval";
            this.Approval.Name = "Approval";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Мөнгөн дүн";
            this.Amount.Name = "Amount";
            // 
            // AquireBankId
            // 
            this.AquireBankId.HeaderText = "AquireBankId";
            this.AquireBankId.Name = "AquireBankId";
            // 
            // FormNonCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 197);
            this.Controls.Add(this.labelNonCashAmount);
            this.Controls.Add(this.textBoxNonCashAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNonCash";
            this.Text = "Бэлэн бус гүйлгээ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNonCash)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewNonCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNonCashAmount;
        private System.Windows.Forms.Label labelNonCashAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AquireBankId;
    }
}