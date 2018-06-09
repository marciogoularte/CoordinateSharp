﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordinateSharp
{
    internal class MeeusTables
    {
        /// <summary>
        /// Sum of Apogee Terms from Jean Meeus Astronomical Algorithms Table 50.A
        /// </summary>
        /// <param name="D">Moom's mean elongation at time JDE</param>
        /// <param name="M">Sun's mean anomaly</param>
        /// <param name="F">Moon's arguement f latitude</param>
        /// <param name="T">Time in Julian centuries since epoch 2000</param>
        /// <returns>double</returns>
        public static double ApogeeTermsA(double D, double M, double F, double T)
        {
            double sum;
         
            sum = Math.Sin(2 * D) * 0.4392;
            sum += Math.Sin(4 * D) * 0.0684;
            sum += Math.Sin(M) * .0456 - 0.00011 * T;
            sum += Math.Sin(2 * D - M) * .0426 - 0.00011 * T;
            sum += Math.Sin(2 * F) * .0212;
            sum += Math.Sin(D) * -0.0189;
            sum += Math.Sin(6 * D) * .0144;
            sum += Math.Sin(4 * D - M) * .0113;
            sum += Math.Sin(2 * D + 2 * F) * .0047;
            sum += Math.Sin(D + M) * .0036;
            sum += Math.Sin(8 * D) * .0035;
            sum += Math.Sin(6 * D - M) * .0034;
            sum += Math.Sin(2 * D - 2 * F) * -0.0034;
            sum += Math.Sin(2 * D - 2 * M) * .0022;
            sum += Math.Sin(3 * D) * -.0017;
            sum += Math.Sin(4 * D + 2 * F) * 0.0013;

            sum += Math.Sin(8 * D - M) * .0011;
            sum += Math.Sin(4 * D - 2 * M) * .0010;
            sum += Math.Sin(10 * D) * .0009;
            sum += Math.Sin(3 * D + M) * .0007;
            sum += Math.Sin(2 * M) * .0006;
            sum += Math.Sin(2 * D + M) * .0005;
            sum += Math.Sin(2 * D + 2 * M) * .0005;
            sum += Math.Sin(6 * D + 2 * F) * .0004;
            sum += Math.Sin(6 * D - 2 * M) * .0004;
            sum += Math.Sin(10 * D - M) * .0004;
            sum += Math.Sin(5 * D) * -0.0004;
            sum += Math.Sin(4 * D - 2 * F) * -0.0004;
            sum += Math.Sin(2 * F + M) * .0003;
            sum += Math.Sin(12 * D) * .0003;
            sum += Math.Sin(2 * D + 2 * F - M) * 0.0003;
            sum += Math.Sin(D - M) * -0.0003;
            return sum;
        }
        /// <summary>
        /// Sum of Perigee Terms from Jean Meeus Astronomical Algorithms Table 50.A
        /// </summary>
        /// <param name="D">Moom's mean elongation at time JDE</param>
        /// <param name="M">Sun's mean anomaly</param>
        /// <param name="F">Moon's arguement f latitude</param>
        /// <param name="T">Time in Julian centuries since epoch 2000</param>
        /// <returns>double</returns>
        public static double PerigeeTermsA(double D, double M, double F, double T)
        {
            double sum;

            sum = Math.Sin(2 * D) * -1.6769;
            sum += Math.Sin(4 * D) * .4589;
            sum += Math.Sin(6 * D) * -.1856;
            sum += Math.Sin(8 * D) * .0883;
            sum += Math.Sin(2 * D - M) * -.0773 + .00019 * T;
            sum += Math.Sin(M) * .0502 - .00013 * T;
            sum += Math.Sin(10 * D) * -.0460;
            sum += Math.Sin(4 * D - M) * .0422 - .00011 * T;
            sum += Math.Sin(6 * D - M) * -.0256;
            sum += Math.Sin(12 * D) * .0253;
            sum += Math.Sin(D) * .0237;
            sum += Math.Sin(8 * D - M) * .0162;
            sum += Math.Sin(14 * D) * -.0145;
            sum += Math.Sin(2 * F) * .0129;
            sum += Math.Sin(3 * D) * -.0112;
            sum += Math.Sin(10 * D - M) * -.0104;
            sum += Math.Sin(16 * D) * .0086;
            sum += Math.Sin(12 * D - M) * .0069;
            sum += Math.Sin(5 * D) * .0066;
            sum += Math.Sin(2 * D + 2 * F) * -.0053;
            sum += Math.Sin(18 * D) * -.0052;
            sum += Math.Sin(14 * D - M) * -.0046;
            sum += Math.Sin(7 * D) * -.0041;
            sum += Math.Sin(2 * D + M) * .0040;
            sum += Math.Sin(20 * D) * .0032;
            sum += Math.Sin(D + M) * -.0032;
            sum += Math.Sin(16 * D - M) * .0031;
            sum += Math.Sin(4 * D + M) * -.0029;
            sum += Math.Sin(9 * D) * .0027;
            sum += Math.Sin(4 * D + 2 * F) * .0027;

            sum += Math.Sin(2 * D - 2 * M) * -.0027;
            sum += Math.Sin(4 * D - 2 * M) * .0024;
            sum += Math.Sin(6 * D - 2 * M) * -.0021;
            sum += Math.Sin(22 * D) * -.0021;
            sum += Math.Sin(18 * D - M) * -.0021;
            sum += Math.Sin(6 * D + M) * .0019;
            sum += Math.Sin(11 * D) * -.0018;
            sum += Math.Sin(8 * D + M) * -.0014;
            sum += Math.Sin(4 * D - 2 * F) * -.0014;
            sum += Math.Sin(6 * D + 2 * F) * -.0014;
            sum += Math.Sin(3 * D + M) * .0014;
            sum += Math.Sin(5 * D + M) * -.0014;
            sum += Math.Sin(13 * D) * .0013;
            sum += Math.Sin(20 * D - M) * .0013;
            sum += Math.Sin(3 * D + 2 * M) * .0011;
            sum += Math.Sin(4 * D + 2 * F - 2 * M) * -.0011;
            sum += Math.Sin(D + 2 * M) * -.0010;
            sum += Math.Sin(22 * D - M) * -.0009;
            sum += Math.Sin(4 * F) * -.0008;
            sum += Math.Sin(6 * D - 2 * F) * .0008;
            sum += Math.Sin(2 * D - 2 * F + M) * .0008;
            sum += Math.Sin(2 * M) * .0007;
            sum += Math.Sin(2 * F - M) * .0007;
            sum += Math.Sin(2 * D + 4 * F) * .0007;
            sum += Math.Sin(2 * F - 2 * M) * -.0006;
            sum += Math.Sin(2 * D - 2 * F + 2 * M) * -.0006;
            sum += Math.Sin(24 * D) * .0006;
            sum += Math.Sin(4 * D - 4 * F) * .0005;
            sum += Math.Sin(2 * D + 2 * M) * .0005;
            sum += Math.Sin(D - M) * -.0004;

            return sum;
        }
        /// <summary>
        /// Sum of Apogee Terms from Jean Meeus Astronomical Algorithms Table 50.B
        /// </summary>
        /// <param name="D">Moom's mean elongation at time JDE</param>
        /// <param name="M">Sun's mean anomaly</param>
        /// <param name="F">Moon's arguement f latitude</param>
        /// <param name="T">Time in Julian centuries since epoch 2000</param>
        /// <returns>double</returns>
        public static double ApogeeTermsB(double D, double M, double F, double T)
        {
            double sum = 3245.251;

            sum += Math.Cos(2 * D) * -9.147;
            sum += Math.Cos(D) * -.841;
            sum += Math.Cos(2 * F) * .697;
            sum += Math.Cos(M) * -0.656 + .0016 * T;
            sum += Math.Cos(4 * D) * .355;
            sum += Math.Cos(2 * D - M) * .159;
            sum += Math.Cos(D + M) * .127;
            sum += Math.Cos(4 * D - M) * .065;

            sum += Math.Cos(6 * D) * .052;
            sum += Math.Cos(2 * D + M) * .043;
            sum += Math.Cos(2 * D + 2 * F) * .031;
            sum += Math.Cos(2 * D - 2 * F) * -.023;
            sum += Math.Cos(2 * D - 2 * M) * .022;
            sum += Math.Cos(2 * D + 2 * M) * .019;
            sum += Math.Cos(2 * M) * -.016;
            sum += Math.Cos(6 * D - M) * .014;
            sum += Math.Cos(8 * D) * .010;

            return sum;
        }
        /// <summary>
        /// Sum of Perigee Terms from Jean Meeus Astronomical Algorithms Table 50.B
        /// </summary>
        /// <param name="D">Moom's mean elongation at time JDE</param>
        /// <param name="M">Sun's mean anomaly</param>
        /// <param name="F">Moon's arguement f latitude</param>
        /// <param name="T">Time in Julian centuries since epoch 2000</param>
        /// <returns>double</returns>
        public static double PerigeeTermsB(double D, double M, double F, double T)
        {
            //Sum of Perigee Terms from Jean Meeus Astronomical Algorithms Table 50.B          
            double sum = 3629.215;

            sum += Math.Cos(2 * D) * 63.224;
            return sum;
        }
    }
    /// <summary>
    ///  moon perigee or apogee indicator
    /// </summary>
    internal enum MoonDistanceType
    {
        /// <summary>
        /// Moon's perigee
        /// </summary>
        Perigee,
        /// <summary>
        /// Moon's apogee
        /// </summary>
        Apogee
    }
    /// <summary>
    /// Stores Perigee or Apogee values
    /// </summary>
    [Serializable]
    public class PerigeeApogee
    {
        private DateTime date;
        private double horizontalParallax;

        /// <summary>
        /// Initializes a Perigee or Apogee object
        /// </summary>
        /// <param name="d">Date of Event</param>
        /// <param name="p">Horizontal Parallax</param>
        public PerigeeApogee(DateTime d, double p)
        {
            date = d;
            horizontalParallax = p;
        }

        /// <summary>
        /// Date of event.
        /// </summary>
        public DateTime Date
        {
            get { return date; }
        }
        /// <summary>
        /// Horizontal Parallax.
        /// </summary>
        public double HorizontalParallax
        {
            get { return horizontalParallax; }
        }
    }
    /// <summary>
    /// Used for Julian date conversions
    /// </summary>
    internal class JulianConversions
    {
        private static double dayMs = 1000 * 60 * 60 * 24, J1970 = 2440588, J2000 = 2451545;
        public static double toJulian(DateTime date)
        {
            DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime t = date;
            double l = (double)(t - d).TotalMilliseconds;
            double tj = l / dayMs - 0.5 + J1970;

            return tj;

        }
        public static double toDays(DateTime date)
        {
            double d = toJulian(date) - J2000;

            return d;
        }
        public static double GetJulianDay(DateTime date)
        {
            int month = date.Month;
            int day = date.Day;
            int year = date.Year;

            bool gregorian = (year < 1583) ? false : true;

            if ((month == 1) || (month == 2))
            {
                year = year - 1;
                month = month + 12;
            }

            double a = Math.Truncate((double)year / 100);
            double b = 0;

            if (gregorian)
                b = 2 - a + Math.Truncate(a / 4);
            else
                b = 0.0;

            double jd = Math.Truncate(365.25 * (year + 4716))
                       + Math.Truncate(30.6001 * (month + 1))
                       + day + b - 1524.5;

            return jd;
        }
        public static DateTime? fromJulian(double j)
        {
            if (Double.IsNaN(j)) { return null; } //No Event Occured

            double unixTime = (j + 0.5 - J1970) * 86400;

            System.DateTime dtDateTime = new DateTime(1970, 1, 1);
            dtDateTime = dtDateTime.AddSeconds(unixTime);

            return dtDateTime;

        }
    }
    /// <summary>
    /// Contains last and next perigee
    /// </summary>
    [Serializable]
    public class Perigee
    {
        private PerigeeApogee lastPerigee;
        private PerigeeApogee nextPerigee;

        /// <summary>
        /// Initializes an Perigee object.
        /// </summary>
        /// <param name="last"></param>
        /// <param name="next"></param>
        public Perigee(PerigeeApogee last, PerigeeApogee next)
        {
            lastPerigee = last;
            nextPerigee = next;
        }

        /// <summary>
        /// Last perigee
        /// </summary>
        public PerigeeApogee LastPerigee { get { return lastPerigee; } }
        /// <summary>
        /// Next perigee
        /// </summary>
        public PerigeeApogee NextPerigee { get { return NextPerigee; } }

    }
    /// <summary>
    /// Contains last and next apogee
    /// </summary>
    [Serializable]
    public class Apogee
    {
        private PerigeeApogee lastApogee;
        private PerigeeApogee nextApogee;

        /// <summary>
        /// Initializes an Apogee object.
        /// </summary>
        /// <param name="last"></param>
        /// <param name="next"></param>
        public Apogee(PerigeeApogee last, PerigeeApogee next)
        {
            lastApogee = last;
            nextApogee = next;
        }

        /// <summary>
        /// Last apogee
        /// </summary>
        public PerigeeApogee LastApogee { get { return lastApogee; } }
        /// <summary>
        /// Next apogee
        /// </summary>
        public PerigeeApogee NextApogee { get { return NextApogee; } }
    }
    /// <summary>
    /// Astrological Signs
    /// </summary>
    [Serializable]
    public class AstrologicalSigns
    {
        /// <summary>
        /// Astrological Zodiac Sign
        /// </summary>
        public string MoonName { get; set; }
        /// <summary>
        /// Astrological Moon Sign
        /// </summary>
        public string MoonSign { get; set; }
        /// <summary>
        /// Astrological Zodiac Sign
        /// </summary>
        public string ZodiacSign { get; set; }
    }
    /// <summary>
    /// Additional Solar Time Information
    /// </summary>
    [Serializable]
    public class AdditionalSolarTimes
    {
        /// <summary>
        /// Create an AdditionalSolarTimes object.
        /// </summary>
        public AdditionalSolarTimes()
        {
            //Set dates to avoid null errors. If year return 1900 event did not occur.
            CivilDawn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            CivilDusk = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            NauticalDawn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            NauticalDusk = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        }
        /// <summary>
        /// Returns Civil Dawn Time
        /// </summary>
        public DateTime? CivilDawn { get; set; }
        /// <summary>
        /// Returns Civil Dusk Time
        /// </summary>
        public DateTime? CivilDusk { get; set; }
        /// <summary>
        /// Returns Nautical Dawn Time
        /// </summary>
        public DateTime? NauticalDawn { get; set; }
        /// <summary>
        /// Returns Nautical Dusk Time
        /// </summary>
        public DateTime? NauticalDusk { get; set; }
    }
    /// <summary>
    /// Class containing solar eclipse information
    /// </summary>
    [Serializable]
    public class SolarEclipse
    {
        /// <summary>
        /// Initialize a SolarEclipse object
        /// </summary>
        public SolarEclipse()
        {
            LastEclipse = new SolarEclipseDetails();
            NextEclipse = new SolarEclipseDetails();
        }
        /// <summary>
        /// Details about the previous solar eclipse
        /// </summary>
        public SolarEclipseDetails LastEclipse { get; set; }
        /// <summary>
        /// Details about the next solar eclipse
        /// </summary>
        public SolarEclipseDetails NextEclipse { get; set; }
    }
    /// <summary>
    /// Class containing lunar eclipse information
    /// </summary>
    [Serializable]
    public class LunarEclipse
    {
        /// <summary>
        /// Initialize a LunarEclipse object
        /// </summary>
        public LunarEclipse()
        {
            LastEclipse = new LunarEclipseDetails();
            NextEclipse = new LunarEclipseDetails();
        }
        /// <summary>
        /// Details about the previous lunar eclipse
        /// </summary>
        public LunarEclipseDetails LastEclipse { get; set; }
        /// <summary>
        /// Details about the next lunar eclipse
        /// </summary>
        public LunarEclipseDetails NextEclipse { get; set; }
    }
    /// <summary>
    /// Class containing specific solar eclipse information
    /// </summary>
    [Serializable]
    public class SolarEclipseDetails
    {
        private DateTime date;
        private SolarEclipseType type;
        private DateTime partialEclispeBegin;
        private DateTime aorTEclipseBegin;
        private DateTime maximumEclipse;
        private DateTime aorTEclipseEnd;
        private DateTime partialEclispeEnd;
        private TimeSpan aorTDuration;
        private bool hasEclipseData;

        /// <summary>
        /// Initialize a SolarEclipseDetails object
        /// </summary>
        /// <param name="values">Solar Eclipse String Values</param>
        public SolarEclipseDetails(List<string> values)
        {
            //Eclipse has value
            hasEclipseData = true;
            //Set Eclipse Date
            date = Convert.ToDateTime(values[0]);

            switch (values[1])
            {
                case "P":
                    type = SolarEclipseType.Partial;
                    break;
                case "A":
                    type = SolarEclipseType.Annular;
                    break;
                case "T":
                    type = SolarEclipseType.Total;
                    break;
                default:
                    break;
            }
            TimeSpan ts;
            //Eclipse start
            if (TimeSpan.TryParse(values[2], out ts))
            {
                partialEclispeBegin = date.Add(ts);
            }
            //A or T start
            if (TimeSpan.TryParse(values[4], out ts))
            {
                aorTEclipseBegin = date.Add(ts);
            }
            //Maximum Eclipse
            if (TimeSpan.TryParse(values[5], out ts))
            {
                maximumEclipse = date.Add(ts);
            }
            //A or T ends
            if (TimeSpan.TryParse(values[8], out ts))
            {
                aorTEclipseEnd = date.Add(ts);
            }
            //Eclipse end
            if (TimeSpan.TryParse(values[9], out ts))
            {
                partialEclispeEnd = date.Add(ts);
            }
            //A or T Duration
            if (values[13] != "-")
            {
                string s = values[13].Replace("m", ":").Replace("s", "");
                string[] ns = s.Split(':');
                int mins = 0;
                int secs = 0;

                int.TryParse(ns[0], out mins);
                if (ns.Count() > 0)
                {
                    int.TryParse(ns[1], out secs);
                }

                TimeSpan time = new TimeSpan(0, mins, secs);

                aorTDuration = time;
            }
            else
            {
                aorTDuration = new TimeSpan();
            }
            Adjust_Dates();//Adjust dates if required (needed when eclipse crosses into next day).
        }
        /// <summary>
        /// Initialize an empty SolarEclipseDetails object
        /// </summary>
        public SolarEclipseDetails()
        {
            hasEclipseData = false;
        }
        /// <summary>
        /// JS Eclipse Calc formulas didn't account for Z time calculation.
        /// Iterate through and adjust Z dates where eclipse is passed midnight.
        /// </summary>
        private void Adjust_Dates()
        {
            //Load array in reverse event order
            DateTime[] dateArray = new DateTime[] { partialEclispeBegin, aorTEclipseBegin, maximumEclipse, aorTEclipseEnd, partialEclispeEnd };
            DateTime baseTime = partialEclispeEnd;
            bool multiDay = false; //used to detrmine if eclipse crossed into next Z day

            for (int x = 4; x >= 0; x--)
            {
                DateTime d = dateArray[x];
                //Check if date exist
                if (d > new DateTime())
                {

                    //Adjust if time is less than then baseTime.
                    if (d > baseTime)
                    {
                        switch (x)
                        {
                            case 3:
                                aorTEclipseEnd = aorTEclipseEnd.AddDays(-1);
                                break;
                            case 2:
                                maximumEclipse = maximumEclipse.AddDays(-1);
                                break;
                            case 1:
                                aorTEclipseBegin = aorTEclipseBegin.AddDays(-1);
                                break;
                            case 0:
                                partialEclispeBegin = partialEclispeBegin.AddDays(-1);
                                break;
                            default:
                                break;
                        }

                        multiDay = true;//Set true to change base date value.
                    }
                }
            }
            if (multiDay)
            {
                this.date = this.date.AddDays(-1); //Shave day off base date if multiday.
            }
        }
        /// <summary>
        /// Determine if the SolarEclipseDetails object has been populated
        /// </summary>
        public bool HasEclipseData { get { return hasEclipseData; } }
        /// <summary>
        /// Date of solar eclipse
        /// </summary>
        public DateTime Date { get { return date; } }
        /// <summary>
        /// Solar eclipse type
        /// </summary>
        public SolarEclipseType Type { get { return type; } }
        /// <summary>
        /// DateTime when the partial eclipse begins
        /// </summary>
        public DateTime PartialEclispeBegin { get { return partialEclispeBegin; } }
        /// <summary>
        /// DateTime when an Annular or Total eclipse begins (if applicable)
        /// </summary>
        public DateTime AorTEclipseBegin { get { return aorTEclipseBegin; } }
        /// <summary>
        /// DateTime when eclipse is at Maximum
        /// </summary>
        public DateTime MaximumEclipse { get { return maximumEclipse; } }

        /// <summary>
        /// DateTime when the Annular or Total eclipse ends (if applicable)
        /// </summary>
        public DateTime AorTEclipseEnd { get { return aorTEclipseEnd; } }
        /// <summary>
        /// DateTime when the partial elipse ends
        /// </summary>
        public DateTime PartialEclispeEnd { get { return partialEclispeEnd; } }
        /// <summary>
        /// Duration of Annular or Total eclipse (if applicable)
        /// </summary>
        public TimeSpan AorTDuration { get { return aorTDuration; } }
        /// <summary>
        /// Solat eclipse default string
        /// </summary>
        /// <returns>Solar eclipse base date string</returns>
        public override string ToString()
        {
            return date.ToString("dd-MMM-yyyy");
        }
    }
    /// <summary>
    /// Class containing specific lunar eclipse information
    /// </summary>
    [Serializable]
    public class LunarEclipseDetails
    {
        private DateTime date;
        private LunarEclipseType type;
        private DateTime penumbralEclipseBegin;
        private DateTime partialEclispeBegin;
        private DateTime totalEclipseBegin;
        private DateTime midEclipse;
        private DateTime totalEclipseEnd;
        private DateTime partialEclispeEnd;
        private DateTime penumbralEclipseEnd;

        private bool hasEclipseData;

        /// <summary>
        /// Initialize a LunarEclipseDetails object
        /// </summary>
        /// <param name="values">Lunar Eclipse String Values</param>
        public LunarEclipseDetails(List<string> values)
        {
            //Eclipse has value
            hasEclipseData = true;
            //Set Eclipse Date
            date = Convert.ToDateTime(values[0]);
            switch (values[1])
            {
                case "T":
                    type = LunarEclipseType.Total;
                    break;
                case "P":
                    type = LunarEclipseType.Partial;
                    break;
                case "N":
                    type = LunarEclipseType.Penumbral;
                    break;
                default:
                    break;
            }
            TimeSpan ts;
            //Penumbral Eclipse start
            if (TimeSpan.TryParse(values[4], out ts))
            {
                penumbralEclipseBegin = date.Add(ts);
            }
            //PartialEclipse start
            if (TimeSpan.TryParse(values[6], out ts))
            {
                partialEclispeBegin = date.Add(ts);
            }
            //Total start
            if (TimeSpan.TryParse(values[8], out ts))
            {
                totalEclipseBegin = date.Add(ts);
            }
            //Mid Eclipse
            if (TimeSpan.TryParse(values[10], out ts))
            {
                midEclipse = date.Add(ts);
            }
            //Total ends
            if (TimeSpan.TryParse(values[12], out ts))
            {
                totalEclipseEnd = date.Add(ts);
            }
            //Partial Eclipse end
            if (TimeSpan.TryParse(values[14], out ts))
            {
                partialEclispeEnd = date.Add(ts);
            }
            //Penumbral Eclipse end
            if (TimeSpan.TryParse(values[16], out ts))
            {
                penumbralEclipseEnd = date.Add(ts);
            }
            Adjust_Dates();
        }
        /// <summary>
        /// Initialize an empty LunarEclipseDetails object
        /// </summary>
        public LunarEclipseDetails()
        {
            hasEclipseData = false;
        }
        /// <summary>
        /// JS Eclipse Calc formulas didn't account for Z time calculation.
        /// Iterate through and adjust Z dates where eclipse is passed midnight.
        /// </summary>
        private void Adjust_Dates()
        {
            //Load array in squential order.
            DateTime[] dateArray = new DateTime[] { penumbralEclipseBegin, partialEclispeBegin, totalEclipseBegin, midEclipse, totalEclipseEnd, partialEclispeEnd, penumbralEclipseEnd };
            DateTime baseTime = partialEclispeEnd;
            bool multiDay = false; //used to detrmine if eclipse crossed into next Z day
            baseTime = penumbralEclipseBegin;
            for (int x = 0; x < dateArray.Count(); x++)
            {
                DateTime d = dateArray[x];
                //Check if date exist
                if (d > new DateTime())
                {
                    if (d < baseTime)
                    {
                        multiDay = true;
                    }
                }
                baseTime = dateArray[x];
                if (multiDay == true)
                {
                    switch (x)
                    {
                        case 1:
                            partialEclispeBegin = partialEclispeBegin.AddDays(1);
                            break;
                        case 2:
                            totalEclipseBegin = totalEclipseBegin.AddDays(1);
                            break;
                        case 3:
                            midEclipse = midEclipse.AddDays(1);
                            break;
                        case 4:
                            totalEclipseEnd = totalEclipseEnd.AddDays(1);
                            break;
                        case 5:
                            partialEclispeEnd = partialEclispeEnd.AddDays(1);
                            break;
                        case 6:
                            penumbralEclipseEnd = penumbralEclipseEnd.AddDays(1);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Determine if the LunarEclipseDetails object has been populated
        /// </summary>
        public bool HasEclipseData { get { return hasEclipseData; } }
        /// <summary>
        /// Date of lunar eclipse
        /// </summary>
        public DateTime Date { get { return date; } }
        /// <summary>
        /// Lunar eclipse type
        /// </summary>
        public LunarEclipseType Type { get { return type; } }
        /// <summary>
        /// DateTime when the penumbral eclipse begins
        /// </summary>
        public DateTime PenumbralEclipseBegin { get { return penumbralEclipseBegin; } }
        /// <summary>
        /// DateTime when the partial eclipse begins (if applicable)
        /// </summary>
        public DateTime PartialEclispeBegin { get { return partialEclispeBegin; } }
        /// <summary>
        /// DateTime when Total eclipse begins (if applicable)
        /// </summary>
        public DateTime TotalEclipseBegin { get { return totalEclipseBegin; } }
        /// <summary>
        /// DateTime when eclipse is at Mid
        /// </summary>
        public DateTime MidEclipse { get { return midEclipse; } }
        /// <summary>
        /// DateTime when Total eclipse ends (if applicable)
        /// </summary>
        public DateTime TotalEclipseEnd { get { return totalEclipseEnd; } }
        /// <summary>
        /// DateTime when the partial elipse ends (if applicable)
        /// </summary>
        public DateTime PartialEclispeEnd { get { return partialEclispeEnd; } }
        /// <summary>
        /// DateTime when the penumbral elipse ends
        /// </summary>
        public DateTime PenumbralEclispeEnd { get { return penumbralEclipseEnd; } }
        /// <summary>
        /// Lunar eclipse default string
        /// </summary>
        /// <returns>Lunar eclipse base date string</returns>
        public override string ToString()
        {
            return date.ToString("dd-MMM-yyyy");
        }

    }
    /// <summary>
    /// Solar eclipse type
    /// </summary>
    [Serializable]
    public enum SolarEclipseType
    {
        /// <summary>
        /// Partial Eclipse
        /// </summary>
        Partial,
        /// <summary>
        /// Annular Eclipse
        /// </summary>
        Annular,
        /// <summary>
        /// Total Eclipse...of the heart...
        /// </summary>
        Total
    }
    /// <summary>
    /// Lunar eclipse type
    /// </summary>
    [Serializable]
    public enum LunarEclipseType
    {
        /// <summary>
        /// Penumbral Eclipse
        /// </summary>
        Penumbral,
        /// <summary>
        /// Partial Eclipse
        /// </summary>
        Partial,
        /// <summary>
        /// Total Eclipse...of the heart...
        /// </summary>
        Total
    }
}
