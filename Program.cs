using System;

namespace Multiple_Inheritance
{
    public interface IA //ineterface  1    
    {
        string setImgs(string a);
    }
    public interface IB  //Interface 2    
    {
        int getAmount(int Amt);
    }
    public class Car : IA, IB //implementatin    
    {
        public int getAmount(int Amt)
        {
            return 100;
        }
        public string setImgs(string a)
        {
            return "this is the car";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.getAmount(1000);
            c.setImgs("Text");
        }
    }
}
