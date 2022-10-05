using API.Conciertos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Conciertos.DataAccess
{
    public interface IDataAccess
    {
        Task<List<Concert>> GetConcerts();

        Task<Concert> GetConcertId(int id);

        Task<int> Test();

    }
}
