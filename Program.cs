using System;
using System.Runtime.InteropServices;

namespace Yubaba
{
    class Yubaba
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("契約書だよ。そこに名前を書きな。");
            var name = Console.ReadLine();
            Console.WriteLine($"フン。{name}というのかい。贅沢な名だねぇ。");

            var random = new Random();
            var newNameIndex = random.Next(name.Length);
			GCHandle hName = GCHandle.Alloc(name, GCHandleType.Pinned);
			char * pName = (char *)hName.AddrOfPinnedObject();
            char newName = pName[newNameIndex];
			string value = $"今からお前の名前は{newName}だ。いいかい、{newName}だよ。分かったら返事をするんだ、{newName}!!";
			Console.WriteLine(value);
        }
    }
}
