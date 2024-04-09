﻿namespace Assignment_0408
{
    public class CenturyConverter
    {
        public void convertCentury()
        {
            Console.Write("Enter number of centuries: ");
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = years * 365 + years / 4 - years / 100 + years / 400;
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            long nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
