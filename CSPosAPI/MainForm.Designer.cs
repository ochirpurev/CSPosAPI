namespace CSPosAPI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceNonVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.labelNonCash = new System.Windows.Forms.Label();
            this.labelBillSuffix = new System.Windows.Forms.Label();
            this.labelCityTax = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.textBoxNonCash = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxCityTax = new System.Windows.Forms.TextBox();
            this.buttonCreateBill = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonNonCash = new System.Windows.Forms.Button();
            this.comboBoxStock = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReturnBill = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCustomerNo = new System.Windows.Forms.Label();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.labelPosNo = new System.Windows.Forms.Label();
            this.textBoxPosNo = new System.Windows.Forms.TextBox();
            this.buttonCheckApi = new System.Windows.Forms.Button();
            this.buttonGetInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStocks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.ItemName,
            this.MeasureUnit,
            this.Qty,
            this.UnitPriceNonVat,
            this.UnitPrice,
            this.Amount,
            this.Vat,
            this.BarCode,
            this.CityTax});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStocks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStocks.Location = new System.Drawing.Point(1, 44);
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStocks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStocks.Size = new System.Drawing.Size(383, 271);
            this.dataGridViewStocks.TabIndex = 0;
            this.dataGridViewStocks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStocks_CellValueChanged);
            // 
            // Code
            // 
            this.Code.HeaderText = "Барааны Код";
            this.Code.Name = "Code";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Барааны нэр";
            this.ItemName.Name = "ItemName";
            // 
            // MeasureUnit
            // 
            this.MeasureUnit.HeaderText = "Хэмжих нэгж";
            this.MeasureUnit.Name = "MeasureUnit";
            this.MeasureUnit.Width = 50;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Тоо/ширхэг";
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Qty.Width = 60;
            // 
            // UnitPriceNonVat
            // 
            this.UnitPriceNonVat.HeaderText = "Нэгж үнэ татваргүй";
            this.UnitPriceNonVat.Name = "UnitPriceNonVat";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Нэгж үнэ татвартай";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Нийт үнэ";
            this.Amount.Name = "Amount";
            // 
            // Vat
            // 
            this.Vat.HeaderText = "Татвар";
            this.Vat.Name = "Vat";
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "Бар код";
            this.BarCode.Name = "BarCode";
            // 
            // CityTax
            // 
            this.CityTax.HeaderText = "Нийслэл албан татвар";
            this.CityTax.Name = "CityTax";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(3, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(32, 13);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "Нийт";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(3, 25);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(37, 13);
            this.labelVat.TabIndex = 2;
            this.labelVat.Text = "НӨАТ";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Location = new System.Drawing.Point(194, 25);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(38, 13);
            this.labelCash.TabIndex = 3;
            this.labelCash.Text = "Бэлэн";
            // 
            // labelNonCash
            // 
            this.labelNonCash.AutoSize = true;
            this.labelNonCash.Location = new System.Drawing.Point(194, 0);
            this.labelNonCash.Name = "labelNonCash";
            this.labelNonCash.Size = new System.Drawing.Size(49, 13);
            this.labelNonCash.TabIndex = 4;
            this.labelNonCash.Text = "Картаар";
            // 
            // labelBillSuffix
            // 
            this.labelBillSuffix.AutoSize = true;
            this.labelBillSuffix.Location = new System.Drawing.Point(194, 50);
            this.labelBillSuffix.Name = "labelBillSuffix";
            this.labelBillSuffix.Size = new System.Drawing.Size(44, 13);
            this.labelBillSuffix.TabIndex = 5;
            this.labelBillSuffix.Text = "Дугаар";
            // 
            // labelCityTax
            // 
            this.labelCityTax.AutoSize = true;
            this.labelCityTax.Location = new System.Drawing.Point(3, 50);
            this.labelCityTax.Name = "labelCityTax";
            this.labelCityTax.Size = new System.Drawing.Size(44, 13);
            this.labelCityTax.TabIndex = 6;
            this.labelCityTax.Text = "НХОАТ";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(60, 3);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 7;
            this.textBoxAmount.Text = "0.00";
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(60, 28);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(100, 20);
            this.textBoxVat.TabIndex = 8;
            this.textBoxVat.Text = "0.00";
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(251, 28);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(100, 20);
            this.textBoxCash.TabIndex = 9;
            this.textBoxCash.Text = "0.00";
            // 
            // textBoxNonCash
            // 
            this.textBoxNonCash.Location = new System.Drawing.Point(251, 3);
            this.textBoxNonCash.Name = "textBoxNonCash";
            this.textBoxNonCash.Size = new System.Drawing.Size(100, 20);
            this.textBoxNonCash.TabIndex = 10;
            this.textBoxNonCash.Text = "0.00";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(251, 53);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 11;
            // 
            // textBoxCityTax
            // 
            this.textBoxCityTax.Location = new System.Drawing.Point(60, 53);
            this.textBoxCityTax.Name = "textBoxCityTax";
            this.textBoxCityTax.Size = new System.Drawing.Size(100, 20);
            this.textBoxCityTax.TabIndex = 12;
            this.textBoxCityTax.Text = "0.00";
            // 
            // buttonCreateBill
            // 
            this.buttonCreateBill.Location = new System.Drawing.Point(3, 79);
            this.buttonCreateBill.Name = "buttonCreateBill";
            this.buttonCreateBill.Size = new System.Drawing.Size(90, 70);
            this.buttonCreateBill.TabIndex = 13;
            this.buttonCreateBill.Text = "Баримт хэвлэх";
            this.buttonCreateBill.UseVisualStyleBackColor = true;
            this.buttonCreateBill.Click += new System.EventHandler(this.buttonCreateBill_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(3, 155);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(90, 70);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.Text = "Илгээх";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonNonCash
            // 
            this.buttonNonCash.Location = new System.Drawing.Point(3, 3);
            this.buttonNonCash.Name = "buttonNonCash";
            this.buttonNonCash.Size = new System.Drawing.Size(90, 70);
            this.buttonNonCash.TabIndex = 16;
            this.buttonNonCash.Text = "Картаар";
            this.buttonNonCash.UseVisualStyleBackColor = true;
            this.buttonNonCash.Click += new System.EventHandler(this.buttonNonCash_Click);
            // 
            // comboBoxStock
            // 
            this.comboBoxStock.FormattingEnabled = true;
            this.comboBoxStock.Items.AddRange(new object[] {
            "1201",
            "1202",
            "1000",
            "1001",
            "1002",
            "2001",
            "2002",
            "3000",
            "3001",
            "3002",
            "3003",
            "3004",
            "3005",
            "3006",
            "3007",
            "3008"});
            this.comboBoxStock.Location = new System.Drawing.Point(1, 1);
            this.comboBoxStock.Name = "comboBoxStock";
            this.comboBoxStock.Size = new System.Drawing.Size(383, 21);
            this.comboBoxStock.TabIndex = 18;
            this.comboBoxStock.Text = "Бараа сонгох";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 70);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Нэмэх";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(3, 307);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(90, 70);
            this.buttonNew.TabIndex = 21;
            this.buttonNew.Text = "Шинэ";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonNonCash, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCreateBill, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSend, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNew, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonReturnBill, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(383, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 460);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // buttonReturnBill
            // 
            this.buttonReturnBill.Location = new System.Drawing.Point(3, 383);
            this.buttonReturnBill.Name = "buttonReturnBill";
            this.buttonReturnBill.Size = new System.Drawing.Size(90, 70);
            this.buttonReturnBill.TabIndex = 22;
            this.buttonReturnBill.Text = "Буцаалт";
            this.buttonReturnBill.UseVisualStyleBackColor = true;
            this.buttonReturnBill.Click += new System.EventHandler(this.buttonReturnBill_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.labelAmount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelVat, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCityTax, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelBillSuffix, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelCash, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelNonCash, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxVat, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCityTax, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNumber, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNonCash, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCash, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxAmount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCustomerNo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelDistrict, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPaidAmount, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDistrict, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelPosNo, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPosNo, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 336);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(385, 123);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // labelCustomerNo
            // 
            this.labelCustomerNo.AutoSize = true;
            this.labelCustomerNo.Location = new System.Drawing.Point(3, 75);
            this.labelCustomerNo.Name = "labelCustomerNo";
            this.labelCustomerNo.Size = new System.Drawing.Size(47, 25);
            this.labelCustomerNo.TabIndex = 13;
            this.labelCustomerNo.Text = "Төлсөн дүн";
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Location = new System.Drawing.Point(194, 75);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(51, 25);
            this.labelDistrict.TabIndex = 14;
            this.labelDistrict.Text = "Бүсчлэл код";
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Location = new System.Drawing.Point(60, 78);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxPaidAmount.TabIndex = 15;
            this.textBoxPaidAmount.Text = "0.00";
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Location = new System.Drawing.Point(251, 78);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistrict.TabIndex = 16;
            this.textBoxDistrict.Text = "51";
            // 
            // labelPosNo
            // 
            this.labelPosNo.AutoSize = true;
            this.labelPosNo.Location = new System.Drawing.Point(3, 100);
            this.labelPosNo.Name = "labelPosNo";
            this.labelPosNo.Size = new System.Drawing.Size(41, 13);
            this.labelPosNo.TabIndex = 17;
            this.labelPosNo.Text = "Пос №";
            // 
            // textBoxPosNo
            // 
            this.textBoxPosNo.Location = new System.Drawing.Point(60, 103);
            this.textBoxPosNo.Name = "textBoxPosNo";
            this.textBoxPosNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosNo.TabIndex = 20;
            this.textBoxPosNo.Text = "5610";
            // 
            // buttonCheckApi
            // 
            this.buttonCheckApi.Location = new System.Drawing.Point(61, 462);
            this.buttonCheckApi.Name = "buttonCheckApi";
            this.buttonCheckApi.Size = new System.Drawing.Size(93, 33);
            this.buttonCheckApi.TabIndex = 24;
            this.buttonCheckApi.Text = "API check";
            this.buttonCheckApi.UseVisualStyleBackColor = true;
            this.buttonCheckApi.Click += new System.EventHandler(this.buttonCheckApi_Click);
            // 
            // buttonGetInformation
            // 
            this.buttonGetInformation.Location = new System.Drawing.Point(252, 465);
            this.buttonGetInformation.Name = "buttonGetInformation";
            this.buttonGetInformation.Size = new System.Drawing.Size(99, 33);
            this.buttonGetInformation.TabIndex = 25;
            this.buttonGetInformation.Text = "API info";
            this.buttonGetInformation.UseVisualStyleBackColor = true;
            this.buttonGetInformation.Click += new System.EventHandler(this.buttonGetInformation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 507);
            this.Controls.Add(this.buttonGetInformation);
            this.Controls.Add(this.buttonCheckApi);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBoxStock);
            this.Controls.Add(this.dataGridViewStocks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "НӨАТУС demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStocks;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label labelNonCash;
        private System.Windows.Forms.Label labelBillSuffix;
        private System.Windows.Forms.Label labelCityTax;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.TextBox textBoxNonCash;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxCityTax;
        private System.Windows.Forms.Button buttonCreateBill;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonNonCash;
        private System.Windows.Forms.ComboBox comboBoxStock;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceNonVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityTax;
        private System.Windows.Forms.Button buttonReturnBill;
        private System.Windows.Forms.Label labelCustomerNo;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.Label labelPosNo;
        private System.Windows.Forms.TextBox textBoxPosNo;
        private System.Windows.Forms.Button buttonCheckApi;
        private System.Windows.Forms.Button buttonGetInformation;
    }
}

