using api.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{

    public class Book : Item
    {

        private readonly string _isbn;
        private int _weight;
        private string _format;
        private string _title;
        private string _resume;
        private List<Author> _authors = new List<Author>();
        private List<string> _bookGenres = new List<string>();

        public Book(string nom, string image, int prix, long clickNumber, int stock, int priceExcludingTax, int priceWithTax, string isbn, int weight, string format, string title, string resume, List<Author> authors, List<string> bookGenres) : base(nom, image, prix, clickNumber, stock, priceExcludingTax, priceWithTax)
        {
            _isbn = isbn;
            _weight = weight;
            _format = format;
            _title = title;
            _resume = resume;
            _authors = authors;
            _bookGenres = bookGenres;
        }

        public string Isbn => _isbn;

        public int Weight { get => _weight; set => _weight = value; }
        public string Format { get => _format; set => _format = value; }
        public string Title { get => _title; set => _title = value; }
        public string Resume { get => _resume; set => _resume = value; }
        public List<Author> Authors { get => _authors; set => _authors = value; }
        public List<string> BookGenres { get => _bookGenres; set => _bookGenres = value; }
    }

}
