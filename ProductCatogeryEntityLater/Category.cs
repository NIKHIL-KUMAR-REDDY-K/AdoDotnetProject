using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatogeryEntityLater
{
    public class Category
    {
        public int categoryId;
        public string catogoryName;
        public Category()
        {

        }

        public Category(int categoryId, string catogoryName)
        {
            this.categoryId = categoryId;
            this.catogoryName = catogoryName;
        }
    }
}
