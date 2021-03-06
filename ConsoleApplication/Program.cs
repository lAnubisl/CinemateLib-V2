﻿using System;
using System.Linq;
using CinemateAPI;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string passkey = "XXXXXXXX"; // http://cinemate.cc/preferences/#api

            var api = new CinemateLib(passkey)
                          {ApiKey = "9ea8780481b19c151ec3b9d8d983c9a804b70218"};

            var movies = api.GetMovieList(DateTime.Now.AddMonths(-1), DateTime.Now, 1, 10, null, null,
                                          OrderBy.CreateDate, false);

            var movie = api.GetMovieInfo(movies.Movies.First().Id);

            var movieSearch = api.SearchMovie("Пираты");

            var profile = api.GetProfile();

            var stats = api.GetStats();

            var updates = api.GetUpdatelist();

            var watches = api.GetWatchlist();

            var persons = api.SearchPerson("Боб");

            var person = api.GetPersonInfo(persons.Persons.First().Id);
        }
    }
}