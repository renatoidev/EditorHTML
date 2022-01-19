using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);

        }

        public static void DrawScreen()
        {
            HorizontalEdges();
            Console.Write("\n");
            VerticalEdges();
            HorizontalEdges();
        }

        public static void HorizontalEdges()
        {
            Console.Write("+");

            for (int line = 0; line <= 30; line++)
                Console.Write("-");

            Console.Write("+");
        }

        public static void VerticalEdges()
        {
            for (int i = 0; i <= 10; i++)
            {

                Console.Write("|");
                for (int line = 0; line <= 30; line++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");

            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("1 - Criar arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOptions(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}