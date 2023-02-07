using System;

namespace Assign2A
{
    class Flight
    {
        public int _flightID;
        public string _origin;
        public string _destination;
        public string _date;

        public Flight(int flightID, string origin, string destination, string date)
        {
            _flightID = flightID;
            _origin = origin;
            _destination = destination;
            _date = date;
        }

        public string FlightInfo(int flightID)
        {
            if (flightID == _flightID)
            {
                return "FlightID: " + _flightID + " From: " + _origin + " Destination: " + _destination + " Date: " + _date;
            }
            else
            {
                return "Invalid";
            }
        }
    }
}