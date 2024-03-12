using System.Xml.Serialization;

static void suma(){
    //ejercicio 1
    int num1, num2, resultado = 0;
    Console.WriteLine("Ingrese n1");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese n2");
    num2 = Convert.ToInt32(Console.ReadLine());
    resultado = num1 + num2;
}

static string datos()
{
    //ejercicio 2
    Console.WriteLine("Ingrese Nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Saludos " + nombre);
    return nombre;
}
static void calc_edad()
{
    //ejercicio 3
    Console.WriteLine("Ingrese a~no de nacimiento");
    int nacimiento = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - nacimiento;
    Console.WriteLine("Su edad es: " + nacimiento);
}
static int sumatoria(int num1, int num2, int num3)
{
    int resultado = 0;
    resultado = (num1 + num2 + num3);
    return resultado;
}

void mayor_menor()
{
    int numero = 1, mayor = 0, menor = int.MaxValue;
    do
    {
        Console.WriteLine("Ingrese un numero positivo (ingrese 0 para salir)");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine("Numero invalido");
        }
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero!=0)
        {
            if (numero < menor)
            {
                menor = numero;
            }
        }
    } while (numero != 0);
    Console.WriteLine($"Numero mayor: {mayor}\nNumero menor: {menor}");
}

//string nombre;
//nombre = datos();
//int promedio = sumatoria(20,25,40) / 3;
//Console.WriteLine($"{nombre}, tu promedio es = {promedio}");

static int adivinar() { 
    int num = 0,resultado=0;
    Console.WriteLine("Anote un numero. Multiplicalo por 2, sumale 8, y multiplicalo por 5, e ingresa el resultado");
    num=Convert.ToInt32(Console.ReadLine());
    resultado = (num / 10) - 4;
    Console.WriteLine($"El numero que pensaste es: {resultado}");
    return resultado;
}

static void contador()
{
    string frase = "";
    string[] palabras;
    char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
    int num_pal, num_vocales=0;
    Console.WriteLine("Ingrese una frase");
    frase = Console.ReadLine();
    palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    num_pal = palabras.Count();
    frase = frase.ToLower();
    foreach (char c in frase)
    {
        if (Array.IndexOf(vocales, c) != -1)
        {
            num_vocales++;
        }
    }
    Console.WriteLine($"Numero de palabras: {num_pal}\n Numero de vocales: {num_vocales}");
}

static void palindromo()
{
    string palabra, prueba;
    char[] palindromo;
    Console.WriteLine("Ingrese una palabra");
    palabra = Console.ReadLine();
    palindromo = palabra.ToCharArray();
    Array.Reverse(palindromo);
    prueba = new string(palindromo);
    if (prueba == palabra)
    {
        Console.WriteLine("la palabra " + palabra + " si es un palindromo");
    }
    else if (prueba != palabra)
    {
        Console.WriteLine("la palabra " + palabra + " no es un palindromo");
    }
}


int choice;
do
{
    Console.WriteLine(@"1. Suma
2. Datos
3. Nacimiento
4. Sumatoria
5. Numero Mayor y Menor
6. Adivinar
7. Contador de Palabras
8. Palindromo
9. Salida");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            suma();
            break;
        case 2:
            datos();
            break;
        case 3:
            calc_edad();
            break;
        case 4:
            int n1, n2, n3;
            Console.WriteLine("Ingrese un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n3 = Convert.ToInt32(Console.ReadLine());
            sumatoria(n1,n2,n3);
            break;
        case 5:
            mayor_menor();
            break;
        case 6:
            adivinar();
            break;
        case 7:
            contador();
            break;
        case 8:
            palindromo();
            break;
        default:
            Console.WriteLine("no existe opciones");
            break;
    }
} while (choice != 9);