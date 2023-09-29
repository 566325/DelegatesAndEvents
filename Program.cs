namespace DelegatesDemo
{
    public delegate int Operation(int x, int y);
    internal class Program
    {      
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Demo");

            Operation delegateobj = new Operation(Addition);

            int output = delegateobj.Invoke(2, 6);

            Console.WriteLine("Addition is : " + output);

            Console.WriteLine("*****************************");

            MultiCastDelegate.ImplementDelegate();


        }
    }
}