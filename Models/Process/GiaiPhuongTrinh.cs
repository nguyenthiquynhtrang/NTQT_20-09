namespace DemoMVC.Models.Process
{
public class GiaiPhuongTrinh
{
   public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
   {
    double x;
    string message = "";
    if (heSoA==0)
    {
        if(heSoB==0)
        {
            message ="Phuong trinh co vo so nghiem ";
        }
        else
        {
            message ="Phuong trinh vo nghiem ";
        }
    }
    else 
    {
        x = -heSoB/heSoA;
        message =" Phuong trinh co nghiem x " + x;
    }
     return message;
   }
   //phuong thuc giai phuong trinh bac 2
   public string GiaiPhuongTrinhBacHai (double heSoA,double heSoB, double heSoC)
   {
    string message ="";
    double delta, x1, x2, x;
    if (heSoA == 0)
    {
        message = GiaiPhuongTrinhBacNhat(heSoB,heSoC);
    if(heSoB==0)
    {
        if(heSoC == 0)
        {
            message ="Phuong trinh co vo so nghiem";
        }
        else 
        {
            message = "Phuong trinh vo nghiem ";
        }
    }
        else 
        {
            x= -heSoC/heSoB;
            message =" phuong trinh co nghiem x :" + x;
        }
    }
    else {
        delta = heSoB * heSoB - 4 * heSoA * heSoC ;
        if (delta > 0)
        {
            x1 = (-heSoB + Math.Sqrt(delta)) / 2 * heSoA ;
            x2 = (-heSoB - Math.Sqrt(delta)) / 2 * heSoA ;
            message ="Phuong trinh co nghiem x1 va x2 la :" + x1 + " va " + x2;
        }
        else if (delta == 0)
        {
            x = -heSoB / (2 * heSoA);
            message = "Phuong trinh co nghiem kep x1 = x2 = " + x;
        }
        else
        {
            message = "Phuong trinh vo nghiem";
        }
    } 
    return message;
   }
   }
}