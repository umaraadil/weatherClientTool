using Newtonsoft.Json;

namespace weatherClientTool
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main()
        {
            WeatherInformation weatherInformation = new WeatherInformation();
            CitiesGeoDetails geoDetails = new CitiesGeoDetails();
            GeoInfo geoInfoValue=null;
            Console.WriteLine("\nDelhi,Mumbai,Kolkata,Chennai,Pune,Jaipur,Patna,Kota,Gaya,Gurgaon");
            Console.WriteLine("\nPlease Enter the City Name from the above list of Cities");            
            string cityName = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(cityName) )
            {
                geoInfoValue = geoDetails.GetCitiesDetails(cityName.ToLower());
            }
            else
            {
                Console.WriteLine("City Name is required. Thanks\n");
                return;
            }
            if(geoInfoValue.latitude != 0 &&  geoInfoValue.longitude != 0)
            {
                weatherInformation.RunAsync(geoInfoValue).GetAwaiter().GetResult();
            }
            else
            {
                Console.WriteLine($"\n{cityName} is not available in our database\n");
                return;
            }
        }
        
        
    }
}