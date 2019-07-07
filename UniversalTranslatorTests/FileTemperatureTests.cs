using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using UniversalTranslator;

namespace UniversalTranslatorTests
{
    public class FileTemperatureTests
    {
        string path = "Tests.txt";
        Temperature[] temps;
        FileTemperature f;
        [SetUp]
        public void SetUp()
        {
            f = new FileTemperature();
            temps = new []
            {
                new Temperature
                {
                    value = 0,
                    actualUnit = "C",
                    resultUnit = "F"
                },
                new Temperature
                {
                    value = 64.4,
                    actualUnit = "F",
                    resultUnit = "C"
                },
                new Temperature
                {
                    value = 268,
                    actualUnit = "K",
                    resultUnit = "C"
                },
                new Temperature
                {
                    value = 13,
                    actualUnit = "C",
                    resultUnit = "Y"
                }
            };
            using(StreamWriter sw = new StreamWriter(path))
            {
                foreach(var temp in temps)
                {
                    var line = $"{temp.value}-{temp.actualUnit}-{temp.resultUnit}";
                    sw.WriteLine(line);
                }
            }
        }
        [TearDown]
        public void Delete()
        {
            File.Delete(path);
        }
        [Test]
        public void ReadTemperatureFile_and_returns_list()
        {
            var expected = new List<Temperature>();
            expected.AddRange(temps);
            var temperatures = f.ReadTemperatureFile(path);
            CollectionAssert.AreEquivalent(expected, temperatures);
        }
        [Test]
        public void ConvertValues_and_returns_results()
        {
            var list = new List<Temperature>();
            list.AddRange(temps);
            temps[0].resultValue = 32;
            temps[1].resultValue = 18;
            temps[2].resultValue = -5;
            f.ConvertValues(ref list);
            CollectionAssert.AreEquivalent(temps, list);
        }
        [Test]
        public void WriteTemperatureFile_and_Verify_FileIsCreated()
        {
            string pathTest = "Tests2.txt";
            var list = new List<Temperature>();
            list.AddRange(temps);
            f.WriteTemperatureFile(list,pathTest);
            var Exists = File.Exists(pathTest);
            Assert.IsTrue(Exists);
            File.Delete(pathTest);
        }
    }
}