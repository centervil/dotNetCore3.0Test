using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNetCore3
{
    internal sealed class CppLibWrapper
    {
        [DllImport("Lib\\CppLib.dll"/*, CharSet = CharSet.Unicode*/)]
        public extern static void SleepTest();

        public async static Task SleepTestAsync()
        {
            await Task.Run(() =>
            {
                SleepTest();
            });
        }
    }
}
