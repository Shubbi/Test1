using Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class PulseDataProvider
    {
        public List<PulseDataModel> GetPulseData(int MemberId)
        {
            var sqlQuery = "SELECT * FROM [dbo].[vwPulseData] Where MemberId=@MemberId";
            using (var ctx = new Pulse8TestDbContext())
            {
                var result = ctx.Database.SqlQuery<PulseDataModel>(
                    sqlQuery, new SqlParameter("@MemberId", MemberId)).ToList();
                return result;
            }
        }
    }
}
