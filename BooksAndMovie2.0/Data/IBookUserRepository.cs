﻿using BooksAndMovie.Model;
using BooksAndMovie2._0.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAndMovie2._0.Data
{
    public interface IBookUserRepository
    {
        public void AddBook(int id, Book book, int? _rating);
        public IList<BookUser> ReadBooks();
        public void RemoveBook(int id, Book book);
        public void ChangeRating(int id, Book book, int? _rating);


    }
}