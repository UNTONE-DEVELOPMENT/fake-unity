using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnityEngine
{
    public static class Debug
    {
        public static bool print = false;
        // if this is false, it will still print errors, as those are important.
        // don't disable errors.
        public static void Log(object log)
        {
            if (print == false)
            {
                Console.WriteLine("[FakeUnity] " + log.ToString());
            }
        }

        public static void LogError(string log)
        {
            Console.WriteLine("ERROR[FakeUnity] " + log);
        }
    }

    public class Color32
    {
        public byte r;
        public byte g;
        public byte b;
        public byte a;

        public Color32(byte r, byte g, byte b, byte a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
    }

    public class Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public class Texture2D
    {

    }

    public class TextAsset
    {
        public string text;
    }

    public static class Resources
    {
        internal static T Load<T>(string v)
        {
            // this isn't implemented because we'll never need to make a new file through fake-unity yet
            return default(T);
        }
    }
}