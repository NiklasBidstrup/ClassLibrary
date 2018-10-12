using System;



namespace OOClassLibrary
{
    public class Methods
    {
        private static readonly double Konstant = 28.34952;

        public double ConvertToGram(double gram)
        {
            return gram * Konstant;
        }

        public double ConvertToOunce(double ounce)
        {
            return ounce / Konstant;
        }
    }
}
