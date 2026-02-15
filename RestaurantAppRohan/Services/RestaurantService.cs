using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class RestaurantService
    {
        private List<Restaurant> restaurants = new List<Restaurant>();

        public List<Restaurant> GetAll()
        {
            return restaurants;
        }

        public void Add(Restaurant restaurant)
        {
            restaurant.Id = restaurants.Count + 1;
            restaurants.Add(restaurant);
        }

        public void Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
        }
    }
}
