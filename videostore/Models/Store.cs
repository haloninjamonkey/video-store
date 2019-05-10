using System;
using System.Collections.Generic;

namespace videostore.Models
{
    class Store
    {
        /**Name
        Address
        AvailableMovies This is List of type Movie
        RentedMoviesThis is List of type Movie
        */
        public string Name {get; private set;}
        public string Address { get; private set; } 
        public List<Movie> AvailableMovies { get; set; }
        public List<Movie> RentedMovies { get; set; }

        public Store(string name, string address )
        {
            Name = name;
            Address = address;
            AvailableMovies = new List<Movie>();
            RentedMovies = new List<Movie>();
        }
        public void AddMovie(Movie movie)
        {
            if(movie.Available)
            {
                AvailableMovies.Add(movie);
            }
            else
            {
                RentedMovies.Add(movie);
            }
        }

        public void ViewMovies(List<Movie> movies)
        {   
            int count = 1;
            foreach (Movie movie in movies)
            {
                System.Console.WriteLine("{0}. {1} - {2} {3}\n {4}", count, movie.Title, movie.ReleaseYear, movie.Actors, movie.Plot);
                count ++;
            }
        }

        public bool PrintDirectory()
        {
            bool StayInStore = true;
            System.Console.WriteLine("(V)iew all movies");
            System.Console.WriteLine("(R)eturn a movie");
            System.Console.WriteLine("(C) Rent a movie");
            System.Console.WriteLine("(Q) to leave the store.");
            string input = Console.ReadLine();
            switch(input.ToLower()){
                case "v":
                    Console.Clear();
                    System.Console.WriteLine("The available movies are: ");
                    ViewMovies(AvailableMovies);
                    break;
                case "r":
                    Console.Clear();
                    ReturnMovie();
                    break;
                case "c":
                    Console.Clear();
                    RentMovie();
                    break;
                case "q":
                    StayInStore = false;
                    break;
                default:
                    System.Console.WriteLine("Invalid option!\n Press Enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                    PrintDirectory();
                    break;
            }
            return StayInStore;
        }

        public void RentMovie()
        {
            System.Console.WriteLine("Enter the number of the movie that you'd like to check out: ");
            ViewMovies(AvailableMovies);
            Movie movieToRent = ValidateUserInput(AvailableMovies);
            if(movieToRent == null) return;
            movieToRent.Available = false;
            AvailableMovies.Remove(movieToRent);
            RentedMovies.Add(movieToRent);
            System.Console.WriteLine("We hope that you enjoy {0}", movieToRent.Title);
        }
        public void ReturnMovie()
        {   
            System.Console.WriteLine("Enter the number of the movie you would like to return: ");
            ViewMovies(RentedMovies);
            Movie movieToReturn = ValidateUserInput(RentedMovies);
            //null check to prevent breaking errors
            if(movieToReturn == null) return;
            movieToReturn.Available = true;
            RentedMovies.Remove(movieToReturn);
            AvailableMovies.Add(movieToReturn);
            System.Console.WriteLine("Thanks for returning {0}!", movieToReturn.Title);
        }


        public Movie ValidateUserInput(List<Movie> movies)
        {   
            if(movies.Count == 0)
            {
                System.Console.WriteLine("No movies currently.");
                return null;
            }
            int movieNum = 0;
            while (!Int32.TryParse(Console.ReadLine(), out movieNum) || movieNum < 1 || movieNum > movies.Count) {
                System.Console.WriteLine("Not a valid choice.");
            }
            return movies[movieNum - 1];
        }

        public void Greeting()
        {
            System.Console.WriteLine("Welcome to {0}!", Name);
        }
    }

}