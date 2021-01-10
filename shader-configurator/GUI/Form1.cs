using shader_configurator.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shader_configurator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Control control = new Control();
            control.command.values.Add(ShaderEnum.UpscaleOriginal);
            control.command.values.Add(ShaderEnum.DarkLinesFast);
            control.command.values.Add(ShaderEnum.AutoDownscale);
            ControlManagement.SetControl(control);
            MessageBox.Show("Success");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string str = @"CTRL+ALT+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_Original_x2.glsl;~~/shaders/Anime4K_DarkLines_Fast.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl""";
            Control control = new Control(str);
            ControlManagement.DeleteControl(control);
            MessageBox.Show("Success");
        }
    }
}
