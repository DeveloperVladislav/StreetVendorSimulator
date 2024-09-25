using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetVendorSimulator
{
	public class RandomService
	{
		/// <summary>
		/// Псевдо-генератор.
		/// </summary>
		public Random? Random { get; set; } = new Random();

		/// <summary>
		/// Генерация  случайной  цены  для  продукта.
		/// </summary>
		public decimal GenerateRandomPrice()
		{
			decimal randomPrice = (decimal)Random.NextDouble() * 10;
			return Math.Round(randomPrice, 2);
		}

		/// <summary>
		/// Генерация  случайного бюджета  для  покупателя. 
		/// </summary>
		public int GenerateRandomCustomerBudget()
		{
			int randomBudget = Random.Next(1000);
			return randomBudget;
		}

		/// <summary>
		/// Генерация  случайного  количества  продукта  на  складе. 
		/// </summary>
		public int GenerateRandomProductQuantity()
		{
			int randomQuantity = Random.Next(1,100);
			return randomQuantity;
		}

		/// <summary>
		/// Генерирация  случайного  шанса,  что  продукт  испорчен  (например,  вероятность  10%).
		/// </summary>
		public bool GenerateRandomProductSpoilage()
		{
			int randomProductSpoilage = Random.Next(100);
			return randomProductSpoilage < 10;
		}


		
	}
}
