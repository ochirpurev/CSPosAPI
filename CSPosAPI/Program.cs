using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSPosAPI
{
    static class Program
    {

        /// <summary>
        /// Хэрэглэгчийн системээс бараа, үйлчилгээ борлуусан мэдээллийг JSON string төрөлтэйгээр 
        /// хүлээн авч буцаан баримтын дахин давтагдашгүй дугаар, сугалааны дугаар, гүйлгээ хийсэн огноо, 
        /// баримтын код, QrCode гэсэн утгуудыг нэмж боловсруулах метод
        /// </summary>
        /// <param name="message">JSON string</param>
        /// <returns>
        /// JSON string төрөлтэйгээр баримтын дахин давтагдашгүй
        /// дугаар, сугалааны дугаар, гүйлгээ хийсэн огноо, 
        /// баримтын код, QrCode гэсэн утгуудыг нэмж боловсруулах метод
        /// </returns>
        [DllImport(
            "PosAPI.dll",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.Cdecl
           )]

        [return: MarshalAs(
            UnmanagedType.BStr
            )]
        public static extern string put(String message);


        /// <summary>
        /// Бараа, үйлчилгээ борлуулсан баримтыг хүчингүй болгох метод.
        /// Бараа, үйлчилгээ борлуулсан баримтыг хэсэгчлэн буцааж /10 ширхэг бараанаас зөвхөн 1 ширхэг бараа гэх мэт/ болохгүй. 
        /// Учир нь НӨАТУС-ийн баримтын буцаалт нь тухайн баримтыг шууд хүчингүй баримт болгох бөгөөд тухайн баримтын сугалааг хүчингүй гэж үзнэ. 
        /// Хэрэв хэсэгчлэн буцаасан бол тухайн баримтыг буцаан шинээр баримт хэвлэж өгнө.
        /// </summary>
        /// <param name="message">JSON string Баримтын дугаар</param>
        /// <returns>JSON string</returns>
        [DllImport("PosAPI.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string returnBill(String message);

        /// <summary>
        ///Бүртгэсэн бараа, үйлчилгээ борлуулсан баримтыг НӨАТУС-д илгээх зорилготой. Шидэх үйлдлийг хийхийн тулд тухайн бүртгэлийн машин нь internet сүлжээнд холбогдсон байх ёстой.
        ///Хэрэв тухайн бүртгэлийн машинд PosAPI 2.0 санг шинээр суурьлуулсан бол
        ///sendData method-ийг заавал нэг удаа хоосон дуудна. Ингэснээр НӨАТУС-д тухайн PosAPI-г бүртгүүлж, шаардлагатай тохиргооны мэдээллийг татана.
        /// </summary>
        /// <returns>JSON string</returns>
        [DllImport("PosAPI.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string sendData();


        public const string NUMBER_FORMAT = "0.00";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
