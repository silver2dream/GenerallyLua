#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class SystemConsoleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(System.Console);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 21, 27, 16);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "OpenStandardError", _m_OpenStandardError_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OpenStandardInput", _m_OpenStandardInput_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OpenStandardOutput", _m_OpenStandardOutput_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetError", _m_SetError_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetIn", _m_SetIn_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetOut", _m_SetOut_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Write", _m_Write_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteLine", _m_WriteLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Read", _m_Read_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadLine", _m_ReadLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Beep", _m_Beep_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Clear", _m_Clear_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveBufferArea", _m_MoveBufferArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadKey", _m_ReadKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ResetColor", _m_ResetColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetBufferSize", _m_SetBufferSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCursorPosition", _m_SetCursorPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetWindowPosition", _m_SetWindowPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetWindowSize", _m_SetWindowSize_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CancelKeyPress", _e_CancelKeyPress);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Error", _g_get_Error);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Out", _g_get_Out);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "In", _g_get_In);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "InputEncoding", _g_get_InputEncoding);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OutputEncoding", _g_get_OutputEncoding);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BackgroundColor", _g_get_BackgroundColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BufferHeight", _g_get_BufferHeight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BufferWidth", _g_get_BufferWidth);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CapsLock", _g_get_CapsLock);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CursorLeft", _g_get_CursorLeft);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CursorTop", _g_get_CursorTop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CursorSize", _g_get_CursorSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CursorVisible", _g_get_CursorVisible);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ForegroundColor", _g_get_ForegroundColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeyAvailable", _g_get_KeyAvailable);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LargestWindowHeight", _g_get_LargestWindowHeight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LargestWindowWidth", _g_get_LargestWindowWidth);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "NumberLock", _g_get_NumberLock);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Title", _g_get_Title);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "TreatControlCAsInput", _g_get_TreatControlCAsInput);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WindowHeight", _g_get_WindowHeight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WindowLeft", _g_get_WindowLeft);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WindowTop", _g_get_WindowTop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WindowWidth", _g_get_WindowWidth);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsErrorRedirected", _g_get_IsErrorRedirected);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsOutputRedirected", _g_get_IsOutputRedirected);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsInputRedirected", _g_get_IsInputRedirected);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "InputEncoding", _s_set_InputEncoding);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OutputEncoding", _s_set_OutputEncoding);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BackgroundColor", _s_set_BackgroundColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BufferHeight", _s_set_BufferHeight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BufferWidth", _s_set_BufferWidth);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CursorLeft", _s_set_CursorLeft);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CursorTop", _s_set_CursorTop);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CursorSize", _s_set_CursorSize);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CursorVisible", _s_set_CursorVisible);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ForegroundColor", _s_set_ForegroundColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Title", _s_set_Title);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "TreatControlCAsInput", _s_set_TreatControlCAsInput);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "WindowHeight", _s_set_WindowHeight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "WindowLeft", _s_set_WindowLeft);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "WindowTop", _s_set_WindowTop);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "WindowWidth", _s_set_WindowWidth);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "System.Console does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenStandardError_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        System.IO.Stream gen_ret = System.Console.OpenStandardError(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _bufferSize = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IO.Stream gen_ret = System.Console.OpenStandardError( _bufferSize );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.OpenStandardError!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenStandardInput_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        System.IO.Stream gen_ret = System.Console.OpenStandardInput(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _bufferSize = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IO.Stream gen_ret = System.Console.OpenStandardInput( _bufferSize );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.OpenStandardInput!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenStandardOutput_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        System.IO.Stream gen_ret = System.Console.OpenStandardOutput(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _bufferSize = LuaAPI.xlua_tointeger(L, 1);
                    
                        System.IO.Stream gen_ret = System.Console.OpenStandardOutput( _bufferSize );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.OpenStandardOutput!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetError_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.TextWriter _newError = (System.IO.TextWriter)translator.GetObject(L, 1, typeof(System.IO.TextWriter));
                    
                    System.Console.SetError( _newError );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIn_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.TextReader _newIn = (System.IO.TextReader)translator.GetObject(L, 1, typeof(System.IO.TextReader));
                    
                    System.Console.SetIn( _newIn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOut_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IO.TextWriter _newOut = (System.IO.TextWriter)translator.GetObject(L, 1, typeof(System.IO.TextWriter));
                    
                    System.Console.SetOut( _newOut );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Write_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    char _value = (char)LuaAPI.xlua_tointeger(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isuint64(L, 1))) 
                {
                    ulong _value = LuaAPI.lua_touint64(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<char[]>(L, 1)) 
                {
                    char[] _buffer = (char[])translator.GetObject(L, 1, typeof(char[]));
                    
                    System.Console.Write( _buffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || translator.IsDecimal(L, 1))) 
                {
                    decimal _value;translator.Get(L, 1, out _value);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _value = LuaAPI.lua_tostring(L, 1);
                    
                    System.Console.Write( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<char[]>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    char[] _buffer = (char[])translator.GetObject(L, 1, typeof(char[]));
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    int _count = LuaAPI.xlua_tointeger(L, 3);
                    
                    System.Console.Write( _buffer, _index, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    
                    System.Console.Write( _format, _arg0 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object[] _arg = translator.GetParams<object>(L, 2);
                    
                    System.Console.Write( _format, _arg );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    object _arg1 = translator.GetObject(L, 3, typeof(object));
                    
                    System.Console.Write( _format, _arg0, _arg1 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    object _arg1 = translator.GetObject(L, 3, typeof(object));
                    object _arg2 = translator.GetObject(L, 4, typeof(object));
                    
                    System.Console.Write( _format, _arg0, _arg1, _arg2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    object _arg1 = translator.GetObject(L, 3, typeof(object));
                    object _arg2 = translator.GetObject(L, 4, typeof(object));
                    object _arg3 = translator.GetObject(L, 5, typeof(object));
                    
                    System.Console.Write( _format, _arg0, _arg1, _arg2, _arg3 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.Write!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteLine_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                    System.Console.WriteLine(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    char _value = (char)LuaAPI.xlua_tointeger(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isuint64(L, 1))) 
                {
                    ulong _value = LuaAPI.lua_touint64(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<char[]>(L, 1)) 
                {
                    char[] _buffer = (char[])translator.GetObject(L, 1, typeof(char[]));
                    
                    System.Console.WriteLine( _buffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || translator.IsDecimal(L, 1))) 
                {
                    decimal _value;translator.Get(L, 1, out _value);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _value = LuaAPI.lua_tostring(L, 1);
                    
                    System.Console.WriteLine( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<char[]>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    char[] _buffer = (char[])translator.GetObject(L, 1, typeof(char[]));
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    int _count = LuaAPI.xlua_tointeger(L, 3);
                    
                    System.Console.WriteLine( _buffer, _index, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    
                    System.Console.WriteLine( _format, _arg0 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object[] _arg = translator.GetParams<object>(L, 2);
                    
                    System.Console.WriteLine( _format, _arg );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    object _arg1 = translator.GetObject(L, 3, typeof(object));
                    
                    System.Console.WriteLine( _format, _arg0, _arg1 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    object _arg1 = translator.GetObject(L, 3, typeof(object));
                    object _arg2 = translator.GetObject(L, 4, typeof(object));
                    
                    System.Console.WriteLine( _format, _arg0, _arg1, _arg2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 1);
                    object _arg0 = translator.GetObject(L, 2, typeof(object));
                    object _arg1 = translator.GetObject(L, 3, typeof(object));
                    object _arg2 = translator.GetObject(L, 4, typeof(object));
                    object _arg3 = translator.GetObject(L, 5, typeof(object));
                    
                    System.Console.WriteLine( _format, _arg0, _arg1, _arg2, _arg3 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.WriteLine!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Read_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = System.Console.Read(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadLine_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        string gen_ret = System.Console.ReadLine(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Beep_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                    System.Console.Beep(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _frequency = LuaAPI.xlua_tointeger(L, 1);
                    int _duration = LuaAPI.xlua_tointeger(L, 2);
                    
                    System.Console.Beep( _frequency, _duration );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.Beep!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.Console.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveBufferArea_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    int _sourceLeft = LuaAPI.xlua_tointeger(L, 1);
                    int _sourceTop = LuaAPI.xlua_tointeger(L, 2);
                    int _sourceWidth = LuaAPI.xlua_tointeger(L, 3);
                    int _sourceHeight = LuaAPI.xlua_tointeger(L, 4);
                    int _targetLeft = LuaAPI.xlua_tointeger(L, 5);
                    int _targetTop = LuaAPI.xlua_tointeger(L, 6);
                    
                    System.Console.MoveBufferArea( _sourceLeft, _sourceTop, _sourceWidth, _sourceHeight, _targetLeft, _targetTop );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<System.ConsoleColor>(L, 8)&& translator.Assignable<System.ConsoleColor>(L, 9)) 
                {
                    int _sourceLeft = LuaAPI.xlua_tointeger(L, 1);
                    int _sourceTop = LuaAPI.xlua_tointeger(L, 2);
                    int _sourceWidth = LuaAPI.xlua_tointeger(L, 3);
                    int _sourceHeight = LuaAPI.xlua_tointeger(L, 4);
                    int _targetLeft = LuaAPI.xlua_tointeger(L, 5);
                    int _targetTop = LuaAPI.xlua_tointeger(L, 6);
                    char _sourceChar = (char)LuaAPI.xlua_tointeger(L, 7);
                    System.ConsoleColor _sourceForeColor;translator.Get(L, 8, out _sourceForeColor);
                    System.ConsoleColor _sourceBackColor;translator.Get(L, 9, out _sourceBackColor);
                    
                    System.Console.MoveBufferArea( _sourceLeft, _sourceTop, _sourceWidth, _sourceHeight, _targetLeft, _targetTop, _sourceChar, _sourceForeColor, _sourceBackColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.MoveBufferArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        System.ConsoleKeyInfo gen_ret = System.Console.ReadKey(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)) 
                {
                    bool _intercept = LuaAPI.lua_toboolean(L, 1);
                    
                        System.ConsoleKeyInfo gen_ret = System.Console.ReadKey( _intercept );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Console.ReadKey!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    System.Console.ResetColor(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBufferSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _width = LuaAPI.xlua_tointeger(L, 1);
                    int _height = LuaAPI.xlua_tointeger(L, 2);
                    
                    System.Console.SetBufferSize( _width, _height );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCursorPosition_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _left = LuaAPI.xlua_tointeger(L, 1);
                    int _top = LuaAPI.xlua_tointeger(L, 2);
                    
                    System.Console.SetCursorPosition( _left, _top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetWindowPosition_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _left = LuaAPI.xlua_tointeger(L, 1);
                    int _top = LuaAPI.xlua_tointeger(L, 2);
                    
                    System.Console.SetWindowPosition( _left, _top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetWindowSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _width = LuaAPI.xlua_tointeger(L, 1);
                    int _height = LuaAPI.xlua_tointeger(L, 2);
                    
                    System.Console.SetWindowSize( _width, _height );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Error(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Console.Error);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Out(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Console.Out);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_In(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Console.In);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InputEncoding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Console.InputEncoding);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OutputEncoding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Console.OutputEncoding);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BackgroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Console.BackgroundColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BufferHeight(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.BufferHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BufferWidth(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.BufferWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CapsLock(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.CapsLock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CursorLeft(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.CursorLeft);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CursorTop(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.CursorTop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CursorSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.CursorSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CursorVisible(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.CursorVisible);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ForegroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, System.Console.ForegroundColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeyAvailable(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.KeyAvailable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LargestWindowHeight(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.LargestWindowHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LargestWindowWidth(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.LargestWindowWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NumberLock(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.NumberLock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Title(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, System.Console.Title);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TreatControlCAsInput(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.TreatControlCAsInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowHeight(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.WindowHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowLeft(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.WindowLeft);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowTop(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.WindowTop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowWidth(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, System.Console.WindowWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsErrorRedirected(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.IsErrorRedirected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsOutputRedirected(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.IsOutputRedirected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsInputRedirected(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, System.Console.IsInputRedirected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InputEncoding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    System.Console.InputEncoding = (System.Text.Encoding)translator.GetObject(L, 1, typeof(System.Text.Encoding));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OutputEncoding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    System.Console.OutputEncoding = (System.Text.Encoding)translator.GetObject(L, 1, typeof(System.Text.Encoding));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BackgroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.ConsoleColor gen_value;translator.Get(L, 1, out gen_value);
				System.Console.BackgroundColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BufferHeight(RealStatePtr L)
        {
		    try {
                
			    System.Console.BufferHeight = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BufferWidth(RealStatePtr L)
        {
		    try {
                
			    System.Console.BufferWidth = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CursorLeft(RealStatePtr L)
        {
		    try {
                
			    System.Console.CursorLeft = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CursorTop(RealStatePtr L)
        {
		    try {
                
			    System.Console.CursorTop = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CursorSize(RealStatePtr L)
        {
		    try {
                
			    System.Console.CursorSize = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CursorVisible(RealStatePtr L)
        {
		    try {
                
			    System.Console.CursorVisible = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ForegroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.ConsoleColor gen_value;translator.Get(L, 1, out gen_value);
				System.Console.ForegroundColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Title(RealStatePtr L)
        {
		    try {
                
			    System.Console.Title = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TreatControlCAsInput(RealStatePtr L)
        {
		    try {
                
			    System.Console.TreatControlCAsInput = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowHeight(RealStatePtr L)
        {
		    try {
                
			    System.Console.WindowHeight = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowLeft(RealStatePtr L)
        {
		    try {
                
			    System.Console.WindowLeft = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowTop(RealStatePtr L)
        {
		    try {
                
			    System.Console.WindowTop = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowWidth(RealStatePtr L)
        {
		    try {
                
			    System.Console.WindowWidth = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_CancelKeyPress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.ConsoleCancelEventHandler gen_delegate = translator.GetDelegate<System.ConsoleCancelEventHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.ConsoleCancelEventHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					System.Console.CancelKeyPress += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					System.Console.CancelKeyPress -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to System.Console.CancelKeyPress!");
        }
        
    }
}
