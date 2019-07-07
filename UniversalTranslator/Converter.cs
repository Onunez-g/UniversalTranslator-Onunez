using System;

namespace UniversalTranslator
{
    public class Converter
    {
        /// <summary>
        /// Converts a temperature unit Celsius to celsius
        /// </summary>
        /// <param name="celsius">The value in celsius to convert</param>
        /// <returns>The temperature to celsius</returns>
        public double CelsiusToCelsius(double celsius) => Math.Round(celsius, 2);
        /// <summary>
        /// Converts a temperature unit Celsius to celsius
        /// </summary>
        /// <param name="celsius">The value in celsius to convert</param>
        /// <returns>The temperature to celsius</returns>
        public double CelsiusToFahrenheit(double celsius) => Math.Round((celsius * 1.8) + 32, 2);
        /// <summary>
        /// Converts a temperature unit Celsius to celsius
        /// </summary>
        /// <param name="celsius">The value in celsius to convert</param>
        /// <returns>The temperature to celsius</returns>
        public double CelsiusToKelvin(double celsius) => Math.Round(celsius + 273, 2);
        /// <summary>
        /// Converts a temperature unit fahrenheit to fahrenheit
        /// </summary>
        /// <param name="fahrenheit">The value in fahrenheit to convert</param>
        /// <returns>The temperature to fahrenheit</returns>
        public double FahrenheitToFahrenheit(double fahrenheit) => Math.Round(fahrenheit, 2);
        /// <summary>
        /// Converts a temperature unit fahrenheit to celsius
        /// </summary>
        /// <param name="fahrenheit">The value in fahrenheit to convert</param>
        /// <returns>The temperature to celsius</returns>
        public double FahrenheitToCelsius(double fahrenheit) => Math.Round((fahrenheit - 32) * (5.0 / 9.0), 2);
        /// <summary>
        /// Converts a temperature unit fahrenheit to fahrenheit
        /// </summary>
        /// <param name="fahrenheit">The value in fahrenheit to convert</param>
        /// <returns>The temperature to fahrenheit</returns>
        public double FahrenheitToKelvin(double fahrenheit) => Math.Round((fahrenheit - 32) * ((5.0 / 9.0)) + 273, 2);
        /// <summary>
        /// Converts a temperature unit kelvin to kelvin
        /// </summary>
        /// <param name="kelvin">The value in kelvin to convert</param>
        /// <returns>The temperature to Kelvin</returns>
        public double KelvinToKelvin(double kelvin) => Math.Round(kelvin, 2);
        /// <summary>
        /// Converts a temperature unit kelvin to celsius
        /// </summary>
        /// <param name="kelvin">The value in kelvin to convert</param>
        /// <returns>The temperature to Celsius</returns>
        public double KelvinToCelsius(double kelvin) => Math.Round(kelvin - 273, 2);
        /// <summary>
        /// Converts a temperature unit kelvin to farenheit
        /// </summary>
        /// <param name="kelvin">The value in kelvin to convert</param>
        /// <returns>The temperature to Farenheit</returns>
        public double KelvinToFahrenheit(double kelvin) => Math.Round((kelvin - 273) * 1.8 + 32, 2);
    }
}