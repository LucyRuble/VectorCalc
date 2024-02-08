using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(0, 0,0);
        public static readonly Vector One = new Vector(0, 0, 0);

        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public double GetMagnitude()
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
           
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public double GetDirection()
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
     
            return Math.Atan(this.y / this.x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
           
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);

        }

        public static Vector Negate(Vector v)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
           
            Vector Output = new Vector(v.x, v.y, v.z);
            Output.x -= (v.x * 2);
            Output.y -= (v.y * 2);
            Output.z -= (v.z * 2);
            return Output;
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
   
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, double scalar )
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
          
            return new Vector(v.x * scalar, v.y * scalar, v.z * scalar);
        }

        public static Vector Normalize(Vector v)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
           
            return new Vector(v.x / v.GetMagnitude(), v.y / v.GetMagnitude(), v.z / v.GetMagnitude());
        }

        public static double DotProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
         
            return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
           
            return new Vector((v1.y * v2.z) - (v1.z * v2.y),
                (v1.z * v2.x) - (v1.x * v2.z),
                (v1.x * v2.y) - (v1.y * v2.x));
        }

        public static Double AngleBetween(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
   
            return Math.Acos((DotProduct(v1, v2)) / (v1.GetMagnitude() * v2.GetMagnitude()));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
           Double numerScalar = DotProduct(v1, v2) / Math.Pow (v2.GetMagnitude(), 2);
            return Vector.Scale(v2, numerScalar);

        }
    }
}
