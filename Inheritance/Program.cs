namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Siin sisestad masina koodi
            Console.WriteLine("Enter VIN CODE");

            //Loeb sisetatud koodi
            int vinCode = Convert.ToInt32(Console.ReadLine());

            //Loob uue objekti, kasutades Machine classi,
            //mis pärib Car classist
            Machine machine = new Machine();
            machine.SetVinCode(vinCode);

            //Prindib välja Vin code is: ... GetVinCode() meetodi abil
            Console.WriteLine("Vin code is: " + machine.GetVinCode());
        }
    }   
}
