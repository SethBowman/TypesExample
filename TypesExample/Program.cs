namespace TypesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            // Type - name - value
            int whatever = 100;
            //ints are whole numbers

            double number = 10.5;

            decimal cash = 500.00m;

            string myWord = "hello class 123";
            
            char initial = 'a';

            bool isAlive = true;


            //VALUE TYPES

            int a = 1;
            int b = a;

            a = 500;

            //REFERENCE TYPES

            var p1 = new Point();

            p1.X = 1;

            var p2 = p1;

            p2.X = 500;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);
        }
    }
}