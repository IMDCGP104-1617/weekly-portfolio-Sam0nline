using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClass
{
    class Vector3
    {

        float X;
        float Y;
        float Z;
        bool isDirty;
        double magnitude;

        static double[] _lookup = new double[6];
        
        public Vector3() { }
        public Vector3(float x, float y, float z) { X = x; Y = y; Z = z; }

        public static Vector3 operator +(Vector3 lhs,Vector3 rhs)
        {
            return new Vector3(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        public static Vector3 operator -(Vector3 lhs,Vector3 rhs)
        {
            return new Vector3(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static Vector3 operator *(Vector3 vec, float value)
        {
            return new Vector3(vec.X * value, vec.Y * value, vec.Z * value);
        }

        public double mag ()
        {
            if(isDirty)
            {
                magnitude = Math.Sqrt(X * X + Y * Y + Z * Z);
            }
            return magnitude;
        }
    }
}

/*static void Main(String[] args)
        {
            
        }
*/