using System;
using System.Text;
using System.IO;

namespace shader_configurator
{
    public static class CopyMaker
    {
        public static string Output(string str, int cpy)
        {
            String st = Path.GetFileNameWithoutExtension(str);
            String stExt = Path.GetExtension(str);
            StringBuilder sb = new StringBuilder();
            sb.Append(st);
            sb.Append("(" + cpy + ")");
            sb.Append(stExt);

            return sb.ToString();
        }
    }
}