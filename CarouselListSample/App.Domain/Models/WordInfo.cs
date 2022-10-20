using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class WordInfo
    {
        public string Text { get; set; }
        public string OtherForms { get; set; }
        public string Meanig { get; set; }
        public override string ToString() => Text;
    }
}
