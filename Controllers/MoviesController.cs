﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using AndrewsApi.Core;
using AndrewsApi.Models;

namespace AndrewsApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [AllowCrossSite]
    public class MoviesController : ApiController
    {
       
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Movies
        
        public IHttpActionResult Get()
        {
            var movies = db.Movies.ToList();
            return Ok(movies);
        }

        // GET: api/Movies/5
        [ResponseType(typeof(Movies))]
        public IHttpActionResult GetMovies(int id)
        {
            Movies movies = db.Movies.Find(id);
            if (movies == null)
            {
                return NotFound();
            }

            return Ok(movies);
        }

        // PUT: api/Movies/5
        [HttpGet]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMovies(int id, Movies movies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movies.id)
            {
                return BadRequest();
            }

            db.Entry(movies).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoviesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Movies
        [ResponseType(typeof(Movies))]
        public IHttpActionResult PostMovies(Movies postmovies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var movies = new Movies();
            movies.Title = postmovies.Title;
            movies.Genre = postmovies.Genre;
            movies.DirectorName = postmovies.DirectorName;
            db.Movies.Add(movies);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = movies.id }, movies);
        }

        // DELETE: api/Movies/5
        [ResponseType(typeof(Movies))]
        public IHttpActionResult DeleteMovies(int id)
        {
            Movies movies = db.Movies.Find(id);
            if (movies == null)
            {
                return NotFound();
            }

            db.Movies.Remove(movies);
            db.SaveChanges();

            return Ok(movies);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MoviesExists(int id)
        {
            return db.Movies.Count(e => e.id == id) > 0;
        }
    }
}