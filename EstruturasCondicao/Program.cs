﻿using System;

var notaDigitada = Console.ReadLine();

var nota = int.Parse(notaDigitada);

if (nota >= 70)
{
    Console.WriteLine("Aprovado.");
}
else if (nota >= 40)
{
    Console.WriteLine("Em Recuperação.");
}
else
{
    Console.WriteLine("Reprovado.");
}

Console.ReadKey();