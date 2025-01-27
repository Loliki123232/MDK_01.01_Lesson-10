using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_2
{
    public abstract class Translator
    {
        public abstract string Translate(string text);
        public abstract string getLanguage();

        public void tap()
        {
            Console.WriteLine("Я переводчик");
        }
    }


    public class EnglishTranslator : Translator
    {
        public override string Translate(string text)
        {
           
            return $"Перевод с английского: {text}";
        }

        public override string getLanguage()
        {
            return "Я переводчик с английского";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            EnglishTranslator translator = new EnglishTranslator();
            translator.tap();
            Console.WriteLine(translator.getLanguage());
            Console.WriteLine(translator.Translate("Hello"));

            Console.ReadKey();
        }
    }
}
