// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Welcome to Fluent Calculator!");

var calculator = new FluentCalculator.Calculator.FluentCalculator();

var onePlusTwo = calculator.One.Plus.Two.Result();
var onePlusTwoPlusThreeMinusOneMinusTwoMinusFour =
	calculator.One.Plus.Two.Plus.Three.Minus.One.Minus.Two.Minus.Four.Result();
var onePlusTenMinusTen = calculator.One.Plus.Ten.Result() - 10;


Console.WriteLine($"onePlusTwo : {onePlusTwo}");
Console.WriteLine($"onePlusTwoPlusThreeMinusOneMinusTwoMinusFour : {onePlusTwoPlusThreeMinusOneMinusTwoMinusFour}");
Console.WriteLine($"onePlusTenMinusTen : {onePlusTenMinusTen}");
Console.ReadLine();