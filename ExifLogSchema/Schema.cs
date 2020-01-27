using System;
using System.Collections.Generic;
namespace ExifLog.Schema {
public class Schema
{
    public class Roll
    {
        public string ver;
        public int size;
        public string ISO;
        public bool isColour;
        public string copyright;
        public List<Frame> frames= new List<Frame>();
    }
    public class Frame
    {
        public string shutterSpeed;
        public string aperture;
        public string exposureBias;
        public string focalLength;
        public string caption;
    }
    public class References
    {
        public string[] shutterSpeeds = new string[] { "1/500", "1/250", "1/125", "1/60", "1/30", "1/25", "1/15", "1/8", "1/4", "1/2", "1", "2", "5", "10", "30", "B", "T" };
        public string[] apertureValues = new string[] { "f/22", "f/16", "f/11", "f/8.0", "f/5.6", "f/4.0", "f/2.8", "f/2.0", "f/1.4" };
    }
}
}