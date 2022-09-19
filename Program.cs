using System;

int m;
int v;
int p;
Console.Write("Введите массу ");
m = int.Parse(Console.ReadLine());
Console.Write("Введите объём ");
v = int.Parse(Console.ReadLine());
p = m / v;
Console.WriteLine("Плотность = {0}", p);
Console.ReadLine();
