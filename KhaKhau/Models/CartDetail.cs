﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KhaKhau.Areas.Admin.Models;

namespace KhaKhau.Models
{
	[Table("CartDetail")]
	public class CartDetail
	{
		public int Id { get; set; }
		[Required]
		public int ShoppingCartId { get; set; }
		[Required]
		public int ProductId { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public double UnitPrice { get; set; }
		public Product Product { get; set; }
		public ShoppingCart ShoppingCart { get; set; }
	}
}

