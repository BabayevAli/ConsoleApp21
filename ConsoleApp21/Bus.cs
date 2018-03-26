using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Bus
    {
        string BUS_ID,
       PLATE, DRIVER_NAME,
       CURRENT_STOP, PREV_STOP,
       SPEED, BUS_MODEL, LATITUDE, LONGITUDE, ROUTE_NAME, LAST_UPDATE_TIME, DISPLAY_ROUTE_CODE, SVCOUNT;



        public Bus(string bUS_ID, string pLATE, string dRIVER_NAME, string cURRENT_STOP, string pREV_STOP, string sPEED, string bUS_MODEL, string lATITUDE, string lONGITUDE, string rOUTE_NAME, string lAST_UPDATE_TIME, string dISPLAY_ROUTE_CODE, string sVCOUNT)
        {
            BUS_ID = bUS_ID;
            PLATE = pLATE;
            DRIVER_NAME = dRIVER_NAME;
            CURRENT_STOP = cURRENT_STOP;
            PREV_STOP = pREV_STOP;
            SPEED = sPEED;
            BUS_MODEL = bUS_MODEL;
            LATITUDE = lATITUDE;
            LONGITUDE = lONGITUDE;
            ROUTE_NAME = rOUTE_NAME;
            LAST_UPDATE_TIME = lAST_UPDATE_TIME;
            DISPLAY_ROUTE_CODE = dISPLAY_ROUTE_CODE;
            SVCOUNT = sVCOUNT;
        }

        public String getDriver()
        {
            return DRIVER_NAME;
        }

    }
}
