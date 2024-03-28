using System;

namespace PersonalTaskManager.Core.Helpers
{
    public class CalculateDateHelper
    {
        public string NumberOfDaysOVerdue(DateOnly dateToCompare)
        {
            var date = DateOnly.FromDateTime(DateTime.Now);

            var comparisonDays = date.CompareTo(dateToCompare);


            if (comparisonDays < 0)
                return $"A tarefa está atrasado há {comparisonDays} dia(s).";

            if (comparisonDays == 0)
                return "Sua tarefa venceu hoje";

            return $"Sua tarefa irá vencer em {comparisonDays}";
        }
    }
}
