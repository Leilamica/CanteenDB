using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BusinessLogic;
using Model;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection string to your SQL Server database
            string connectionString
               = "Data Source =DESKTOP-7SKO6VG\\SQLEXPRESS; Initial Catalog = CanteenDb; Integrated Security = True;";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            void Connect()
            {
                sqlConnection.Open();
            }
            MenuService menuService = new MenuService(connectionString);
            List<MenuItem> menuItems = menuService.GetMenuItems();

            Console.WriteLine("Welcome to the Canteen!");
            Console.WriteLine("Here are the menu items:");

            foreach (var menuItem in menuItems)
            {
                Console.WriteLine($"{menuItem.name} - Php {menuItem.price}");
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
