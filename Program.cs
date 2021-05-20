using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Samsung = new Celular();
            Console.Clear();
            Console.WriteLine(Samsung.modelo);
            Console.WriteLine(Samsung.cor);
            Console.WriteLine(Samsung.tamanho);

            Console.WriteLine("Ligue seu celular novo...Dica: Ligar \n");
            string VouLigar = Console.ReadLine();

            Console.WriteLine("\n");
            if (VouLigar == "Ligar")
            {
                Samsung.Ligar();
                
                if (!Samsung.Ligar())
                {
                    do
                    {
                        Console.WriteLine(@"
                         ____________________________         
                        ||______________________0 0_||
                        ||   ____________________   ||
                        ||  |                    |  ||
                        ||  | Olá Seja Bem-Vindo |  ||
                        ||  |                    |  ||
                        ||  |____________________|  ||
                        ||                          ||
                        ||                          ||
                        ||--------------------------||
                        ||                          ||
                        ||                          ||
                        ||                          ||
                        ||      2- Desligar         ||
                        ||                          ||
                        ||    3- Fazer Ligação      ||
                        ||    4- Enviar Mensagem    ||
                        ||__________________________||
                        ||____________O_____________||
                        ");

                        string escolha = Console.ReadLine();
                        switch (escolha)
                        {
                            case "2":
                                Console.WriteLine(Samsung.Desligar());
                                Samsung.desligar = true;
                                break;

                            case "3":
                                Console.WriteLine(Samsung.FazerLigacao());
                                Samsung.desligar = false;
                                break;

                            case "4":
                                Console.WriteLine(Samsung.EnviarMensagem());
                                Samsung.desligar = false;
                                break;

                            default:
                                Console.WriteLine("Opção invalida.");
                                Samsung.desligar = false;
                                break;
                        }

                    } while (Samsung.desligar == false);

                }
            }
            else
            {
                Console.Write("Deveria ter ligado direito...");
            }

        }
    }
}