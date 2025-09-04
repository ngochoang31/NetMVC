namespace DemoMVC.Models
{
    public class Bai1
    {
        public string FullName { get; set; }
        public int YearOfBirth { get; set; }
        public int Age 
        {
            get
            {
                return 2025 - YearOfBirth;
            }
        }

    }
}