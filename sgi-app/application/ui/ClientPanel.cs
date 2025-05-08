using System;
using sgi_app.domain.entities;

namespace sgi_app.UI
{
    public class ClientPanel : BaseCrudPanel
    {
        public override void Show()
        {
            while (true)
            {
                ShowHeader("GESTIÓN DE CLIENTES");
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
            ShowHeader("CREAR CLIENTE");
            
            var client = new Client
            {
                Name = ReadLine("Nombre del cliente: "),
                Email = ReadLine("Email: "),
                Phone = ReadLine("Teléfono: ")
            };

            // TODO: Implementar la lógica de creación
            ShowMessage("Cliente creado exitosamente");
        }

        private void Read()
        {
            ShowHeader("LISTA DE CLIENTES");
            // TODO: Implementar la lógica de lectura
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Update()
        {
            ShowHeader("ACTUALIZAR CLIENTE");
            var id = int.Parse(ReadLine("Ingrese el ID del cliente a actualizar: "));
            
            // TODO: Implementar la lógica de actualización
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Delete()
        {
            ShowHeader("ELIMINAR CLIENTE");
            var id = int.Parse(ReadLine("Ingrese el ID del cliente a eliminar: "));
            
            // TODO: Implementar la lógica de eliminación
            ShowMessage("Funcionalidad en desarrollo");
        }
    }
} 