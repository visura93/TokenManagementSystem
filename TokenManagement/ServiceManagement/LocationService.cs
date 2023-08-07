namespace TokenManagement.ServiceManagement
{
    using System.Collections.Generic;
    using System.Linq; // Import LINQ for querying
    using TokenManagement.Models;
    using TokenManagement.Models.DomainObjects;

    public class LocationService
    {
        private readonly ApplicationDbContext dbContext; // Replace YourDbContext with the actual name of your DbContext class.

        public LocationService(ApplicationDbContext dbContext) // Inject the DbContext through constructor injection.
        {
            this.dbContext = dbContext;
        }

        public List<Locations> GetLocations()
        {
            // Query the Locations table using Entity Framework
            List<Locations> locations = dbContext.Locations.ToList();

          

            return locations;
        }
    }

}
