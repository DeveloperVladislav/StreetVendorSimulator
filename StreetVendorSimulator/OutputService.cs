using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetVendorSimulator
{
	public class OutputService
	{
		/// <summary>
		/// Вывод  в  консоль  информацию  о  продукте.
		/// </summary>
		/// <param name="product">Продукт.</param>
		public void DisplayProductInfo(Product product)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Вывод  в  консоль  информацию  о  покупателе.
		/// </summary>
		/// <param name="product">Продукт.</param>
		public void DisplayCustomerInfo(Customer customer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Вывод  в  консоль  информацию  о  складе  (список  продуктов,  количество  каждого  продукта).
		/// </summary>
		/// <param name="product">Склад.</param>
		public void DisplayWarehouseInfo(Warehouse warehouse)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Вывод  в  консоль  текущую  прибыль  продавца.
		/// </summary>
		/// <param name="product">Продавец.</param>
		public void DisplayProfit(TradeManager tradeManager)
		{
			throw new NotImplementedException();
		}
	}
}
