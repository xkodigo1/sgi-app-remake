using System;
using sgi_app.domain.entities;

namespace sgi_app.UI
{
    public class SupplierPanel : BaseCrudPanel
    {
        public override void Show()
        {
            while (true)
            {
                ShowHeader("GESTIÓN DE PROVEEDORES");
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
            ShowHeader("CREAR PROVEEDOR");
            
            var supplier = new Supplier
            {
                Name = ReadLine("Nombre del proveedor: "),
                ContactName = ReadLine("Nombre de contacto: "),
                Phone = ReadLine("Teléfono: "),
                Email = ReadLine("Email: ")
            };

            // TODO: Implementar la lógica de creación
            ShowMessage("Proveedor creado exitosamente");
        }

        private void Read()
        {
            ShowHeader("LISTA DE PROVEEDORES");
            // TODO: Implementar la lógica de lectura
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Update()
        {
            ShowHeader("ACTUALIZAR PROVEEDOR");
            var id = int.Parse(ReadLine("Ingrese el ID del proveedor a actualizar: "));
            
            // TODO: Implementar la lógica de actualización
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Delete()
        {
            ShowHeader("ELIMINAR PROVEEDOR");
            var id = int.Parse(ReadLine("Ingrese el ID del proveedor a eliminar: "));
            
            // TODO: Implementar la lógica de eliminación
            ShowMessage("Funcionalidad en desarrollo");
        }
    }
} 