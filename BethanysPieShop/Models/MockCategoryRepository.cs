﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Model
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category> {
            new Category{CategoryId = 1, CategoryName="Fruit pies", Description = "All-fruity pies"},
            new Category{ CategoryId = 2, CategoryName="Cheese Cakes", Description ="Cheesay all the way"}, 
            new Category{ CategoryId=3, CategoryName="Seasonal Pies", Description="Get in the mood for a seasonal pie"}
            };
    }
}
