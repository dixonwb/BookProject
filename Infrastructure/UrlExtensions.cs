using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This will be necessary in routing as well as in the json functionality

namespace BookProject.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery (this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }       // If the query string has value, execute the first option : else execute this
}
