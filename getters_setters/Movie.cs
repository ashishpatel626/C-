using System;

namespace getters_setters
{
    class Movie
    {
        public string title;
        public string director;
        private int rating;

        public Movie(string aTitle, string aDirector, int aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        } 

        public int Rating
        {
            get{return rating;}
            set
            {
                if (value < 10)
                {
                    rating = value;
                }
                else
                {
                    rating = 10;
                }
            }
        }
    }
}