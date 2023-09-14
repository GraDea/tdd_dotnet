using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;

namespace TddReference.WebAPI.Domain
{
    public class Library
    {
        public List<Reader> Readers { get; set; }
        public bool IsClosed { get; set; }

        public Library()
        {
            Readers = new List<Reader>();
            IsClosed = true;
        }
    }
}