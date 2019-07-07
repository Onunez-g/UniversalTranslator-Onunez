using NUnit.Framework;
using UniversalTranslator;

namespace UniversalTranslatorTests
{
    public class ConverterTests
    {
        Converter c;
        [SetUp]
        public void Setup()
        {
            c = new Converter();
        }

        [TestCase(34, ExpectedResult=34)]
        [TestCase(18, ExpectedResult=18)]
        [TestCase(13.5, ExpectedResult=13.5)]
        [TestCase(-5, ExpectedResult=-5)]
        public double CelsiusToCelsius_value_and_returns_value(double celsius) => c.CelsiusToCelsius(celsius);
        
        [TestCase(0, ExpectedResult=32)]
        [TestCase(18, ExpectedResult=64.4)]
        [TestCase(13.5, ExpectedResult=56.3)]
        [TestCase(-5, ExpectedResult=23)]
        public double CelsiusToFahrenheit_value_and_returns_fahrenheit(double celsius) => c.CelsiusToFahrenheit(celsius);
        [TestCase(0, ExpectedResult=273)]
        [TestCase(18, ExpectedResult=291)]
        [TestCase(13.5, ExpectedResult=286.5)]
        [TestCase(-5, ExpectedResult=268)]
        public double CelsiusToKelvin_value_and_returns_kelvin(double celsius) => c.CelsiusToKelvin(celsius);
        [TestCase(32, ExpectedResult=32)]
        [TestCase(64.4, ExpectedResult=64.4)]
        [TestCase(56.3, ExpectedResult=56.3)]
        [TestCase(23, ExpectedResult=23)]
        public double FahrenheitToFahrenheit_value_and_returns_fahrenheit(double fahrenheit) => c.FahrenheitToFahrenheit(fahrenheit);
        [TestCase(32, ExpectedResult=0)]
        [TestCase(64.4, ExpectedResult=18)]
        [TestCase(56.3, ExpectedResult=13.5)]
        [TestCase(23, ExpectedResult=-5)]
        public double FahrenheitToCelsius_value_and_returns_celsius(double fahrenheit) => c.FahrenheitToCelsius(fahrenheit);
        [TestCase(32, ExpectedResult=273)]
        [TestCase(64.4, ExpectedResult=291)]
        [TestCase(56.3, ExpectedResult=286.5)]
        [TestCase(23, ExpectedResult=268)]
        public double FahrenheitToKelvin_value_and_returns_kelvin(double fahrenheit) => c.FahrenheitToKelvin(fahrenheit);
        [TestCase(273, ExpectedResult=273)]
        [TestCase(291, ExpectedResult=291)]
        [TestCase(286.5, ExpectedResult=286.5)]
        [TestCase(268, ExpectedResult=268)]
        public double KelvinToKelvin_value_and_returns_kelvin(double kelvin) => c.KelvinToKelvin(kelvin);
        [TestCase(273, ExpectedResult=0)]
        [TestCase(291, ExpectedResult=18)]
        [TestCase(286.5, ExpectedResult=13.5)]
        [TestCase(268, ExpectedResult=-5)]
        public double KelvinToCelsius_value_and_returns_celsius(double kelvin) => c.KelvinToCelsius(kelvin);
        [TestCase(273, ExpectedResult=32)]
        [TestCase(291, ExpectedResult=64.4)]
        [TestCase(286.5, ExpectedResult=56.3)]
        [TestCase(268, ExpectedResult=23)]
        public double KelvinToFahrenheit_value_and_returns_fahrenheit(double kelvin) => c.KelvinToFahrenheit(kelvin);
    }
}