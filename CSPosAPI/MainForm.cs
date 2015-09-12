using CSPosAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace CSPosAPI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Нийт бэлэн бусаар төлсөн дүн
        /// </summary>
        private double summaryNonCash;
        /// <summary>
        /// Нийт төлөх дүн
        /// </summary>
        private double summaryAmount;
        /// <summary>
        /// Нийт НӨАТ дүн
        /// </summary>
        private double summaryVat;
        /// <summary>
        /// Нийт НХОАТ дүн
        /// </summary>
        private double summaryCityTax;
        /// <summary>
        /// 
        /// </summary>
        private Result resultData;
        /// <summary>
        /// Хэвлэгч обьект
        /// </summary>
        PrintDocument pdoc = null;
        /// <summary>
        /// Баримтын цаасанд тохируулан хэвлэх үржүүлэгч
        /// Уг тоо нь 80mm цаас ашиглах үед 1 байна.
        /// 57,75mm г.м үед харгалзах үржүүлэгчээр хэмжээг тохируулна
        /// </summary>
        private double k = 1;
        /// <summary>
        /// Бэлэн бус гүйлгээний жагсаалт
        /// </summary>
        private List<BillBankTransaction> ListBankTranscation;

        public MainForm()
        {
            InitializeComponent();
        }

        #region EVENT_CLICK
        /// <summary>
        /// Бэлэн бусаар тооцоо хийх цонхыг ажиллуулна. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNonCash_Click(object sender, EventArgs e)
        {
            var formNonCash = new FormNonCash();
            formNonCash.ShowDialog();
            this.summaryNonCash = formNonCash.SummaryNonCash;
            textBoxNonCash.Text = this.summaryNonCash.ToString(Program.NUMBER_FORMAT);
            this.ListBankTranscation = formNonCash.ListBankTranscation;
            Calculate();
            this.summaryNonCash = 0;
        }

        /// <summary>
        /// Гүйлгээний мэдээллийг JSON форматанд хөрвүүлэн 
        /// сугалаа,баримтын дугаар, QR код г.м мэдээллийг үүсгэнэ 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateBill_Click(object sender, EventArgs e)
        {
            var data = new BillData();
            data.amount = textBoxAmount.Text;
            data.vat = textBoxVat.Text;
            data.cashAmount = textBoxCash.Text;
            data.nonCashAmount = textBoxNonCash.Text;
            data.billIdSuffix = textBoxNumber.Text;

            var lstBillStock = new List<BillDetail>();

            foreach (DataGridViewRow row in dataGridViewStocks.Rows)
            {
                if (!row.IsNewRow)
                {
                    var stock = new BillDetail();
                    stock.code = row.Cells["Code"].Value.ToString();
                    stock.name = row.Cells["ItemName"].Value.ToString();
                    stock.measureUnit = row.Cells["MeasureUnit"].Value.ToString();
                    stock.qty = row.Cells["Qty"].Value.ToString();
                    stock.unitPrice = row.Cells["UnitPriceNonVat"].Value.ToString();
                    stock.totalAmount = row.Cells["Amount"].Value.ToString();
                    stock.vat = row.Cells["Vat"].Value.ToString();
                    stock.barCode = row.Cells["BarCode"].Value.ToString();
                    stock.cityTax = row.Cells["CityTax"].Value.ToString();
                    lstBillStock.Add(stock);
                }
            }
            data.cityTax = textBoxCityTax.Text;
            data.bankTransactions = this.ListBankTranscation;

            if (lstBillStock.Count == 0)
            {
                lstBillStock = null;
            }
            data.stocks = lstBillStock;

            data.districtCode = textBoxDistrict.Text;

            var json = new JavaScriptSerializer().Serialize(data);
            var result = Program.put(json);
            this.resultData = new JavaScriptSerializer().Deserialize<Result>(result);

            if ("True".Equals(this.resultData.success.ToString()))
            {
                print();
            }
        }
        /// <summary>
        /// Буцаалтын гүйлгээний цонх-г ажиллуулна.
        /// Буцаалтыг тухайн баримтын дугаарыг оруулна.
        /// Хэсэгчилсэн буцаалт хийхгүй тухайн гүйлгээг хүчингүйд тооцно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturnBill_Click(object sender, EventArgs e)
        {
            var formBillReturn = new BillReturn();
            formBillReturn.ShowDialog();
        }

        /// <summary>
        /// НӨАТУС-с багц сугалааны дугаар татах буюу
        /// тухайн ПОС-д хийгдсэн гүйлгээний мэдээллийг
        /// НӨАТУС-д илгээнэ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            var result = Program.sendData();
            var resultSend = new JavaScriptSerializer().Deserialize<Result>(result);
            if ("True".Equals(resultSend.success))
            {
                MessageBox.Show("Aмжилттай");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        /// <summary>
        /// Сонгогдсон барааг жагсаалтанд нэмнэ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStock.SelectedItem != null)
            {
                var stock = GetItemById(comboBoxStock.SelectedItem.ToString());
                DataGridViewRow row = (DataGridViewRow)dataGridViewStocks.Rows[0].Clone();
                row.Cells[0].Value = stock.code;
                row.Cells[1].Value = stock.name;
                row.Cells[2].Value = stock.measureUnit;
                row.Cells[3].Value = stock.qty;
                row.Cells[4].Value = stock.unitPrice;
                row.Cells[5].Value = (Convert.ToDouble(stock.unitPrice) * Convert.ToDouble(stock.qty)).ToString();
                row.Cells[6].Value = stock.totalAmount;
                row.Cells[7].Value = stock.vat;
                row.Cells[8].Value = stock.barCode;
                row.Cells[9].Value = stock.cityTax;
                this.dataGridViewStocks.Rows.Add(row);
                Calculate();
                Calculate();
            }
        }
        #endregion

        #region EVENT_VALUECHANGED
        private void dataGridViewStocks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            summaryAmount = 0;
            summaryVat = 0;
            summaryCityTax = 0;
            foreach (DataGridViewRow row in dataGridViewStocks.Rows)
            {
                if (!row.IsNewRow)
                {
                    double qty = Convert.ToDouble(row.Cells["Qty"].Value);
                    double unitPrice = Convert.ToDouble(row.Cells["UnitPrice"].Value);
                    double vat = Convert.ToDouble(row.Cells["Vat"].Value);
                    double cityTax = Convert.ToDouble(row.Cells["CityTax"].Value);
                    double unitPriceNonVat = Convert.ToDouble(row.Cells["UnitPriceNonVat"].Value);
                    double summary = qty * (unitPrice + cityTax);
                    row.Cells["UnitPrice"].Value = (unitPriceNonVat * 1.1).ToString(Program.NUMBER_FORMAT);
                    row.Cells["Vat"].Value = (unitPriceNonVat * 0.1).ToString(Program.NUMBER_FORMAT);
                    row.Cells["Amount"].Value = summary.ToString(Program.NUMBER_FORMAT);
                    summaryAmount += summary;
                    summaryVat += vat;
                    summaryCityTax += cityTax;
                }
            }
        }
        #endregion


        private BillDetail GetItemById(string id)
        {
            var stock = new BillDetail();

            if ("1201".Equals(id))
            {
                stock.code = id;
                stock.name = "Талх";
                stock.measureUnit = "ш";
                stock.qty = "3.00";
                stock.unitPrice = "1000.00";
                stock.totalAmount = "3900";
                stock.vat = "100";
                stock.barCode = "156266";
                stock.cityTax = "0.00";
            }
            else if ("1202".Equals(id))
            {
                stock.code = id;
                stock.name = "Цамц";
                stock.measureUnit = "ш";
                stock.qty = "1.00";
                stock.unitPrice = "45000.00";
                stock.totalAmount = "45000.00";
                stock.vat = "4500.00";
                stock.barCode = "156266";
                stock.cityTax = "0.00";
            }
            else if ("1000".Equals(id))
            {
                stock.code = id;
                stock.name = "Сүү";
                stock.measureUnit = "л";
                stock.qty = "1.00";
                stock.unitPrice = "980.00";
                stock.totalAmount = "980.00";
                stock.vat = "100.00";
                stock.barCode = "156266";
                stock.cityTax = "0.00";
            }
            else if ("1001".Equals(id))
            {
                stock.code = id;
                stock.name = "Архи-Ex";
                stock.measureUnit = "ш";
                stock.qty = "1.00";
                stock.unitPrice = "20000.00";
                stock.totalAmount = "20000.00";
                stock.vat = "2000.00";
                stock.barCode = "0124652";
                stock.cityTax = (Convert.ToDouble(stock.unitPrice) * 0.01).ToString(Program.NUMBER_FORMAT);
            }
            else if ("1002".Equals(id))
            {
                stock.code = id;
                stock.name = "Гуляш";
                stock.measureUnit = "ш";
                stock.qty = "1.00";
                stock.unitPrice = "4000.00";
                stock.totalAmount = "4000.00";
                stock.vat = "400.00";
                stock.barCode = "01246526";
                stock.cityTax = "0.00";
            }
            else if ("2001".Equals(id))
            {
                stock.code = id;
                stock.name = "Тамхи Esse";
                stock.measureUnit = "ш";
                stock.qty = "1.00";
                stock.unitPrice = "3500.00";
                stock.totalAmount = "3500.00";
                stock.vat = "350.00";
                stock.barCode = "012465233";
                stock.cityTax = (Convert.ToDouble(stock.unitPrice) * 0.01).ToString(Program.NUMBER_FORMAT);
            }
            else if ("2002".Equals(id))
            {
                stock.code = id;
                stock.name = "Magna";
                stock.measureUnit = "ш";
                stock.qty = "1.00";
                stock.unitPrice = "2500.00";
                stock.totalAmount = "2500.00";
                stock.vat = "250.00";
                stock.barCode = "012465233";
                stock.cityTax = (Convert.ToDouble(stock.unitPrice) * 0.01).ToString(Program.NUMBER_FORMAT);
            }
            return stock;
        }

        private void Calculate()
        {
            dataGridViewStocks_CellValueChanged(null, null);
            textBoxAmount.Text = summaryAmount.ToString(Program.NUMBER_FORMAT);
            textBoxVat.Text = summaryVat.ToString(Program.NUMBER_FORMAT);
            textBoxCityTax.Text = summaryCityTax.ToString(Program.NUMBER_FORMAT);
            textBoxNonCash.Text = summaryNonCash.ToString(Program.NUMBER_FORMAT);
            textBoxCash.Text = (summaryAmount - summaryNonCash < 0 ? 0 : summaryAmount - summaryNonCash).ToString(Program.NUMBER_FORMAT);

            textBoxPaidAmount.Text = textBoxCash.Text;
        }

        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);

             //PaperSize psize = new PaperSize("Custom", 219, 1000);
            pd.Document = pdoc;
            //pd.Document.DefaultPageSettings.PaperSize = psize;
            
            if (pd.Document.DefaultPageSettings.PaperSize.Width <= 284)
            {
                k = Convert.ToDouble(pd.Document.DefaultPageSettings.PaperSize.Width) / 284;
            }

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
                pp.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                pp.PrintPreviewControl.Zoom = 1f;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }
        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            string underLine;
            Font font;
            if (k < 1)
            {
                font = new Font("Courier New", 6);
                underLine = "-------------------------------------";
            }
            else
            {
                font = new Font("Courier New", 8);
                underLine = "---------------------------------------";
            }

            float fontHeight = font.GetHeight();
            int startX = 0;
            int startY = 10;
            int Offset = Convert.ToInt32(fontHeight);

            int newLine15 = toValue(15);
            int newLine20 = toValue(20);

            graphics.DrawString("Мерчант :".PadRight(10) + this.resultData.merchantId,
                    font,
                    new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + newLine15;

            graphics.DrawString("Баримт №: " + this.resultData.billId,
                    font,
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine15;
            graphics.DrawString("Огноо :".PadRight(10) + this.resultData.date,
                     font,
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + newLine15;

            graphics.DrawString("Касс :".PadRight(10) + "122",
                     font,
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + newLine15;

            graphics.DrawString(underLine, font,
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            string tmp = "Д/д Бараа".PadRight(10) + "Х/нэгж".PadRight(8) + "Код";
            graphics.DrawString(tmp, font,
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + newLine15;
            string tmp1 = "Үнэ".PadRight(7) + "НӨАТ".PadRight(6) + "НХАТ".PadRight(7) + "тоо/ш".PadRight(12) + "Дүн";
            tmp1 = tmp1.PadLeft(38);
            graphics.DrawString(tmp1, font,
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            if (this.resultData.stocks != null)
            {
                var count = 0;
                foreach (BillDetail stock in this.resultData.stocks)
                {
                    graphics.DrawString(++count + " " + stock.name.PadRight(12) + stock.measureUnit.PadRight(4) + stock.code, font, new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + newLine20;
                    string unitPriceVat = (Convert.ToDouble(stock.unitPrice) + Convert.ToDouble(stock.vat)).ToString(Program.NUMBER_FORMAT);

                    var value = String.Format("   {0:F0}   {1:F0}   {2:F0}   x {3}", Convert.ToDouble(stock.unitPrice), Convert.ToDouble(stock.vat), Convert.ToDouble(stock.cityTax), stock.qty);
                    var amount = Convert.ToDouble(stock.totalAmount);
                    value += amount.ToString().PadLeft(10);
                    value = value.PadLeft(38);

                    graphics.DrawString(value, font,
                       new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + newLine15;
                }

            }

            graphics.DrawString(underLine, font,
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + newLine20;

            if (resultData.bankTransactions != null && resultData.bankTransactions.Count != 0)
            {
                string tmpb = String.Format("Банк/нэр".PadRight(13) + "RRN".PadRight(12) + "Approval".PadRight(9) + "Дүн");
                graphics.DrawString(tmpb, font,
                  new SolidBrush(Color.Black), startX, startY + Offset);

                Offset = Offset + newLine20;
                foreach (BillBankTransaction banktranscation in this.resultData.bankTransactions)
                {
                    graphics.DrawString(banktranscation.bankName.PadRight(12),
                    font,
                     new SolidBrush(Color.Black),
                    new Rectangle(startX, startY + Offset, 100, 50)
                    );
                    var value = banktranscation.bankName.PadRight(8) +banktranscation.rrn.PadRight(16) + banktranscation.approvalCode.PadRight(9)+ banktranscation.amount;
                    graphics.DrawString(value, font,
                      new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + newLine20; //newLine20;
                }

                graphics.DrawString(underLine, font,
                         new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + newLine20;
            }

            graphics.DrawString("Бэлэн :".PadRight(13) + resultData.cashAmount, font,
                   new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            graphics.DrawString("Бэлэн Бус :".PadRight(13) + resultData.nonCashAmount, font,
                   new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            graphics.DrawString("НӨАТ :".PadRight(13) + resultData.vat, font,
                 new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            graphics.DrawString("НХАТ :".PadRight(13) + resultData.cityTax, font,
               new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            graphics.DrawString("Нийт :".PadRight(13) + resultData.amount, font,
       new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            graphics.DrawString("Төлсөн :".PadRight(13) + Convert.ToDouble(textBoxPaidAmount.Text).ToString(Program.NUMBER_FORMAT), font,
 new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            graphics.DrawString("Хариулт :".PadRight(13) + (Convert.ToDouble(textBoxPaidAmount.Text) - Convert.ToDouble(this.resultData.cashAmount)).ToString(Program.NUMBER_FORMAT), font,
 new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + newLine20;

            graphics.DrawString(underLine, font,
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + newLine20;

            if (resultData.lottery != null && resultData.lottery.Length != 0)
            {
                graphics.DrawString("Сугалаа :".PadRight(15) + this.resultData.lottery,
                    font,
                    new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + newLine15;
            }


            if (resultData.lottery != null && resultData.lottery.Length != 0)
            {
                ZXing.IBarcodeWriter writer = new ZXing.BarcodeWriter
                {
                    Format = ZXing.BarcodeFormat.QR_CODE,
                    Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Width = toValue(150),
                        Height = toValue(150)
                    }
                };
                var dataQr = writer.Write(resultData.qrData);
                var barcodeBitmap = new Bitmap(dataQr, new Size(toValue(150), toValue(150)));
                graphics.DrawImage(barcodeBitmap, toValue(startX + 55), startY + Offset);

                Offset = Offset + toValue(100 + 50);
            }

            var writerBarCode = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.CODE_128,
                Options = new ZXing.OneD.Code128EncodingOptions
                {
                    PureBarcode = true,
                    Width = toValue(180),
                    Height = toValue(50),
                }
            };

            var bitmap = writerBarCode.Write(this.resultData.billId);
            graphics.DrawImage(bitmap, k < 1 ? toValue(startX) : toValue(startX + 30), startY + Offset);

            Offset = Offset + toValue(70);

            if (resultData.internalCode != null && resultData.internalCode.Length != 0)
            {
                graphics.DrawString("Internal Code :".PadLeft(20), font,
                       new SolidBrush(Color.Black), toValue(startX + 50), startY + Offset);
                Offset = Offset + newLine20;

                graphics.DrawString(resultData.internalCode, font,
                        new SolidBrush(Color.Black), new Rectangle(toValue(startX + 50), startY + Offset, toValue(150), 50));
                Offset = Offset + newLine20;
            }

            graphics.Dispose();

        }
        int toValue(int value)
        {
            return Convert.ToInt32(Convert.ToDouble(value) * this.k);
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            dataGridViewStocks.Rows.Clear();
            Calculate();
        }
    }
}
