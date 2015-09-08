using CSPosAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CSPosAPI
{
    public partial class BillReturn : Form
    {

       
        public BillReturn()
        {
            InitializeComponent();
            
            dateTimePickerReturn.CustomFormat = "yyyy-MM-dd-HH:mm:ss";
            //dateTimePickerReturn.ShowUpDown = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            var returnBillData = new ReturnBill() {
                returnBillId = textBoxReturn.Text,
                date = dateTimePickerReturn.Value.ToString("yyyy-MM-dd HH:mm:ss")
            };
            var jsonData = new JavaScriptSerializer().Serialize(returnBillData);


            var result = Program.returnBill(jsonData);
            var resultData = new JavaScriptSerializer().Deserialize<Result>(result);

            if ("True".Equals(resultData.success))
            {
                MessageBox.Show("Амжилттай буцаагдглаа.");
            }
            else {
                if ("310".Equals(resultData.errorCode)) {
                    MessageBox.Show("Уг баримт буцаагдсан байна.");
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }
    }
}
