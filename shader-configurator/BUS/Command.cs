using shader_configurator.VAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace shader_configurator
{
    public class Command
    {
        public string command_name;
        public List<ShaderEnum> values;
        public Command()
        {
            this.command_name = "";
            this.values = new List<ShaderEnum>();
        }

        public Command(string cmd) : this()
        {
            if (Validation.IsValidCommandString(cmd))
            {
                Match match = Regex.Match(cmd, Validation.patternCommand);
                if (match.Success)
                {
                    this.command_name = match.Groups[1].Value;
                    //Removing paths from strings
                    List<String> sList = GetValues(match.Groups[2].Value);
                    //Removing (*) from copies
                    Regex r = new Regex(@"\(\d\)");
                    for (int i = 0; i < sList.Count; i++) { sList[i] = r.Replace(sList[i], ""); }
                    //Getting Matching value from Shader Dictionary
                    for (int i = 0; i < sList.Count; i++)
                    {
                        if (!String.IsNullOrEmpty(sList[i]))
                        {
                            values.Add(Shader.shaders.FirstOrDefault(x => x.Value == sList[i]).Key);
                        }
                    }
                }
            }
        }
        public string Output()
        {
            return String.Join("", values);
        }

        public string ValueOutput()
        {
            Dictionary<ShaderEnum,int> dList = new Dictionary<ShaderEnum, int>();
            StringBuilder sb = new StringBuilder();
            foreach(ShaderEnum element in this.values)
            {
                //If dList contains the shader being iterated, the main(Original Copy) is already used. So we the copies.
                if (dList.ContainsKey(element))
                {
                    String[] line = Shader.GetValue(element, Shader.GetShaderCopyRootDirectory()).Split('.');
                    sb.Append(line[0]);
                    sb.Append("(" + dList[element] + ")");
                    sb.Append(".");
                    sb.Append(line[1]);
                    dList[element]++;
                }
                //Else we use the main and the shader to the dList
                else
                {
                    sb.Append(Shader.GetValue(element));
                    dList.Add(element, 1);
                }
                sb.Append(";");
            }
            string str = @"""" + sb.ToString().TrimEnd(';') + @"""";
            return this.command_name + " " + str;
        }
        public string ValueOutput(string shaderRootDirector)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ShaderEnum element in this.values)
            {
                sb.Append(Shader.GetValue(element,shaderRootDirector));
                sb.Append(";");
            }
            string str = @"""" + sb.ToString().TrimEnd(';') + @"""";
            return this.command_name + " " + str;
        }

        public static List<String> GetValues(string cmd)
        {
            List<String> sList = new List<String>();
            //Remove "" and replace / with \
            cmd = cmd.Replace("/", "\\").Replace(@"""", "");
            //Split string by ;
            string[] line = cmd.Split(';');
            //Get filename for each string
            foreach(string element in line)
            {
                string filename = Path.GetFileName(element);
                sList.Add(filename);
            }
            return sList;
        }
    }
}