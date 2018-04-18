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
                CostOfBeveragesPerPerson = ((NumberOfPeople * 5) * 0.95M);
            }
            else
            {
                CostOfBeveragesPerPerson = (NumberOfPeople * 20);

            }

        }

        public void CalculateCostOfDecorations(bool fancyOption)
        {
            if (fancyOption)
            {
                CostOfDecoration = (NumberOfPeople * 15) + 50.0M;
            }
            else
            {
                CostOfDecoration = (NumberOfPeople * 7.50M) + 30M;
            }

        }
        public decimal CalculateCost()
        {
            decimal wholePrice = (NumberOfPeople * CostOfFoodPerPerson) + CostOfDecoration + CostOfBeveragesPerPerson;


            return wholePrice;


            

        }

    }
}
