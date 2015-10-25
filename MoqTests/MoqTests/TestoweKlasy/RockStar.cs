using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoqTests.TestoweKlasy
{
    public class RockStar
    {
        private readonly RockStar rs;
        private readonly IFetch fetch;

        //here's the magic sauce for the unittests
        public FetchCms(IFetch fetch, RockStar rs)
        {
            this.fetch = fetch;
            this.rs = rs;
        }
        //production code calls this which calls 
        //the other constructor. mmm.
        public FetchRockStar() : this(new Fetch(), new RockStar()) { }

        public RockStar GetRockStar(string urlToLookup)
        {
            try
            {
                var parms = new[] { new SqlParameter("@urlName", urlToLookup) };
                using (IDataReader reader =
                fetch.ExecuteDataReader("localhell", "rockstar_page_get", parms))
                {
                    if (reader != null && reader.Read())
                    {
                        rs.Name = reader["name"].ToString();
                        rs.Guitar = reader["guitar"].ToString();
                        //add some logic... and so on...                       
                    }
                }
            }
            catch //swine flu
            { }
            return fs;
        }
    }
}