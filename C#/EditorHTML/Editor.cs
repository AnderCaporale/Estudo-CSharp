
using System.Text;

namespace EditorHTML{

    public static class Editor{

        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Start();

        }

        public static void Start(){
            var text = new StringBuilder();
            var letra = Console.ReadKey();
            do{
                text.Append(letra.KeyChar);
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine); 
                letra = Console.ReadKey();
            }while(letra.Key != ConsoleKey.Escape);


            Console.WriteLine("----------");
            Console.WriteLine("DDeseja salvar o arquivo? (y/n)");
            var salvar = Console.ReadLine();
           
            if (salvar!.CompareTo("y") == 0){
                using (var file = new StreamWriter("C:/Users/Anderson_Anan/Aulas/Balta/Estudo-CSharp/EditorHTML/texto.txt"))
                {
                    file.Write(text);
                }

                Console.WriteLine("Arquivo Salvo!");
            } 
            
            Console.ResetColor();
            Console.Clear();

        }
    }
}