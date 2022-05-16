using System;

namespace getters_setters
{
    class Movie
    {
        private string title;
        private string director;
        private int rating;

        public Movie(string aTitle, string aDirector, int aRating)
        {
            Title = aTitle;
            Director = aDirector;
            Rating = aRating;
        } 

        public string Title
        {
            get{return title;}
            set{title = value;}
        }

        public string Director
        {
            get{return director;}
            set{director = value;}
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