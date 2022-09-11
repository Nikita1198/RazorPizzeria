namespace RazorPizzeria.Models
{
    //for midration this class to ower DataBase we need to write in NuGet consol migration script:
    //     add-migration addedPizzaOrder

    public class PizzaOrder
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
    }
}
