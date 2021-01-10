using shader_configurator.DAL;
using shader_configurator.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shader_configurator
{
    static class Program
    {
        static void SetDefaultDirectories()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.ShaderRootDirectory))
            {
                Properties.Settings.Default.ShaderRootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\mpv\\shaders";
                Properties.Settings.Default.Save();
            }
            if (String.IsNullOrEmpty(Properties.Settings.Default.ShaderCopyRootDirectory))
            {
                Properties.Settings.Default.ShaderCopyRootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\mpv\\shaders\\copy";
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetDefaultDirectories();
            ControlManagement.CreateMPVInput();
            Application.Run(new ControlForm());
        }
    }
}
