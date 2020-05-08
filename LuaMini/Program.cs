using System;
using System.IO;
using XLua;

namespace LuaMini
{
    class Program
    {
        static void Main(string[] args)
        {
            LuaEnvironment env = new LuaEnvironment();
            var Lua = LuaEnvironment.CreateScript("HelloWorld", new object());
            Lua.Start();
        }
    }
}
