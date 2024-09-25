using System;

namespace StreetVendorSimulator
{
	public class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			RandomService randomService = new RandomService();
			OutputService outputService = new OutputService();
			TradeManager tradeManager = new TradeManager();

			List<Product> products = new List<Product>()
			{
				new Product("Apple", randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(), randomService.GenerateRandomProductSpoilage()),
				new Product("Orange",randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(),randomService.GenerateRandomProductSpoilage()),
				new Product("Banana",randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(),randomService.GenerateRandomProductSpoilage()),
				new Product("Cucumber",randomService.GenerateRandomPrice(), randomService.GenerateRandomProductQuantity(), randomService.GenerateRandomProductSpoilage()),
				new Product("Tomato",randomService.GenerateRandomPrice(), randomService.GenerateRandomProductQuantity(), randomService.GenerateRandomProductSpoilage()),
				new Product("Potato",randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(),randomService.GenerateRandomProductSpoilage())
			};

			Warehouse warehouse = new Warehouse(products);
			outputService.DisplayWarehouseInfo(warehouse);

			Customer customer = new Customer(randomService.GenerateRandomCustomerBudget());
			customer.GenerateRandomShoppingList();
			outputService.DisplayCustomerInfo(customer);
			int choiceProduct = random.Next(0, 5);
			int choiceQuantity = random.Next(1, randomService.GenerateRandomProductQuantity());
			customer.BuyProduct(products[choiceProduct], choiceQuantity);
			outputService.BuyProductInfo(products[choiceProduct], choiceQuantity);

			outputService.DisplayWarehouseInfo(warehouse);





			Console.WriteLine();

		

		
		}
	}
}