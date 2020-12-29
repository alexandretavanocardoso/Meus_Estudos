
/* DATETIME */
-- Representa um instante

-- dd/MM/yyyy - dia/mes/ano
-- yyyy-MM-dd - ano-mes-dia
-- HH:mm:ss - Hora:Minuto:Segundo
-- HH:mm:ss..fff - Hora:Minuto:Segundo:Milisegundo

----- Instanciando -----

Datetime d1 = DateTime.Now; // Horario Atual

----- Instanciando Construtor -----

Datetime d1 = new DateTime(ano, mes, dia);
Datetime d2 = new DateTime(ano, mes, dia, hora, minuto, segundo);
Datetime d3 = new DateTime(ano, mes, dia, hora, minuto, segundo, milisegundo);

----- Builders Básicos -----

Datetime d1 = DateTime.Now; // Data e Horario Atual
Datetime d2 = DateTime.Today; // Data Atual
Datetime d3 = DateTime.utcNow; // Horario de agora, porem universal

----- Usando Parse -----
- Converte string em data

Datetime d1 = Datetime.Parse("ano-mes-dia"); // Converte string em data
Datetime d2 = Datetime.Parse("ano-mes-dia hora:minuto:segundo"); // Converte string em data

Datetime d3 = Datetime.Parse("dia/mes/ano"); // Converte string em data
Datetime d4 = Datetime.Parse("dia/mes/ano hora:minuto:segundo"); // Converte string em data

----- Usando ParseExact -----
- O proprio autor formata a data

Datetime d1 = Datetime.ParseExact("ano-mes-dia", "Mascara de Formatação");

Ex.
Datetime d1 = Datetime.ParseExact("2002-08-28", "yyyy-MM-dd", cultureInfo.InvariantCulture);
Datetime d2 = Datetime.ParseExact("15/08/2000 13:05:20", "dd/MM/yyyy HH:mm:ss", cultureInfo.InvariantCulture);

----- Propriedades -----

DateTime d = new DateTime(2000, 8, 12, 13, 45, 58, 275);

-- Date (DateTime) --

console.WriteLine(d.Date); // (2000, 8, 12

-- Day (Int) --

console.WriteLine(d.Day); // 12

-- DayOfWeek (DayOfWeek --

console.WriteLine(d.DayOfWeek); // Dia da Semana 

-- DayOfYear (DayOfYear) --

console.WriteLine(d.DayOfWeek); // Dia do ano 

-- Hour (Int) --

console.WriteLine(d.Hour); // 13

-- Kind (DateTimeKind) --
-- Tipo, local ou universal

console.WriteLine(d.Kind);

-- Milliseconds (Int) --

console.WriteLine(d.Milisecond // 275

-- Minute (Int) --

console.WriteLine(d.Minute); // 45

-- Month (Int) --

console.WriteLine(d.Month); // 8

-- Second (Int) --

console.WriteLine(d.Second); // 58

-- Ticks (Long) --

console.WriteLine(d.Ticks); // 631334799582750000

-- TimeOfDay (TimeSpan) --

console.WriteLine(d.TimeOfDay); // Horario, Duração

-- Year (Int) --

console.WriteLine(d.Year); // 2000

----- Formatações -----

DateTime d = new DateTime(2000, 8, 12, 13, 45, 58);

-- ToLongDateString() --
Console.WriteLine(d.ToLongDateString()); // Data mais completa, converte para string

-- ToLongTimeString() --
Console.WriteLine(d.ToLongTimeString()); // Horario, Converte em String

-- ToShortDateString() --
Console.WriteLine(d.ToShortDateString()); // Data em formato Resumido

-- ToShortTimeString() --
Console.WriteLine(d.ToShortTimeString()); // Hora  minuto  
  
-- ToString() com mascara --  
Console.WriteLine(d.ToString("yyyy/MM/dd HH:mm:ss"))  

-- ToString() com mascara -- 
Console.WriteLine(d.ToString("yyyy/MM/dd HH:mm:ss.fff"));

----- Operações -----

DateTime d = new DateTime(2000, 8, 12, 13, 45, 58);

-- Add() --

DateTime d2 = d.Add();

-- AddDays() --

DateTime d2 = d.AddDays(2);

-- AddHours() --

DateTime d2 = d.AddHours(2);

-- AddMilliseconds() --

DateTime d2 = d.AddMilliseconds(2);

-- Addminutes() --

DateTime d2 = d.AddMinutes(2);

-- AddMonths() --

DateTime d2 = d.AddMonths(2);

-- AddSeconds() --

DateTime d2 = d.AddSeconds(2);

-- AddTicks() --

DateTime d2 = d.AddTicks();

-- AddYears() --

DateTime d2 = d.AddYears(2);

-- Subtract(timeSpan) -- 

TimeSpan df = d.Subtract(OutraData); // Diferença de Datas

-- Subtract(dateTime) --

Datetime dt = d.Subtract(OutraData);














