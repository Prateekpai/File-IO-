using System;
using CSVHandler;
using CsvHelper;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHandler
{
    public class CSVHandler
    {
        public static void CSVImplement()
        {
            string importFilePath = @"E:\LFP 119\Day 28\UC14\UC14\Import.csv";
            string exportFilePath = @"E:\LFP 119\Day 28\UC14\UC14\Export.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader (reader, CultureInfo.InvariantCulture))
            {
                var record = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read Data Successfully");
                foreach (AddressData address in record)
                {
                    Console.WriteLine(address.FirstName);
                    Console.WriteLine(address.LastName);
                    Console.WriteLine(address.Address);
                    Console.WriteLine(address.City);
                    Console.WriteLine(address.State);
                    Console.WriteLine(address.Mobile);
                    Console.WriteLine(address.Email);
                }
                using (var Writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(Writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(record);
                }

            }
        }
    }
}
