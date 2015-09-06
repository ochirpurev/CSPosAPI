using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSPosAPI.Common
{
    /// <summary>
    /// Бэлэн бус гүйлгээний мэдээлэл
    /// </summary>
    public class BillBankTransaction
    {
        /// <summary>
        /// Бэлэн бус гүйлгээний баримтын дугаар
        /// </summary>
        public string rrn;
        /// <summary>
        /// Бэлэн бус гүйлгээ хийсэн банкны код
        /// </summary>
        public string bankId;
        /// <summary>
        /// Бэлэн бус гүйлгээ хийсэн банкны нэр
        /// </summary>
        public string bankName;
        /// <summary>
        /// Бэлэн бус гүйлгээ хийсэн банкны терминалийн дугаар
        /// </summary>
        public string terminalId;
        /// <summary>
        /// Бэлэн бус гүйлгээний лавлах зөвшөөрлийн код
        /// </summary>
        public string approvalCode;
        /// <summary>
        /// Бэлэн бус гүйлгээний хөлийн дүн
        /// </summary>
        public string amount;
        /// <summary>
        /// Банкны ПОС терминалыг эзэмшигч банкны ID
        /// </summary>
        public string acquiringBankId;
    }
}
