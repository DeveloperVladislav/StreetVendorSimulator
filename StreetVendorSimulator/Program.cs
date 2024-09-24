using System;

namespace StreetVendorSimulator
{
	public class Program
	{
		static void Main(string[] args)
		{
			RandomService randomService = new RandomService();
			OutputService outputService = new OutputService();

			List<Product> products = new List<Product>()
			{
				new Product("Apple", randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(), randomService.GenerateRandomProductSpoilage()),
				new Product("Orange",randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(),randomService.GenerateRandomProductSpoilage()),
				new Product("Banana",randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(),randomService.GenerateRandomProductSpoilage()),
				new Product("Cucumber",randomService.GenerateRandomPrice(), randomService.GenerateRandomProductQuantity(), randomService.GenerateRandomProductSpoilage()),
				new Product("Tomato",randomService.GenerateRandomPrice(), randomService.GenerateRandomProductQuantity(), randomService.GenerateRandomProductSpoilage()),
				new Product("Potato",randomService.GenerateRandomPrice(),randomService.GenerateRandomProductQuantity(),randomService.GenerateRandomProductSpoilage())
			};
			Warehouse warehouse = new Warehouse()
			{

			};
			TradeManager tradeManager = new TradeManager();

			List<string> shoppingList = new List<string>();

			Console.WriteLine("Введите продукты (введите 'стоп' для завершения):");
			string? product = "";
			while (product != "стоп")
			{
				product = Console.ReadLine();
				if (product != "стоп")
				{
					shoppingList.Add(product);
				}
			}

			Customer customer = new Customer(randomService.GenerateRandomCustomerBudget(), shoppingList);	
			
			foreach(var list in products)
			{
				outputService.DisplayProductInfo(list);
				Console.WriteLine();
			}
			
			Console.WriteLine();

			outputService.DisplayCustomerInfo(customer);
		

		
		}
	}
}