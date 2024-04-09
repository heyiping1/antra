namespace Assignment_0408
{
    public class UnderstandingTypes
    {
        public void understandTypes()
        {
            Console.WriteLine("Data Type\tBytes\tMin Value\t\t\tMax Value");
            Console.WriteLine($"sbyte\t\t{sizeof(sbyte)}\t{sbyte.MinValue}\t\t\t\t{sbyte.MaxValue}");
            Console.WriteLine($"byte\t\t{sizeof(byte)}\t{byte.MinValue}\t\t\t\t{byte.MaxValue}");
            Console.WriteLine($"short\t\t{sizeof(short)}\t{short.MinValue}\t\t\t\t{short.MaxValue}");
            Console.WriteLine($"ushort\t\t{sizeof(ushort)}\t{ushort.MinValue}\t\t\t\t{ushort.MaxValue}");
            Console.WriteLine($"int\t\t{sizeof(int)}\t{int.MinValue}\t\t\t{int.MaxValue}");
            Console.WriteLine($"uint\t\t{sizeof(uint)}\t{uint.MinValue}\t\t\t\t{uint.MaxValue}");
            Console.WriteLine($"long\t\t{sizeof(long)}\t{long.MinValue}\t\t{long.MaxValue}");
            Console.WriteLine($"ulong\t\t{sizeof(ulong)}\t{ulong.MinValue}\t\t\t\t{ulong.MaxValue}");
            Console.WriteLine($"float\t\t{sizeof(float)}\t{float.MinValue}\t\t\t{float.MaxValue}");
            Console.WriteLine($"double\t\t{sizeof(double)}\t{double.MinValue}\t{double.MaxValue}");
            Console.WriteLine($"decimal\t\t{sizeof(decimal)}\t{decimal.MinValue}\t{decimal.MaxValue}");
        }
    }
}
