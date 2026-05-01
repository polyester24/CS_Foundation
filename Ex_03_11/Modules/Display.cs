using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_11.Modules
{
    public class Display
    {
        public void SendData()
        {
            Console.WriteLine("PCにマウスの移動情報を送信しました");
        }
        public void ReciveData()
        {
            Console.WriteLine("ディスプレイに表示する情報を受信しました");
        }
    }
}