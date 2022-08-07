using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.Model.Seeds
{
    public static class ApplicationContextExtension
    {
        public static void Seed(this ApplicationContext context)
        {
            var sushi = new Category { Name = "Суши" };
            var pizza = new Category { Name = "Пицца" };
            var burger = new Category { Name = "Бургеры" };
            var coffee = new Category { Name = "Кофе" };
            var shaurma = new Category { Name = "Шаурма" };
            var dessert = new Category { Name = "Десерты" };
            context.Categories.AddRange(sushi, pizza, burger, coffee, shaurma, dessert);
            context.SaveChanges();
            context.Restaurants.AddRange(new Restaurant[] {
                new Restaurant{Name="Лакомка", Adress="ул. Белова 2" , Categories=new List<Category>{ dessert } },
                new Restaurant{Name="Шаверма", Adress="Железнодорожная 50", Categories=new List<Category>{ shaurma } },
                new Restaurant{Name="Лаваш", Adress="ул. Брестская 19", Categories=new List<Category>{ shaurma } },
                new Restaurant{Name="Перец", Adress="Торговый комплекс, ул. Карла Маркса 29", Categories=new List<Category>{ shaurma } },
                new Restaurant{Name="Капибара", Adress="ул. Первомайская 55; ул. Гайдаенко 102", Categories=new List<Category>{ sushi } },
                new Restaurant{Name="Три кита", Adress="ул. Первомайская 24", Categories=new List<Category>{ sushi } },
                new Restaurant{Name="Крутим-Вертим", Adress="ул. Рокоссовского 23д", Categories=new List<Category>{ sushi, pizza } },
                new Restaurant{Name="PizzaStation", Adress="ул. Иркутско-Пинской Дивизии 31", Categories=new List<Category>{ sushi, pizza, dessert } },
                new Restaurant{Name="Пицца Итальяна", Adress="ул. Коржа 12", Categories=new List<Category>{ pizza , shaurma } },
                new Restaurant{Name="Фуд Юнион", Adress="ул. Ленина 26", Categories=new List<Category>{ pizza, burger, coffee, shaurma, dessert } },
                new Restaurant{Name="Паб Уинстон Черчилль", Adress="ул. Ленина 32", Categories=new List<Category>{ pizza , burger } },
                new Restaurant{Name="KFC", Adress="ул. Брестская 37; ул. Железнодорожная 56; ул. Партизанская 42", Categories=new List<Category>{ burger } },
                new Restaurant{Name="МуМо", Adress="ул. Ленина 2-4", Categories=new List<Category>{ burger } },
                new Restaurant{Name="Обжора", Adress="ул. Иркутско-Пинской Дивизии 36", Categories=new List<Category>{ burger } },
                new Restaurant{Name="Молоко", Adress="ул. Первомайская 26", Categories=new List<Category>{ coffee, dessert } },
                new Restaurant{Name="Paragraph", Adress="ул. Ленина 2", Categories=new List<Category>{ coffee, dessert } },
                new Restaurant{Name="Зефир", Adress="пл. Ленина 7/1", Categories=new List<Category>{ coffee, dessert } },
                new Restaurant{Name="Золотой Колос", Adress="ул. Ленина 22", Categories=new List<Category>{ coffee } },
                new Restaurant{Name="Sushi Fighter", Adress="ул. Рокоссовского 4В", Categories=new List<Category>{ sushi } },
            });
            context.SaveChanges();
        }
    }
}
