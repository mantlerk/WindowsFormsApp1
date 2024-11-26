using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MyTransportApp.Models;

namespace MyTransportApp.Services
{
    public class DataService
    {
        private const string DataFilePath = "data.json";

        public void SaveData(List<Car> cars, List<Driver> drivers, List<Client> clients)
        {
            var data = new { Cars = cars, Drivers = drivers, Clients = clients };
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(DataFilePath, json);
        }

        public (List<Car>, List<Driver>, List<Client>) LoadData()
        {
            if (!File.Exists(DataFilePath))
                return (new List<Car>(), new List<Driver>(), new List<Client>());

            var json = File.ReadAllText(DataFilePath);
            dynamic data = JsonConvert.DeserializeObject(json);

            var cars = JsonConvert.DeserializeObject<List<Car>>(data.Cars.ToString());
            var drivers = JsonConvert.DeserializeObject<List<Driver>>(data.Drivers.ToString());
            var clients = JsonConvert.DeserializeObject<List<Client>>(data.Clients.ToString());

            return (cars, drivers, clients);
        }
    }
}


