
namespace DemoMVC.Models
{
    public class Bai2
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Operation { get; set; }
        public double Result
        {
            get
            {
                return Operation switch
                {
                    "add" => Number1 + Number2,
                    "sub" => Number1 - Number2,
                    "mul" => Number1 * Number2,
                    "div" => Number1 / Number2 != 0 ? Number1 / Number2 : 0,
                    _ => 0
                };
            }
        }
        
    }
}