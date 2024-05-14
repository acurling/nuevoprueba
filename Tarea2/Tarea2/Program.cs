// See https://aka.ms/new-console-template for more information

int[,] matriz = new int[100, 100]; // matriz

Random rand = new Random();
for (int f = 99; f >= 0; f--)  // filas
{
    for (int c = 99; c >= 0; c--) // columnas
    {
        matriz[f, c] = rand.Next(100);
    }
}

// Imprimir matriz
Console.WriteLine("Matriz:");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write($"   {matriz[i, j]}");
    }
    Console.WriteLine();
}

// Suma de las esquinas
int sumaEsquinas = matriz[0, 0] + matriz[0, 9] + matriz[9, 0] + matriz[9, 9];

// Suma de la diagonal principal
int sumaDiagonalPrincipal = 0;
for (int i = 0; i < 10; i++)
{
    sumaDiagonalPrincipal += matriz[i, i];
}

// Suma de la diagonal secundaria
int sumaDiagonalSecundaria = 0;
for (int i = 0; i < 10; i++)
{
    sumaDiagonalSecundaria += matriz[i, 9 - i];
}

// Suma de las columnas
int[] sumaColumnas = new int[10];
for (int j = 0; j < 10; j++)
{
    for (int i = 0; i < 10; i++)
    {
        sumaColumnas[j] += matriz[i, j];
    }
}

Console.WriteLine($"Suma de las esquinas: {sumaEsquinas}");
Console.WriteLine($"Suma de la diagonal principal: {sumaDiagonalPrincipal}");
Console.WriteLine($"Suma de la diagonal secundaria: {sumaDiagonalSecundaria}");
Console.WriteLine("Suma de las columnas:");
for (int j = 0; j < 10; j++)
{
    Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
}
    
    

