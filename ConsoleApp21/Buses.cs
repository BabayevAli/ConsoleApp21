using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Buses
    {
        List<Bus> listBus;

            static Buses instance = new Buses();

            public static Buses Instance()
            {
               
                return instance;
            }

            public Buses()
            {
                listBus = new List<Bus>();
            }

            public void SetListBus(List<Bus> list)
            {
                listBus = list;
            }

            public List<Bus> GetList()
            {
                return listBus;
            }

        }
    
}
