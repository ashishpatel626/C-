namespace Abstraction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PlatiniumCustomer p = new PlatiniumCustomer();
            decimal x = p.Discount();
            Console.WriteLine(x);
        }
    }

    public interface ICustomer
    {
        string name {get; set;}
        
    }

    public abstract class Customer
    {
        string name {get; set;}

        public void Enquiry()
        {
            Console.WriteLine("Explain him product");
        }
        
        public abstract int Discount();
    }

    public class PlatiniumCustomer : Customer
    {
        public override int Discount()
        {
            return 1;
        }
    }
    
    public class WalkInCustomer : Customer
    {
        public override int Discount()
        {
            return 2;
        }
    }
}
