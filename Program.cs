using ConsoleAppAptek;
using ConsoleAppAptek.Dal;


string word = "";
do
{
    Console.WriteLine("1.Category Menu");
    Console.WriteLine("2.Derman menu");
    Console.WriteLine("0.Exit");
    Console.Write("Secim edin :  ");
    word = Console.ReadLine();

    switch (word)
    {
            case "1":
            Console.WriteLine("Category menusu");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Update");
            Console.WriteLine("0.Exit");
            Console.Write("Secim edin :  ");
            string word3 = Console.ReadLine();

            switch (word3)
            {
                case "1": ClassMethods.CreateCategory(); break;
                case "2": ClassMethods.DeleteCategory(); break;
                case "3": ClassMethods.UpdateCategory(); break;
                default: Console.WriteLine("Duzgun deyer daxil edin"); break;
            }
            break;
            case "2": ClassMethods.MedicineMenu(); break;
           
            default:
            Console.WriteLine("Duzgun et secimi");
            break;
    }
} while (word != "0");


