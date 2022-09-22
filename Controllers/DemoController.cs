using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models.Process;

namespace DemoMVC.Controllers;

    public class DemoController : Controller
    {
            GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
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
    
  }



