using System;
using videostore.Models;
/***
=================================================================================
|      ___  __         __    ___           __            _   ___    __          |
|     / _ )/ /__  ____/ /__ / _ )__ _____ / /____ ____  | | / (_)__/ /__ ___    |
|    / _  / / _ \/ __/  '_// _  / // (_-</ __/ -_) __/  | |/ / / _  / -_) _ \   |
|   /____/_/\___/\__/_/\_\/____/\_,_/___/\__/\__/_/     |___/_/\_,_/\__/\___/   |
=================================================================================
Blockbuster
In this project you will build out a console based application that is capable of keeping track of a Movie Rental Store's inventory of Vidoes.

Required Features
A user should be able to use the console to view the contents of the movie store. If desired the user can rent a movie. 
Because we are old school a user may only two movies rented at a time. Therefore the user should be able to return a movie they have rented.

You will need to have a class for each of the following. Each class should be seperated into its own file.

HINT: Don't forget your namespace

Store
Name
Address
AvailableMovies // This is List of type Movie
RentedMovies // This is List of type Movie
Movie
Title
Plot
ReleaseYear
Actors // This is List of type Actor
Actor
Name
 */
namespace videostore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Store duckyVideo = new Store("Ducky Video", "123 Main St");
            Movie Avengers = new Movie ("Avengers", "Earth's mightiest heroes must come together and learn to fight as a team \n if they are going to stop the mischievous Loki and his alien army from enslaving humanity.", 2012, true);
            Actor RDJ = new Actor("Robert Downey Jr");
            Actor ChrisE = new Actor("Chris Evans");
            Actor ChrisH = new Actor("Chris Hemsworth");
            Avengers.Actors.Add(RDJ);
            Avengers.Actors.Add(ChrisE);
            Avengers.Actors.Add(ChrisH);
            duckyVideo.AddMovie(Avengers);
            Movie Hook = new Movie ("Hook", "When Captain Hook kidnaps his children, an adult Peter Pan must return to Neverland \n and reclaim his youthful spirit in order to challenge his old enemy.", 1991, true);
            Actor RobinW = new Actor("Robin Williams");
            Hook.Actors.Add(RobinW);
            duckyVideo.AddMovie(Hook);
            Movie JL = new Movie("Justice League", "DC Superherooes fight their greatest rival - WB Executives", 2016, true);
            Actor Batfleck = new Actor("Ben Afleck");
            Actor Mustache = new Actor("Henry Cavill");
            Actor GalG = new Actor("Gal Gadot");
            JL.Actors.Add(Batfleck);
            JL.Actors.Add(Mustache);
            JL.Actors.Add(GalG);
            duckyVideo.AddMovie(JL);
            bool inStore = true;
            duckyVideo.Greeting();
            while(inStore) 
            {
                Console.ReadLine();
                Console.Clear();
                bool stayInStore = duckyVideo.PrintDirectory();
                if(!stayInStore)
                {
                    inStore = false;
                    System.Console.WriteLine("Thanks for visiting! Goodbye.");
                }
            }
        }
    }
}
