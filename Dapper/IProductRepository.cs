using System;
using System.Collections.Generic;

namespace Dapper
{
	public interface IProductRepository
	{
        public IEnumerable<Product> GetAllProducts();

    }
}

