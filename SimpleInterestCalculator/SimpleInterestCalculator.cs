using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculator
{
    /// <summary>
    /// Class that contains all the methods for calculating Simple Interest, principal, Rate and years
    /// when anyone is required. 
    /// </summary>
    class SimpleInterestCalculator
    {
        //Private member variables
        private decimal principal;
        private double rate;
        private decimal interest;
        private double years;

        public decimal Principal { get => principal; set => principal = value; }
        public double Rate { get => rate; set => rate = value; }
        public decimal Interest { get => interest; set => interest = value; }
        public double Years { get => years; set => years = value; }

        /// <summary>
        /// Calculates simple interest when provide with the prinicple, rate and number of years by6 the user.
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="rate"></param>
        /// <param name="years"></param>
        /// <returns></returns>
        public decimal GetSimpleInterest(decimal principal, double rate, double years)
        {
            Principal = principal;
            Rate = rate;
            Years = years;

            Interest = Principal * ((decimal)Rate/ 100) * (decimal)Years;
            return Interest;
        }

        /// <summary>
        /// Gets rate of a simple interest with principal, number of years and interest provided by user.
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="years"></param>
        /// <param name="interest"></param>
        /// <returns></returns>
        public double GetRate(decimal principal, double years, decimal interest)
        {
            Interest = interest;
            Principal = principal;
            Years = years;
            Rate = (double)Interest / ((double)Principal * Years);
            return Rate;
        }

        /// <summary>
        /// Gets Number of year to get a particular Interest with principal, rate and interest provided by user.
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="interest"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public double GetNumberOfYears(decimal principal, decimal interest, double rate)
        {
            Interest = interest;
            Principal = principal;
            Rate = rate;

            Years = (double)Interest / ((double)Principal * (Rate/100));
            return Years;
        }

        /// <summary>
        /// Gets Principal amount of an interest based on interest, rate and number of Years provided by user.
        /// </summary>
        /// <param name="interest"></param>
        /// <param name="rate"></param>
        /// <param name="years"></param>
        /// <returns></returns>
        public decimal GetPrincipal(decimal interest, double rate, double years)
        {
            Interest = interest;
            Rate = rate;
            Years = years;

            Principal = Interest / (decimal)((Rate/100) * Years);
            return Principal;
        }

    }
}   
