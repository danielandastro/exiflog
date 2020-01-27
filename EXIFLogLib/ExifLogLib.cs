using System;
using EXIFLog.Schema;
namespace EXIFLog.EXIFLogLib
{
    public class Builder
    {
        ///<summary> Your starting point, given the size of roll, a copyright string, the iso and if the roll is colour, the library will return an otherwise empty schema </summary>
        public Schema.Schema.Roll BuildRoll(int size, string copyright, bool isColour, string iso)
        {
            var temp = new Schema.Schema.Roll();
            temp.size = size;
            temp.copyright = copyright;
            temp.isColour = isColour;
            temp.ISO = iso;
            return temp;
        }
        ///<summary> Use this to create a frame, don't forget to add it to your frames in the roll </summary>
        public Schema.Schema.Frame BuildFrame(string aperture, string focalLength, string caption, string exposureBias, string shutterSpeed)
        {
            var temp = new Schema.Schema.Frame();
            temp.aperture = aperture;
            temp.focalLength = focalLength;
            temp.caption = caption;
            temp.exposureBias = exposureBias;
            temp.shutterSpeed = shutterSpeed;
            return temp;
        }
    }
}
