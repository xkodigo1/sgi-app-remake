using System;

namespace sgi_app.UI
{
    public class MainMenu
    {
        private readonly ProductPanel _productPanel;
        private readonly ClientPanel _clientPanel;
        private readonly EmployeePanel _employeePanel;
        private readonly SupplierPanel _supplierPanel;
        private readonly ThirdPartiesPanel _thirdPartiesPanel;

        public MainMenu()
        {
            _productPanel = new ProductPanel();
            _clientPanel = new ClientPanel();
            _employeePanel = new EmployeePanel();
            _supplierPanel = new SupplierPanel();
            _thirdPartiesPanel = new ThirdPartiesPanel();
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=".PadRight(50, '='));
                Console.WriteLine("SISTEMA DE GESTIÓN INTEGRAL".PadLeft(38));
                Console.WriteLine("=".PadRight(50, '='));
                Console.WriteLine();

                Console.WriteLine("1. Gestión de Productos");
                Console.WriteLine("2. Gestión de Clientes");
                Console.WriteLine("3. Gestión de Empleados");
                Console.WriteLine("4. Gestión de Proveedores");
                Console.WriteLine("5. Gestión de Terceros");
                Console.WriteLine("6. Salir");
                Console.WriteLine();

                Console.Write("Seleccione una opción: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        _productPanel.Show();
                        break;
                    case "2":
                        _clientPanel.Show();
                        break;
                    case "3":
                        _employeePanel.Show();
                        break;
                    case "4":
                        _supplierPanel.Show();
                        break;
                    case "5":
                        _thirdPartiesPanel.Show();
                        break;
                    case "6":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción no válida");
                        Console.ResetColor();
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
} 