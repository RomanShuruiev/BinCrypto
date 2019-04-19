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

  

    [Serializable]
    class Crypto
    {
        Convertion conv;
        public string ResultDat;
        public string Result;
        public string OriginalText;
        public string OriginalGamma;

        public string DES()
        {
            
          //Serialize Serial = new Serialize(Convertion.ConvertResult);
          // Deserialize Deserial = new Deserialize(Convertion.ConvertResultDat);

          
            conv.ConvertResult(Result);

            using (StreamReader ReaderGamma = new StreamReader(Path.Combine(@"C:\","Gamma.txt")))
            using (StreamReader ReaderText = new StreamReader(Path.Combine(@"C:\", "Text.txt")))
            //using (StreamWriter Writer = new StreamWriter("BinGamma.txt"))
            {
                int positionGamm = 0;
                int positionText = 0;

                while (!ReaderGamma.EndOfStream)
                {
                    List<byte> Gamma = new List<byte>();
                    List<byte> Text = new List<byte>();
                    List<byte> TextLeft = new List<byte>();
                    List<byte> TextRight = new List<byte>();
                    List<byte> GammaOne = new List<byte>();
                    List<byte> GammaTwo = new List<byte>();


                    BitArray[] BitGammaOne;
                    BitArray[] BitGammaTwo;
                    BitArray[] BitTextLeft;
                    BitArray[] BitTextTwo;

                    char[] BufferOne = new char[16];
                    char[] BufferTwo = new char[16];
                    int CharReadGamm = ReaderGamma.ReadBlock(BufferOne, 0, 16);
                    int CharReadText = ReaderText.ReadBlock(BufferTwo, 0, 16);
                    //Writer.Write("{0}: ", String.Format("{0:x4}", position));
                    positionGamm += CharReadGamm;
                    positionText += CharReadText;

                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 16; i++)
                        {
                            if (i < CharReadGamm && i < CharReadText)
                            {

                                Gamma.Add((byte)BufferOne[i]);
                                Text.Add((byte)BufferTwo[i]);
                            }

                            if (i < 2)
                            {
                                GammaOne.Add(Gamma[i]);
                                TextLeft.Add(Text[i]);
                                //BitGammaOne[i] = GammaOne[i];   byte --> BitArray  ??
                            }
                            else
                            {
                                GammaTwo.Add(Gamma[i]);
                                TextRight.Add(Text[i]);
                            }

                        }

                        
                    }
                    
                }




            return Result;
        }

        

            
              
            }
        }
    }

