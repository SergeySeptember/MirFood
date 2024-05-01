using System.ComponentModel;

namespace Domain
{
    public class MenuItem
    {
        public FirstDishes FirstDishes { get; set; }
        public SecondDishes SecondDishes { get; set; }
        public Drink Drink { get; set; }

        public static MenuItem GetMenu()
        {
            MenuItem menuItems = new()
            {
                    FirstDishes = new()
                    {
                        FirstPosition = new()
                        {
                            Name = "Borsh", IsSelected = false, Description = "Вода, мясо, буряк, лук"
                        },
                        SecondPosition = new()
                        {
                            Name = "Sausege", IsSelected = true, Description = "Мясо"
                        }
                    },
                    SecondDishes = new()
                    {
                        FirstPosition = new()
                        {
                            Name = "Pie", IsSelected = false, Description = "Лук, мясо, зира, грибы, тесто?"
                        },
                        SecondPosition = new()
                        {
                            Name = "Bread", IsSelected = false, Description = "Пшенциа, соль, разрыхрытель"
                        }
                    },
                    Drink = new()
                    {
                        FirstPosition = new()
                        {
                            Name = "Vodka", IsSelected = false
                        },
                        SecondPosition = new()
                        {
                            Name = "Beer", IsSelected = true
                        },
                        ThirdPosition = new()
                        {
                            Name = "Gin", IsSelected = false
                        },
                        FourthPosition = new()
                        {
                            Name = "Water", IsSelected = true
                        }
                    }
            };

            return menuItems;
        }
    }

    public class FirstDishes
    {
        public Dish FirstPosition { get; set; }
        public Dish SecondPosition { get; set; }
    }
    public class SecondDishes
    {
        public Dish FirstPosition { get; set; }
        public Dish SecondPosition { get; set; }
    }
    public class Drink
    {
        public Dish FirstPosition { get; set; }
        public Dish SecondPosition { get; set; }
        public Dish ThirdPosition { get; set; }
        public Dish FourthPosition { get; set; }
    }

    public class Dish
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public string Description { get; set; }
    }
}
