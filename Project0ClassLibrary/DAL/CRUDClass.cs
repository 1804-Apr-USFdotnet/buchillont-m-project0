using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CRUDClass
    {
        public RestaurantsEntities db = new RestaurantsEntities();

        //get restaurants function
        //crud operations (then create ui, logger, data access code)

        public IEnumerable<Restaurant> ShowRestaurants()
        {
            return db.Restaurants.ToList();
        }

        //read and find

        public Restaurant FindRestaurantByTheId (int theId)
        {
            foreach (var r in db.Restaurants)
            {

                if (r.RestaurantID == theId)
                {
                    Console.WriteLine(r.RestaurantID + "||" + r.name);
                }

            }
           return db.Restaurants.Find(theId);
        }


        public Restaurant FindRestaurantByTheName (string theName)
        {

            return db.Restaurants.Where(x => x.name == theName).FirstOrDefault();
        }

        public Restaurant ReadARestaurant(string aName)
        {
            foreach (var r in db.Restaurants)
            {
                if(r.name == aName)
                {
                    //show the details of the restaurant, right?
                    Console.WriteLine("Name: {0} \nAddress: {1}\nEmail: {2}\nPhone: {3}\nAverage Rating: {4}\n", r.name, r.address, r.email, r.phone, r.avgRating);
                    return r;
                }
            }

            return null;          //just putting this here to have some return value for now
        }
    }
}
