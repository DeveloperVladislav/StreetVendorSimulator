using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StreetVendorSimulator
{
	public class Product
	{
		/// <summary>
		/// Название продукта.
		/// </summary>
		public string? Name { get; set; }

		/// <summary>
		/// Стоимость продукта.
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Количество продукта в наличии на данный момент.
		/// </summary>
		public int Quantity { get; set; }

		/// <summary>
		/// Флаг, указывающий, испорчен ли продукт.
		/// </summary>
		public bool IsSpoiled { get; set; }

		/// <summary>
		/// Уменьшение количества продукта.
		/// </summary>
		/// <param name="amount">Еденица.</param>
		/// 

		public Product(string name, decimal price, int quantity, bool isSpoiled)
		{
			Name = name;
			Price = price;
			Quantity = quantity;
			IsSpoiled = isSpoiled;
		}


		public bool DecreaseQuantity(int amount)
		{
			if (Quantity < amount)
			{
				return false;
			}

			Quantity = -amount;
			return true;
		}

		/// <summary>
		/// Изменяет цену продукта.
		/// </summary>
		/// <param name="newPrice">Новая цена.</param>
		public bool ChangePrice(decimal newPrice)
		{
			if (newPrice > 0)
			{
				return false;
			}
			Price = newPrice;

			return true;
		}

	}
}
