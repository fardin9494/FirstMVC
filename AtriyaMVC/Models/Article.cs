using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtriyaMVC.Models
{
    public class Article : IEnumerable
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Client { get; set; }

        public Article(int id, string title, string description, string photo, string client)
        {
            Id = id;
            Title = title;
            Description = description;
            Photo = photo;
            Client = client;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
