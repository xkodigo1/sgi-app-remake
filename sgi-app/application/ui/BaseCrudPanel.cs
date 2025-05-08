using System;

namespace sgi_app.UI
{
    public abstract class BaseCrudPanel
    {
        protected void ShowHeader(string title)
        {
            Console.Clear();
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine(title.PadLeft((50 + title.Length) / 2));
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();
        }

        protected void ShowMenu()
        {
            Console.WriteLine("1. Crear");
            Console.WriteLine("2. Leer");
            Console.WriteLine("3. Actualizar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Volver al menú principal");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");
        }

        protected string ReadLine(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }

        protected void ShowMessage(string message, bool isError = false)
        {
            Console.ForegroundColor = isError ? ConsoleColor.Red : ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public abstract void Show();
    }
} 