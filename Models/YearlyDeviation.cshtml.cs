using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class YearlyDeviationModel : PageModel  
    {  
				public List<Models.NetCrime> NetCrimeList { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
				  List<Models.NetCrime> netCrimes = new List<Models.NetCrime>();
					
					// make input available to web page:
					Input = input;
					
					// clear exception:
					EX = null;
					
					try
					{
						//
						// Do we have an input argument?  If so, we do a lookup:
						//
						if (input == null)
						{
							//
							// there's no page argument, perhaps user surfed to the page directly?  
							// In this case, nothing to do.
							//
						}
						else  
						{
							// 
							// Lookup movie(s) based on input, which could be id or a partial name:
							// 
							int id;
							string sql;

							if (System.Int32.TryParse(input, out id))
							{
								// lookup crime by id:
								sql = string.Format(@"
    SELECT YEAR(Crimes.CrimeDate) AS Year, ((COUNT(Crimes.IUCR))) AS CrimesPerYear, (SUM(COUNT(Crimes.IUCR)) OVER()) AS TotalCrimes, Areas.Area, Areas.AreaName
    FROM Crimes
    LEFT JOIN Areas ON Crimes.Area = Areas.Area
    WHERE Areas.Area = '{0}' 
    GROUP BY YEAR(Crimes.CrimeDate), Areas.Area, Areas.AreaName
    ORDER BY YEAR(Crimes.CrimeDate)
	", id);
							}
							else
							{
								// lookup crimes by name
								input = input.Replace("'", "''");

								sql = string.Format(@"
    SELECT YEAR(Crimes.CrimeDate) AS Year, ((COUNT(Crimes.IUCR))) AS CrimesPerYear, (SUM(COUNT(Crimes.IUCR)) OVER()) AS TotalCrimes, Areas.Area, Areas.AreaName
    FROM Crimes
    LEFT JOIN Areas ON Crimes.Area = Areas.Area
    WHERE Areas.AreaName = '{0}' 
    GROUP BY YEAR(Crimes.CrimeDate), Areas.Area, Areas.AreaName
    ORDER BY YEAR(Crimes.CrimeDate)
	", input);
							}

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables["TABLE"].Rows)
							{
								Models.NetCrime n = new Models.NetCrime();

								n.Year = Convert.ToInt32(row["Year"]);
                                n.CrimesPerYear = Convert.ToInt32(row["CrimesPerYear"]);
                                n.TotalAreaCrimes = Convert.ToInt32(row["TotalCrimes"]);
                                n.Area = Convert.ToInt32(row["Area"]);
                                n.AreaName = Convert.ToString(row["AreaName"]);

                                netCrimes.Add(n);

							}
						}//else
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
					  NetCrimeList = netCrimes;
				  }
				}
			
    }//class  
}//namespace