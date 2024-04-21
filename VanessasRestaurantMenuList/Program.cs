using System;
using MenuListBusinessLogic;
using MenuListDataLayer;
using MenuListModel;


namespace MenuListUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("░W░E░L░C░O░M░E░ ░t░o░ ░V░A░N░E░S░S░A░'░S░ ░R░E░S░T░A░U░R░A░N░T░");

            string input;
            do
            {
                Console.WriteLine("\nType 'order' to see the menu:");
                input = Console.ReadLine();
            } while (!input.Equals("order"));

            MenuService menuService = new MenuService(new MenuDataService());

            List<Menu> menus = menuService.GetAllMenus();

            Dictionary<string, List<Menu>> groupedMenus = GroupMenusByCategory(menus);

            Console.WriteLine("\nVANESSA'S RESTAURANT MENU");
            foreach (var category in groupedMenus)
            {
                Console.WriteLine($"\n{category.Key}");
                Console.WriteLine("---------------------------");
                foreach (var item in category.Value)
                {
                    int spacing = 30 - item.Item.Length;
                    Console.WriteLine($"{item.Item}{new string(' ', spacing)}{item.Price}");
                }
            }
            Console.WriteLine("\nPlease enter your orders (type 'done' to finish):");
            List<string> orders = new List<string>();
            do
            {
                input = Console.ReadLine();
                if (!input.Equals("done"))
                {

                    if (menus.Select(menu => menu.Item).Contains(input))
                    {
                        orders.Add(input);
                    }
                    else
                    {
                       
                        Console.WriteLine(" item not in the menu. Please try again.");
                    }
                }
                else if (orders.Count == 0)
                {
                    Console.WriteLine("No items selected.");
                }
            } while (!input.Equals("done"));
            if (orders.Count > 0)
            {

                Console.WriteLine("\nYour Current Order:");
                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                }
                Console.WriteLine("\nWould you like to add more items to your order? (yes/no)");
                string addChoice = Console.ReadLine();
                if (addChoice.Equals("yes"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter additional orders(Type 'done' to finish):");
                    do
                    {
                        input = Console.ReadLine();
                        if (!input.Equals("done"))
                        {
                            if (menus.Select(menu => menu.Item).Contains(input))
                            {
                                orders.Add(input);
                            }
                            else
                            {                               
                                Console.WriteLine(" item not in the menu. Please try again.");
                            }
                        }
                    } while (!input.Equals("done"));

                    Console.WriteLine("\nYour Updated Order:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                   
                }
                else if (addChoice.Equals("no"))
                {
                    Console.WriteLine("\nYour Current Order:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                }

                Console.WriteLine("\nWould you like to remove any items from your order? (yes/no)");
                string removeChoice = Console.ReadLine();
                bool removedItems = false;
                if (removeChoice.Equals("yes"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the items you want to remove (type 'done' when finished):");
                    do
                    {
                        input = Console.ReadLine();
                        if (!input.Equals("done"))
                        {
                            if (orders.Contains(input))
                            {
                                orders.Remove(input);
                            }
                            else
                            {                              
                                Console.WriteLine("not found in the order, Please try again");
                            }
                        }
                    } while (!input.Equals("done"));

                    Console.WriteLine("\nYour Final Order:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                    removedItems = true;
                }

                if (!removedItems)
                {
                    Console.WriteLine("\nYour order is:");
                    foreach (var order in orders)
                    {
                        Console.WriteLine(order);
                    }
                }

                Console.WriteLine("\nThank you for ordering!");
            }

            static Dictionary<string, List<Menu>> GroupMenusByCategory(List<Menu> menus)
            {
                Dictionary<string, List<Menu>> groupedMenus = new Dictionary<string, List<Menu>>();
                foreach (var menu in menus)
                {
                    if (!groupedMenus.ContainsKey(menu.Category))
                    {
                        groupedMenus[menu.Category] = new List<Menu>();
                    }
                    groupedMenus[menu.Category].Add(menu);
                }
                return groupedMenus;
            }
        }
    }
}