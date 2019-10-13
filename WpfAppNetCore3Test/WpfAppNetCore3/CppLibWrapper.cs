using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WpfAppNetCore3
{
    internal sealed class CppLibWrapper
    {
        [DllImport("Lib\\CppLib.dll"/*, CharSet = CharSet.Unicode*/)]
        public extern static void SleepTest();
    }
}
