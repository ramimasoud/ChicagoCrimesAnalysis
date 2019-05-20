using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class TopCrimesChicagoModel : PageModel  
    {  
        public List<Models.Crime> CrimeList { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet()  
        {  
				  List<Models.Crime> crimes = new List<Models.Crime>();
					
					// clear exception:
					EX = null;
					
					try
					{
						string sql = string.Format(@"
                    SELECT Top(10) Crimes.IUCR , Codes.PrimaryDesc, Codes.SecondaryDesc, Count(*) AS NumCrime, (SUM(COUNT(Crimes.IUCR)) OVER()) AS TotalCrimes, (SUM(CAST(Arrested AS INT))) AS ArrestedCount
                    FROM Crimes
                    INNER JOIN Codes ON Codes.IUCR = Crimes.IUCR
                    GROUP BY Crimes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc
                    ORDER BY NumCrime DESC;
                        ");

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

							crimes.Add(c);
						}
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