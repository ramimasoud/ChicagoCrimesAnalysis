using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class CrimeCodesGuideModel : PageModel  
    {  
        public List<Models.CrimeCode> CrimeCodeList { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet()  
        {  
				  List<Models.CrimeCode> crimeCodes = new List<Models.CrimeCode>();
					
					// clear exception:
					EX = null;
					
					try
					{
						string sql = string.Format(@"
                    SELECT Codes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, COUNT(Crimes.IUCR) AS NumCrime
                    FROM Codes
                    LEFT JOIN Crimes ON Crimes.IUCR = Codes.IUCR
                    GROUP BY Codes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc
                    ORDER BY Codes.PrimaryDesc ASC, Codes.SecondaryDesc ASC
                        ");

						DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

						foreach (DataRow row in ds.Tables["TABLE"].Rows)
						{
							Models.CrimeCode c = new Models.CrimeCode();

                            c.IUCR = Convert.ToString(row["IUCR"]);
                            c.PrimaryDesc = Convert.ToString(row["PrimaryDesc"]);
                            c.SecondaryDesc = Convert.ToString(row["SecondaryDesc"]);
                            c.NumCrime = Convert.ToDouble(row["NumCrime"]);

							crimeCodes.Add(c);
						}
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
            CrimeCodeList = crimeCodes;  
				  }
        }  
				
    }//class
}//namespace