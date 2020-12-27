using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Movie
    {
        //private access specifier cuts of access from any other class
        public string title;
        private string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle; 
            director = aDirector;
            Rating = aRating; //sets rating through setter fn , user cannot set anything invalid
        }

        public string Rating
        {
            get { return rating; } //can get the raing inspite of being pvt
            set { //can set the rating inspite of bring private
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
