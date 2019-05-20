using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class CrimeByMonthModel : PageModel  
    {  
        public List<int> NumCrimes { get; set; }
            public Exception EX { get; set; }
  
        public void OnGet()  
        {  
				  List<int> numbers = new List<int>();
                  
					// clear exception:
					EX = null;
					
					try
					{
						string sql = string.Format(@"
                    SELECT ((COUNT(Crimes.IUCR))) AS MONTHS
                    FROM Crimes
                    GROUP BY MONTH(Crimes.CrimeDate)
                    ORDER BY MONTH(Crimes.CrimeDate);
                        ");

						DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

						foreach (DataRow row in ds.Tables["TABLE"].Rows)
						{

							numbers.Add(Convert.ToInt32(row["MONTHS"]));
						}
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
                        NumCrimes = numbers;
            
                    }
        }  
				
    }//class
}//namespace