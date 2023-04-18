using ConsoleAppAptek;
using ConsoleAppAptek.Dal;


string deyer = "";
do
{
    Console.WriteLine("1.Category Menu");
    Console.WriteLine("2.Derman menu");
    Console.WriteLine("0.Exit");
    Console.Write("Secim edin :  ");
    deyer = Console.ReadLine();

    switch (deyer)
    {
        case "1":
            Console.WriteLine("Category menusu");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Update");
            Console.WriteLine("0.Exit");
            Console.Write("Secim edin :  ");
            string deyer3 = Console.ReadLine();

            switch (deyer3)
            {
                case "1":
                    Console.WriteLine("Categori adini qeyd edin: ");
                    string deyer4 = Console.ReadLine();

                    Category category = new Category(deyer4);
                    Context.categories.Add(category);
                                break;
                case "2":
                    Console.WriteLine("silmek ek istediyiniz id ni daxil edinb");
                    int num=Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < Context.categories.Count; i++)
                    {
                        if (Context.categories[i].Id==num)
                        {
                            Context.categories.Remove(Context.categories[i]);
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("deyismek istediyiniz category id ni daxil edin ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < Context.categories.Count; i++)
                    {
                        if (num2== Context.categories[i].Id)
                        {
                            string deyerr = Console.ReadLine();
                            Context.categories[i].Name = deyerr;
                        }
                    }

                    break;
                default: Console.WriteLine("Duzgun deyer daxil edin");
                    break;

            }

            break;
        case "2":
            Console.WriteLine("dewrman menu");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.delete");
            Console.WriteLine("3.Update");
            Console.WriteLine("0.Exit");
            Console.Write("Secim edin :  ");
            string deyer5= Console.ReadLine();
            switch(deyer5)
            {
                case "1":
                    Console.WriteLine("derman adi ve derman deyeri daxil edin");
                    string deyer6 = Console.ReadLine();
                    double deyerdouble = Convert.ToDouble(Console.ReadLine());
                    
                    Medicine medicine = new Medicine(deyer6,deyerdouble);
                    Context.medicines.Add(medicine);
                    break;
                case "2":
                    Console.WriteLine("silmek ek istediyiniz id ni daxil edinb");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < Context.medicines.Count; i++)
                    {
                        if (Context.medicines[i].Count == num)
                        {
                            Context.medicines.Remove(Context.medicines[i]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("uzgun id daxil edin ");
                    break;
            }

            break;
        case "3":
            Console.WriteLine("deyismek istediyiniz dermanin id ni daxil edin ");
            int num1 = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 0; i < Context.medicines.Count; i++)
             
            {
                if (num1 == Context.medicines[i].Count)
                {
                    string deyer7 = Console.ReadLine();
                    double deyer8 = Convert.ToDouble(Console.ReadLine());
                    Context.medicines[i].Name = deyer7;
                    Context.medicines[i].Price = deyer8;
                }
            }
            break;
        default:
            Console.WriteLine("Duzgun et secimi");
            break;
    }

} while (deyer != "0");
foreach (var item in Context.medicines)
{
    Console.WriteLine(item.Name);
}
