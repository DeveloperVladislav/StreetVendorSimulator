using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StreetVendorSimulator
{
	public class Customer
	{
		public Random? Random { get; set; } = new Random();
		/// <summary>
		/// Количество денег у покупателя.
		/// </summary>
		public decimal Money { get; set; }

		/// <summary>
		/// Список названий продуктов, которые хочет купить покупатель. 
		/// </summary>
		public List<string>? ShoppingList { get; set; }

		public Customer(int money)
		{
			Money = money;
			ShoppingList = new List<string>();
		}


		/// <summary>
		/// Покупка продуктов.
		/// </summary>
		/// <param name="product">Продукт.</param>
		/// <param name="quantity">Количество.</param>
		public bool BuyProduct(Product product, int quantity)
		{
			if (Money >= product.Price)
			{
				if (quantity <= product.Quantity)
				{
					Money = -product.Price * quantity;

					product.Quantity -= quantity;

					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Добавление продукта.
		/// </summary>
		/// <param name="productName">Название продукта.</param>
		public void AddProductsToShoppingList()
		{

			throw new NotImplementedException();
		}

		/// <summary>
		/// Создание случайного списка покупок для покупателя С УЧЁТОМ БЮДЖЕТА ПОКУПАТЕЛЯ.
		/// </summary>
		public void GenerateRandomShoppingList()
		{
			int productCount = Random.Next(3, 10);
			decimal currentBudget = Money;

			List<Product> products = new List<Product>()
			{
				new Product("Apple", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Milk", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Bread", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Cheese", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Banana", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Candy", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Juice", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Potato", Random.Next(1, 10),Random.Next(1, 10)),
				new Product("Cucumber", Random.Next(1, 10),Random.Next(1, 10)),
			};

			List<string> addedProducts = new List<string>();

			while (ShoppingList.Count < productCount)
			{
				int randomIndex = Random.Next(products.Count);
				string productName = products[randomIndex].Name;
				if (!addedProducts.Contains(productName))
				{
					ShoppingList.Add(productName);
					addedProducts.Add(productName);
				}
			}

		}




	}
}
