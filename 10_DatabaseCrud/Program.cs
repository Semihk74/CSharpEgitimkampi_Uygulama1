using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create, Read, Update, Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------");

            #region Kategori ekleme işlemi

            //Console.Write("Eklemek İstediğiniz Kategory Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-M53BHBB\\SQLEXPRESS02;initial catalog=EgitimKampi;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Ekleme İşlemi Başarıyla Gerçekleşti.");
            #endregion

            #region ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-M53BHBB\\SQLEXPRESS02;initial catalog=EgitimKampi;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName, ProductPrice,productStatus) values (@productName, @productPrice,@prodcutStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@prodcutStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün Ekleme İşlemi Başarıyla Gerçekleşti.");

            #endregion

            #region Ürün Listelem İşlemi

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-M53BHBB\\SQLEXPRESS02;initial catalog=EgitimKampi;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable datatable = new DataTable();
            //adapter.Fill(datatable);

            //foreach(DataRow row in datatable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + "  ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data SOurce = DESKTOP-M53BHBB\\SQLEXPRESS02;initial catalog=EgitimKampi;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue ("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Silme işlemi başarıyla gerçekleşti.");



            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenecek ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-M53BHBB\\SQLEXPRESS02;initial catalog=EgitimKampi;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");

            #endregion




            Console.Read();

        }
    }
}
