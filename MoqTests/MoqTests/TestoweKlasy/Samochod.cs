using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MoqTests.TestoweKlasy
{
    public class Samochod :ISamochod
    {
        public int dupa()
        {
            throw new NotImplementedException();
        }

        public int licznik()
        {
            return 1;
        }

        public virtual string getNazwa()
        {
            return "Super Audi";
        }

    }
}