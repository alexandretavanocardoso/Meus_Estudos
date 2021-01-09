
/* TIMESPAN */

-- Representa uma duração, intervalo de instantes

----- Instanciando -----

TimeSpan t1 = new TimeSpan(hora, minuto, segundo);

Ex.
TimeSpan t1 = new TimeSpan(5, 1, 30);

----- Instanciando Construtor -----

TimeSpan t1 = new TimeSpan(); // Padrao, duração 0
TimeSpan t2 = new TimeSpan(900000000L); // Ticks
TimeSpan t3 = new TimeSpan(hora, minuto, segundo);
TimeSpan t4 = new TimeSpan(dia, horas, minutos, segundos);
TimeSpan t5 = new TimeSpan(dia, hora, minutos, segundos, milisegundos);

----- Instanciando Usando FROM -----

TimeSpan t1 = TimeSpan.FromDays(dia); // 1.5
TimeSpan t2 = TimeSpan.FromHours(horas); // 1.5
TimeSpan t3 = TimeSpan.FromMinutes(minutos); // 1.5
TimeSpan t4 = TimeSpan.FromSeconds(segundos); // 1.5
TimeSpan t5 = TimeSpan.FromMiliseconds(Milisegundos); // 1
TimeSpan t6 = TimeSpan.FromTicks(Ticks); // 900000000L

----- Propriedades -----


TimeSpan t = new TimeSpan(2, 3, 5 ,7, 11);

-- Days --

Console.WriteLine(t.Days); // 2

-- Hours --

Console.WriteLine(t.Hours); // 3

-- Minutes --

Console.WriteLine(t.Minutes); // 5

-- Milliseconds --

Console.WriteLine(t.Milliseconds); // 11

-- Seconds --

Console.WriteLine(t.Seconds); // 7

-- Ticks --

Console.WriteLine(t.Ticks); // 1839070110000

-- TotalDays --

Console.WriteLine(t.TotalDays); // 2,128

-- TotalHours --

Console.WriteLine(t.TotalHours); // 51,082

-- TotalMinutes --

Console.WriteLine(t.TotalMinutes); // 3065,11685

-- TotalSeconds --

Console.WriteLine(t.TotalSeconds); // 183907,011

-- TotalMilliseconds --

Console.WriteLine(t.TotalMilliseconds); // 183907011

-- Max Value --
TimeSpan t1 = TimeSpan.MaxValue;

-- Min Value --
TimeSpan t1 = TimeSpan.MinValue;

-- Zero --
TimeSpan t1 = TimeSpan.Zero;

----- Operações -----

TimeSpan t = new TimeSpan(1, 30, 10);
TimeSpan t1 = new TimeSpan(0, 10, 5);

-- Add() --

TimeSpan soma = t.Add(t1)
Console.WriteLine(soma); 

-- Subtract() --

TimeSpan subtra = t.Subtract(t1)
Console.WriteLine(subtra); 

-- Multiply() --

TimeSpan mult = t1.Multiply(2.0); // Recebe um double
Console.WriteLine(mult); 

-- Divide() --

TimeSpan divide = t1.Divide(2.0); // Recebe um double
Console.WriteLine(divide); 























