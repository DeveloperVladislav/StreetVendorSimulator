using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetVendorSimulator
{
	public class Customer
	{
		/// <summary>
		/// Количество денег у покупателя.
		/// </summary>
		public int Money { get; set; }

		/// <summary>
		/// Список названий продуктов, которые хочет купить покупатель. 
		/// </summary>
		public List<string>? ShoppingList { get; set; }

		public Customer(int money, List<string> shoppingsList)
		{
			Money = money;
			ShoppingList = shoppingsList;
		}


		/// <summary>
		/// Покупка продуктов.
		/// </summary>
		/// <param name="product">Продукт.</param>
		/// <param name="quantity">Количество.</param>
		public bool BuyProduct(Product product, int quantity)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Добавление продукта.
		/// </summary>
		/// <param name="productName">Название продукта.</param>
		public void AddProductToShoppingList(string productName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Создание случайного списка покупок для покупателя с учетом его бюджета.
		/// </summary>
		public void GenerateRandomShoppingList()
		{
			throw new NotImplementedException();
		}




	}
}
