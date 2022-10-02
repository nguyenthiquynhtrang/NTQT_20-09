using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models.Process;
namespace DemoMVC.Controllers;

    public class DemoController : Controller
    {
            GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
            StringProcess strPro = new StringProcess();
        public IActionResult Index()
        {
            return View();
        }
        //nhan duoc du lieu tu view gui len 
        [HttpPost]
        public IActionResult Index(string heSoA, string heSoB)
        {
           
            double a = Convert.ToDouble( heSoA );
            double b = Convert.ToDouble( heSoB );
            string thongBao = gpt.GiaiPhuongTrinhBacNhat(a,b);
            ViewBag.mess = thongBao;
            return View();
        }
    //Phuong Trinh Bac 2
    public IActionResult Create( string heSoA, string heSoB, string heSoC )
    {
        double A = Convert.ToDouble(heSoA);
        double B = Convert.ToDouble(heSoB);
        double C = Convert.ToDouble(heSoC);
        string thongBao = gpt.GiaiPhuongTrinhBacHai(A, B, C);
        ViewBag.abc = thongBao ;
        return View();
    }
    
        public IActionResult XuLyChuoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult XuLyChuoi(string strInput)
        {
            ViewBag.thongBao = strPro.RemoveRemainingWhiteSpace(strInput);
            return View();
        }
        
         public IActionResult VietThuong(string strInput)
        {
            ViewBag.thongBao = strPro.UpperToLower(strInput);
            return View();
        }
        public IActionResult VietHoa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VietHoa(string strInput)
        {
            ViewBag.thongBao = strPro.LowerToUpper(strInput);
            return View();
        }
        public IActionResult VietHoaKyTuDauTien()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VietHoaKyTuDauTien(string strInput)
        {
            ViewBag.thongBao = strPro.CapitalizeOneFirstCharacter(strInput);
            return View();
        }
        public IActionResult VietHoaCacKyTuDauTien()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VietHoaCacKyTuDauTien(string strInput)
        {
            ViewBag.thongBao = strPro.CapitalizeFirstCharacter(strInput);
            return View();
        }
        public IActionResult BoDauVietNam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BoDauVietNam(string strInput)
        {
            ViewBag.thongBao = strPro.RemoveVietnameseAccents(strInput);
            return View();
        }
    }

       
    

