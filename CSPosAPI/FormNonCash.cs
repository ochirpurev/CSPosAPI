using CSPosAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSPosAPI
{
    public partial class FormNonCash : Form
    {
        private double summaryNonCash = 0;

        private List<BillBankTransaction> listBankTranscation = null;

        public double SummaryNonCash
        {
            get { return summaryNonCash; }
        }

        public List<BillBankTransaction> ListBankTranscation
        {
            get { return listBankTranscation; }
        }
        public FormNonCash()
        {
            InitializeComponent();

            dataGridViewNonCash.Rows[0].Cells["RRN"].Value = "234598562687";
            dataGridViewNonCash.Rows[0].Cells["BankId"].Value = "05";
            dataGridViewNonCash.Rows[0].Cells["BankName"].Value = "Хаан банк Жуков";
            dataGridViewNonCash.Rows[0].Cells["TerminalId"].Value = "KH98793";
            dataGridViewNonCash.Rows[0].Cells["Approval"].Value = "156946";
            dataGridViewNonCash.Rows[0].Cells["Amount"].Value = "0.00";
            dataGridViewNonCash.Rows[0].Cells["AquireBankId"].Value = "04";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listBankTranscation = null;
            summaryNonCash = 0;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            this.listBankTranscation = new List<BillBankTransaction>();
            foreach (DataGridViewRow row in dataGridViewNonCash.Rows)
            {
                if (!row.IsNewRow)
                {
                    var btrans = new BillBankTransaction();
                    btrans.rrn = row.Cells["RRN"].Value.ToString();
                    btrans.bankId = row.Cells["BankId"].Value.ToString();
                    btrans.bankName = row.Cells["BankName"].Value.ToString();
                    btrans.terminalId = row.Cells["TerminalId"].Value.ToString();
                    btrans.approvalCode = row.Cells["Approval"].Value.ToString();
                    btrans.amount = row.Cells["Amount"].Value.ToString();
                    btrans.acquiringBankId = row.Cells["AquireBankId"].Value.ToString();
                    listBankTranscation.Add(btrans);
                }
            }

            this.Close();
        }

        private void dataGridViewNonCash_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            summaryNonCash = 0;
            foreach (DataGridViewRow row in dataGridViewNonCash.Rows)
            {
                if (!row.IsNewRow)
                {
                    double amountNonCash = Convert.ToDouble(row.Cells["Amount"].Value);
                    summaryNonCash += amountNonCash;
                }
            }
            textBoxNonCashAmount.Text = summaryNonCash.ToString(Program.NUMBER_FORMAT);
        }
    }
}
