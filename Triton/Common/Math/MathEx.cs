namespace Triton.Common.Math
{
    using System;
    using System.Runtime.InteropServices;

    public static class MathEx
    {
        private static readonly System.Random random_0 = new System.Random();

        public static Vector3 CalculatePointFrom(Vector3 myLoc, Vector3 targetLoc, float pointDistanceToTarget)
        {
            Vector3 vector = targetLoc - myLoc;
            vector.Normalize();
            return (targetLoc - ((Vector3) (vector * pointDistanceToTarget)));
        }

        public static float Clamp(float min, float max, float value)
        {
            if (value <= min)
            {
                return min;
            }
            if (value >= max)
            {
                return max;
            }
            return value;
        }

        public static float Distance(ref Vector3 point, ref LineSegment line)
        {
            return (float) Math.Sqrt((double) DistanceSqr(ref point, ref line));
        }

        public static float Distance(Vector3 point, LineSegment line)
        {
            return (float) Math.Sqrt((double) DistanceSqr(ref point, ref line));
        }

        public static float DistanceSqr(ref Vector3 point, ref LineSegment line)
        {
            if (line.Start == line.End)
            {
                return Vector3.DistanceSqr(ref point, ref line.Start);
            }
            Vector3 vector = line.End - line.Start;
            if (Vector3.Dot(vector, point - line.Start) < 0f)
            {
                return Vector3.DistanceSqr(ref point, ref line.Start);
            }
            vector *= new Vector3(-1f);
            if (Vector3.Dot(vector, point - line.End) < 0f)
            {
                return Vector3.DistanceSqr(ref point, ref line.End);
            }
            Vector3 vector3 = line.End - line.Start;
            return (Vector3.Cross(point - line.Start, point - line.End).LengthSqr() / vector3.LengthSqr());
        }

        public static float DistanceSqr(Vector3 point, LineSegment line)
        {
            return DistanceSqr(ref point, ref line);
        }

        public static float GetAmount(float min, float max, float value)
        {
            return ((value - min) / (max - min));
        }

        public static float GetPercentage(float current, float max, bool isHundredHigh = true)
        {
            float num = GetAmount(0f, max, current);
            if (isHundredHigh)
            {
                return (num * 100f);
            }
            return num;
        }

        public static Vector3 GetPointAt(Vector3 from, float distance, float rotationRadians)
        {
            float x = (float) (Math.Cos((double) rotationRadians) * distance);
            float y = (float) (Math.Sin((double) rotationRadians) * distance);
            return (from + new Vector3(x, y, 0f));
        }

        public static bool IntersectsPath(Vector2i target, float radius, Vector2i start, Vector2i destination)
        {
            return IntersectsPath(new Vector3((float) target.X, (float) target.Y, 0f), radius, new Vector3((float) start.X, (float) start.Y, 0f), new Vector3((float) destination.X, (float) destination.Y, 0f));
        }

        public static bool IntersectsPath(Vector3 target, float radius, Vector3 start, Vector3 destination)
        {
            Ray ray = new Ray(start, Vector3.NormalizedDirection(start, destination));
            Sphere sphere = new Sphere(target, radius);
            float? nullable = ray.Intersects(sphere);
            return (nullable.HasValue && (nullable.Value <= start.Distance(destination)));
        }

        public static float InverseLerp(float min, float max, float amount)
        {
            return ((amount - min) / (max - min));
        }

        public static float Lerp(float min, float max, float amount)
        {
            return (min + ((max - min) * amount));
        }

        public static double Random(double min, double max)
        {
            return (min + (random_0.NextDouble() * (max - min)));
        }

        public static float ToDegrees(float radians)
        {
            return (float) (radians * 57.295779513082323);
        }

        public static float ToRadians(float degrees)
        {
            return (float) (degrees * 0.017453292519943295);
        }

        public static float WrapAngle(float radian)
        {
            double num = Math.IEEERemainder((double) radian, 6.2831853071795862);
            if (num <= -3.1415926535897931)
            {
                num += 6.2831853071795862;
            }
            else if (num > 3.1415926535897931)
            {
                num -= 6.2831853071795862;
            }
            return (float) num;
        }
    }
}

