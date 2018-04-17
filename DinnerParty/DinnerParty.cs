using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    public class DinnerParty
    {
        public int NumberOfPeople = 0;
        decimal CostOfBeveragesPerPerson = 0.0M;
        decimal CostOfDecoration = 0.0M;
        public const int CostOfFoodPerPerson = 25;
        public void SetHealthyOption(bool healthyOption)
        {
            if(healthyOption)
            {
                CostOfBeveragesPerPerson = 5;

                CostOfBeveragesPerPerson += CostOfFoodPerPerson;

            }
            else
            {
                CostOfBeveragesPerPerson = 20;

                CostOfBeveragesPerPerson += CostOfFoodPerPerson;

            }

        }

        public void CalculateCostOfDecorations(bool fancyOption)
        {

        }
        public decimal CalculateCost()
        {
            

        }

    }
}
