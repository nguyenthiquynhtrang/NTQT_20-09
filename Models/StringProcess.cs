namespace DemoMVC.Models.Process
{
    public class StringProcess
    {
         public string RemoveRemainingWhiteSpace(string strInput)
        {
            string result = "";
            //viet code xu ly cac ky tu trang con thua
            //xoa bo ky tu trang o dau va cuoi chuoi
            strInput = strInput.Trim();
            //xoa bo ky tu trang o giua chuoi
            int index = strInput.IndexOf("  ");
            while(strInput.IndexOf("  ") > 0)
            {
                strInput = strInput.Replace("  "," ");
            }
            result = strInput;
            return result;
        }
         public string UpperToLower(string strInput)
        {
            string strResult = "";
            //viet code xu ly theo yeu cau cua bai toan
            strInput = strInput.ToLower();
            strResult = strInput;
            //tra ve gia tri
            return strResult;
        }
        public string CapitalizeOneFirstCharacter(string strInput)
        {
            string strResult = "";
            string firstCharacter = strInput.Substring(0, 1).ToUpper();
            strResult = firstCharacter + strInput.Substring(1);
            return strResult;
        }
        public string CapitalizeFirstCharacter(string strInput)
        {
            string strResult = "";
            //tach cac tu trong chuoi dua vao 1 mang
            string[] chuoi = strInput.Split(" ");
            for(int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] != "")
                {
                    chuoi[i] = CapitalizeOneFirstCharacter(chuoi[i]);
                }

            }
            strResult = String.Join(" ", chuoi);
            return strResult;
        }
        public string LowerToUpper(string strInput)
        {
            return strInput.ToUpper();
        }

        public string RemoveVietnameseAccents(string strInput)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                            "đ",
                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                            "í","ì","ỉ","ĩ","ị",
                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                            "ý","ỳ","ỷ","ỹ","ỵ"};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                            "d",
                            "e","e","e","e","e","e","e","e","e","e","e",
                            "i","i","i","i","i",
                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                            "u","u","u","u","u","u","u","u","u","u","u",
                            "y","y","y","y","y"};
            for(int i = 0; i < arr1.Length; i++)
            {
                strInput = strInput.Replace(arr1[i], arr2[i]);
                strInput = strInput.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }

            return strInput;
        }
    }
}

        
    
