using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using projGerenciadorDeOperacoes.Model;

namespace projGerenciadorDeOperacoes.Controller
{
    class DataController
    {
        public static double SumOpe = 0, SumTax = 0;
        public static DataTable CreateTable()
        {
            DataTable dataTable = new DataTable();

            SetColumn(dataTable);
            LoadAllData(dataTable, false, "", "");

            return dataTable;
        }

        public static DataTable Search(string name, string date)
        {
            DataTable dataTable = new DataTable();

            SetColumn(dataTable);
            LoadAllData(dataTable, true, name, date);

            return dataTable;
        }

        private static void SetColumn(DataTable data)
        {
            DataColumn name = new DataColumn("Nome");
            DataColumn date = new DataColumn("Data de transação");
            DataColumn initial = new DataColumn("Câmbio inicial");
            DataColumn iniValue = new DataColumn("Valor inicial");
            DataColumn final = new DataColumn("Câmbio final");
            DataColumn finValue = new DataColumn("Valor Final");
            DataColumn tax = new DataColumn("Taxa de transação");

            data.Columns.Add(name);
            data.Columns.Add(date);
            data.Columns.Add(initial);
            data.Columns.Add(iniValue);
            data.Columns.Add(final);
            data.Columns.Add(finValue);
            data.Columns.Add(tax);
        }

        private static void LoadAllData(DataTable data, bool search,string searchName, string date)
        {
            DatabaseController database = new DatabaseController();
            List<Client> clients;
            if (search)
            {
                if (date == "" && searchName != "")
                    clients = database.SearchClients(searchName, "Name");
                else if (date != "" && searchName == "")
                    clients = database.SearchClients(date.Substring(0, 9), "Date");
                else if (date != "" && searchName != "")
                    clients = database.SearchClientsWithNameAndDate(searchName, date);
                else
                    clients = database.GetClients();
            }
            else
                 clients = database.GetClients();
            RestoreData(data);

            foreach (var item in clients)
            {
                DataRow row = data.NewRow();
                row["Nome"] = item.Name;
                row["Data de transação"] = item.Date;
                row["Câmbio inicial"] = item.Initial;
                row["Valor inicial"] = item.InitialValue;
                row["Câmbio final"] = item.Converted;
                row["Valor Final"] = item.ConvertedValue;
                row["Taxa de transação"] = item.TaxValue;
                data.Rows.Add(row);

                SumOpe += Convert.ToDouble(item.InitialValue, CultureInfo.InvariantCulture);
                SumTax += Convert.ToDouble(item.TaxValue, CultureInfo.InvariantCulture);
            }
        }

        private static void RestoreData(DataTable data)
        {
            data.Rows.Clear();
            SumOpe = 0;
            SumTax = 0;
        }


    }
}
