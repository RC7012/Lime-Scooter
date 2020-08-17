using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    /// <summary>
    /// Scooter object with 3 fields 
    /// string suburb informing the location of the scooter
    /// string type informing the model
    /// int batterylevel informing the battery percentage
    /// </summary>
    class Scooter
    {
        private string _suburb;
        private string _type;
        private int _batteryLevel;

        /// <summary>
        /// initialises the object with the parameters passed in
        /// </summary>
        /// <param name="suburb">the scooter location</param>
        /// <param name="type">the scooter model</param>
        /// <param name="battery">the scooter battery level</param>
        public Scooter(string suburb, string type, int battery)
        {
            Suburb = suburb;
            Type = type;
            BatteryLevel = battery;
        }

        /// <summary>
        /// Gets the location of the scooter
        /// </summary>
        public string Suburb
        {
            get { return _suburb; } 
            set { _suburb = value; }
        }

        /// <summary>
        /// gets the model of the scooter
        /// </summary>
        public string Type
        {
            get { return _type; }
            set
            {
                if (value == "G3" || value == "G2.5")
                {
                    _type = value;
                }
                else              // Default model is G3
                {
                    _type = "G3";
                }
            }
        }

        /// <summary>
        /// Gets the battery level of the scooter
        /// </summary>
        public int BatteryLevel
        {
            get { return _batteryLevel; }
            set 
            { 
                //Makes sure the value is positive and is between 0 to 100
                if (Math.Abs(value) >= 0 && value <= 100)
                {
                    _batteryLevel = Math.Abs(value);
                }
                else
                {
                    throw new Exception("Invalid Battery Level");
                }
            }
        }

        /// <summary>
        /// Gets the amount to pay to charge the scooter
        /// </summary>
        public decimal Pay
        {
            get { return (Decimal)((100 - _batteryLevel) * 5.5 / 100);}
        }

        /// <summary>
        /// giving information of the scooter, including location, model, and battery level and amount to pay to charge
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Suburb.PadRight(20, ' ') + Type.PadRight(10, ' ') + BatteryLevel.ToString().PadRight(10, ' ') + Pay.ToString("c") + " to charge";
        }

    }
}
