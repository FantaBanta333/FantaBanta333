using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Car : IVehicle
    {
        //ACCESS MODIFIERS
        // private - ONLY this class can see
        // public - EVERYONE can see
        // protected - this class and all descendents of this class

        #region Fields (data, variables)
        //follows _camelCasingNamingConvention
        //  compound word: first word is lowercase, every word after starts with an uppercase
        //generally make PRIVATE unless some special case

        //an INSTANCE field
        //every instance gets their own variable
        protected int _odometerReading = 0;//initialize the field

        //STATIC field. ONE variable for ALL instances
        private static int _numberOfCarsBuilt = 0;
        #endregion

        #region Properties (control access to the data)
        //follow PascalNamingConvention
        //generally make them public

        public VehicleClassification CarType { get; set; }

        public static int NumberOfCarsBuilt
        {
            get { return _numberOfCarsBuilt; }
        }

        public int Odomoter
        {
            //get (accessor)
            //same as...
            //public int GetOdomoter() {return _odometerReading;}
            get //hidden "this" parameter. this refers to the current instance
            {
                return this._odometerReading;
            }

            //set (mutator)
            //same as...
            //public void SetOdometer(int odometer) {_odometerReading = odometer;}
            set //hidden parameter called "value" and "this"
            {
                if(value >= 0 && value <= 5000000)
                    this._odometerReading = value;
            }
        }

        //auto-prop. the backing field is provided by the compiler
        public bool IsOriginalOwner { get; private set; } = true;

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        #endregion

        #region Constructors
        //public Car() //default constructor
        //{
        //    _numberOfCarsBuilt++;
        //}

        public Car(int odomoter)
        {
            _numberOfCarsBuilt++;

            //Initialize the instance
            //assign the parameters to the fields/properties
            Odomoter = odomoter;//calls the SET
            //odometer = Odomoter;//BACKWARDS!!!
        }

        public Car(int year, string make, string model, int odometer = 0)
        {
            Year = year;
            Make = make;
            Model = model;
            Odomoter = odometer;
        }
        #endregion

        #region Methods
        //instance method
        public virtual string CarInfo()//there is a hidden "this" parameter
        {
            return $"----------My Car-------------\nYear: {Year}\nMake: {Make}\nModel: {Model}\nOriginal Owner: {IsOriginalOwner}\nOdometer: {_odometerReading}";
        }

        public string Info()
        {
            return CarInfo();
        }
        #endregion
    }
}
