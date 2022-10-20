using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
        public override string ToString() => Name;

    }
}
