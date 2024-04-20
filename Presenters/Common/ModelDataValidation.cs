﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters.Common
{
    internal class ModelDataValidation
    {
       
            [DisplayName("Pay Mode Nam")]
            [Required(ErrorMessage = "Pay mode name is required")]
            [StringLength(50, MinimumLength = 3,
                ErrorMessage = "Pay mode name must be between 3 and 50 characters")]

            public string Name { get; set; }

            public void Validate(object model)
            {
                string errorMessage = "";
                List<ValidationResult> validationResults = new List<ValidationResult>();
                ValidationContext validationContext = new ValidationContext(model);
                bool isValid = Validator.TryValidateObject(
                    model, validationContext, validationResults, true);
                if (isValid == false)
                {
                    foreach (var item in validationResults)
                    {
                        errorMessage += item.ErrorMessage + "\n";
                    }
                    throw new Exception(errorMessage);
                }
            }
        }

    public class ProductModelValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (ProductModel)validationContext.ObjectInstance;

            if (product.CategoryId == 0)
            {
                return new ValidationResult("Category is required");
            }

            if (product.ProviderId == 0)
            {
                return new ValidationResult("Provider is required");
            }

            return ValidationResult.Success;
        }
    }
}


