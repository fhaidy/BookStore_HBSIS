using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BookStore.Application.Controllers
{
    [Route("api/v1/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            try
            {
                return _service.Get();
            }
            catch (Exception)
            {

                throw new Exception("Unable to get books");
            }
        }

        [HttpGet]
        [Route("{id}")]
        public Book Get(int id)
        {
            try
            {
                return _service.Get(id);
            }
            catch (Exception)
            {
                throw new Exception("Unable to get book");
            }
        }

        [HttpPost]
        public Book Post(Book obj)
        {
            try
            {
                return _service.Post(obj);
            }
            catch (Exception)
            {
                throw new Exception("Unable to save book");
            }
        }

        [HttpPut]
        public Book Put(Book obj)
        {
            try
            {
                return _service.Put(obj);
            }
            catch (Exception)
            {
                throw new Exception("Unable to edit book");
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public Book Delete(int id)
        {
            try
            {
                return _service.Delete(id);
            }
            catch (Exception)
            {
                throw new Exception("Unable to remove book");
            }
        }
    }
}
