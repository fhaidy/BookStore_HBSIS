using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BookStore.Application.Controllers
{
    [Route("api/v1/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;
        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            try
            {
                return _service.Get();
            }
            catch (Exception)
            {

                throw new Exception("Unable to get authors");
            }
        }

        [HttpGet]
        [Route("{id}")]
        public Author Get(int id)
        {
            try
            {
                return _service.Get(id);
            }
            catch (Exception)
            {
                throw new Exception("Unable to get author");
            }
        }

        [HttpPost]
        public Author Post(Author obj)
        {
            try
            {
                return _service.Post(obj);
            }
            catch (Exception)
            {
                throw new Exception("Unable to save author");
            }
        }

        [HttpPut]
        public Author Put(Author obj)
        {
            try
            {
                return _service.Put(obj);
            }
            catch (Exception)
            {
                throw new Exception("Unable to edit author");
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public Author Delete(int id)
        {
            try
            {
                return _service.Delete(id);
            }
            catch (Exception)
            {
                throw new Exception("Unable to remove author");
            }
        }
    }
}
