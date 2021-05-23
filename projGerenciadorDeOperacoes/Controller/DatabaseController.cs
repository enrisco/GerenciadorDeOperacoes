using System;
using System.Xml.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using projGerenciadorDeOperacoes.Model;

namespace projGerenciadorDeOperacoes.Controller
{
    class DatabaseController
    {
        public void Add(Client c)
        {
            XDocument _xml = UseXML.Xml;

            Console.WriteLine("Creating data of " + c.Name);
            _xml.Element("Database").Element("Clients").Add
            (
                new XElement
                (
                    "Client",
                    new XAttribute("Name", c.Name),
                    new XAttribute("Date", c.Date),
                    new XAttribute("InitialCoin", c.Initial),
                    new XAttribute("ConvertedCoin", c.Converted),
                    new XAttribute("InitialValue", c.InitialValue.ToString(CultureInfo.InvariantCulture)),
                    new XAttribute("ConvertedValue", c.ConvertedValue.ToString(CultureInfo.InvariantCulture)),
                    new XAttribute("TaxValue", c.TaxValue.ToString(CultureInfo.InvariantCulture))
                )
            );

            UseXML.Xml = _xml;
            UseXML.SaveDatabase();
            Console.WriteLine("Finish!");
        }

        public void Add(Coin c)
        {
            XDocument _xml = UseXML.Xml;

            Console.WriteLine("Creating data of " + c.CoinName);
            _xml.Element("Database").Element("Coins").Add
            (
                new XElement
                (
                    "Coin",
                    new XAttribute("Name", c.CoinName),
                    new XAttribute("Value", c.Value.ToString(CultureInfo.InvariantCulture))
                )
            );

            UseXML.Xml = _xml;
            UseXML.SaveDatabase();
            Console.WriteLine("Finish!");
        }

        public string[] GetNameOfElements(string name)
        {
            XDocument _xml = UseXML.Xml;
            Console.WriteLine("Reading " + name);
            var query = _xml.Descendants(name).Select(s => (string)s.Attribute("Name"));
            Console.WriteLine("Finish!");
            return query.ToArray();
        }

        public bool CheckIfElementExist(string name, string value)
        {
            XDocument _Xml = UseXML.Xml;
            Console.WriteLine("Searching " + name);

            return _Xml.Descendants(name).Where(x => x.Attribute("Name").Value == value).Any();
        }

        public Coin GetCoin(string name)
        {
            XDocument _xml = UseXML.Xml;
            Console.WriteLine("Reading " + name);
            var query = _xml.Descendants("Coin").Where(s => s.Attribute("Name").Value == name);

            Coin c = new Coin();

            foreach(var i in query)
            {
                c.CoinName = i.Attribute("Name").Value;
                c.Value = Convert.ToDouble(i.Attribute("Value").Value, CultureInfo.InvariantCulture);
            }

            return c;
        }

        public List<Client> GetClients()
        {
            XDocument _xml = UseXML.Xml;
            List<Client> clients = new List<Client>();
            Console.WriteLine("Reading clients");

            var query = _xml.Element("Database").Element("Clients")
                .Elements("Client");

            foreach (var s in query)
            {
                clients.Add
                (
                    new Client
                    {
                        Name = s.Attribute("Name").Value,
                        Date = s.Attribute("Date").Value,
                        Initial = s.Attribute("InitialCoin").Value,
                        Converted = s.Attribute("ConvertedCoin").Value,
                        InitialValue = Convert.ToDouble(s.Attribute("InitialValue").Value, CultureInfo.InvariantCulture),
                        ConvertedValue = Convert.ToDouble(s.Attribute("ConvertedValue").Value, CultureInfo.InvariantCulture),
                        TaxValue = Convert.ToDouble(s.Attribute("TaxValue").Value, CultureInfo.InvariantCulture)
                    }
                );
            }

            return clients;
        }

        public List<Client> SearchClients(string query, string atributte)
        {
            XDocument _xml = UseXML.Xml;
            List<Client> clients = new List<Client>();
            Console.WriteLine("Reading clients");

            var q = _xml.Element("Database").Element("Clients")
                .Elements("Client").Where(s => s.Attribute(atributte).Value.Contains(query));

            foreach (var s in q)
            {
                clients.Add
                (
                    new Client
                    {
                        Name = s.Attribute("Name").Value,
                        Date = s.Attribute("Date").Value,
                        Initial = s.Attribute("InitialCoin").Value,
                        Converted = s.Attribute("ConvertedCoin").Value,
                        InitialValue = Convert.ToDouble(s.Attribute("InitialValue").Value, CultureInfo.InvariantCulture),
                        ConvertedValue = Convert.ToDouble(s.Attribute("ConvertedValue").Value, CultureInfo.InvariantCulture),
                        TaxValue = Convert.ToDouble(s.Attribute("TaxValue").Value, CultureInfo.InvariantCulture)
                    }
                );
            }

            return clients;
        }

        public List<Client> SearchClientsWithNameAndDate(string query, string date)
        {
            XDocument _xml = UseXML.Xml;
            List<Client> clients = new List<Client>();
            Console.WriteLine("Reading clients");

            var q = _xml.Element("Database").Element("Clients")
                .Elements("Client").Where(s => s.Attribute("Name").Value.Contains(query)
                && s.Attribute("Date").Value.Contains(date));
            foreach (var s in q)
            {
                clients.Add
                (
                    new Client
                    {
                        Name = s.Attribute("Name").Value,
                        Date = s.Attribute("Date").Value,
                        Initial = s.Attribute("InitialCoin").Value,
                        Converted = s.Attribute("ConvertedCoin").Value,
                        InitialValue = Convert.ToDouble(s.Attribute("InitialValue").Value, CultureInfo.InvariantCulture),
                        ConvertedValue = Convert.ToDouble(s.Attribute("ConvertedValue").Value, CultureInfo.InvariantCulture),
                        TaxValue = Convert.ToDouble(s.Attribute("TaxValue").Value, CultureInfo.InvariantCulture)
                    }
                );
            }

            return clients;
        }
    }
}