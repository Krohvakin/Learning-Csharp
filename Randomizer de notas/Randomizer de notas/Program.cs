//array de A a G
string[] gaveta = ["A", "B", "C", "D", "E", "F", "G"];
string[] gaveta2 = ["b", "#"];

//randomizer
Random rand = new Random();
int rng = rand.Next(0, 7);
int rng2 = rand.Next(0, 2);

//proibir E e B de ter sinal
if (rng == 1 || rng == 4) 
{
    Console.WriteLine(gaveta[rng]);
}
else
{
    Console.WriteLine(gaveta[rng] + gaveta2[rng2]);
}