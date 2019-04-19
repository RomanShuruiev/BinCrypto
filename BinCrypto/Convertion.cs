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
    class Convertion
    {
         public string Result;
         public string ResultDat;


         public void ConvertResult(string Result)
         {
             using (Stream output = File.Create(Path.Combine(@"C:\","Result.dat")))
             {
                 BinaryFormatter Formatter = new BinaryFormatter();
                 Formatter.Serialize(output, Result);
             }
         }

         public string ConvertResultDat() {

             using (Stream input = File.OpenRead(Path.Combine(@"C:\", "Result.dat")))
             {
                 BinaryFormatter Unformatter = new BinaryFormatter();
                 ResultDat = (string)Unformatter.Deserialize(input);
             }

             return ResultDat;
         }
    }
}
