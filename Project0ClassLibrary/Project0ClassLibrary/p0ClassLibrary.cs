using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0ClassLibrary
{
    //This is the library project for project 0. All business logic will be here in this namespace.
    //so for now, class for restaurant and class for reviews


    public class Review
    {
        public double rating;
        public string description;

        //default constructor
        public Review()
        {
            rating = 0.0;
            description = "";
        }



        //constructor
        public Review(double rating, string description)
        {
            this.rating = rating;
            this.description = description;
        }

        //Console.WriteLine("New review created. ");
    }

    public class Restaurant
    {
        public string name, address, email, phone;
        public double avgRating;
        //public string tempVariable;

        public List<Review> reviews = new List<Review>();

        //default constructor
        public Restaurant()
        {
            name = "";
            address = "";
            email = "";
            phone = "";
            avgRating = 0;
        }

        //constructor
        public Restaurant(string name, string address, string email, string phone, double avgRating)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.avgRating = avgRating;
           // this.tempVariable = avgRatingString;

            foreach(Review review in reviews)
            {
                reviews.Add((Review) review);
            }

            //the avgRating is the average of all the ratings a restaurant gets

            double sumRatings = 0;
            int amountOfRatings = 0;

            foreach(Review review in reviews)
            {
                sumRatings += review.rating;
                amountOfRatings++;
            }

            avgRating = (sumRatings / amountOfRatings);
            //avgRating.ToString();
            
            
        }


    }
}


