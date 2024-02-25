using System;
using System.ComponentModel.DataAnnotations;

namespace MyScriptures3.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Book { get; set; }
        public string Text { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}