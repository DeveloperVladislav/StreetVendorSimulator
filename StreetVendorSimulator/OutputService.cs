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
			Console.WriteLine("-ProductInfo-");
			Console.WriteLine($"Name - {product.Name}\nPrice - {product.Price}\nQuantity - {product.Quantity}\nIsSpoiled - {product.IsSpoiled}");
		}

		/// <summary>
		/// Вывод  в  консоль  информацию  о  покупателе.
		/// </summary>
		/// <param name="product">Продукт.</param>
		public void DisplayCustomerInfo(Customer customer)
		{
			Console.WriteLine("-CustomerInfo-");
			Console.WriteLine($"Money = {customer.Money}\nListProducts:");
			foreach(var list in customer.ShoppingList)
			{
				Console.WriteLine($"- {list}");
			}
		}

		/// <summary>
		/// Вывод  в  консоль  информацию  о  складе  (список  продуктов,  количество  каждого  продукта).
		/// </summary>
		/// <param name="product">Склад.</param>
		public void DisplayWarehouseInfo(Warehouse warehouse)
		{
			Console.WriteLine("-WarehouseInfo-");
			Console.WriteLine($"Products - {warehouse.Products}");
		}

		/// <summary>
		/// Вывод  в  консоль  текущую  прибыль  продавца.
		/// </summary>
		/// <param name="product">Продавец.</param>
		public void DisplayProfitInfo(TradeManager tradeManager)
		{
			Console.WriteLine("-ProfitInfo-");
			Console.WriteLine($"CurrentProfit - {tradeManager.CurrentProfit}");
		}
	}
}
