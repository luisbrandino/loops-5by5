Console.Write("Digite um número para o início: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Digite um número para o incremento: ");
int increment = int.Parse(Console.ReadLine());

int i = 0;

for (; i < increment; i++)
    Console.WriteLine($"For: {start + i}");

Console.WriteLine($"Número final depois do for: {start + i}");

i = 0;
do
{
    Console.WriteLine($"Do while: {start + i}");
    i++;
} while (i < increment);

Console.WriteLine($"Número final depois do do while: {start + i}");

i = 0;
while (i < increment)
{
    Console.WriteLine($"While: {start + i}");
    i++;
}

Console.WriteLine($"Número final depois do while: {start + i}");