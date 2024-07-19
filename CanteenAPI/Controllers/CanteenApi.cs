using Business;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace MenuManagement.API.Controllers
{
    [ApiController]
    [Route("api/menu")]
    public class MenuController : Controller
    {
        private readonly MenuService _menuService;

        public MenuController(MenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _menuService.GetMenuItems();
        }

        [HttpPost]
        public IActionResult AddMenuItem(MenuItem request)
        {
            _menuService.AddMenuItem(request);
            return Ok(new { message = "Menu item added successfully" });
        }

        [HttpPatch]
        public IActionResult UpdateMenuItem(MenuItem request)
        {
            _menuService.UpdateMenuItem(request);
            return Ok(new { message = "Menu item updated successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMenuItem(int id)
        {
            _menuService.DeleteMenuItem(id);
            return Ok(new { message = "Menu item deleted successfully" });
        }
    }
}
