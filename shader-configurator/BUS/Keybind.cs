using shader_configurator.VAL;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace shader_configurator
{
    public enum KeybindEnum
    {
        EMPTY,
        CTRL,
        SHIFT,
        ALT,
        META
    }
    public class Keybind
    {
        private string secondKey;
        public KeybindEnum FirstKey { get; set; }
        public string SecondKey 
        { 
            get { return secondKey; } 
            set { 
                if (!Validation.ContainsWordChar(value)) { secondKey = value; } 
            } 
        }

        public Keybind()
        {
            this.FirstKey = KeybindEnum.EMPTY;
            this.SecondKey = "";
        }
        public Keybind(string kb) : this()
        {
            if (Validation.IsValidKeybindString(kb))
            {
                string pattern = Validation.patternKeybind;
                Match match = Regex.Match(kb, pattern);
                if(match.Success)
                {
                    if (String.IsNullOrEmpty(match.Groups[1].Value))
                    {
                        FirstKey = KeybindEnum.EMPTY;
                    }
                    else
                    {
                        FirstKey = (KeybindEnum)Enum.Parse(typeof(KeybindEnum), match.Groups[1].Value);
                    }
                    SecondKey = match.Groups[2].Value;
                }
            }
        }
        public string Output()
        {
            return OutputRemoveNullEmpty(FirstKey.ToString() + "+" + SecondKey);
        }
        public string OutputRemoveNullEmpty(string v)
        {
            v = v.Replace("EMPTY+", "");
            v = v.Replace("++","+");
            v = v.Trim('+');
            return v;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Keybind c = obj as Keybind;
            if (c == null)
            {
                return false;
            }
            if (this.FirstKey == c.FirstKey && this.SecondKey == c.SecondKey)
            {
                return true;
            }
            return false;
        }
    }
}