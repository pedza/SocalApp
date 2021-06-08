using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = System.DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago ",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                    
                },

                new Activity
                {
                    Title = "Past Activity 2",
                    Date = System.DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 months ago ",
                    Category = "food",
                    City = "London",
                    Venue = "McDonalds"
                    
                },
                new Activity
                {
                    Title = "Past Activity 3",
                    Date = System.DateTime.Now.AddDays(-25),
                    Description = "Activity 25 days ago ",
                    Category = "sport",
                    City = "Manchester",
                    Venue = "Baloon"
                    
                },
                new Activity
                {
                    Title = "Past Activity 4",
                    Date = System.DateTime.Now.AddDays(-18),
                    Description = "Activity 18 days ago ",
                    Category = "sport",
                    City = "Skopje",
                    Venue = "Vodno"
                    
                },
                new Activity
                {
                    Title = "Past Activity 5",
                    Date = System.DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in the Future",
                    Category = "Concert",
                    City = "Berlin",
                    Venue = "Berlin Arena"
                    
                },
                new Activity
                {
                    Title = "Past Activity 6",
                    Date = System.DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in the Future",
                    Category = "Cross",
                    City = "Kraguevac",
                    Venue = "Brdo"
                    
                }
            }; 

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();

        }
    }
}