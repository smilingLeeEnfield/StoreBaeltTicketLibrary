using bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class RepositoryClass
    {
        public static List<StorebæltCar> CarList= new List<StorebæltCar>();

        /// <summary>
        /// Returns a list of all cars in the repository
        /// </summary>
        /// <returns></returns>
        public List<StorebæltCar> GetAllCars()
        {
            return CarList;
        }
        /// <summary>
        /// Adds a car to the repository
        /// </summary>
        /// <param name="car"></param>
        public void AddCar(StorebæltCar car)
        {
            CarList.Add(car);
        }
        /// <summary>
        /// Finds all tickets by licence plate
        /// </summary>
        /// <param name="lp"></param>
        /// <returns></returns>
        public List<StorebæltCar> TicketByLP(string lp)
        {
            return CarList.FindAll(i=>i.LicencePlate==lp).ToList();
        }
    }
}
