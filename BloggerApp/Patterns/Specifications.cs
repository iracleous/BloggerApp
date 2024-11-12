using BlogDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns;

public class PriceSpecification : Specification<Product>
{
    private readonly decimal _minPrice;
    private readonly decimal _maxPrice;

    public PriceSpecification(decimal minPrice, decimal maxPrice)
    {
        _minPrice = minPrice;
        _maxPrice = maxPrice;
    }

    public override bool IsSatisfiedBy(Product product)
    {
        return product.Price >= _minPrice && product.Price <= _maxPrice;
    }
}


public class CategorySpecification : Specification<Product>
{
    private readonly string _category;

    public CategorySpecification(string category)
    {
        _category = category;
    }

    public override bool IsSatisfiedBy(Product product)
    {
        //if( product != null && product.Category != null )
        // return   product.Category.Equals(_category, StringComparison.OrdinalIgnoreCase) 
        // return false;

        return product != null && product.Category != null?
            product.Category.Equals(_category, StringComparison.OrdinalIgnoreCase): false;
    }
}