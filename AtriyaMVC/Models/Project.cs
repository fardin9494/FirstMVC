using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtriyaMVC.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client  { get; set; }

        public Project(int id, string title, string description, string image, string client)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}
