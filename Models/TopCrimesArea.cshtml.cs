using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class TopCrimesAreaModel : PageModel  
    {  
				public List<Models.Crime> CrimeList { get; set; }
				public string Input { get; set; }
				// ********** public int NumMovies { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
				  List<Models.Crime> crimes = new List<Models.Crime>();
					
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
	SELECT Top(10) Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, COUNT(*) AS NumCrime, (SUM(COUNT(Crimes.IUCR)) OVER()) AS TotalCrimes, (SUM(CAST(Arrested AS INT))) AS ArrestedCount, Areas.Area, Areas.AreaName
    FROM Crimes
    LEFT JOIN Codes ON Codes.IUCR = Crimes.IUCR 
    LEFT JOIN Areas ON Crimes.Area = Areas.Area
    WHERE Crimes.Area = '{0}'
    GROUP BY Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, Areas.Area, Areas.AreaName
    ORDER BY NumCrime DESC;
	", id);
							}
							else
							{
								// lookup crimes by name
								input = input.Replace("'", "''");

								sql = string.Format(@"
	SELECT Top(10) Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, COUNT(*) AS NumCrime, (SUM(COUNT(Crimes.IUCR)) OVER()) AS TotalCrimes, (SUM(CAST(Arrested AS INT))) AS ArrestedCount, Areas.Area, Areas.AreaName
    FROM Crimes
    LEFT JOIN Codes ON Codes.IUCR = Crimes.IUCR 
    LEFT JOIN Areas ON Crimes.Area = Areas.Area
    WHERE Areas.AreaName = '{0}'
    GROUP BY Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, Areas.Area, Areas.AreaName
    ORDER BY NumCrime DESC;
	", input);
							}

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables["TABLE"].Rows)
							{
								Models.Crime c = new Models.Crime();

								c.IUCR = Convert.ToString(row["IUCR"]);
                                c.PrimaryDesc = Convert.ToString(row["PrimaryDesc"]);
                                c.SecondaryDesc = Convert.ToString(row["SecondaryDesc"]);
                                c.NumCrime = Convert.ToDouble(row["NumCrime"]);
                                c.TotalCrimes = Convert.ToDouble(row["TotalCrimes"]);
                                c.ArrestedCount = Convert.ToDouble(row["ArrestedCount"]);
                                c.Area = Convert.ToDouble(row["Area"]);
                                c.AreaName = Convert.ToString(row["AreaName"]);

                                crimes.Add(c);

							}
						}//else
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
					  CrimeList = crimes;
				  }
				}
			
    }//class  
}//namespace