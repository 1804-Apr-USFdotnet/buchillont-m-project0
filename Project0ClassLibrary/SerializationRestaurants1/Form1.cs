using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Project0ClassLibrary;

namespace SerializationRestaurants1
{
    public partial class Form1 : Form
    {
        string direc = AppDomain.CurrentDomain.BaseDirectory;
        string theFileName = "the_Restaurants";
        List<Restaurant> Restaurant_List = new List<Restaurant>();

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
            public string tempVariable;
            

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
            public Restaurant(string name, string address, string email, string phone, string avgRatingString)
            {
                this.name = name;
                this.address = address;
                this.email = email;
                this.phone = phone;
                //this.avgRating = avgRating;
                this.tempVariable = avgRatingString;

                foreach (Review review in reviews)
                {
                    reviews.Add((Review)review);
                }

                //the avgRating is the average of all the ratings a restaurant gets

                double sumRatings = 0;
                int amountOfRatings = 0;

                foreach (Review review in reviews)
                {
                    sumRatings += review.rating;
                    amountOfRatings++;
                }

                avgRating = sumRatings / amountOfRatings;

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)   //button1 would be the button to click in order to save the restaurant
        {
            Restaurant restaurant = new Restaurant(Restaurant_textbox.Text, Address_textbox.Text, textbox_email.Text, textbox_phone.Text, Rating_textbox.Text);
            if(!Restaurant_List.Contains(restaurant))
            {
                //add the restaurant if it is not in Restaurant_List
                Restaurant_List.Add(restaurant);
            }

            else
            {
                Console.WriteLine("Restaurant added. ");
            }
        }

        private void label1_Click(object sender, EventArgs e)   //the exit button
        {
            Console.WriteLine("The end for now");
        }

        private void Address_label_Click(object sender, EventArgs e)
        {
            
        }
    }
}

