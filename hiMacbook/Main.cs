using AppKit;
using System;
using System.Drawing;
using Foundation;
using ObjCRuntime;

namespace hiMacbook
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.Main(args);
        }
    }
}
