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
		public void GenerateRandomPrice()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Генерация  случайного бюджета  для  покупателя.
		/// </summary>
		public void GenerateRandomCustomerBudget()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Генерация  случайного  количества  продукта  на  складе. 
		/// </summary>
		public void GenerateRandomProductQuantity()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Генерирация  случайного  шанса,  что  продукт  испорчен  (например,  вероятность  10%).
		/// </summary>
		public void GenerateRandomProductSpoilage()
		{
			throw new NotImplementedException();
		}
	}
}
