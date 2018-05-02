using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0ClassLibrary
{
    enum sortChoices {rName, rRating};

    static internal class SortingOutRestaurants
    {
        //so we take restaurants and we sort them out...
        static internal void sortTheRestaurants(ref List<Restaurant> theRestaurants)
        {
            //I can sort the restaurants by name, by rating...probably by location as well...
            //okay, one at a time for now, by name

            /* So the way it would work is that the user would choose to sort the restaurants by name and then I would take that with this code
             and then sort out the restaurants by alphabetical order*/

            int sortChosen = 0;

            if (sortChosen == (int) sortChoices.rName)
            {
                //sort by restaurant name, alphabetically
            }

            else
            {
                //sort restaurants by highest rating to lowest rating
            }
        }
    }
}
