using System;
public class Quiz
{
	public static void Main()
	{
		OrderCost costs = new OrderCost
		{
			SubTotal = 100,
			ShippingTotal = 10,
			TotalTax = 1
		};

		if (costs.GrandTotal == 111)
		{
			Console.WriteLine("Order cost is correct");
		}
		else
		{
			Console.WriteLine("Order cost is incorrect");
		}

		Console.WriteLine("\n\nPress Enter to terminate");
		Console.ReadLine();
	}
}

public class OrderCost
{
	private decimal subtotal;
	private decimal _shippingTotal;
	public decimal ShippingTotal
	{
		get
		{
			return _shippingTotal;
		}
		set
		{
			_shippingTotal = value;
		}
	}
	private decimal taxTotal = 0;
	public decimal TotalTax
	{
		get
		{
			return this.taxTotal;
		}
		set
		{
			this.taxTotal = value;
		}
	}
	private decimal subTotal = 0;
	public decimal SubTotal
	{
		get
		{
			return subtotal;
		}
		set
		{
			subtotal = value;
		}
	}
	private decimal grandTotal = 0;
	public decimal GrandTotal
	{
		get
		{
			return subTotal + taxTotal + _shippingTotal;
		}
	}
}
