//
// Crime Object for part 1 and 2
//

namespace crimes.Models
{

  public class NetCrime
	{
	
		// data members with auto-generated getters and setters:
        public int Year {get; set;}
        public int CrimesPerYear {get; set;}
        public int TotalAreaCrimes {get; set;}
        public int Area {get; set;}
        public string AreaName {get; set;}
	
		// default constructor:
		public NetCrime()
		{ }
		
		// constructor:
		public NetCrime(int year, int crimesPerYear, int totalAreaCrimes, int area, string areaName)
		{
			Year = year;
            CrimesPerYear = crimesPerYear;
            TotalAreaCrimes = totalAreaCrimes;
            Area = area;
            AreaName = areaName;
		}
		
	}//class

}//namespace