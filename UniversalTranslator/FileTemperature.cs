using System;
using System.Collections.Generic;
using System.IO;

namespace UniversalTranslator
{
    public class FileTemperature
    {
        /// <summary>
        /// Reads a file from a <paramref name="path"/>
        /// </summary>
        /// <param name="path">the pathfile to read</param>
        /// <returns>A List of temperatures</returns>
        public List<Temperature> ReadTemperatureFile(string path)
        {
            var list = new List<Temperature>();
            try{
                using(StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) 
                    {
                        string[] values = line.Split("-");
                        if(values.Length != 3) throw new Exception();
                        var temperature = new Temperature()
                        {
                            value = Convert.ToDouble(values[0]),
                            actualUnit = values[1],
                            resultUnit = values[2]
                        };
                        list.Add(temperature);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(ex.Message);
            }
            return list;
        }
        /// <summary>
        /// Converts the value depending on the actual and result temperature unit
        /// </summary>
        /// <param name="temps">List of temperatures passed by ref</param>
        public void ConvertValues(ref List<Temperature> temps)
        {
            Converter c = new Converter();
            foreach(var temp in temps)
            {
                string conversion = $"{temp.actualUnit} to {temp.resultUnit}";
                switch(conversion)
                {
                    case "F to F":
                        temp.resultValue = c.FahrenheitToFahrenheit(temp.value);
                    break;
                    case "F to C":
                        temp.resultValue = c.FahrenheitToCelsius(temp.value);
                    break;
                    case "F to K":
                        temp.resultValue = c.FahrenheitToKelvin(temp.value);
                    break;
                    case "C to C":
                        temp.resultValue = c.CelsiusToCelsius(temp.value);
                    break;
                    case "C to F":
                        temp.resultValue = c.CelsiusToFahrenheit(temp.value);
                    break;
                    case "C to K":
                        temp.resultValue = c.CelsiusToKelvin(temp.value);
                    break;
                    case "K to K":
                        temp.resultValue = c.KelvinToKelvin(temp.value);
                    break;
                    case "K to C":
                        temp.resultValue = c.KelvinToCelsius(temp.value);
                    break;
                    case "K to F":
                        temp.resultValue = c.KelvinToFahrenheit(temp.value);
                    break;
                    default:
                        System.Console.WriteLine($"Invalid Unit at {temp.value}-{temp.actualUnit}-{temp.resultUnit}");
                        System.Console.WriteLine("All units should be: \n F for Fahrenheit \n C for Celsius \n K for Kelvin");
                    break;
                }
            }
        }
        /// <summary>
        /// Overwrites the file with an Extra column: the result
        /// </summary>
        /// <param name="temps">List of temperatures</param>
        /// <param name="path">Path to write the file</param>
        public void WriteTemperatureFile(List<Temperature> temps, string path)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach(var temp in temps)
                    {
                        string line = $"{temp.value}-{temp.actualUnit}-{temp.resultUnit}-{temp.resultValue}";
                        sw.WriteLine(line);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Error while Writing the file");
                Console.WriteLine(ex.Message);
            }
        }
    }
}