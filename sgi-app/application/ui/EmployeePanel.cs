using System;
using sgi_app.domain.entities;

namespace sgi_app.UI
{
    public class EmployeePanel : BaseCrudPanel
    {
        public override void Show()
        {
            while (true)
            {
                ShowHeader("GESTIÓN DE EMPLEADOS");
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
            ShowHeader("CREAR EMPLEADO");
            
            var employee = new Employee
            {
                Name = ReadLine("Nombre del empleado: "),
                Position = ReadLine("Cargo: "),
                Salary = decimal.Parse(ReadLine("Salario: ")),
                Department = ReadLine("Departamento: ")
            };

            // TODO: Implementar la lógica de creación
            ShowMessage("Empleado creado exitosamente");
        }

        private void Read()
        {
            ShowHeader("LISTA DE EMPLEADOS");
            // TODO: Implementar la lógica de lectura
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Update()
        {
            ShowHeader("ACTUALIZAR EMPLEADO");
            var id = int.Parse(ReadLine("Ingrese el ID del empleado a actualizar: "));
            
            // TODO: Implementar la lógica de actualización
            ShowMessage("Funcionalidad en desarrollo");
        }

        private void Delete()
        {
            ShowHeader("ELIMINAR EMPLEADO");
            var id = int.Parse(ReadLine("Ingrese el ID del empleado a eliminar: "));
            
            // TODO: Implementar la lógica de eliminación
            ShowMessage("Funcionalidad en desarrollo");
        }
    }
} 