namespace DemoMVC.Models.Process
{
    public class GenCode
    {
        //Phuong thuc sinh ma tu dong
        public string AutoGenCode(string lastCode)
        {
            string newCode = string.Empty;

            if (!string.IsNullOrEmpty(lastCode))
            {
                //Chu va so tach rieng
                string prefix = new string(lastCode.TakeWhile(c => !char.IsDigit(c)).ToArray());
                string numberPart = new string(lastCode.SkipWhile(c => !char.IsDigit(c)).ToArray());

                //Chuyen phan so sang kieu int va +1
                int number = int.Parse(numberPart) + 1;

                //Ghep lai voi dinh dang co 3 chu so 
                newCode = prefix + number.ToString("D3");

            }
            else
            {
                //Neu bat dau tu ma dau tien
                newCode = "STD001";
            }
            return newCode;
        }
    }
}