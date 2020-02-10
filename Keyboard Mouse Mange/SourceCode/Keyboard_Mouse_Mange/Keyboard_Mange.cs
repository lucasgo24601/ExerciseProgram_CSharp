using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace Keyboard_Mouse_Mange
{
	class Keyboard_Mange
    {
        IntPtr hhook = IntPtr.Zero;

        public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;

        #region API user32 & kernel32
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        #endregion

        public struct keyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        #region 建構子和解構子
        public Keyboard_Mange()
        {
            IntPtr hInstance = LoadLibrary("User32");
            Trace.WriteLine(hInstance);
            hhook = SetWindowsHookEx(APIConstansts.WH_KEYBOARD_LL, hookProc, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
            Trace.WriteLine(GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName));
        }

        ~Keyboard_Mange()
        {
            UnhookWindowsHookEx(hhook);
        }
        #endregion

        public int hookProc(int code, int wParam, ref keyboardHookStruct lParam)
        {
            Keys key = (Keys)lParam.vkCode; // key = 當前按的按鍵

            KeyEventArgs kea = new KeyEventArgs(key);
            if ((wParam == APIConstansts.WM_KEYDOWN || wParam == APIConstansts.WM_SYSKEYDOWN))
            {
                KeyDown(this, kea);
            }
            else if ((wParam == APIConstansts.WM_KEYUP || wParam == APIConstansts.WM_SYSKEYUP))
            {
                KeyUp(this, kea);
            }

            return CallNextHookEx(hhook, code, wParam, ref lParam);
        }
    }
}
