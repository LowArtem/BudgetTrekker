using System.Collections.Generic;

namespace BudgetTrekker.Models
{
    public static class SpendingsCategories
    {
        public static string Credit { get; } = "Кредит";
        public static string PublicService { get; } = "ЖК услуги";
        public static string Food { get; } = "Продукты";
        public static string Personal { get; } = "Личные";
        public static string Entertainment { get; } = "Развлечения";
        public static string Transport { get; } = "Транспорт";
        public static string Other { get; } = "Другое";

        public static bool isRightCategory(string value)
        {
            if (value == Credit || value == PublicService || value == Food || value == Personal || value == Entertainment || 
                value == Transport || value == Other)
                return true;
            else
                return false;
        }

        public static List<string> GetCategoriesList()
        {
            var list = new List<string>();
            list.Add(Credit);
            list.Add(PublicService);
            list.Add(Food);
            list.Add(Personal);
            list.Add(Entertainment);
            list.Add(Transport);
            list.Add(Other);

            return list;
        }
    }
}
