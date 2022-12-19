using Businnes.Concrete;
using DataAcces.Concrete.EntityFramework;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Kullanıcı adını giriniz:");
            String userName = Console.ReadLine();
            Console.Write("Password:");
            String password = Console.ReadLine();
            Console.WriteLine("\n\n");
            string mailCode = "1234";
            String truePassword = password;
            String attept = "";

            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;
            int cracks = 0;

            string[] array = { "", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "y", "z" };

           int j = 0;
            
            while (!attept.Equals(password))
            {
                if (first == array.Length)
                {
                    second++;
                    first = 0;
                }
                if (second == array.Length)
                {
                    third++;
                    second = 0;
                }
                if (third == array.Length)
                {
                    fourth++;
                    third = 0;
                }
                if (fourth == array.Length)
                {
                    break;
                }
        
                attept = array[fourth] + array[third] + array[second] + array[first];

                //if (attept.Length == 4)
                //{
                //    Console.WriteLine(attept);
                //}


                if (!password.Equals(attept) && attept.Length == 4)
                {
                    if (j < 10)
                    {
                        Console.WriteLine(attept);
                        Console.WriteLine("şifrenizi hatalı girdiniz tekrar deneyiniz");
                        j++;
                        if (j == 9)
                        {
                            Console.Write("\n\nMaile gelen kodu giriniz : ");
                            string code = Console.ReadLine();
                            if (!mailCode.Equals(code))
                            {
                                Console.WriteLine("Sistem bloke edilmiştir");
                            }
                            else
                            {

                                Console.Write("Kullanıcı adını giriniz:");
                                userName = Console.ReadLine();
                                Console.Write("Password:");
                                password = Console.ReadLine();
                                Console.WriteLine("\n\n");
                                if (password.Equals(truePassword))
                                {
                                    Console.WriteLine("---------------Veriler Listelendi ------------------------- ");
                                    ProductManager productManager = new ProductManager(new EfProductDao());
                                    foreach (var product in productManager.GetAll())
                                    {
                                        Console.WriteLine(product.ProductName);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Şifreniz yanlış girdiniz sistem bloke edilmiştir");
                                }

                            }

                            j++;
                        }
                    }

                    else
                    {
                        break;
                    }


                }



                first++;
                

            }
            

            if (password.Equals(attept))
            {
                ProductManager productManager = new ProductManager(new EfProductDao());
                Console.WriteLine("---------------Veriler Listelendi ------------------------- ");
                foreach (var product in productManager.GetAll())
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            
            Console.ReadLine();

            


            
            
        }



        private static void PasswordHack(String password)

        {

        }

    }
}
