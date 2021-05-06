using ProductCategoryBusinessLogicLayer;
using ProductCatogeryEntityLater;
using System;
using System.Collections.Generic;

namespace ProductCatogeryPresentationLayer
{
    class PresentationLayer
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                try
                {
                    MainMenu();
                    Console.WriteLine("please enter ur option from the list");
                    byte choise = byte.Parse(Console.ReadLine());
                    flag = ProcessInTheOption(choise);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (flag);
            
        }

        private static void MainMenu()
        {
            Console.WriteLine("Press 1: To insert data into category table");
            Console.WriteLine("Press 2: To insert data into product table");
            Console.WriteLine("press 3: To retrive data from the category table");
            Console.WriteLine("press 4:To retrive data from the product table");
            Console.WriteLine("press 5: To retrive product details based on product id");
            Console.WriteLine("press 6: To update product price based on the product id");
            Console.WriteLine("press 7: To Delete product price based on the product id" );
            Console.WriteLine("press 8: EXIT");
        }

        private static bool ProcessInTheOption(byte choise)
        {
            BusinessLogicLayer bl = new BusinessLogicLayer();
            switch (choise)
            {
                case 1:
                    try
                    {
                        Category c = AcceptCategoryInputsFromUser();
                        bool res = bl.SendInputsToCatogeryTableToInsert(c);
                        if (res)
                        {
                            Console.WriteLine("insertion is successfull completed");
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }
                    return true;
                case 2:
                    try
                    {
                        Product p = AcceptProductInputsFromUser();
                        bool res = bl.SendInputsToProductTableToInsert(p);
                        if (res)
                        {
                            Console.WriteLine("insertion is successfull completed");
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }
                    return true;
                case 3:
                    try
                    {
                        List<string> li = bl.GetDataFromCatogeryTable();
                        Display(li);
                        return true;
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                default:
                    return true;

            }
        }

        private static Category AcceptCategoryInputsFromUser()
        {

            Console.WriteLine("please enter the catogeryid");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the category name");
            string categoryName = Console.ReadLine();
            Category c = new Category(id, categoryName);
            return c;


        }

        private static Product AcceptProductInputsFromUser()
        {
            Console.WriteLine("please enter the product id");
            string productId = Console.ReadLine();
            Console.WriteLine("please enter product name");
            string productName = Console.ReadLine();
            Console.WriteLine("please enter the price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter the category name");
            int categoryId = int.Parse(Console.ReadLine());
            Product p = new Product(productId, productName, price, categoryId);
            return p;
        }

        private static void  Display(List<string> li)
        {
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
        }
    }
}
