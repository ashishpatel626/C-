namespace Abstraction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer c1 = new PlatiniumCustomer();
            c1.Enquiry();
        }
    }

    public interface ICustomer
    {
        string name {get; set;}

        void Enquiry();
        
    }

    public abstract class Customer : ICustomer
    {
        public string name {get; set;}

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
