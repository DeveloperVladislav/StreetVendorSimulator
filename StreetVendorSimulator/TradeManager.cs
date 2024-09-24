using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetVendorSimulator
{
	public class TradeManager
	{
		/// <summary>
		/// Склад.
		/// </summary>
		public Warehouse? Warehouse { get; set; }

		/// <summary>
		///  Текущая  прибыль  продавца.
		/// </summary>
		public decimal CurrentProfit { get; set; }

		/// <summary>
		/// Обрабатка заказа покупателя.
		/// </summary>
		/// <param name="customer">Покупатель.</param>
		public bool ProcessCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Возврат текущей  прибыли  продавца. 
		/// </summary>
		public decimal CalculateProfit()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Обновление  количества  продуктов  на  складе  после  продаж.
		/// </summary>
		public void UpdateStock()
		{
			//(возможно  использовать  Warehouse.CheckStock  и  Warehouse.RemoveProduct). 
			throw new NotImplementedException();
		}




	}
}
