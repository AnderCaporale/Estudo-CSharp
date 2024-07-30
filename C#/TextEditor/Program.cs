namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {

        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Editar arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: EditFile(); break;
            default: Menu(); break;
        }

        static void OpenFile()
        {

            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);

            }

            Console.WriteLine("------");
            Console.ReadKey();

            Menu();
        }

        static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (Esc para sair)");
            Console.WriteLine("-----------------------");
            String text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(text);

        }

        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso");
            Console.ReadKey();

            Menu();
        }
    }
}
