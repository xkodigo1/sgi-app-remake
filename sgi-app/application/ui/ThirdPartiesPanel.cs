using System;
using sgi_app.domain.entities;

namespace sgi_app.UI
{
    public class ThirdPartiesPanel : BaseCrudPanel
    {
        public override void Show()
        {
            while (true)
            {
                ShowHeader("GESTIÓN DE TERCEROS");
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
            ShowHeader("CREAR TERCERO");
            
            var thirdParty = new ThirdParties
            {
                Name = ReadLine("Nombre del tercero: "),
                Type = ReadLine("Tipo: "),
                Document = ReadLine("Documento: ")
            };

            // TODO: Implementar la lógica de creación
            ShowMessage("Tercero creado exitosamente");
        }

        private void Read()
        {
            ShowHeader("LISTA DE TERCEROS");
            // TODO: Implementar la lógica de lectura
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Update()
        {
            ShowHeader("ACTUALIZAR TERCERO");
            var id = int.Parse(ReadLine("Ingrese el ID del tercero a actualizar: "));
            
            // TODO: Implementar la lógica de actualización
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Delete()
        {
            ShowHeader("ELIMINAR TERCERO");
            var id = int.Parse(ReadLine("Ingrese el ID del tercero a eliminar: "));
            
            // TODO: Implementar la lógica de eliminación
            ShowMessage("Funcionalidad en desarrollo");
        }
    }
} 