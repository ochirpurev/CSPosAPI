using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSPosAPI.Common
{
    /// <summary>
    /// Худалдан авсан бараа үйлчилгээ
    /// </summary>
    public class BillDetail
    {
        /// <summary>
        /// Авсан бараа үйлчилгээний код
        /// </summary>
        public string code;
        /// <summary>
        /// Авсан бараа үйлчилгээний дугаар
        /// </summary>
        public string name;
        /// <summary>
        /// Авсан бараа үйлчилгээний хэмжих нэгж
        /// </summary>
        public string measureUnit;
        /// <summary>
        /// Авсан бараа үйлчилгээний тоон хэмжээ
        /// </summary>
        public string qty;
        /// <summary>
        /// Авсан бараа үйлчилгээний нэгж үнэ
        /// </summary>
        public string unitPrice;
        /// <summary>
        /// Авсан бараа үйлчилгээний нийт үнэ
        /// </summary>
        public string totalAmount;
        /// <summary>
        /// Авсан бараа үйлчилгээний НӨАТ
        /// </summary>
        public string vat;
        /// <summary>
        /// Барааны 1D баркод
        /// </summary>
        public string barCode;
        /// <summary>
        /// Нийслэл хотын албан татвар
        /// </summary>
        public string cityTax;
    }
}
