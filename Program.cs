// See https://aka.ms/new-console-template for more information

using FluentCalculator;

Console.WriteLine("Добро поожаловать!");


var someValue = new SomeValue();
if (someValue == true && someValue == false)
{
	Console.WriteLine(
		"Вы видите этот текст так как (someValue == true && someValue == false) выражение в результате возвращает true");
	Console.WriteLine("Нажvите клавишу Enter, чтобы увидеть результаты работы Fluent Calculator");
}

Console.ReadLine();



var calculator = new FluentCalculator.Calculator.FluentCalculator();

var onePlusTwo = calculator.One.Plus.Two.Result();
var onePlusTwoPlusThreeMinusOneMinusTwoMinusFour =
	calculator.One.Plus.Two.Plus.Three.Minus.One.Minus.Two.Minus.Four.Result();
var onePlusTenMinusTen = calculator.One.Plus.Ten.Result() - 10;


Console.WriteLine($"onePlusTwo : {onePlusTwo}");
Console.WriteLine($"onePlusTwoPlusThreeMinusOneMinusTwoMinusFour : {onePlusTwoPlusThreeMinusOneMinusTwoMinusFour}");
Console.WriteLine($"onePlusTenMinusTen : {onePlusTenMinusTen}");
Console.ReadLine();