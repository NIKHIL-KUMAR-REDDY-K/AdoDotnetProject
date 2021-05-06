using ProductCatogeryDataAcessLayer;
using ProductCatogeryEntityLater;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCategoryBusinessLogicLayer
{
   public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public bool SendInputsToCatogeryTableToInsert(Category c)
        {
            try
            {
                return dal.InsertingValuesIntoCategoryTable(c);
            }
            catch (Exception e)
            {
                
                throw new Exception();
            }

        }
        public bool SendInputsToProductTableToInsert(Product p)
        {
            try
            {
                return dal.InsertingValuesIntoProductTable(p);
            }
            catch (Exception e)
            {

                throw new Exception();
            }

        }
        public List<string> GetDataFromCatogeryTable()
        {
            try
            {
                return dal.RetriveDataFromTheCategoryTable();
            }
            catch (Exception )
            {

                throw new Exception();
            }

        }
    }
}
