using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class StorebæltCar : bridge.Car
    {
        public StorebæltCar(string LP, bool biz) : base(LP, biz)
        {
        }
        /// <summary>
        /// returns price of a car ticket on the Storebælt bridge with a discount if brobizz is used and a weekend discount
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double tPrice = base.Price();
            if (DateTime.Now.DayOfWeek == 0 || DateTime.Now.DayOfWeek == 0) return base.Price() *0.85;
            return tPrice;
        }
    }
}
