using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba1.Tests
{
    [TestClass]
    public class Laba1Tests
    {
        [TestMethod]
        public void CaesarEncodeFirst()
        {
            //Общий алфавит, прямое направление сдвига, шаг 2, закодировать

            //Строка для шифровки:
            //"Никогда не стоит недооценивать предсказуемость тупизны."

            //Ожидаемая строка:
            //"Пкмреёв пж уфркф пжёрршжпкдвфю стжёумвйхжоруфю фхскйпэ."

            //arrange
            string str = "Никогда не стоит недооценивать предсказуемость тупизны.";
            uint sdv = 2;
            string dir = "Right";
            string alph = "one";
            string action = "encode";
            string expected = "Пкмреёв пж уфркф пжёрршжпкдвфю стжёумвйхжоруфю фхскйпэ.";
            //act
            string actual = Caesar.CaesarMethod(str, sdv, dir, alph, action);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CaesarDecodeFirst()
        {
            //Общий алфавит, прямое направление сдвига, шаг 2, декодировать

            //Строка для дешифровки:
            //"Пкмреёв пж уфркф пжёрршжпкдвфю стжёумвйхжоруфю фхскйпэ."

            //Ожидаемая строка:
            //"Никогда не стоит недооценивать предсказуемость тупизны."

            //arrange
            string str = "Пкмреёв пж уфркф пжёрршжпкдвфю стжёумвйхжоруфю фхскйпэ.";
            uint sdv = 2;
            string dir = "Right";
            string alph = "one";
            string action = "decode";
            string expected = "Никогда не стоит недооценивать предсказуемость тупизны.";
            //act
            string actual = Caesar.CaesarMethod(str, sdv, dir, alph, action);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CaesarEncodeSecond()
        {
            //Раздельный алфавит, обратное направление сдвига, шаг 11, закодировать

            //Строка для шифровки:
            //"Эту строку пишет Даня, которому 20 лет. Написано в Visual Studio 2019."

            //Ожидаемая строка:
            //"Тзи жзёдаи еюнъз Щхгф, адздёдви 19 бъз. Гхеюжхгд ч Visual Studio 1908."

            //arrange
            string str = "Эту строку пишет Даня, которому 20 лет. Написано в Visual Studio 2019.";
            uint sdv = 11;
            string dir = "Left";
            string alph = "two";
            string action = "encode";
            string expected = "Тзи жзёдаи еюнъз Щхгф, адздёдви 19 бъз. Гхеюжхгд ч Visual Studio 1908.";
            //act
            string actual = Caesar.CaesarMethod(str, sdv, dir, alph, action);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CaesarDecodeSecond()
        {
            //Раздельный алфавит, обратное направление сдвига, шаг 11, декодировать

            //Строка для дешифровки:
            //"Тзи жзёдаи еюнъз Щхгф, адздёдви 19 бъз. Гхеюжхгд ч Visual Studio 1908."

            //Ожидаемая строка:
            //"Эту строку пишет Даня, которому 20 лет. Написано в Visual Studio 2019."

            //arrange
            string str = "Тзи жзёдаи еюнъз Щхгф, адздёдви 19 бъз. Гхеюжхгд ч Visual Studio 1908.";
            uint sdv = 11;
            string dir = "Left";
            string alph = "two";
            string action = "decode";
            string expected = "Эту строку пишет Даня, которому 20 лет. Написано в Visual Studio 2019.";
            //act
            string actual = Caesar.CaesarMethod(str, sdv, dir, alph, action);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
