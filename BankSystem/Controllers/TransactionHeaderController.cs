using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;

namespace BankSystem.Controllers
{
    public class TransactionHeaderController : ApiController
    {
        private SqlConnection con;

        public TransactionHeaderController()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        protected override void Dispose(bool disposing)
        {
            con.Dispose();
        }

        public IHttpActionResult GetTransectionHeader()
        {
            SqlCommand cmd = new SqlCommand("USP_Get_transpresentmentHeader", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            List<TransPresentmentHeader> presentmentHeaders = new List<TransPresentmentHeader>();
            con.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                presentmentHeaders.Add(
                    new TransPresentmentHeader(reader[0],
                                               reader[1],
                                               reader[2],
                                               reader[3],
                                               reader[4],
                                               reader[5],
                                               reader[6],
                                               reader[7]));
            }
            con.Close();

            return Ok(presentmentHeaders);
        }

        [HttpPost]
        public IHttpActionResult CreateTransectionHeader(TransPresentmentHeader presentmentHeader)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            //SqlCommand cmd = new SqlCommand("USP_Get_Rows_tbltranspresentmentHeader", con)
            //{
            //    CommandType = CommandType.StoredProcedure
            //};
            //con.Open();
            //var rows=cmd.ExecuteReader();
            //rows.Read();
            //string FileNo = "ACH-DR-KKBK-HERONACH-" + String.Format("{0:ddMMMyyyy}", DateTime.Now) +"-0000000" +(Convert.ToInt64(rows[0])+1) + "-INP";

            //cmd.Dispose();
            //con.Close();
            //con.Open();
            //cmd = new SqlCommand("USP_Create_transpresentmentHeader", con)
            //{
            //    CommandType = CommandType.StoredProcedure
            //};


            //cmd.Parameters.AddWithValue("@FileNo",FileNo);
            //cmd.Parameters.AddWithValue("@Date", presentmentHeader.Date);
            //cmd.Parameters.AddWithValue("@BankName", presentmentHeader.BankName);
            //cmd.Parameters.AddWithValue("@IsActive", presentmentHeader.IsActive);
            //cmd.Parameters.AddWithValue("@IsDeleted", presentmentHeader.IsDeleted);
            //cmd.Parameters.AddWithValue("@PresentmentHeaderNo", presentmentHeader.PresentmentHeaderNo);

            //cmd.ExecuteNonQuery();

            //con.Close();
            SqlCommand cmd = new SqlCommand("USP_Create_transpresentmentHeader", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            con.Open();
            cmd.Parameters.AddWithValue("@Date", presentmentHeader.Date);
            cmd.Parameters.AddWithValue("@BankName", presentmentHeader.BankName);
            cmd.Parameters.AddWithValue("@IsActive", presentmentHeader.IsActive);
            cmd.Parameters.AddWithValue("@IsDeleted", presentmentHeader.IsDeleted);
            cmd.Parameters.AddWithValue("@PresentmentHeaderNo", presentmentHeader.PresentmentHeaderNo);
            cmd.ExecuteNonQuery();

            con.Close();
            return Ok();
        }
    }
}
