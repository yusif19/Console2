using ConsoleAppAptek.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAptek
{
    internal class ClassMethods
    {
        public static void CreateCategory()
        {
            try
            {
                Console.WriteLine("Categori adini qeyd edin: ");
                string word4 = Console.ReadLine();

                Category category = new Category(word4);
                Context.categories.Add(category);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void DeleteCategory()
        {
            try
            {
                bool flag= false;
                Console.WriteLine("silmek ek istediyiniz id ni daxil edinb");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Context.categories.Count; i++)
                {
                    if (Context.categories[i].Id == num)
                    {
                        Context.categories.Remove(Context.categories[i]);
                        flag = true;
                        Console.WriteLine("Secdiyiniz category silindi");
                    }
                }
                if (!flag)
                {

                    Console.WriteLine("Daxil etdiyiniz Id-e uygun Category tapilmadi");

                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void UpdateCategory()
        {
            try
            {
                bool flag= false;
                Console.WriteLine("Deyismek istediyiniz category id ni daxil edin ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Context.categories.Count; i++)
                {
                    if (num2 == Context.categories[i].Id)
                    {
                        Console.WriteLine("Yeni category adini daxil edin");
                        string deyerr = Console.ReadLine();
                        Context.categories[i].Name = deyerr;
                        flag= true;
                        Console.WriteLine("Category adi ugurla deyisdirildi");
                    }
                }
                if (!flag)
                {
                   
                        Console.WriteLine("Daxil etdiyiniz Id-e uygun Category tapilmadi");
                   
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void MedicineMenu()
        {
            Console.WriteLine("Derman menu");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.Sale");
            Console.WriteLine("0.Exit");
            Console.Write("Secim edin :  ");
            string word5 = Console.ReadLine();
            switch (word5)
            {
                case "1":
                    try
                    {
                        if (Context.categories.Count!=0)
                        {
                            Console.WriteLine("Derman adini daxil edin");
                            string word6 = Console.ReadLine();
                            Console.WriteLine("Derman qiymetini daxil edin");
                            double numdouble = Convert.ToDouble(Console.ReadLine());
                            Medicine medicine = new Medicine(word6, numdouble);
                            Context.medicines.Add(medicine);
                        }
                        else
                        {
                            Console.WriteLine("Category list bos oldugundan medicine yarana bilmez,ilk olaraq category yaradin");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case "2":
                    try
                    {
                        bool flag = false;
                        Console.WriteLine("Silmek istediyiniz id-ni daxil edin");
                        int num = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < Context.medicines.Count; i++)
                        {
                            if (Context.medicines[i].Count == num)
                            {
                                Context.medicines.Remove(Context.medicines[i]);
                                Console.WriteLine("Derman ugurla silindi");
                                flag = true;
                            }

                        }
                        if (!flag)
                        {
                              Console.WriteLine("Daxil etdiyiniz Id-e uygun Derman tapilmadi"); 
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case "3":
                    Console.WriteLine("Deyismek istediyiniz dermanin id ni daxil edin ");
                    try
                    {
                        bool flag= false;
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < Context.medicines.Count; i++)

                        {
                            if (num1 == Context.medicines[i].Count)
                            {
                                Console.WriteLine("Yeni adini daxil edin");
                                string word7 = Console.ReadLine();
                                Console.WriteLine("Yeni qiymeti daxil edin");
                                double numdouble8 = Convert.ToDouble(Console.ReadLine());
                                Context.medicines[i].Name = word7;
                                Context.medicines[i].Price = numdouble8;
                                Console.WriteLine("derman adi ve qiymeti ugurla deyisdirildi");
                                flag = true;
                            }
                           

                        }
                        if (!flag)
                        {
                            Console.WriteLine("Daxil etdiyiniz Id-e uygun Derman tapilmadi");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                    case "4":
                    try
                    {
                        bool flag=false;
                        Console.WriteLine("Satis etmek istediyiniz dermanin id sini daxil edin");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < Context.medicines.Count; i++)
                        {
                            if (num2 == Context.medicines[i].Count)
                            {
                                Console.WriteLine($"{Context.medicines[i].Name} adli derman satildi ");
                                Context.medicines.Remove(Context.medicines[i]);
                                flag = true;
                            }
                            
                        }
                        if (!flag)
                        {
                            Console.WriteLine("Daxil etdiyiniz Id-e uygun Derman tapilmadi");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                    default:
                    Console.WriteLine("Duzgun deyer daxil edin");
                    break;
            }
            //exceptionlari try catch ile yazdimki eger sehvlik olsa ekrana errorun novunu mesaj olaraq versin,
            //proqrami sonlandirmasin,eger sonlamdirilmsini istese idim throe-dan istifade ederdim

        }

    }
}
