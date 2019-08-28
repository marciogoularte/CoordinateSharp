﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CoordinateSharp;
using System.Reflection;
using System.Diagnostics;
namespace CoordinateSharp_TestProj
{
    public class CelestialTests
    {
        public static void Run_Test()
        {
            Console.WriteLine("Loading Celestial Values...");
            Console.WriteLine();
            CelestialTests ct = new CelestialTests();

            ct.Populate_CelestialTests();
            Coordinate c = new Coordinate();

            Pass.Write("Sunset: ", ct.Check_Values(ct.SunSets, "CelestialData\\SunSet.txt"));
            Pass.Write("Sunrise: ", ct.Check_Values(ct.SunRises, "CelestialData\\SunRise.txt"));          
            Pass.Write("AstroDawn: ", ct.Check_Values(ct.AstroDawn, "CelestialData\\AstroDawn.txt"));
            Pass.Write("AstroDusk: ", ct.Check_Values(ct.AstroDusk, "CelestialData\\AstroDusk.txt"));
            Pass.Write("CivilDawn: ", ct.Check_Values(ct.CivilDawn, "CelestialData\\CivilDawn.txt"));
            Pass.Write("CivilDusk: ", ct.Check_Values(ct.CivilDusk, "CelestialData\\CivilDusk.txt"));
            Pass.Write("NauticalDawn: ", ct.Check_Values(ct.NauticalDawn, "CelestialData\\NauticalDawn.txt"));
            Pass.Write("NauticalDusk: ", ct.Check_Values(ct.NauticalDusk, "CelestialData\\NauticalDusk.txt"));
            Pass.Write("BottomSolarDiscRise: ", ct.Check_Values(ct.BottomSolarDiscRise, "CelestialData\\BottomDiscRise.txt"));
            Pass.Write("BottomSolarDiscSet: ", ct.Check_Values(ct.BottomSolarDiscSet, "CelestialData\\BottomDiscSet.txt"));
            Pass.Write("Moon Set: ", ct.Check_Values(ct.MoonSets, "CelestialData\\MoonSet.txt"));
            Pass.Write("Moon Rise: ", ct.Check_Values(ct.MoonRises, "CelestialData\\MoonRise.txt"));
            Console.WriteLine();
            Pass.Write("Sun Altitude: ", ct.Check_Values(ct.SunAlts, "CelestialData\\SunAlts.txt"));
            Pass.Write("Sun Azimuth: ", ct.Check_Values(ct.SunAzs, "CelestialData\\SunAzs.txt"));
            Pass.Write("Moon Altitude: ", ct.Check_Values(ct.MoonAlts, "CelestialData\\MoonAlts.txt"));
            Pass.Write("Moon Azimuth: ", ct.Check_Values(ct.MoonAzs, "CelestialData\\MoonAzs.txt"));
            Pass.Write("Moon Distance: ", ct.Check_Values(ct.MoonDistances, "CelestialData\\MoonDistance.txt"));
            Pass.Write("Moon Fraction: ", ct.Check_Values(ct.MoonFraction, "CelestialData\\MoonFraction.txt"));
            Pass.Write("Moon Phase ", ct.Check_Values(ct.MoonPhase, "CelestialData\\MoonPhase.txt"));
            Pass.Write("Moon Phase Name: ", ct.Check_Values(ct.MoonPhaseName, "CelestialData\\MoonPhaseName.txt"));
            Console.WriteLine();
            Pass.Write("Solar Eclipse: ", ct.Check_Solar_Eclipse());
            Pass.Write("Lunar Eclipse: ", ct.Check_Lunar_Eclipse());
            Pass.Write("Perigee: ", ct.Check_Perigee());
            Pass.Write("Apogee: ", ct.Check_Apogee());
            Console.WriteLine();
            Console.WriteLine("***Running IsSunUp Test (This will take a minute)****");
            Console.WriteLine();
            Pass.Write("IsSunUp", ct.Check_IsSunUp());
            Console.WriteLine();
            Console.WriteLine("***Running IsMoonUp Test (This will take a minute)****");
            Console.WriteLine();
            Pass.Write("IsMoonUp", ct.Check_IsMoonUp());
            Console.WriteLine();
        }
        private void Populate_CelestialTests()
        {
            //Test will run against N39, W72
            //Sun Times and Moon Times will range for 1 Mar-2018 to 30-Mar-2018
            //Sun/Moon Alt, Az, Perigee, Apogee, Eclipses, fraction and distance with be tested against 15-Mar-2018 UTC
            Coordinate c = new Coordinate(39, -72, new DateTime(2018, 03, 15));
            SunAlts = new List<double>();
            SunAzs = new List<double>();
            MoonAlts = new List<double>();
            MoonAzs = new List<double>();
            MoonAlts = new List<double>();
            MoonDistances = new List<double>();
            MoonFraction = new List<double>();
            MoonPhase = new List<double>();
            MoonPhaseName = new List<string>();       

            for (int x = 0; x < 144; x++)
            {
                if (x != 0)
                {
                    c.GeoDate = c.GeoDate.AddMinutes(10);
                }
                SunAlts.Add(c.CelestialInfo.SunAltitude);
                SunAzs.Add(c.CelestialInfo.SunAzimuth);
                MoonAlts.Add(c.CelestialInfo.MoonAltitude);
                MoonAzs.Add(c.CelestialInfo.MoonAzimuth);
                MoonFraction.Add(c.CelestialInfo.MoonIllum.Fraction);
               
            }
          
            c.GeoDate = new DateTime(2018, 3, 1);

            SunRises = new List<DateTime?>();        
            SunSets = new List<DateTime?>();
            MoonRises = new List<DateTime?>();
            MoonSets = new List<DateTime?>();

            CivilDawn = new List<DateTime?>();
            CivilDusk = new List<DateTime?>();
            NauticalDawn = new List<DateTime?>();
            NauticalDusk = new List<DateTime?>();
            AstroDawn = new List<DateTime?>();
            AstroDusk = new List<DateTime?>();
            BottomSolarDiscRise = new List<DateTime?>();
            BottomSolarDiscSet = new List<DateTime?>();
           
            for (int x = 0; x < 31; x++)
            {
                if (x != 0)
                {
                    c.GeoDate = c.GeoDate.AddDays(1);
                }
                SunRises.Add(c.CelestialInfo.SunRise);
                SunSets.Add(c.CelestialInfo.SunSet);
                MoonRises.Add(c.CelestialInfo.MoonRise);
                MoonSets.Add(c.CelestialInfo.MoonSet);

                MoonDistances.Add(c.CelestialInfo.MoonDistance.Kilometers);
                CivilDawn.Add(c.CelestialInfo.AdditionalSolarTimes.CivilDawn);
                CivilDusk.Add(c.CelestialInfo.AdditionalSolarTimes.CivilDusk);
                NauticalDawn.Add(c.CelestialInfo.AdditionalSolarTimes.NauticalDawn);
                NauticalDusk.Add(c.CelestialInfo.AdditionalSolarTimes.NauticalDusk);
                AstroDawn.Add(c.CelestialInfo.AdditionalSolarTimes.AstronomicalDawn);
                AstroDusk.Add(c.CelestialInfo.AdditionalSolarTimes.AstronomicalDusk);
                BottomSolarDiscRise.Add(c.CelestialInfo.AdditionalSolarTimes.SunriseBottomDisc);
                BottomSolarDiscSet.Add(c.CelestialInfo.AdditionalSolarTimes.SunsetBottomDisc);

                MoonPhase.Add(c.CelestialInfo.MoonIllum.Phase);
                MoonPhaseName.Add(c.CelestialInfo.MoonIllum.PhaseName);            
            }

            //Set Dates and Finish
            //THESE OBJECT ARE TESTED AGAINST SERIALIZED OBJECTS.
            //IF CHANGING THE MODEL YOU WILL HAVE TO CHANGE THE OBJECTS THEY ARE TESTED AGAINST AS WELL

            SolarEclispe = c.CelestialInfo.SolarEclipse;
            LunarEclispe = c.CelestialInfo.LunarEclipse;
            Perigee = c.CelestialInfo.Perigee;
            Apogee = c.CelestialInfo.Apogee;          
        }
        private void Check_Solar_Only_Times()
        {
            bool pass = true;

            //Check if values populate.
            Celestial c = Celestial.CalculateSunData(45, 45, DateTime.Now);
        }
        private bool Check_Values(object prop, string file)
        {
            string[] lines = File.ReadAllLines(file);

            if (prop.GetType() == typeof(List<DateTime?>))
            {
                List<DateTime?> d = (List<DateTime?>)prop;
                for (int x = 0; x < lines.Length; x++)
                {
                    DateTime date;
                    if(lines[x] != "*")
                    {
                        if (DateTime.TryParse(lines[x], out date))
                        {
                            TimeSpan span = date - d[x].Value;
                            if(Math.Abs(span.TotalMinutes)> 1)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }                 
                    }
                    else
                    {
                        if (d[x].HasValue) { return false; }
                    }
                }
            }
            if (prop.GetType() == typeof(List<double>))
            {
                List<double> d = (List<double>)prop;
                for (int x = 0; x < lines.Length; x++)
                {
                    double dub;

                    if (double.TryParse(lines[x], out dub))
                    {
                        if (Math.Abs(dub - d[x]) > 1)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (prop.GetType() == typeof(List<string>))
            {
                List<string> d = (List<string>)prop;
                for (int x = 0; x < lines.Length; x++)
                {               
                    if (lines[x] != d[x])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool Check_Solar_Eclipse()
        {
            IFormatter formatter = new BinaryFormatter();
            //Deserialize     
            using (StreamReader streamReader = new StreamReader("CelestialData\\SolarEclipse.txt"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                SolarEclipse ev = (SolarEclipse)binaryFormatter.Deserialize(streamReader.BaseStream);

                SolarEclipseDetails lE1 = ev.LastEclipse;
                SolarEclipseDetails nE1 = ev.NextEclipse;
                SolarEclipseDetails lE2 = SolarEclispe.LastEclipse;
                SolarEclipseDetails nE2 = SolarEclispe.NextEclipse;
                
                PropertyInfo[] properties = typeof(SolarEclipseDetails).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    var l1 = property.GetValue(lE1);
                    var l2 = property.GetValue(lE2);
                    var n1 = property.GetValue(nE1);
                    var n2 = property.GetValue(nE2);

                    if (l1.ToString() != l2.ToString()) { return false; }

                    if (n1.ToString() != n2.ToString()) { return false; }

                }
            }
            return true;
        }
        private bool Check_Lunar_Eclipse()
        {
            IFormatter formatter = new BinaryFormatter();
            //Deserialize     
            using (StreamReader streamReader = new StreamReader("CelestialData\\LunarEclipse.txt"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                LunarEclipse ev = (LunarEclipse)binaryFormatter.Deserialize(streamReader.BaseStream);

                LunarEclipseDetails lE1 = ev.LastEclipse;
                LunarEclipseDetails nE1 = ev.NextEclipse;
                LunarEclipseDetails lE2 = LunarEclispe.LastEclipse;
                LunarEclipseDetails nE2 = LunarEclispe.NextEclipse;
                
                PropertyInfo[] properties = typeof(LunarEclipseDetails).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    var l1 = property.GetValue(lE1);
                    var l2 = property.GetValue(lE2);
                    var n1 = property.GetValue(nE1);
                    var n2 = property.GetValue(nE2);

                    if (l1.ToString() != l2.ToString()) { return false; }

                    if (n1.ToString() != n2.ToString()) { return false; }

                }
            }
            return true;
        }
        private bool Check_Perigee()
        {
            IFormatter formatter = new BinaryFormatter();
            //Deserialize     
            using (StreamReader streamReader = new StreamReader("CelestialData\\Perigee.txt"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Perigee ev = (Perigee)binaryFormatter.Deserialize(streamReader.BaseStream);

                PerigeeApogee lE1 = ev.LastPerigee;
                PerigeeApogee nE1 = ev.NextPerigee;
                PerigeeApogee lE2 = this.Perigee.LastPerigee;
                PerigeeApogee nE2 = this.Perigee.NextPerigee;
                
                PropertyInfo[] properties = typeof(PerigeeApogee).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    var l1 = property.GetValue(lE1);
                    var l2 = property.GetValue(lE2);
                    var n1 = property.GetValue(nE1);
                    var n2 = property.GetValue(nE2);

                    if (l1.ToString() != l2.ToString()) { return false; }
                    if (l1.GetType() == typeof(Distance) && l2.GetType() == typeof(Distance))
                    {
                        PropertyInfo[] propertiesSub = typeof(Distance).GetProperties();
                        foreach (PropertyInfo propertySub in propertiesSub)
                        {
                            var l1Sub = propertySub.GetValue(l1);
                            var l2Sub = propertySub.GetValue(l2);
                            if (l1Sub.ToString() != l2Sub.ToString()) { return false; }
                        }
                    }
                    if (n1.ToString() != n2.ToString()) { return false; }
                    if (n1.GetType() == typeof(Distance) && n2.GetType() == typeof(Distance))
                    {
                        PropertyInfo[] propertiesSub = typeof(Distance).GetProperties();
                        foreach (PropertyInfo propertySub in propertiesSub)
                        {
                            var n1Sub = propertySub.GetValue(n1);
                            var n2Sub = propertySub.GetValue(n2);
                            if (n1Sub.ToString() != n2Sub.ToString()) { return false; }
                        }
                    }

                }
            }
            return true;
        }
        private bool Check_Apogee()
        {
            IFormatter formatter = new BinaryFormatter();
            //Deserialize     
            using (StreamReader streamReader = new StreamReader("CelestialData\\Apogee.txt"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Apogee ev = (Apogee)binaryFormatter.Deserialize(streamReader.BaseStream);

                PerigeeApogee lE1 = ev.LastApogee;
                PerigeeApogee nE1 = ev.NextApogee;
                PerigeeApogee lE2 = this.Apogee.LastApogee;
                PerigeeApogee nE2 = this.Apogee.NextApogee;

                PropertyInfo[] properties = typeof(PerigeeApogee).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    var l1 = property.GetValue(lE1);
                    var l2 = property.GetValue(lE2);
                    var n1 = property.GetValue(nE1);
                    var n2 = property.GetValue(nE2);

                    if (l1.ToString() != l2.ToString()) { return false; }
                    if (l1.GetType() == typeof(Distance) && l2.GetType() == typeof(Distance))
                    {
                        PropertyInfo[] propertiesSub = typeof(Distance).GetProperties();
                        foreach (PropertyInfo propertySub in propertiesSub)
                        {
                            var l1Sub = propertySub.GetValue(l1);
                            var l2Sub = propertySub.GetValue(l2);
                            if (l1Sub.ToString() != l2Sub.ToString()) { return false; }
                        }
                    }
                    if (n1.ToString() != n2.ToString()) { return false; }
                    if (n1.GetType() == typeof(Distance) && n2.GetType() == typeof(Distance))
                    {
                        PropertyInfo[] propertiesSub = typeof(Distance).GetProperties();
                        foreach (PropertyInfo propertySub in propertiesSub)
                        {
                            var n1Sub = propertySub.GetValue(n1);
                            var n2Sub = propertySub.GetValue(n2);
                            if (n1Sub.ToString() != n2Sub.ToString()) { return false; }
                        }
                    }

                }
            }
            return true;
        }

        private bool Check_IsSunUp()
        {
           
            string[] lines = File.ReadAllLines("CelestialData\\IsSunUp.txt");
            foreach(string line in lines)
            {
                string[] split = line.Split(',');
                double lat = double.Parse(split[0]);
                double longi = double.Parse(split[1]);
                DateTime geoDate = DateTime.Parse(split[2]).Date;
                string sR = split[3];
                string SS = split[4];
                string condition = split[5];

                Coordinate c = new Coordinate(lat, longi, geoDate);
                //Iterate each minute in the day
                for(int x=0;x<1440;x++)
                {
                    int i = 1;
                    if (x == 0) { i = 0; }
                    switch(condition)
                    {
                        case "DownAllDay":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if(c.CelestialInfo.IsSunUp == true) { return false; }
                            break;
                        case "UpAllDay":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if (c.CelestialInfo.IsSunUp == false) { return false; }
                            break;
                        case "NoRise":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if (c.CelestialInfo.SunSet > c.GeoDate && c.CelestialInfo.IsSunUp==false) { return false; }
                            if (c.CelestialInfo.SunSet <= c.GeoDate && c.CelestialInfo.IsSunUp == true) { return false; }
                            break;
                        case "NoSet":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if (c.CelestialInfo.SunRise >= c.GeoDate && c.CelestialInfo.IsSunUp == true) { return false; }
                            if (c.CelestialInfo.SunRise < c.GeoDate && c.CelestialInfo.IsSunUp == false) { return false; }
                            break;
                        case "RiseAndSet":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            //When working in Z time we have to account for rise occuring after set
                            if(c.CelestialInfo.SunSet>c.CelestialInfo.SunRise)
                            {
                                //SUN SHOULD BE UP
                                if(c.GeoDate > c.CelestialInfo.SunRise && c.GeoDate < c.CelestialInfo.SunSet && c.CelestialInfo.IsSunUp == false) { return false; }
                                //SUN SHOULD BE DOWN
                                if ((c.GeoDate <= c.CelestialInfo.SunRise || c.GeoDate >= c.CelestialInfo.SunSet) && c.CelestialInfo.IsSunUp == true) { return false; }
                            }
                            else
                            {
                                //AFTER RISE SUN SHOULD BE UP
                                if(c.GeoDate>c.CelestialInfo.SunRise && c.CelestialInfo.IsSunUp == false) { return false; }
                                //BETWEEN SET AND RISE SUN SHOULD BE DOWN
                                if (c.GeoDate <= c.CelestialInfo.SunRise && c.GeoDate >= c.CelestialInfo.SunSet && c.CelestialInfo.IsSunUp == true) { return false; }
                                //BEFORE SET SUN SHOULD BE UP
                                if(c.GeoDate < c.CelestialInfo.SunSet && c.CelestialInfo.IsSunUp == false) { return false; }
                            }
                            
                            break;
                        default:
                            break;
                    }
                }
                
            }
            return true;
        }

        private bool Check_IsMoonUp()
        {

            string[] lines = File.ReadAllLines("CelestialData\\IsMoonUp.txt");
            foreach (string line in lines)
            {
                string[] split = line.Split(',');
                double lat = double.Parse(split[0]);
                double longi = double.Parse(split[1]);
                DateTime geoDate = DateTime.Parse(split[2]).Date;
                string sR = split[3];
                string SS = split[4];
                string condition = split[5];

                Coordinate c = new Coordinate(lat, longi, geoDate);
                //Iterate each minute in the day
                for (int x = 0; x < 1440; x++)
                {
                    int i = 1;
                    if (x == 0) { i = 0; }
                    switch (condition)
                    {
                        case "DownAllDay":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if (c.CelestialInfo.IsMoonUp == true) { return false; }
                            break;
                        case "UpAllDay":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if (c.CelestialInfo.IsMoonUp == false) { return false; }
                            break;
                        case "NoRise":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if (c.CelestialInfo.MoonSet > c.GeoDate && c.CelestialInfo.IsMoonUp == false) { return false; }
                            if (c.CelestialInfo.MoonSet <= c.GeoDate && c.CelestialInfo.IsMoonUp == true) { return false; }
                            break;
                        case "NoSet":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            if (c.CelestialInfo.MoonRise >= c.GeoDate && c.CelestialInfo.IsMoonUp == true) { return false; }
                            if (c.CelestialInfo.MoonRise < c.GeoDate && c.CelestialInfo.IsMoonUp == false) { return false; }
                            break;
                        case "RiseAndSet":
                            c.GeoDate = c.GeoDate.AddMinutes(i);
                            //When working in Z time we have to account for rise occuring after set
                            if (c.CelestialInfo.MoonSet > c.CelestialInfo.MoonRise)
                            {
                                //Moon SHOULD BE UP
                                if (c.GeoDate > c.CelestialInfo.MoonRise && c.GeoDate < c.CelestialInfo.MoonSet && c.CelestialInfo.IsMoonUp == false) { return false; }
                                //Moon SHOULD BE DOWN
                                if ((c.GeoDate <= c.CelestialInfo.MoonRise || c.GeoDate >= c.CelestialInfo.MoonSet) && c.CelestialInfo.IsMoonUp == true) { return false; }
                            }
                            else
                            {
                                //AFTER RISE Moon SHOULD BE UP
                                if (c.GeoDate > c.CelestialInfo.MoonRise && c.CelestialInfo.IsMoonUp == false) { return false; }
                                //BETWEEN SET AND RISE Moon SHOULD BE DOWN
                                if (c.GeoDate <= c.CelestialInfo.MoonRise && c.GeoDate >= c.CelestialInfo.MoonSet && c.CelestialInfo.IsMoonUp == true) { return false; }
                                //BEFORE SET Moon SHOULD BE UP
                                if (c.GeoDate < c.CelestialInfo.MoonSet && c.CelestialInfo.IsMoonUp == false) { return false; }
                            }

                            break;
                        default:
                            break;
                    }
                }

            }
            return true;
        }

        private List<DateTime?> SunRises { get; set; }   
        private List<DateTime?> MoonRises { get; set; }
        private List<DateTime?> SunSets { get; set; }
        private List<DateTime?> MoonSets { get; set; }

        private List<DateTime?> CivilDawn { get; set; }
        private List<DateTime?> CivilDusk { get; set; }
        private List<DateTime?> NauticalDawn { get; set; }
        private List<DateTime?> NauticalDusk { get; set; }
        private List<DateTime?> AstroDawn { get; set; }
        private List<DateTime?> AstroDusk { get; set; }
        private List<DateTime?> BottomSolarDiscRise { get; set; }
        private List<DateTime?> BottomSolarDiscSet { get; set; }

        private List<double> SunAlts { get; set; }
        private List<double> SunAzs { get; set; }
        private List<double> MoonAlts { get; set; }
        private List<double> MoonAzs { get; set; }
        private List<double> MoonDistances { get; set; }
        private List<double> MoonFraction{ get; set; }
        private List<double> MoonPhase { get; set; }
        private List<string> MoonPhaseName { get; set; }

        private SolarEclipse SolarEclispe { get; set; }
        private LunarEclipse LunarEclispe { get; set; }
        private Perigee Perigee { get; set; }
        private Apogee Apogee { get; set; }

        private List<bool> IsSunUp { get; set; }
        private List<bool> IsMoonUp { get; set; }
    }
}