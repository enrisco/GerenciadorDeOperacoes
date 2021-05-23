using System;
using System.Xml.Linq;
using System.IO;
using projGerenciadorDeOperacoes.Model;

namespace projGerenciadorDeOperacoes.Controller
{
    public static class UseXML
    {
        public static XDocument Xml { get; set; }
        public readonly static string directory = string.Format
        (
            @"{0}\Database\", 
            LocalObserver.GetDirectoryOfApp()
        );

        public static bool CheckifXMLDontExist()
        {
            if (!Directory.Exists(directory))
            {
                Console.WriteLine("Database do not exist,");
                return true;
            }
            else
            {
                Console.WriteLine("Loading database...");
                Xml = XDocument.Load(directory + @"\Database.xml");
                return false;
            }
        }

        public static void CreateDatabase()
        {
            Directory.CreateDirectory(directory);
            Console.WriteLine("Database dont't exist. Creating...");

            XDocument x = new XDocument
                (
                    new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Database")
                );

            Console.WriteLine("Creating clients table...");
            x.Element("Database").Add
            (
                new XElement
                (
                    "Clients"
                )
            );

            Console.WriteLine("Creating coins table...");
            x.Element("Database").Add
            (
                new XElement
                (
                    "Coins"
                )
            );

            Xml = x;

            SaveDatabase();
            Console.WriteLine("Finish!");
        }

        public static void SaveDatabase()
        {
            Xml.Save(directory + "Database.xml");
        }
        
    }
}
