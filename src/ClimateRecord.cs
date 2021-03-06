//  Authors:  Amin Almassian, Robert M. Scheller, John McNabb, Melissa Lucash

using System.Collections.Generic;

namespace Landis.Library.Climate
{
    /// <summary>
    /// Weather parameters for each month/day
    /// </summary>
    public class ClimateRecord
    {
        private double avgMinTemp;
        private double avgMaxTemp;
        private double stdDevTemp;
        private double avgVarTemp;
        private double avgPpt;
        private double avgVarPpt;
        private double stdDevPpt;
        private double avgPAR;
        private double avgWindDirection;
        private double stdDevWindDirection;
        private double avgVarWindDirection;
        private double avgWindSpeed;
        private double stdDevWindSpeed;
        private double avgVarWindSpeed;
        private double avgNDeposition;
        private double stdDevNDeposition;
        private double avgVarNDeposition;
        private double avgCO2;
        private double stdDevCO2;
        private double avgVarCO2;
        private double avgMinRH;
        private double avgMaxRH;
        private double stdDevRH;
        private double avgVarRH;
        private double avgFWI;
        

        
        public double AvgMinTemp
        {
            get {
                return avgMinTemp;
            }
            set {
                avgMinTemp = value;
            }
        }

        public double AvgMaxTemp
        {
            get {
                return avgMaxTemp;
            }
            set {
                avgMaxTemp = value;
            }
        }
        public double StdDevTemp
        {
            get {
                return stdDevTemp;
            }
            set {
                stdDevTemp = value;
            }
        }
        public double AvgPpt
        {
            get {
                return avgPpt;
            }
            set {
                avgPpt = value;
            }
        }
        public double StdDevPpt
        {
            get {
                return stdDevPpt;
            }
            set {
                stdDevPpt = value;
            }
        }
        public double AvgPAR
        {
            get {
                return avgPAR;
            }
            set {
                avgPAR = value;
            }
        }

        public double AvgVarTemp
        {
            get
            {
                return avgVarTemp;
            }
            set
            {
                avgVarTemp = value;
            }
        }
        public double AvgVarPpt
        {
            get
            {
                return avgVarPpt;
            }
            set
            {
                avgVarPpt = value;
            }
        }

        public double AvgWindDirection
        {
            get
            {
                return avgWindDirection;
            }
            set
            {
                avgWindDirection = value;
            }
        }
        public double StdDevWindDirection
        {
            get
            {
                return stdDevWindDirection;
            }
            set
            {
                stdDevWindDirection = value;
            }
        }
        public double AvgVarWindDirection
        {
            get
            {
                return avgVarWindDirection;
            }
            set
            {
                avgVarWindDirection = value;
            }
        }

        public double AvgWindSpeed
        {
            get
            {
                return avgWindSpeed;
            }
            set
            {
                avgWindSpeed = value;
            }
        }
        public double StdDevWindSpeed
        {
            get
            {
                return stdDevWindSpeed;
            }
            set
            {
                stdDevWindSpeed = value;
            }
        }
        public double AvgVarWindSpeed
        {
            get
            {
                return avgVarWindSpeed;
            }
            set
            {
                avgVarWindSpeed = value;
            }
        }


        public double AvgNDeposition
        {
            get
            {
                return avgNDeposition;
            }
            set
            {
                avgNDeposition = value;
            }
        }

        public double AvgVarNDeposition
        {
            get
            {
                return avgVarNDeposition;
            }
            set
            {
                avgVarNDeposition = value;
            }
        }

        public double StdDevNDeposition
        {
            get
            {
                return stdDevNDeposition;
            }
            set
            {
                stdDevNDeposition = value;
            }
        }
        public double AvgCO2
        {
            get
            {
                return avgCO2;
            }
            set
            {
                avgCO2 = value;
            }
        }
        public double AvgVarCO2
        {
            get
            {
                return avgVarCO2;
            }
            set
            {
                avgVarCO2 = value;
            }
        }
        public double StdDevCO2
        {
            get
            {
                return stdDevCO2;
            }
            set
            {
                stdDevCO2 = value;
            }
        }
        //public double AvgRH
        //{
        //    get
        //    {
        //        return avgRH;
        //    }
        //    set
        //    {
        //        avgRH = value;
        //    }
        //}
        public double AvgMinRH
        {
            get
            {
                return avgMinRH;
            }
            set
            {
                avgMinRH = value;
            }
        }
        public double AvgMaxRH
        {
            get
            {
                return avgMaxRH;
            }
            set
            {
                avgMaxRH = value;
            }
        }
        public double StdDevRH
        {
            get
            {
                return stdDevRH;
            }
            set
            {
                stdDevRH = value;
            }
        }
        public double AvgVarRH
        {
            get
            {
                return avgVarRH;
            }
            set
            {
                avgVarRH = value;
            }
        }
        public double AvgFWI
        {
            get
            {
                return avgFWI;
            }
            set
            {
                avgFWI = value;
            }
        }

        public ClimateRecord(double avgMinTemp, double avgMaxTemp, double stdDevTemp, double avgPpt, double stdDevPpt, double avgPAR, double avgVarTemp, double avgVarPpt, double avgWindDirection,
                            double avgVarWindDirection, double stdDevWindDirection, double avgWindSpeed, double avgVarWindSpeed, double stdDevWindSpeed, double avgNDeposition, double avgVarNDeposition, 
                            double stdDevNDeposition, double avgCO2, double avgVarCO2, double stdDevCO2, double avgMinRH, double avgMaxRH, double stdDevRH, double avgVarRH, double avgFWI)
        {
            this.avgMinTemp = avgMinTemp;
            this.avgMaxTemp = avgMaxTemp;
            this.stdDevTemp = stdDevTemp;
            this.avgPpt = avgPpt;
            this.stdDevPpt = stdDevPpt;
            this.avgPAR = avgPAR;
            this.avgVarTemp = avgVarTemp;
            this.avgVarPpt = avgVarPpt;
            this.avgWindDirection = avgWindDirection;
            this.avgVarWindDirection = avgVarWindDirection;
            this.stdDevWindDirection = stdDevWindDirection;
            this.avgWindSpeed = avgWindSpeed;
            this.avgVarWindSpeed = avgVarWindSpeed;
            this.stdDevWindSpeed = stdDevWindSpeed;
            this.avgNDeposition = avgNDeposition;
            this.avgVarNDeposition = avgVarNDeposition;
            this.stdDevNDeposition = stdDevNDeposition;
            this.avgCO2 = avgCO2;
            this.avgVarCO2 = avgVarCO2;
            this.stdDevCO2 = stdDevCO2;
            this.avgMinRH = avgMinRH;
            this.avgMaxRH = avgMaxRH;
            this.stdDevRH = stdDevRH;
            this.avgVarRH = avgVarRH;
            this.avgFWI = avgFWI;
        }
        
        public ClimateRecord()
        {
            this.avgMinTemp = -99.0;
            this.avgMaxTemp = -99.0;
            this.stdDevTemp = -99.0;
            this.avgPpt = -99.0;
            this.stdDevPpt = -99.0;
            this.avgPAR = -99.0;
            this.avgVarTemp = -99.0;
            this.avgVarPpt = -99.0;
            this.avgWindDirection = -99.0;
            this.avgVarWindDirection = -99.0;
            this.stdDevWindDirection = -99.0;
            this.avgWindSpeed = -99.0;
            this.avgVarWindSpeed = -99.0;
            this.stdDevWindSpeed = -99.0;
            this.avgNDeposition = -99.0;
            this.avgVarNDeposition = -99.0;
            this.stdDevNDeposition = -99.0;
            this.avgCO2 = -99.0;
            this.avgVarCO2 = -99.0;
            this.stdDevCO2 = -99.0;
            this.avgMinRH = -99.0;
            this.avgMaxRH = -99.0;
            this.stdDevRH = -99.0;
            this.avgVarRH = -99.0;
            this.avgFWI = -99.0;
        }
    }
}
