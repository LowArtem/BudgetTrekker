using System.Collections.Generic;

namespace BudgetTrekker.Models
{
    public static class IncomeCategories
    {
        public static string Father { get; } = "Зарплата (муж)";
        public static string Mother { get; } = "Зарплата (жена)";
        public static string SideJob { get; } = "Подработка";
        public static string Business { get; } = "Бизнес";
        public static string Other { get; } = "Другое";       

        public static bool isRightCategory(string value)
        {
            if (value == Father || value == Mother || value == SideJob || value == Business || value == Other)
                return true;
            else
                return false;
        }

        public static List<string> GetCategoriesList()
        {
            var list = new List<string>();
            list.Add(Father);
            list.Add(Mother);
            list.Add(SideJob);
            list.Add(Business);            
            list.Add(Other);

            return list;
        }
    }
}
