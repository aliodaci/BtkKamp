using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _con = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()//Method
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Select * from Products", _con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }
            reader.Close();
            _con.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("insert into products values(@txtName,@txtUnitPrice,@txtStockAmount)", _con);
            cmd.Parameters.AddWithValue("@txtName", product.Name);
            cmd.Parameters.AddWithValue("@txtUnitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@txtStockAmount", product.StockAmount);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("update products set Name=@txtName,UnitPrice=@txtUnitPrice,StockAmount=@txtStockAmount where Id=@Id", _con);
            cmd.Parameters.AddWithValue("@txtName", product.Name);
            cmd.Parameters.AddWithValue("@txtUnitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@txtStockAmount", product.StockAmount);
            cmd.Parameters.AddWithValue("@Id", product.Id);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("delete from Products where Id=@Id ", _con);
            cmd.Parameters.AddWithValue("@Id",Id);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        /* public DataTable GetAll2()//Method
         {

             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }

             SqlCommand cmd = new SqlCommand("Select * from Products", con);
             SqlDataReader reader = cmd.ExecuteReader();
             DataTable dataTable = new DataTable();
             dataTable.Load(reader);
             reader.Close();
             con.Close();
             return dataTable;
         }*/
    }
}
