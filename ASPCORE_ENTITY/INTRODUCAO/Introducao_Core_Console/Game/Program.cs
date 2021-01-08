
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new Jogo(
               new Jogador_1(),
               new Jogador_2());
            
            jogo.IniciarJogo();
        }
    }
}   

    


