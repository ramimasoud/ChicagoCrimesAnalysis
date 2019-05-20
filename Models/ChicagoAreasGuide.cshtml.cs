using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class ChicagoAreasGuideModel : PageModel  
    {  
        public List<Models.ChicagoArea> ChicagoAreaList { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet()  
        {  
				  List<Models.ChicagoArea> chicagoAreas = new List<Models.ChicagoArea>();
					
					// clear exception:
					EX = null;
					
					try
					{
						string sql = string.Format(@"
                    SELECT Areas.Area, Areas.AreaName, COUNT(Crimes.Area) AS NumAreaCrimes, (SUM(COUNT(Crimes.IUCR)) OVER()) AS TotalCrimes
                    FROM Areas
                    LEFT JOIN Crimes ON Crimes.Area = Areas.Area
                    WHERE Areas.AreaName NOT LIKE '%unknown%'
                    GROUP BY Areas.Area, Areas.AreaName
                    ORDER BY Areas.AreaName ASC
                        ");

						DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

						foreach (DataRow row in ds.Tables["TABLE"].Rows)
						{
							Models.ChicagoArea c = new Models.ChicagoArea();

                            c.Area = Convert.ToString(row["Area"]);
                            c.AreaName = Convert.ToString(row["AreaName"]);
                            c.NumAreaCrimes = Convert.ToDouble(row["NumAreaCrimes"]);
                            c.TotalCrimes = Convert.ToDouble(row["TotalCrimes"]);

							chicagoAreas.Add(c);
						}
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
            ChicagoAreaList = chicagoAreas;  
				  }
        }  
				
    }//class
}//namespace