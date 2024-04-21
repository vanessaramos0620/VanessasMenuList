using System;
using MenuListDataLayer;

namespace MenuListBusinessLogic
{
    public class MenuService
    {
        private readonly MenuDataService _menuDataService;

        public MenuService(MenuDataService menuDataService)
        {
            _menuDataService = menuDataService;
        }

        public List<MenuListModel.Menu> GetAllMenus()
        {
            return _menuDataService.GetMenus();
        }
        public MenuListModel.Menu GetMenu(string order)
        {
            return _menuDataService.GetMenus(order);
        }
    }
}