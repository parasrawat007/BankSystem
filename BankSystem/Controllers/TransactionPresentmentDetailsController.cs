using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankSystem.Controllers
{
    public class TransactionPresentmentDetailsController : ApiController
    {
        private SqlConnection con;

        public TransactionPresentmentDetailsController()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        protected override void Dispose(bool disposing)
        {
            con.Dispose();
        }

        //public IHttpActionResult GetTransectionHeader()
        //{
        //    SqlCommand cmd = new SqlCommand("USP_Get_transpresentmentHeader", con)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };
        //    List<TransactionPresentmentDetail> presentmentHeaders = new List<TransactionPresentmentDetail>();
        //    con.Open();
        //    var reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        presentmentHeaders.Add(
        //            new TransactionPresentmentDetail(reader[0],
        //                                       reader[1],
        //                                       reader[2],
        //                                       reader[3],
        //                                       reader[4],
        //                                       reader[5],
        //                                       reader[6],
        //                                       reader[7]));
        //    }
        //    con.Close();

        //    return Ok(presentmentHeaders);
        //}

        [HttpPost]
        public IHttpActionResult CreateTransectionHeader(TransactionPresentmentDetail presentmentDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
                       
            SqlCommand cmd = new SqlCommand("", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            con.Open();
            cmd.Parameters.AddWithValue("@Amount", presentmentDetail.Amount);

            cmd.ExecuteNonQuery();

            con.Close();
            return Ok();
        }
    }
}
