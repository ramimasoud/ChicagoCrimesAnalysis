//
// CrimeCode Object for Part 3
//

namespace crimes.Models
{

  public class CrimeCode
	{
	
		// data members with auto-generated getters and setters:
        public string IUCR {get; set;}
        public string PrimaryDesc {get; set;}
        public string SecondaryDesc {get; set;}
        public double NumCrime {get; set;}
	
		// default constructor:
		public CrimeCode()
		{ }
		
		// constructor:
		public CrimeCode(string iucr, string primaryDesc, string secondaryDesc, double numCrime)
		{
			IUCR = iucr;
            PrimaryDesc = primaryDesc;
            SecondaryDesc = secondaryDesc;
            NumCrime = numCrime;
		}
		
	}//class

}//namespace