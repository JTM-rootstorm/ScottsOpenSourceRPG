using System;
using System.ComponentModel;
using Engine.Entities;

namespace Engine
{
    public static class ExtensionMethods
    {
        public static string InLocalizedLanguage(this string text)
        {
            return Resources.Literals.ResourceManager.GetString(text) ?? text;
        }

        public static int WithinLimits(this int value, int lowerLimit, int upperLimit)
        {
            return Math.Max(lowerLimit, Math.Min(upperLimit, value));
        }

        public static void SafeInvoke<T>(this EventHandler<T> evt, T e) where T : EventArgs
        {
            if(evt != null)
            {
                evt(evt, e);
            }
        }

        public static void SafeInvoke(this EventHandler evt)
        {
            if(evt != null)
            {
                evt(null, null);
            }
        }

        public static void SafeInvoke(this PropertyChangedEventHandler evt, object sender, string propertyName)
        {
            if(evt != null)
            {
                evt(sender, new PropertyChangedEventArgs(propertyName));
            }
        }

        public static Coordinate CoordinatesToNorth(this Coordinate coordinate)
        {
            return new Coordinate(coordinate.X, (coordinate.Y + 1));
        }

        public static Coordinate CoordinatesToSouth(this Coordinate coordinate)
        {
            return new Coordinate(coordinate.X, (coordinate.Y - 1));
        }

        public static Coordinate CoordinatesToEast(this Coordinate coordinate)
        {
            return new Coordinate((coordinate.X + 1), coordinate.Y);
        }

        public static Coordinate CoordinatesToWest(this Coordinate coordinate)
        {
            return new Coordinate((coordinate.X - 1), coordinate.Y);
        }
    }
}
