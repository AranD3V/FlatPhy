using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPhy
{
    public readonly struct FlatVec
    {
        public readonly float X; 
        public readonly float Y;

        public static readonly FlatVec Zero = new FlatVec(0f, 0f);

        public FlatVec(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public static FlatVec operator +(FlatVec a, FlatVec b) 
        {
            return new FlatVec(a.X + b.X, a.Y + b.Y);
        }

        public static FlatVec operator -(FlatVec a, FlatVec b)
        {
            return new FlatVec(a.X - b.X, a.Y - b.Y);
        }

        public static FlatVec operator -(FlatVec v)
        {
            return new FlatVec(-v.X, -v.Y);
        }

        public static FlatVec operator *(FlatVec v, float s)
        {
            return new FlatVec(v.X * s, v.Y * s);
        }

        public static FlatVec operator /(FlatVec v, float s)
        {
            return new FlatVec(v.X / s, v.Y / s);
        }

        public bool Equal(FlatVec other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if(obj is FlatVec other)
            {
                return this.Equal(other);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return new { this .X, this.Y }.GetHashCode();
        }

        public override string ToString()
        {
            return $"X: {this.X}, Y:{this.Y}";
        }

    }
}
