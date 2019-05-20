//
// ChicagoArea Model for part 4
//

namespace crimes.Models
{

  public class ChicagoArea
	{
	
		// data members with auto-generated getters and setters:
        public string Area {get; set;}
        public string AreaName {get; set;}
        public double NumAreaCrimes {get; set;}
        public double TotalCrimes {get; set;}
	
		// default constructor:
		public ChicagoArea()
		{ }
		
		// constructor:
		public ChicagoArea(string area, string areaName, double numAreaCrimes, double totalCrimes)
		{
			Area = area;
            AreaName = areaName;
            NumAreaCrimes = numAreaCrimes;
            TotalCrimes = totalCrimes;
		}
		
	}//class

}//namespace