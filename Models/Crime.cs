//
// Crime Object for part 1 and 2
//

namespace crimes.Models
{

  public class Crime
	{
	
		// data members with auto-generated getters and setters:
        public string IUCR {get; set;}
        public string PrimaryDesc {get; set;}
        public string SecondaryDesc {get; set;}
        public double NumCrime {get; set;}
        public double TotalCrimes {get; set;}
        public double ArrestedCount {get; set;}
        public double Area {get; set;}
        public string AreaName {get; set;}
	
		// default constructor:
		public Crime()
		{ }
		
		// constructor:
		public Crime(string iucr, string primaryDesc, string secondaryDesc, double numCrime, double totalCrimes, double arrestedCount, double area, string areaName)
		{
			IUCR = iucr;
            PrimaryDesc = primaryDesc;
            SecondaryDesc = secondaryDesc;
            NumCrime = numCrime;
            TotalCrimes = totalCrimes;
            ArrestedCount = arrestedCount;
            Area = area;
            AreaName = areaName;
		}
		
	}//class

}//namespace