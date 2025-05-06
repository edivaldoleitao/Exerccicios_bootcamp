using rpg.classes;

Console.WriteLine("Hello, World!");

Personagem heroi = new Personagem("cara", 2, 1);
Personagem monstro = new Personagem("goblin", 6, 5);
heroi.vida = 100;
monstro.vida = 100;

// while (heroi.vida > 0 && monstro.vida > 0)           /////////     COMENTÁRIOS EM BLOCO ==> CRTL+K+C      ////////////
// {

//     heroi.atacar(monstro);
//     monstro.atacar(heroi);
//     if (heroi.vida <= 0)
//     {
//         System.Console.WriteLine($"{heroi.getNome()} foi derrotado !!");
//         break;
//     }
//     else if (monstro.vida <= 0)
//     {
//         System.Console.WriteLine($"{monstro.getNome()} foi derrotado !!");
//         break;
//     }
// }

int[,] matriz = new int[10, 10];

for (int i = 0; i < matriz.Length / 10; i++)
{
    for (int j = 0; j < matriz.Length / 10; j++)
    {
        matriz[i, j] = 1;
    }
}

for (int i = 0; i < matriz.Length / 10; i++)
{
    for (int j = 0; j < matriz.Length / 10; j++)
    {
        System.Console.Write($"{matriz[i, j]} ");
    }
    System.Console.WriteLine();
}
