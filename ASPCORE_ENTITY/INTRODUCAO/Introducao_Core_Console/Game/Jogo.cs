
namespace Game
{
    public class Jogo{
       private readonly IJogador _jogadorA;
       private readonly IJogador _jogadorB;
        public Jogo(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Correr());
            System.Console.Write(_jogadorA.Chutar());
            System.Console.Write(_jogadorA.Passar());   

            System.Console.Write("\n Proximo \n");

            System.Console.Write(_jogadorB.Correr());
            System.Console.Write(_jogadorB.Chutar());
            System.Console.Write(_jogadorB.Passar());   
        }
    }
}