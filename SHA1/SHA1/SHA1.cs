using System;

namespace SHA1
{
    public class SHA1
    {
        private uint h0 = 0x67452301,
                h1 = 0xEFCDAB89,
                h2 = 0x98BADCFE,
                h3 = 0x10325476,
                h4 = 0xC3D2E1F0;

        public byte[] ComputeHash(byte[] data)
        {
            byte[] res = new byte[20];

            int len = data.Length*8;
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = 128;

            while (data.Length % 64 != 56)
            {
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = 0;
            }

            Array.Resize(ref data, data.Length + 8);

            int i = data.Length - 1;
            while (len != 0)
            {
                data[i--] = (byte)len;
                len >>= 8;
            }
            
            
            uint[] w = new uint[80];
            uint a, b, c, d, e, f = 0, k = 0, temp;
            for (int j = 0; j < data.Length - 1;)
            {
                int t = j;
                for (i = 0; i < 16; i++)
                {
                    w[i] = BytesToUint(new byte[] { data[t], data[t + 1], data[t + 2], data[t + 3] });
                    t += 4;
                }

                for (i = 16; i < 80; i++)
                {
                    w[i] = ShiftLeft(w[i - 3] ^ w[i - 8] ^ w[i - 14] ^ w[i - 16], 1);
                }

                a = h0;
                b = h1;
                c = h2;
                d = h3;
                e = h4;
                for (i = 0; i < 80; i++)
                {
                    if (i <= 19)
                    {
                        f = (b & c) | (~b & d);
                        k = 0x5A827999;
                    }
                    else if (i <= 39){
                        f = b ^ c ^ d;
                        k = 0x6ED9EBA1;
                    }
                    else if (i <= 59){
                        f = (b & c) | (b & d) | (c & d);
                        k = 0x8F1BBCDC;
                    }
                    else{
                        f = b ^ c ^ d;
                        k = 0xCA62C1D6;
                    }

                    temp = ShiftLeft(a, 5) + f + e + k + w[i];
                    e = d;
                    d = c;
                    c = ShiftLeft(b, 30);
                    b = a;
                    a = temp;
                }

                h0 = h0 + a;
                h1 = h1 + b;
                h2 = h2 + c;
                h3 = h3 + d;
                h4 = h4 + e;

                j += j == 0 ? 63 : 64;
            }
            uint[] hs = new[] { h0, h1, h2, h3, h4 };

            res = UintsToBytes(hs);
            return res;
        }

        private byte[] UintsToBytes(uint[] u)
        {
            byte[] res = new byte[4 * u.Length];
            for (int i = 0; i < u.Length; i++)
            {
                uint temp = u[i];
                for (int j = 3; j >= 0; j--)
                {
                    res[i * 4 + j] = (byte)temp;
                    temp = temp >> 8;
                }
            }

            return res;
        }

        private uint BytesToUint(byte[] byteArr)
        {
            uint res = 0;
            for(int i = 0; i <4; i++)
            {
                res <<= 8;
                res += byteArr[i];
            }

            return res;
        }

        private uint ShiftLeft(uint value, uint count)
        {
            uint leftBit;
            for (uint i = 1; i <= count; i++)
            {
                leftBit = value / 0x80000000;
                value = (value * 2) + leftBit;
            }

            return value;
        }
    }
}
