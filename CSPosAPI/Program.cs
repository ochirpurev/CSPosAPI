using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

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
        /// <summary>
        /// Хэрэглэгчийн системийн тогтвортой ажиллагааг хангах шаардлагын улмаас PosAPI сангийн ажиллагааг шалгана. Хэрэглэгчийн системийг ажиллуулж буй үйлдлийн системийн хэрэглэгч нь заавал өөрийн HOME directory-той байх ёстой. Хэрэв уг шаардлагыг хангаагүй бол уг функц нь амжилтгүй гэсэн утгыг буцаана.
        /// </summary>
        /// <returns></returns>
        [DllImport("PosAPI.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string checkApi();
        /// <summary>
        /// Хэрэглэгчийн систем нь нэгээс олон PosAPI ашиглаж буй үед харьцаж буй PosAPI-гийн мэдээллийг харах шаардлага тулгардаг. Уг функц нь уг асуудлыг шийдэж буй бөгөөд уг функцийн тусламжтайгаар хэрэглэгчийн систем нь тухайн ашиглаж буй PosAPI-гийн дотоод мэдээллүүдийг авна.
        /// </summary>
        /// <returns></returns>
        [DllImport("PosAPI.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string getInformation();


        /// <summary>
        /// PosAPI нь цаашид шинээр нэмэлт функцүүд нэмэгдэх бөгөөд нэмэгдсэн функцийг ашиглахын тулд заавал өөрийн PosAPI-г шинээр татах шаардлаггүй юм. Уг нэмэлт функцүүдийг уг функцийн тусламжтайгаар дуудана.
        /// </summary>
        /// <param name="funcName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        [DllImport(
            "PosAPI.dll",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.Cdecl
           )]
        [return: MarshalAs(
            UnmanagedType.BStr
            )]
        public static extern string callFunction(string funcName, string param);

        /// <summary>
        /// Тоон формат
        /// </summary>
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
