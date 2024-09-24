using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetVendorSimulator
{
	public class Warehouse
	{
		/// <summary>
		/// Список продуктов, хранящихся на складе. 
		/// </summary>
		public List<Product>? Products { get; set; }

		/// <summary>
		/// Добавление на склад продуктов. 
		/// </summary>
		/// <param name="product">Еденица продукта.</param>
		/// <param name="quantity">Количество продуктов.</param>
		public void Restock(Product product, int quantity)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Возвращение количества продукта на склад. 
		/// </summary>
		/// <param name="productName">Имя продукта.</param>
		public void CheckStock(string productName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Удаление продукта со склада.
		/// </summary>
		/// <param name="productName">Имя продукта.</param>
		/// <param name="amount">Количество продукта.</param>
		public void RemoveProduct(string productName, int amount)
		{
			throw new NotImplementedException();
		}


	}
}
