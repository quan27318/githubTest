using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mid_Assignment.Models;
using Mid_Assignment.Service;

namespace Mid_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _iBook;
        public BookController(IBook ibook)
        {
            _iBook = ibook;
        }
        

        [HttpGet]
        public List<Book> GetBooks(){
            return _iBook.GetAllBooks();
        }
        
    }
    }

        