using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp.Chart1
{
    [StructLayout(LayoutKind.Explicit)]
    struct SignedNumberWithText
    {
        [FieldOffset(0)]
        public sbyte Numb1;
        [FieldOffset(0)]
        public short Numb2;
        [FieldOffset(0)]
        public int Numb3;
        [FieldOffset(0)]
        public long Numb4;
        [FieldOffset(0)]
        public float Numb5;
        [FieldOffset(0)]
        public double Numb6;
        [FieldOffset(16)]
        public string Text1;
    }
}
