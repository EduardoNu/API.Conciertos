using API.Conciertos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Conciertos.DataAccess.DataAccess.Mock
{
    public class MockDataAccess : IDataAccess
    {
        private List<Concert> list;

        public Task<Concert> GetConcertId(int id)
        {
            Concert concert = new Concert();
            concert.Id = 1;
            concert.Hour = "5:00";
            concert.Price = 5;
            concert.Age = 20;
            concert.Description = "Lo mejor de salsa en vivo";
            

        }

        public async Task<List<Concert>> GetConcerts()
        {
           List<Concert> concert = new List<Concert>();

            concert.Add(new Concert()
            {
                Id = 1,
                Day = 13,
                Event = "Vive",
                Ubication = "SantaFe",
                Hour= "5",
                Price= 200,
                Age= 20,
                



            });
            concert.Add(new Concert()
            {
                Id = 2,
                Day = 18,
                Event = "Corona",
                Ubication = "Perisur",
                Hour = "5",
                Price = 3000,
                Age = 18,


            });
            concert.Add(new Concert()
            {
                Id = 3,
                Day = 25,
                Event = "Vilma",
                Ubication = "Condesa",
                Hour = "5",
                Price = 450,
                Age = 18,


            });

            return concert;
        }

        public Task<int> Test()
        {
            throw new NotImplementedException();
        }
    }
}
