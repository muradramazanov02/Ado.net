using AdoNet.Controller;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryController ccontroller = new CategoryController();
            ProductController pcontroller = new ProductController();

            int choice;

            do
            {
                Console.WriteLine("Menu:\n1.Yarat\n2.Hamsini goster\n3.Secilmis birini goster\n4.Sil\n5.Update et\n0.Proqrami bitir");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    int select;
                    do
                    {
                        Console.WriteLine("1.Category yarat\n2.Product yarat\n0.Esas menyuya qayit");
                        select = Convert.ToInt32(Console.ReadLine());

                        if (select == 1)
                        {
                            ccontroller.AddCategory();
                        }
                        else if (select == 2)
                        {
                            pcontroller.AddProducts();
                        }
                    }
                    while (select != 0);
                }
                else if(choice == 2)
                {
                    int select;
                    do
                    {
                        Console.WriteLine("1.Butun categoryleri goster\n2.Butun productlari goster\n0.Esas menyuya qayit");
                        select = Convert.ToInt32(Console.ReadLine());

                        if (select == 1)
                        {
                            ccontroller.GetAllCategory();
                        }
                        else if (select == 2)
                        {
                            pcontroller.GetAllProducts();
                        }
                    }
                    while (select != 0);
                    
                }
                else if(choice == 3)
                {
                    int select;
                    do
                    {
                        Console.WriteLine("1.Category goster\n2.Product goster\n0.Esas menyuya qayit");
                        select= Convert.ToInt32(Console.ReadLine());

                        if(select == 1)
                        {
                            ccontroller.GetCategory();
                        }
                        else if(select == 2)
                        {
                            pcontroller.GetProduct();
                        }
                    }
                    while(select != 0);
                }
                else if (choice == 4)
                {
                    int select;
                    do
                    {
                      
                        Console.WriteLine("1.Category sil\n2.Product sil\n0.Esas menyuya qayit");
                        select = Convert.ToInt32(Console.ReadLine());

                        if (select == 1)
                        {
                            ccontroller.DeleteCategory();
                        }
                        else if (select == 2)
                        {
                            pcontroller.DeleteProducts();
                        }
                    }
                    while (select != 0);
                }
                else if (choice == 5)
                {
                    int select;

                    do
                    {
                        Console.WriteLine("1.Category update et\n2.Product update et\n0.Esas menyuya qayit");
                        select = Convert.ToInt32(Console.ReadLine());

                        if (select == 1)
                        {
                            ccontroller.UpdateCategory();
                        }
                        else if(select == 2)
                        {
                            pcontroller.UpdateProducts();
                        }
                    }
                    while( select != 0);
                    
                }
            }
            while (choice != 0);
        }
    }
}
