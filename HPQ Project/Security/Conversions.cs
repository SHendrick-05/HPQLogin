using System.Collections.Generic;

namespace HPQ_Project
{
    class Conversions
    {
        private static readonly uint[] _lookup32 = CreateLookup32();

        private static uint[] CreateLookup32()
        {
            var result = new uint[256];
            for (int i = 0; i < 256; i++)
            {
                string s = i.ToString("X2");
                result[i] = ((uint)s[0]) + ((uint)s[1] << 16);
            }
            return result;
        }

        internal static string ByteArrayToHexViaLookup32(byte[] bytes)
        {
            var lookup32 = _lookup32;
            var result = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                var val = lookup32[bytes[i]];
                result[2 * i] = (char)val;
                result[2 * i + 1] = (char)(val >> 16);
            }
            return new string(result);
        }

        internal static string rightShift(string key, int shift)
        {
            shift %= key.Length;
            return key.Substring(key.Length - shift) + key.Substring(0, key.Length - shift);
        }

        private readonly static Dictionary<char, byte> hexmap = new Dictionary<char, byte>()
	    {
		    { 'a', 0xA },{ 'b', 0xB },{ 'c', 0xC },{ 'd', 0xD },
		    { 'e', 0xE },{ 'f', 0xF },{ 'A', 0xA },{ 'B', 0xB },
		    { 'C', 0xC },{ 'D', 0xD },{ 'E', 0xE },{ 'F', 0xF },
		    { '0', 0x0 },{ '1', 0x1 },{ '2', 0x2 },{ '3', 0x3 },
		    { '4', 0x4 },{ '5', 0x5 },{ '6', 0x6 },{ '7', 0x7 },
		    { '8', 0x8 },{ '9', 0x9 }
	    };

        public static byte[] HexToByte(string hex)
        {
            byte[] bytesArr = new byte[(hex.Length) / 2];

            char leftNib;
            char rightNib;
            int x = 0;
            for (int i = 0; i < hex.Length; i += 2, x++)
            {
                leftNib = hex[i];
                rightNib = hex[i + 1];
                bytesArr[x] = (byte)((hexmap[leftNib] << 4) | hexmap[rightNib]);
            }
            return bytesArr;
        }
    }
}
