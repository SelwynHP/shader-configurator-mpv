using Microsoft.VisualStudio.TestTools.UnitTesting;
using shader_configurator;
using shader_configurator.DAL;
using shader_configurator.VAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestKeybind
    {
        [TestMethod]
        public void KeybindOutputTypeTest()
        {
            Keybind kb = new Keybind();
            Assert.AreEqual(typeof(string), kb.Output().GetType());
        }
        [TestMethod]
        public void KeybindOutputFormatTest()
        {
            Keybind kb = new Keybind
            {
                FirstKey = KeybindEnum.CTRL,
                SecondKey = "1"
            };
            string pattern = Validation.patternKeybind;
            Assert.IsTrue(Regex.IsMatch(kb.Output(), pattern));
        }
        [TestMethod]
        public void KeybindOutputRemoveNullEmptyTest()
        {
            Keybind kb = new Keybind
            {
                FirstKey = KeybindEnum.ALT,
                SecondKey = "1"
            };
            string str = kb.Output();
            Assert.IsTrue(!str.Contains("EMPTY") || !str.Contains(@"\s"));
        }
        [TestMethod]
        public void KeyBindSecondKeyMustBeWordCharTest()
        {
            Keybind keybind = new Keybind
            {
                FirstKey = KeybindEnum.CTRL,
                SecondKey = "!"
            };
            string pattern = @"\W";
            bool success;
            if (!Regex.IsMatch(keybind.SecondKey, pattern))
            {
                success = true;
            }
            else
            {
                success = false;
            }
            Assert.IsTrue(success);
        }
    }
    [TestClass]
    public class UnitTestCommand
    {
        [TestMethod]
        public void CommandOutputTypeTest()
        {
            Command cmd = new Command();
            Assert.AreEqual(typeof(string), cmd.Output().GetType());
        }
        [TestMethod]
        public void CommandValueOutputTypeTest()
        {
            Command cmd = new Command();
            cmd.values.Add(ShaderEnum.DarkLinesFast);
            cmd.values.Add(ShaderEnum.DeblurMedium);
            cmd.values.Add(ShaderEnum.UpscaleOriginal);
            Assert.AreEqual(typeof(string), cmd.ValueOutput().GetType());
        }
        [TestMethod]
        public void CommandValueOutputFormatTest()
        {
            Command cmd = new Command
            {
                command_name = "no-osd change-list glsl-shaders set",
                values = new List<ShaderEnum>
                {
                    ShaderEnum.DarkLinesFast,
                    ShaderEnum.DeblurMedium,
                    ShaderEnum.UpscaleOriginal
                }
            };
            string pattern = Validation.patternCommand;
            Assert.IsTrue(Regex.IsMatch(cmd.ValueOutput(), pattern));
        }
        [TestMethod]
        public void CommandGetFiles()
        {
            string cmd = "C:/Users/VMRIG/AppData/Roaming/mpv/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;C:/Users/VMRIG/AppData/Roaming/mpv/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;C:/Users/VMRIG/AppData/Roaming/mpv/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl";
            List<String> sList = new List<string> { "Anime4K_Upscale_CNN_L_x2_Denoise.glsl","Anime4K_Auto_Downscale_Pre_x4.glsl","Anime4K_Upscale_CNN_M_x2_Deblur.glsl" };
            List<String> vList = Command.GetValues(cmd);
            Assert.IsTrue(vList.All(sList.Contains)&&vList.Count==sList.Count);
        }
    }
    [TestClass]
    public class UnitTestControl
    {
        [TestMethod]
        public void ControlOutputTypeTest()
        {
            Control control = new Control();
            Assert.AreEqual(typeof(string), control.Output().GetType());
        }
        [TestMethod]
        public void ControlOutputFormatTestRange()
        {
            bool success = true;
            string[] input = new string[]
            {
                @"CTRL+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Faithful)""",
                @"CTRL+2 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Perceptual Quality)""",
                @"CTRL+3 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Perceptual Quality and Deblur)""",
                @"CTRL+4 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Faithful)""",
                @"CTRL+5 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Perceptual Quality)""",
                @"CTRL+6 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Perceptual Quality and Deblur)""",
                @"CTRL+0 no-osd change-list glsl-shaders clr """"; show-text ""GLSL shaders cleared""",
                @"CTRL+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+2 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+3 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+4 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+5 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+6 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+0 no-osd change-list glsl-shaders clr """""
            };
            
            foreach(string str in input)
            {
                if(!ControlOutputFormatTest(new Control(str)))
                {
                    Assert.IsTrue(success);
                    break;
                }
            }
            Assert.IsTrue(success);
        }
        public bool ControlOutputFormatTest(Control control)
        {
            string pattern = Validation.patternControl;
            bool match = Regex.IsMatch(control.Output(), pattern);
            return match;
        }
        [TestMethod]
        public void ControlInputFormatTest()
        {
            string controlstr = @"CTRL+2 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Perceptual Quality)""";
            string pattern = Validation.patternControl;
            Assert.IsTrue(Regex.IsMatch(controlstr, pattern));
        }
        [TestMethod]
        public void ControlDuplicateTest()
        {
            bool success = true;
            Control control = new Control
            {
                keybind = new Keybind("CTRL+9"),
                command = new Command
                {
                    command_name = "no-osd change-list glsl-shaders set",
                    values = new List<ShaderEnum>{ShaderEnum.ACNet,ShaderEnum.DarkLinesHQ}
                },
                Comment = "Test"
            };

            shader_configurator.DAL.ControlManagement.SetControl(control);
            List<Control> cList = ControlManagement.GetControls();
            ControlManagement.SetControl(control);

            if(cList.FindAll(x=>x == control).Count > 1)
            {
                success = false;
            }
            ControlManagement.DeleteControl(control);
            Assert.IsTrue(success);
            
        }
        [TestMethod]
        public void ControtSetDefaultTest()
        {
            bool success = false;
            List<Control> defaultControls = ControlManagement.defaultControls;
            List<Control> oldControls = ControlManagement.GetControls();
            ControlManagement.SetControls();
            List<Control> newControls = ControlManagement.GetControls();
            if (defaultControls.All(newControls.Contains) && defaultControls.Count == newControls.Count)
            {
                success = true;
            }
            ControlManagement.SetControls(oldControls);
            Assert.IsTrue(success);
        }
    }
    [TestClass]
    public class UnitTestControlManagement
    {
        [TestMethod]
        public void ControlManagementSetControlTest()
        {
            bool success = false;
            //Control Initialization
            Control control = new Control();
            control.keybind.FirstKey = KeybindEnum.SHIFT;
            control.keybind.SecondKey = "2";
            control.command.command_name = "no-osd change-list glsl-shaders set";
            control.command.values.Add(ShaderEnum.AutoDownscale);
            control.command.values.Add(ShaderEnum.DarkLinesHQ);
            control.command.values.Add(ShaderEnum.ResamplingArtifactLarge);
            control.command.values.Add(ShaderEnum.UpscaleUltra);

            ControlManagement.SetControl(control);
            List<Control> cList = ControlManagement.GetControls();
            if (cList.Contains(control)) { success = true; ControlManagement.DeleteControl(control); }
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void ControlManagementUpdateControlTest()
        {
            bool success = false;

            Control control = new Control();
            control.keybind.FirstKey = KeybindEnum.CTRL;
            control.keybind.SecondKey = "9";
            control.command.command_name = "no-osd change-list glsl-shaders set";
            control.command.values.Add(ShaderEnum.AutoDownscale);
            control.command.values.Add(ShaderEnum.DarkLinesHQ);
            control.command.values.Add(ShaderEnum.ResamplingArtifactLarge);
            control.command.values.Add(ShaderEnum.UpscaleUltra);
            ControlManagement.SetControl(control);

            Control newControl = new Control();
            newControl.keybind.FirstKey = KeybindEnum.SHIFT;
            newControl.keybind.SecondKey = "0";
            newControl.command.command_name = "no-osd change-list glsl-shaders set";
            newControl.command.values.Add(ShaderEnum.AutoDownscale);
            newControl.command.values.Add(ShaderEnum.DeblurLarge);
            newControl.command.values.Add(ShaderEnum.UpscaleOriginal);
            newControl.command.values.Add(ShaderEnum.UpscaleUltraDenoise);

            ControlManagement.UpdateControl(control, newControl);

            List<Control> cList = ControlManagement.GetControls();
            if(cList.Contains(newControl) && !cList.Contains(control)) { success = true; ControlManagement.DeleteControl(newControl); }
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void ControlManagementDeleteControlTest()
        {
            Control control = new Control();
            control.keybind.FirstKey = KeybindEnum.CTRL;
            control.keybind.SecondKey = "7";
            control.command.command_name = "no-osd change-list glsl-shaders set";
            control.command.values.Add(ShaderEnum.AutoDownscale);
            control.command.values.Add(ShaderEnum.DarkLinesHQ);
            control.command.values.Add(ShaderEnum.ResamplingArtifactLarge);
            control.command.values.Add(ShaderEnum.UpscaleUltra);

            ControlManagement.SetControl(control);
            ControlManagement.DeleteControl(control);
            List<Control> cList = ControlManagement.GetControls();
            Assert.IsTrue(!cList.Contains(control));
            
        }
        [TestMethod]
        public void ControlManagementGetControlsTest()
        {
            Assert.AreEqual(typeof(List<Control>), ControlManagement.GetControls().GetType());
        }
    }
    [TestClass]
    public class UnitTestShader
    {
        [TestMethod]
        public void ShaderTypeTest()
        {
            Assert.AreEqual(typeof(Dictionary<ShaderEnum, string>), Shader.shaders.GetType());
        }
        [TestMethod]
        public void ShaderGetValueTest()
        {
            Assert.AreEqual(typeof(string), Shader.GetValue(ShaderEnum.AutoDownscale).GetType());
        }
    }
    [TestClass]
    public class UnitTestCopyMaker
    {
        [TestMethod]
        public void CopyFunctionOutputFormatTest()
        {
            //Function Requirements:
            //Accepts 2 Parameters<string, int>
            //Returns string in correct format w/ necessary seperator ;
            string pattern = @"^.+\.glsl(?>;.*\.glsl)*$";
            Assert.IsTrue(Regex.IsMatch(CopyMaker.Output(Shader.shaders.GetValueOrDefault(ShaderEnum.AutoDownscale), 3), pattern));
        }
    }
}
