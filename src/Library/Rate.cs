using ClassLibrary;
using Locate;
namespace ClassLibrary
{
    public class Rating
    {
        public static void Rate(IPerson person, int ratingAmount)
        {
            if(ratingAmount<=5)
            {
                person.Service.StarsRating = (person.Service.StarsRating+ratingAmount)/(person.Service.amountOfRatings+1);
                person.Service.amountOfRatings+=1;
            }
        }
    }
}