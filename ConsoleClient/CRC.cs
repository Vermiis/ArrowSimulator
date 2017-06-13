using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class CRC
    {
        public enum CRC8_POLY
        {
            CRC8 = 0xd5,
            CRC8_CCITT = 0x07,
            CRC8_DALLAS_MAXIM = 0x31,
            CRC8_SAE_J1850 = 0x1D,
            CRC_8_WCDMA = 0x9b,
        };
        public class CRC8Calc
        {
            private byte[] table = new byte[256];

            public byte Checksum(params byte[] val)
            {
                if (val == null)
                    throw new ArgumentNullException("val");

                byte c = 0;

                foreach (byte b in val)
                {
                    c = table[c ^ b];
                }

                return c;
            }

            public byte[] Table
            {
                get
                {
                    return this.table;
                }
                set
                {
                    this.table = value;
                }
            }

            public byte[] GenerateTable(CRC8_POLY polynomial)
            {
                byte[] csTable = new byte[256];

                for (int i = 0; i < 256; ++i)
                {
                    int curr = i;

                    for (int j = 0; j < 8; ++j)
                    {
                        if ((curr & 0x80) != 0)
                        {
                            curr = (curr << 1) ^ (int)polynomial;
                        }
                        else
                        {
                            curr <<= 1;
                        }
                    }

                    csTable[i] = (byte)curr;
                }

                return csTable;
            }

            public CRC8Calc(CRC8_POLY polynomial)
            {
                this.table = this.GenerateTable(polynomial);
            }
        }

        public static class Crc8
        {
            static byte[] table = new byte[256];
            // x8 + x7 + x6 + x4 + x2 + 1
            const byte poly = 0xd5;

            public static byte ComputeChecksum(params byte[] bytes)
            {
                byte crc = 0;
                if (bytes != null && bytes.Length > 0)
                {
                    foreach (byte b in bytes)
                    {
                        crc = table[crc ^ b];
                    }
                }
                return crc;
            }

            static Crc8()
            {
                for (int i = 0; i < 256; ++i)
                {
                    int temp = i;
                    for (int j = 0; j < 8; ++j)
                    {
                        if ((temp & 0x80) != 0)
                        {
                            temp = (temp << 1) ^ poly;
                        }
                        else
                        {
                            temp <<= 1;
                        }
                    }
                    table[i] = (byte)temp;
                }
            }
        }
    }
}
