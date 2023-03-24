namespace weatherClientTool;
public class CitiesGeoDetails
{

    public GeoInfo GetCitiesDetails(string city)
    {
        GeoInfo geoInfo = new GeoInfo();
        Dictionary<string, List<GeoInfo>> citiesDetails = new Dictionary<string, List<GeoInfo>>();
        citiesDetails.Add("delhi", new List<GeoInfo>() { new GeoInfo() { latitude=28.6600,longitude=77.2300 }});
        citiesDetails.Add("mumbai", new List<GeoInfo>() { new GeoInfo() { latitude = 18.9667, longitude = 72.8333 } });
        citiesDetails.Add("kolkata", new List<GeoInfo>() { new GeoInfo() { latitude = 22.5411, longitude = 88.3378 } });
        citiesDetails.Add("chennai", new List<GeoInfo>() { new GeoInfo() { latitude = 13.0825, longitude = 80.2750 } });
        citiesDetails.Add("pune", new List<GeoInfo>() { new GeoInfo() { latitude = 18.5196, longitude = 73.8553 } });
        citiesDetails.Add("jaipur", new List<GeoInfo>() { new GeoInfo() { latitude = 26.9167, longitude = 75.8667 } });
        citiesDetails.Add("patna", new List<GeoInfo>() { new GeoInfo() { latitude = 25.6100, longitude = 85.1414 } });
        citiesDetails.Add("kota", new List<GeoInfo>() { new GeoInfo() { latitude = 25.1800, longitude = 75.8300 } });
        citiesDetails.Add("gaya", new List<GeoInfo>() { new GeoInfo() { latitude = 24.7500, longitude = 85.0167 } });
        citiesDetails.Add("gurgaon", new List<GeoInfo>() { new GeoInfo() { latitude = 28.4500, longitude = 77.0200 } });

        if (citiesDetails.ContainsKey(city))
        {
            var myValue = citiesDetails.FirstOrDefault(x => x.Key == city).Value;
            foreach(var kvp in myValue)
            {
                geoInfo.latitude = kvp.latitude; 
                geoInfo.longitude=kvp.longitude;
            }
        }
        return geoInfo;
    }
}
