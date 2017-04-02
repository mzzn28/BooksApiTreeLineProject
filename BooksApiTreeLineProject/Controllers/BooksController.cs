using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using BooksApiTreeLineProject.Models;
using BooksApiTreeLineProject.dto;


namespace BooksApiTreeLineProject.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values
        public IEnumerable<Book> Get()
        {
            //make the books objects 
            myDto dataObj = new myDto();
            List<Book> bookslist= dataObj.makedata(); 

            //JavaScriptSerializer jsSerializerBook = new JavaScriptSerializer();
            //string JSONBooks = jsSerializerBook.Serialize(bookslist);


            return bookslist;
        }

    }
}
