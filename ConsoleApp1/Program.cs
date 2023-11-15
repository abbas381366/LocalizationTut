// See https://aka.ms/new-console-template for more information


using System.Globalization;

decimal Money = 1000;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

CultureInfo Culture = CultureInfo.CurrentCulture;

Console.WriteLine(Money.ToString("C"));


