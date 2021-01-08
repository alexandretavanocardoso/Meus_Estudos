namespace Game.Lib
{
    public class Jogador_1 : IJogador {
        public readonly string _Nome;

        public Jogador_1(string nome = "Alexandre")
        {
            _Nome = nome;
        }

        public string Chutar(){
            return $"{_Nome}Chutou \n";
        }

        public string Correr(){
            return $"{_Nome}Correu \n";
        }

        public string Passar(){
            return $"{_Nome}Passou \n";
        }
    }
}