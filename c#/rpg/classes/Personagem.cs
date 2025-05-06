namespace rpg.classes
{
    public class Personagem
    {
        private String nome = "";


        public Personagem(String nome, int tipo, int level)
        {
            if (nome != null)
                this.nome = nome;

            this.tipo = tipo;
            this.level = level;
        }
        public int vida { get; set; }

        public int level { get; protected set; }
        public int tipo { get; protected set; }
        public string getNome()
        {
            return this.nome;
        }

        public Enum getClasse()
        {
            return (Classes)tipo;
        }

        public void atacar(Personagem p)
        {
            if (this.vida > 0)
            {
                var dano = (int)((new Random().Next(1, 10)) * this.level);
                p.vida = p.vida - dano;
                if ((Classes.Monstro.Equals(p.getClasse())))
                {
                    System.Console.WriteLine($"O  {this.nome} atacou com {(Armas)tipo} e causou {dano} de dano !!");
                    System.Console.WriteLine($"O {p.nome} recebeu {dano} pontos de dano  e restam {p.vida} de HP!!!");
                }
                else
                {
                    System.Console.WriteLine($"O {this.nome} ataca e causa {dano} de dano !!");
                }
            }
            else
            {
                System.Console.WriteLine($"{this.nome} foi derrotado !!");
            }
        }




    }
}