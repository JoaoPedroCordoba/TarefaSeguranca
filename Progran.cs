
Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine();

Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());

string fraseMaiuscula = frase.ToUpper(); // Converter a frase para maiúsculas

string fraseAlterada = AumentarLetrasNoAlfabeto(fraseMaiuscula, numero);

Console.WriteLine("Frase original: " + frase);
Console.WriteLine("Frase alterada: " + fraseAlterada);


static string AumentarLetrasNoAlfabeto(string frase, int numero)
{
char[] letras = frase.ToCharArray();
string novaFrase = "";

foreach (char letra in letras)
{
if (char.IsLetter(letra)) // Verificar se é uma letra
{
char novaLetra = (char)(((letra - 'A' + numero) % 26) + 'A'); // Aumentar a letra no alfabeto

novaFrase += novaLetra;
}
else
{
novaFrase += letra; // Manter outros caracteres inalterados
}
}

return novaFrase;
}
