using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BookStore.Application.Controllers
{
    [Route("api/v1/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _service;
        public GenreController(IGenreService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Genre> Get()
        {
            try
            {
                return _service.Get();
            }
            catch (Exception)
            {

                throw new Exception("Unable to get genres");
            }
        }

        [HttpGet]
        [Route("{id}")]
        public Genre Get(int id)
        {
            try
            {
                return _service.Get(id);
            }
            catch (Exception)
            {
                throw new Exception("Unable to get genre");
            }
        }

        [HttpPost]
        public Genre Post(Genre obj)
        {
            try
            {
                return _service.Post(obj);
            }
            catch (Exception)
            {
                throw new Exception("Unable to save genre");
            }
        }

        [HttpPut]
        public Genre Put(Genre obj)
        {
            try
            {
                return _service.Put(obj);
            }
            catch (Exception)
            {
                throw new Exception("Unable to edit genre");
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public Genre Delete(int id)
        {
            try
            {
                return _service.Delete(id);
            }
            catch (Exception)
            {
                throw new Exception("Unable to remove genre");
            }
        }
    }
}
