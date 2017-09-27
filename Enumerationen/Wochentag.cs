using System;

namespace Enumerationen
{
    [Flags]
    internal enum Wochentage : byte
    { 
        Montag = 1,
        Dienstag = 1<<1,
        Mittwoch = 1<<2,
        Donnerstag = 1<<3, 
        Freitag = 0b0001_0000,      // erst ab C#7 (VS2017)
        Samstag = 32,
        Sonntag = 64
    }
}
