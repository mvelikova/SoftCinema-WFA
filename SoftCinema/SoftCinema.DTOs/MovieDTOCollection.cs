﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [XmlRoot("MoviesCollection")]
    public class MovieDTOCollection
    {
        public MovieDTOCollection()
        {
            this.MovieDTOs = new List<MovieDTO>();
        }

        [XmlArray("movies")]
        [XmlArrayItem("movie",typeof(MovieDTO))]
        public List<MovieDTO> MovieDTOs { get; set; }
    }
}
