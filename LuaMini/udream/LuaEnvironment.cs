using System;
using System.Collections.Generic;
using System.Text;

using XLua;

namespace LuaMini
{
    class LuaEnvironment
    {
        static LuaEnvironment instance;
        int _TableCount;
        bool _NeedDisposeEnv;
        const string _Tag = "Udream.Lua.Environment";
        XLua.LuaEnv _Env;
        public string Behaviour;

        public LuaEnvironment()
        {
            _Env = new XLua.LuaEnv();
            instance = this;
        }

        internal LuaTable NewTable(string path, object gameObject)
        {
            _TableCount++;
            var envTable = _Env.NewTable();

            // 为每个脚本设置一个独立的环境，可一定程度上防止脚本间全局变量、函数冲突
            var meta = _Env.NewTable();
            meta.Set("__index", _Env.Global);
            envTable.SetMetaTable(meta);
            meta.Dispose();


            envTable.Set("class_path", path);
            envTable.Set("gameObject", gameObject);
            try
            {
                Behaviour = System.IO.File.ReadAllText(@"lua\Behaviour.lua.txt");
                var objs = _Env.DoString(chunk: Behaviour, chunkName: path, env: envTable);
            }
            catch (LuaException le)
            {
                throw le;
            }

            return envTable;
        }

        internal void DeleteTable(LuaTable table)
        {

            table.Dispose();

            _TableCount--;
            if (_NeedDisposeEnv && _TableCount == 0)
            {
                Console.WriteLine("Lua env dispose.");
                _Env.Dispose();
            }
        }
        public static LuaScript CreateScript(string path, object gameObject)
        {
            LuaEnvironment env = _GetComponent();
            return new LuaScript(env, path, gameObject);
        }

        private static LuaEnvironment _GetComponent()
        {
            return instance;
        }
    }
}
