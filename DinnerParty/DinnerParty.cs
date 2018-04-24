using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    public class DinnerParty
    {
        private int NumberOfPeople = 0;
        decimal CostOfBeveragesPerPerson = 0.0M;
        decimal CostOfDecoration = 0.0M;
        public const int CostOfFoodPerPerson = 25;
        public void SetHealthyOption(bool healthyOption)
        {
            if(healthyOption)
            {
                CostOfBeveragesPerPerson =  5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;

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
        public decimal CalculateCost(bool healthyOption)
        {
            decimal wholePrice = CostOfDecoration + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson ) * NumberOfPeople);

            if (healthyOption)
            {
               return wholePrice * 0.95M;
            }
            return wholePrice;
        }
        public void SetPartyOptions(int people , bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
    }
}
