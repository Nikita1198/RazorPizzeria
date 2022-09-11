using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTile="Margerita", 
                PizzaName="Margerita", 
                BasePrice=2,
                TomatoSouse=true,
                Cheese=true, 
                FinalePrice=4
            },
              new PizzasModel(){
                ImageTile="Bolognese",
                PizzaName="Bolognese",
                BasePrice=1,
                TomatoSouse=true,
                Cheese=true,
                FinalePrice=3
            },
              new PizzasModel(){
                ImageTile="Carbonara",
                PizzaName="Carbonara",
                BasePrice=4,
                TomatoSouse=true,
                Cheese=true,
                FinalePrice=8
            },
              new PizzasModel(){
                ImageTile="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=5,
                TomatoSouse=true,
                Cheese=true,
                Pineapple=true,
                FinalePrice=10
            },
              new PizzasModel(){
                ImageTile="Mushroom",
                PizzaName="Mushroom",
                BasePrice=3,
                TomatoSouse=true,
                Cheese=true,
                Ham = true,
                Mushroom=true,
                FinalePrice=6
            },
              new PizzasModel(){
                ImageTile="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSouse=true,
                Cheese=true,
                Peperoni=true,
                FinalePrice=5
            },
              new PizzasModel(){
                ImageTile="Seafood",
                PizzaName="Seafood",
                BasePrice=5,
                TomatoSouse=true,
                Cheese=true,
                Tuna = true,
                FinalePrice=10
            },
              new PizzasModel(){
                ImageTile="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=1,
                TomatoSouse=true,
                FinalePrice=2
            },
               new PizzasModel(){
                ImageTile="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSouse=true,
                Cheese=true,
                FinalePrice=4
            }


        };
        public void OnGet()
        {
        }
    }
}
