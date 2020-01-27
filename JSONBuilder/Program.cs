using System;
using Newtonsoft;
namespace JSONBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = new ExifLog.Schema.Schema.Roll();
            var frame = new ExifLog.Schema.Schema.Frame();
            frame.aperture = "";
            frame.caption = "";
            frame.exposureBias = "";
            frame.focalLength = "";
            frame.shutterSpeed = "";
            schema.frames.Add(frame);
            System.IO.File.WriteAllText("EXIFLogSchema.json", Newtonsoft.Json.JsonConvert.SerializeObject(schema));
        }
    }
}
