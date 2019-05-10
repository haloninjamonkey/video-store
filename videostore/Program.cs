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
A user should be able to use the console to view the contents of the movie store. If desired the user can rent a movie. Because we are old school a user may only two movies rented at a time. Therefore the user should be able to return a movie they have rented.

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
