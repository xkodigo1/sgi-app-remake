using System;
using sgi_app.domain.entities;

namespace sgi_app.UI
{
    public class ProductPanel : BaseCrudPanel
    {
        public override void Show()
        {
            while (true)
            {
                ShowHeader("GESTIÓN DE PRODUCTOS");
                ShowMenu();

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Create();
                        break;
                    case "2":
                        Read();
                        break;
                    case "3":
                        Update();
                        break;
                    case "4":
                        Delete();
                        break;
                    case "5":
                        return;
                    default:
                        ShowMessage("Opción no válida", true);
                        break;
                }
            }
        }

        private void Create()
        {
            ShowHeader("CREAR PRODUCTO");
            
            var product = new Product
            {
                Name = ReadLine("Nombre del producto: "),
                Description = ReadLine("Descripción: "),
                Price = decimal.Parse(ReadLine("Precio: ")),
                Stock = int.Parse(ReadLine("Stock: ")),
                SupplierId = int.Parse(ReadLine("ID del proveedor: "))
            };

            // TODO: Implementar la lógica de creación
            ShowMessage("Producto creado exitosamente");
        }

        private void Read()
        {
            ShowHeader("LISTA DE PRODUCTOS");
            // TODO: Implementar la lógica de lectura
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Update()
        {
            ShowHeader("ACTUALIZAR PRODUCTO");
            var id = int.Parse(ReadLine("Ingrese el ID del producto a actualizar: "));
            
            // TODO: Implementar la lógica de actualización
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Delete()
        {
            ShowHeader("ELIMINAR PRODUCTO");
            var id = int.Parse(ReadLine("Ingrese el ID del producto a eliminar: "));
            
            // TODO: Implementar la lógica de eliminación
            ShowMessage("Funcionalidad en desarrollo");
        }
    }
} 