using System;
using System.Collections.Generic;
using System.Text;
using XLua;

namespace LuaMini
{
    class LuaScript
    {
        private readonly LuaTable _Table;
        private readonly LuaEnvironment _Env;

        private void _Empty()
        {
            Console.WriteLine("empty");
        }

        public LuaScript(LuaEnvironment env, string path, object gameObject)
        {
            _Env = env;
            var envTable = env.NewTable(path, gameObject);
            _Table = envTable;

            envTable.Get("Print", out _Start);

            if (_Start == null)
                _Start = _Empty;
        }

        System.Action _Start;
        public System.Action Start => _Start;
    }
}
