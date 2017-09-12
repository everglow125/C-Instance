using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// 使类型可排序
    /// </summary>
    public class Square : IComparable<Square>
    {
        public Square() { }
        public int Height { get; set; }
        public int Width { get; set; }
        public Square(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public int CompareTo(Object obj)
        {
            Square square = obj as Square;
            if (square != null)
                return CompareTo(square);
            throw new ArgumentException("Both objects being compare must be of type Square");
        }
        public int CompareTo(Square other)
        {
            long area1 = this.Height * this.Width;
            long area2 = other.Height * other.Width;
            if (area1 == area2) return 0;
            else if (area1 > area2) return 1;
            else if (area1 < area2) return -1;
            else return -1;
        }

        public override string ToString()
        {
            return string.Format("Height:{0} Width:{1}", this.Height, this.Width);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Square square = obj as Square;
            if (square != null)
                return this.Height == square.Height;
            return false;
        }
        public override int GetHashCode()
        {
            return this.Height.GetHashCode() | this.Width.GetHashCode();
        }
        public static bool operator ==(Square x, Square y)
        {
            return x.Equals(y);
        }
        public static bool operator !=(Square x, Square y)
        {
            return !x.Equals(y);
        }
        public static bool operator <(Square x, Square y)
        {
            return (x.CompareTo(y)) < 0;
        }

        public static bool operator >(Square x, Square y)
        {
            return (x.CompareTo(y)) > 0;
        }
    }

}
