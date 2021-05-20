namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor = "Branco";
        public bool desligar = true;
        public string modelo = "Samsung";
        public string tamanho = "13.0 cm A,	7.0 cm L	1.20 cm E";
        public bool Ligar()
        {
            return desligar = false;
        }
        public string Desligar()
        {
            return "Bye Bye...";
        }
        public string FazerLigacao()
        {
            return "Calling"; 
            
        }
        public string EnviarMensagem()
        {
            return "Mensagem enviada";
        }

    }
}