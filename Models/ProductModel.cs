﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product ID")]
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is necessary")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 100 characters")]
        public string ProductName { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "Category is necessary")]
        public int CategoryId { get; set; }

        [DisplayName("Provider")]
        [Required(ErrorMessage = "Provider is necessary")]
        public int ProviderId { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Price can't be a negative number")]
        public decimal Price { get; set; }

        [DisplayName("Stock Quantity")]
        [Required(ErrorMessage = "Stock quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity have to be a positive number")]
        public int StockQuantity { get; set; }
    }
}