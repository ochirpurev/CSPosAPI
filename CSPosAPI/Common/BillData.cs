using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSPosAPI.Common
{
    /// <summary>
    /// Баримтын мэдээлэл
    /// </summary>
    public class BillData
    {
        /// <summary>
        /// Баримтын НӨАТ агуулаагүй хөлийн дүн
        /// </summary>
        public string amount;
        /// <summary>
        /// Баримтын НӨАТ дүн
        /// </summary>
        public string vat;
        /// <summary>
        /// Бэлэн төлбөрийн дүн
        /// </summary>
        public string cashAmount;
        /// <summary>
        /// Бэлэн бус төлбөрийн дүн
        /// </summary>
        public string nonCashAmount;
        /// <summary>
        /// Баримтын дугаарыг давхцуулахгүйн тулд хэрэглэх залгавар /тухайн өдөрийн хэд дэхь баримт гэм/
        /// </summary>
        public string billIdSuffix;
        /// <summary>
        /// Авсан бараа үйлчилгээ
        /// </summary>
        public List<BillDetail> stocks;
        /// <summary>
        /// Нийслэл хотын албан татвар
        /// </summary>
        public string cityTax;
        /// <summary>
        /// Бэлэн бус гүйлгээний мэдээлэл
        /// </summary>
        public List<BillBankTransaction> bankTransactions;
        /// <summary>
        /// Аймгийн код
        /// </summary>
        public string districtCode;

    }
}
