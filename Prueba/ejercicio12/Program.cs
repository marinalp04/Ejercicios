Console.WriteLine("Escrine una palabra");
string word = Console.ReadLine();

bool isPalindrome = true;

for (int i = 0; i < word.Length && isPalindrome; i++)
{
    if (word[i] != word[word.Length - i -1 ])
    {
        isPalindrome = false;
    }
}

if (isPalindrome)
    Console.WriteLine($"la palabra {word} es un palíndromo");
else
    Console.WriteLine($"la palabra {word} no es un palíndromo");

Console.WriteLine("\nPulsa enter para cerrar");
Console.ReadLine();