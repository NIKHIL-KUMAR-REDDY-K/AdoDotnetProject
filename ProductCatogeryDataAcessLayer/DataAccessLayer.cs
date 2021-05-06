using ProductCatogeryEntityLater;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProductCatogeryDataAcessLayer
{
   public class DataAccessLayer
    {
        SqlConnection sqlcon = new SqlConnection("Integrated Security = SSPI;" + "Initial catalog=ProductCatagoryDatabase;" + "Data Source=localhost;");
        public  bool InsertingValuesIntoCategoryTable(Category c)
        {
            SqlCommand cmd = new SqlCommand("insert into Category values ('" + c.categoryId + "','" + c.catogoryName + "')", sqlcon);
            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(DataMisalignedException )
            {
                throw new DataMisalignedException();
            }
            catch(Exception e )
            {
                Console.WriteLine(e.Message);
                throw new Exception();
            }
            finally
            {
                sqlcon.Close();
            }
            
        }

        public bool InsertingValuesIntoProductTable(Product p)
        {
            SqlCommand cmd = new SqlCommand("insert into Product values ('" + p.productId + "','" + p.productName + "','" + p.price+ "','" + p.categoryId+ "')", sqlcon);
            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (DataMisalignedException)
            {
                throw new DataMisalignedException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception();
            }
            finally
            {
                sqlcon.Close();
            }

        }
        public List<string> RetriveDataFromTheCategoryTable()
        {
            List<string> li = new List<string>();
            SqlCommand cmd = new SqlCommand("select * from Category", sqlcon);
            try
            {
                sqlcon.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string s = sdr["CatagoryId"] + "                " + sdr["CategoryName"];
                    li.Add(s);
                }
                sdr.Close();
                return li;
                
            }
        
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception();
            }
            finally
            {
               
                sqlcon.Close();
            }

        }
    }
}
