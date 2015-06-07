using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Sharp.Xmpp.Extensions
{
    internal static class AssemblyExtension
    {
        public static Attribute GetCustomAttribute(this Assembly asm, Type attributeType)
        {
            foreach (Attribute attrib in asm.GetCustomAttributes(attributeType, true))
            {
                return attrib;
            }
            return null;
        }
    }
}
