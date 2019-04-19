using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;



namespace BinCrypto
{
    class Serialization
    {
        public string OriginalText;
        public string OriginalGamma;
        public string GammaDat;
        public string TextDat;

        /*
        List<byte> BitOriginal = new List<byte>();
        List<byte> BitGamma = new List<byte>();
        Queue<byte> BufferOne = new Queue<byte>();
         */

        public void Serialize()
        {

            using (FileStream output = File.Create(Path.Combine(@"C:\Results","Text.dat")))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(OriginalText);
            }



            using (FileStream output = File.Create(Path.Combine(@"C:\Results", "Gamma.dat")))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(OriginalGamma);
            }

        }

        public string ConvertGamma()
        {
            /*
           byte[] BinText = File.ReadAllBytes("Text.dat");
            byte[] BinGamma = File.ReadAllBytes("Gamma.dat");
             */


            using (StreamReader Reader = new StreamReader(Path.Combine(@"C:\", "Text.txt")))
            using (StreamWriter Writer = new StreamWriter("BinText.txt"))
            {
                int position = 0;

                while (!Reader.EndOfStream)
                {
                    char[] BufferOne = new char[16];
                    int CharRead = Reader.ReadBlock(BufferOne, 0, 16);
                    Writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += CharRead;

                    for (int i = 0; i < 16; i++)
                    {
                        if (i < CharRead)
                        {
                            string BinGamma = String.Format("{0:x2}", (byte)BufferOne[i]);
                            Writer.Write(BinGamma + "");
                        }
                        else
                        {
                            Writer.Write("   ");
                        }

                        if (i == 7)
                        {
                            Writer.Write("-- ");
                        }
                        if (BufferOne[i] < 32 || BufferOne[i] > 250)
                        {
                            BufferOne[i] = '.';
                        }

                    }
                    GammaDat = BufferOne.ToString();
                }
                return GammaDat;
            }
        }




            public string ConvertText()
        {


            using (StreamReader Reader = new StreamReader(Path.Combine(@"С:\","Gamma.txt")))
            using (StreamWriter Writer = new StreamWriter("BinGamma.txt"))
            {
                int position = 0;

                while (!Reader.EndOfStream)
                {
                    char[] BufferTwo = new char[16];
                    int CharRead = Reader.ReadBlock(BufferTwo, 0, 16);
                    Writer.Write("{0}: ", String.Format("{0:x4}",position));
                    position += CharRead;

                    for (int i = 0; i < 16; i++)
                    {
                        if (i < CharRead)
                        {
                            string BinText = String.Format("{0:x2}", (byte)BufferTwo[i]);
                            Writer.Write(BinText + "");
                        }
                        else
                        {
                            Writer.Write("   ");
                        }

                        if (i == 7)
                        {
                            Writer.Write("-- ");
                        }
                        if (BufferTwo[i] < 32 || BufferTwo[i] > 250)
                        {
                            BufferTwo[i] = '.';
                        }

                    }
                    GammaDat = BufferTwo.ToString();
                }
                return TextDat;
            }

        }
    }
}
