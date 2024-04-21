using System;
using System.Collections.Generic;
using MenuListModel;

namespace MenuListDataLayer
{
    public class MenuDataService
    {
        private List<Menu> _menus = new List<Menu>
        {
            new Menu { Category = "MAIN DISHES", Item = "Crispy pata", Price = "₱220" },
            new Menu { Category = "MAIN DISHES", Item = "Lechon kawali", Price = "₱250" },
            new Menu { Category = "MAIN DISHES", Item = "Inihaw na liempo", Price = "₱230" },
            new Menu { Category = "MAIN DISHES", Item = "Sinigang na baboy", Price = "₱199" },
            new Menu { Category = "MAIN DISHES", Item = "Adobo", Price = "₱190" },
            new Menu { Category = "DESSERT", Item = "Icecream", Price = "₱140" },
            new Menu { Category = "DESSERT", Item = "Lecheflan", Price = "₱150" },
            new Menu { Category = "DESSERT", Item = "Halo halo", Price = "₱120" },
            new Menu { Category = "DESSERT", Item = "Maiscon hielo", Price = "₱120" },
            new Menu { Category = "DESSERT", Item = "Bananacon leche", Price = "₱155" },
            new Menu { Category = "APPETIZER", Item = "Hotdog sandwich", Price = "₱99" },
            new Menu { Category = "APPETIZER", Item = "Mushroom burger", Price = "₱98" },
            new Menu { Category = "APPETIZER", Item = "Spaghetti", Price = "₱120" },
            new Menu { Category = "APPETIZER", Item = "Pizza", Price = "₱150" },
            new Menu { Category = "APPETIZER", Item = "French fries", Price = "₱130" },
            new Menu { Category = "DRINKS", Item = "Iced Tea", Price = "₱99" },
            new Menu { Category = "DRINKS", Item = "Soda", Price = "₱99" },
            new Menu { Category = "DRINKS", Item = "Purified water", Price = "₱50" },
            new Menu { Category = "DRINKS", Item = "Iced coffee", Price = "₱99" },
            new Menu { Category = "DRINKS", Item = "Buko juice", Price = "₱99" },
            new Menu { Category = "RICE", Item = "Plain rice", Price = "₱60" },
            new Menu { Category = "RICE", Item = "Garlic butter rice", Price = "₱68" },
            new Menu { Category = "RICE", Item = "Korean rice", Price = "₱99" },
            new Menu { Category = "RICE", Item = "Bagoong rice", Price = "₱55" },
            new Menu { Category = "RICE", Item = "Aligue rice", Price = "₱70" }
        };

        public List<Menu> GetMenus()
        { 
           return _menus;
        }
        public Menu GetMenus(string order)
        {
            return _menus.Find(u => u.Item == order);
        }
    }
}