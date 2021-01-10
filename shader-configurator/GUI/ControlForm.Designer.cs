namespace shader_configurator.GUI
{
    partial class ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPreview = new System.Windows.Forms.Label();
            this.labelShaders = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelBindings = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonUnsetComment = new System.Windows.Forms.Button();
            this.buttonSetComment = new System.Windows.Forms.Button();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.buttonUpdateProfile = new System.Windows.Forms.Button();
            this.buttonAddProfile = new System.Windows.Forms.Button();
            this.buttonClearShader = new System.Windows.Forms.Button();
            this.listBoxShaders = new System.Windows.Forms.ListBox();
            this.textBoxBindingSecondKey = new System.Windows.Forms.TextBox();
            this.buttonUnsetShader = new System.Windows.Forms.Button();
            this.buttonSetShader = new System.Windows.Forms.Button();
            this.buttonUnsetBinding = new System.Windows.Forms.Button();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.comboBoxShader = new System.Windows.Forms.ComboBox();
            this.buttonSetBinding = new System.Windows.Forms.Button();
            this.textBoxBindings = new System.Windows.Forms.TextBox();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
            this.listBoxControls = new System.Windows.Forms.ListBox();
            this.comboBoxBindingFirstKey = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxCopies = new System.Windows.Forms.ComboBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelCopies = new System.Windows.Forms.Label();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.labelShaderCopyRootDirectory = new System.Windows.Forms.Label();
            this.textBoxShaderCopyRootDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelShaderRootDirectory = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxShaderRootDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlMain.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.TabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(703, 394);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.buttonReset);
            this.TabPage1.Controls.Add(this.labelPreview);
            this.TabPage1.Controls.Add(this.labelShaders);
            this.TabPage1.Controls.Add(this.labelCommand);
            this.TabPage1.Controls.Add(this.labelBindings);
            this.TabPage1.Controls.Add(this.textBoxComment);
            this.TabPage1.Controls.Add(this.buttonUnsetComment);
            this.TabPage1.Controls.Add(this.buttonSetComment);
            this.TabPage1.Controls.Add(this.buttonDeleteProfile);
            this.TabPage1.Controls.Add(this.buttonUpdateProfile);
            this.TabPage1.Controls.Add(this.buttonAddProfile);
            this.TabPage1.Controls.Add(this.buttonClearShader);
            this.TabPage1.Controls.Add(this.listBoxShaders);
            this.TabPage1.Controls.Add(this.textBoxBindingSecondKey);
            this.TabPage1.Controls.Add(this.buttonUnsetShader);
            this.TabPage1.Controls.Add(this.buttonSetShader);
            this.TabPage1.Controls.Add(this.buttonUnsetBinding);
            this.TabPage1.Controls.Add(this.textBoxPreview);
            this.TabPage1.Controls.Add(this.comboBoxShader);
            this.TabPage1.Controls.Add(this.buttonSetBinding);
            this.TabPage1.Controls.Add(this.textBoxBindings);
            this.TabPage1.Controls.Add(this.comboBoxCommand);
            this.TabPage1.Controls.Add(this.listBoxControls);
            this.TabPage1.Controls.Add(this.comboBoxBindingFirstKey);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(695, 368);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Main";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(287, 59);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 23);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "Default Profiles";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(53, 188);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(51, 13);
            this.labelPreview.TabIndex = 27;
            this.labelPreview.Text = "(Preview)";
            // 
            // labelShaders
            // 
            this.labelShaders.AutoSize = true;
            this.labelShaders.Location = new System.Drawing.Point(403, 16);
            this.labelShaders.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelShaders.Name = "labelShaders";
            this.labelShaders.Size = new System.Drawing.Size(52, 13);
            this.labelShaders.TabIndex = 26;
            this.labelShaders.Text = "(Shaders)";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(285, 16);
            this.labelCommand.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(60, 13);
            this.labelCommand.TabIndex = 25;
            this.labelCommand.Text = "(Command)";
            // 
            // labelBindings
            // 
            this.labelBindings.AutoSize = true;
            this.labelBindings.Location = new System.Drawing.Point(54, 16);
            this.labelBindings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBindings.Name = "labelBindings";
            this.labelBindings.Size = new System.Drawing.Size(53, 13);
            this.labelBindings.TabIndex = 1;
            this.labelBindings.Text = "(Bindings)";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(56, 115);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(225, 21);
            this.textBoxComment.TabIndex = 24;
            // 
            // buttonUnsetComment
            // 
            this.buttonUnsetComment.Location = new System.Drawing.Point(174, 142);
            this.buttonUnsetComment.Name = "buttonUnsetComment";
            this.buttonUnsetComment.Size = new System.Drawing.Size(107, 23);
            this.buttonUnsetComment.TabIndex = 23;
            this.buttonUnsetComment.Text = "Unset Comment";
            this.buttonUnsetComment.UseVisualStyleBackColor = true;
            this.buttonUnsetComment.Click += new System.EventHandler(this.buttonUnsetComment_Click);
            // 
            // buttonSetComment
            // 
            this.buttonSetComment.Location = new System.Drawing.Point(56, 142);
            this.buttonSetComment.Name = "buttonSetComment";
            this.buttonSetComment.Size = new System.Drawing.Size(107, 23);
            this.buttonSetComment.TabIndex = 22;
            this.buttonSetComment.Text = "Set Comment";
            this.buttonSetComment.UseVisualStyleBackColor = true;
            this.buttonSetComment.Click += new System.EventHandler(this.buttonSetComment_Click);
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.Location = new System.Drawing.Point(287, 86);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(112, 23);
            this.buttonDeleteProfile.TabIndex = 21;
            this.buttonDeleteProfile.Text = "Delete Profile";
            this.buttonDeleteProfile.UseVisualStyleBackColor = true;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // buttonUpdateProfile
            // 
            this.buttonUpdateProfile.Location = new System.Drawing.Point(287, 113);
            this.buttonUpdateProfile.Name = "buttonUpdateProfile";
            this.buttonUpdateProfile.Size = new System.Drawing.Size(112, 23);
            this.buttonUpdateProfile.TabIndex = 20;
            this.buttonUpdateProfile.Text = "Update Profile";
            this.buttonUpdateProfile.UseVisualStyleBackColor = true;
            this.buttonUpdateProfile.Click += new System.EventHandler(this.buttonUpdateProfile_Click);
            // 
            // buttonAddProfile
            // 
            this.buttonAddProfile.Location = new System.Drawing.Point(287, 142);
            this.buttonAddProfile.Name = "buttonAddProfile";
            this.buttonAddProfile.Size = new System.Drawing.Size(112, 23);
            this.buttonAddProfile.TabIndex = 19;
            this.buttonAddProfile.Text = "Add Profile";
            this.buttonAddProfile.UseVisualStyleBackColor = true;
            this.buttonAddProfile.Click += new System.EventHandler(this.buttonAddProfile_Click);
            // 
            // buttonClearShader
            // 
            this.buttonClearShader.Location = new System.Drawing.Point(565, 58);
            this.buttonClearShader.Name = "buttonClearShader";
            this.buttonClearShader.Size = new System.Drawing.Size(73, 23);
            this.buttonClearShader.TabIndex = 18;
            this.buttonClearShader.Text = "Clear";
            this.buttonClearShader.UseVisualStyleBackColor = true;
            this.buttonClearShader.Click += new System.EventHandler(this.buttonClearShader_Click);
            // 
            // listBoxShaders
            // 
            this.listBoxShaders.FormattingEnabled = true;
            this.listBoxShaders.Location = new System.Drawing.Point(405, 83);
            this.listBoxShaders.Name = "listBoxShaders";
            this.listBoxShaders.Size = new System.Drawing.Size(233, 82);
            this.listBoxShaders.TabIndex = 17;
            // 
            // textBoxBindingSecondKey
            // 
            this.textBoxBindingSecondKey.Location = new System.Drawing.Point(210, 32);
            this.textBoxBindingSecondKey.Name = "textBoxBindingSecondKey";
            this.textBoxBindingSecondKey.Size = new System.Drawing.Size(71, 20);
            this.textBoxBindingSecondKey.TabIndex = 16;
            // 
            // buttonUnsetShader
            // 
            this.buttonUnsetShader.Location = new System.Drawing.Point(479, 58);
            this.buttonUnsetShader.Name = "buttonUnsetShader";
            this.buttonUnsetShader.Size = new System.Drawing.Size(80, 23);
            this.buttonUnsetShader.TabIndex = 15;
            this.buttonUnsetShader.Text = "Unset Shader";
            this.buttonUnsetShader.UseVisualStyleBackColor = true;
            this.buttonUnsetShader.Click += new System.EventHandler(this.buttonUnsetShader_Click);
            // 
            // buttonSetShader
            // 
            this.buttonSetShader.Location = new System.Drawing.Point(405, 59);
            this.buttonSetShader.Name = "buttonSetShader";
            this.buttonSetShader.Size = new System.Drawing.Size(68, 23);
            this.buttonSetShader.TabIndex = 14;
            this.buttonSetShader.Text = "Set Shader";
            this.buttonSetShader.UseVisualStyleBackColor = true;
            this.buttonSetShader.Click += new System.EventHandler(this.buttonSetShader_Click);
            // 
            // buttonUnsetBinding
            // 
            this.buttonUnsetBinding.Location = new System.Drawing.Point(174, 58);
            this.buttonUnsetBinding.Name = "buttonUnsetBinding";
            this.buttonUnsetBinding.Size = new System.Drawing.Size(107, 23);
            this.buttonUnsetBinding.TabIndex = 13;
            this.buttonUnsetBinding.Text = "Unset Binding";
            this.buttonUnsetBinding.UseVisualStyleBackColor = true;
            this.buttonUnsetBinding.Click += new System.EventHandler(this.buttonUnsetBinding_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(55, 204);
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.Size = new System.Drawing.Size(582, 20);
            this.textBoxPreview.TabIndex = 12;
            // 
            // comboBoxShader
            // 
            this.comboBoxShader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShader.FormattingEnabled = true;
            this.comboBoxShader.Location = new System.Drawing.Point(405, 31);
            this.comboBoxShader.Name = "comboBoxShader";
            this.comboBoxShader.Size = new System.Drawing.Size(233, 21);
            this.comboBoxShader.TabIndex = 9;
            // 
            // buttonSetBinding
            // 
            this.buttonSetBinding.Location = new System.Drawing.Point(56, 59);
            this.buttonSetBinding.Name = "buttonSetBinding";
            this.buttonSetBinding.Size = new System.Drawing.Size(107, 23);
            this.buttonSetBinding.TabIndex = 8;
            this.buttonSetBinding.Text = "Set Binding";
            this.buttonSetBinding.UseVisualStyleBackColor = true;
            this.buttonSetBinding.Click += new System.EventHandler(this.buttonSetBinding_Click);
            // 
            // textBoxBindings
            // 
            this.textBoxBindings.Location = new System.Drawing.Point(56, 88);
            this.textBoxBindings.Multiline = true;
            this.textBoxBindings.Name = "textBoxBindings";
            this.textBoxBindings.Size = new System.Drawing.Size(225, 21);
            this.textBoxBindings.TabIndex = 7;
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(287, 31);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(112, 21);
            this.comboBoxCommand.TabIndex = 6;
            // 
            // listBoxControls
            // 
            this.listBoxControls.FormattingEnabled = true;
            this.listBoxControls.Location = new System.Drawing.Point(55, 229);
            this.listBoxControls.Name = "listBoxControls";
            this.listBoxControls.Size = new System.Drawing.Size(582, 121);
            this.listBoxControls.TabIndex = 3;
            this.listBoxControls.SelectedIndexChanged += new System.EventHandler(this.listBoxControls_SelectedIndexChanged);
            // 
            // comboBoxBindingFirstKey
            // 
            this.comboBoxBindingFirstKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBindingFirstKey.FormattingEnabled = true;
            this.comboBoxBindingFirstKey.Location = new System.Drawing.Point(56, 32);
            this.comboBoxBindingFirstKey.Name = "comboBoxBindingFirstKey";
            this.comboBoxBindingFirstKey.Size = new System.Drawing.Size(148, 21);
            this.comboBoxBindingFirstKey.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonUpdate);
            this.tabPage2.Controls.Add(this.comboBoxCopies);
            this.tabPage2.Controls.Add(this.buttonCopy);
            this.tabPage2.Controls.Add(this.labelCopies);
            this.tabPage2.Controls.Add(this.buttonBrowse2);
            this.tabPage2.Controls.Add(this.labelShaderCopyRootDirectory);
            this.tabPage2.Controls.Add(this.textBoxShaderCopyRootDirectory);
            this.tabPage2.Controls.Add(this.buttonBrowse);
            this.tabPage2.Controls.Add(this.labelShaderRootDirectory);
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Controls.Add(this.textBoxShaderRootDirectory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(581, 40);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 20);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxCopies
            // 
            this.comboBoxCopies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCopies.FormattingEnabled = true;
            this.comboBoxCopies.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCopies.Location = new System.Drawing.Point(97, 117);
            this.comboBoxCopies.Name = "comboBoxCopies";
            this.comboBoxCopies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCopies.TabIndex = 10;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(500, 118);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 20);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.Location = new System.Drawing.Point(94, 102);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.Size = new System.Drawing.Size(91, 13);
            this.labelCopies.TabIndex = 8;
            this.labelCopies.Text = "Number of Copies";
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Location = new System.Drawing.Point(500, 79);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse2.TabIndex = 6;
            this.buttonBrowse2.Text = "Browse";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);
            // 
            // labelShaderCopyRootDirectory
            // 
            this.labelShaderCopyRootDirectory.AutoSize = true;
            this.labelShaderCopyRootDirectory.Location = new System.Drawing.Point(94, 63);
            this.labelShaderCopyRootDirectory.Name = "labelShaderCopyRootDirectory";
            this.labelShaderCopyRootDirectory.Size = new System.Drawing.Size(139, 13);
            this.labelShaderCopyRootDirectory.TabIndex = 5;
            this.labelShaderCopyRootDirectory.Text = "Shader Copy Root Directory";
            // 
            // textBoxShaderCopyRootDirectory
            // 
            this.textBoxShaderCopyRootDirectory.Location = new System.Drawing.Point(97, 79);
            this.textBoxShaderCopyRootDirectory.Name = "textBoxShaderCopyRootDirectory";
            this.textBoxShaderCopyRootDirectory.Size = new System.Drawing.Size(397, 20);
            this.textBoxShaderCopyRootDirectory.TabIndex = 4;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(500, 40);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelShaderRootDirectory
            // 
            this.labelShaderRootDirectory.AutoSize = true;
            this.labelShaderRootDirectory.Location = new System.Drawing.Point(94, 24);
            this.labelShaderRootDirectory.Name = "labelShaderRootDirectory";
            this.labelShaderRootDirectory.Size = new System.Drawing.Size(112, 13);
            this.labelShaderRootDirectory.TabIndex = 2;
            this.labelShaderRootDirectory.Text = "Shader Root Directory";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(500, 164);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save Settings";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxShaderRootDirectory
            // 
            this.textBoxShaderRootDirectory.Location = new System.Drawing.Point(97, 40);
            this.textBoxShaderRootDirectory.Name = "textBoxShaderRootDirectory";
            this.textBoxShaderRootDirectory.Size = new System.Drawing.Size(397, 20);
            this.textBoxShaderRootDirectory.TabIndex = 0;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.tabControlMain);
            this.Name = "ControlForm";
            this.Text = "shader-configurator";
            this.tabControlMain.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonUnsetShader;
        private System.Windows.Forms.Button buttonSetShader;
        private System.Windows.Forms.Button buttonUnsetBinding;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.ComboBox comboBoxShader;
        private System.Windows.Forms.Button buttonSetBinding;
        private System.Windows.Forms.TextBox textBoxBindings;
        private System.Windows.Forms.ComboBox comboBoxCommand;
        private System.Windows.Forms.ListBox listBoxControls;
        private System.Windows.Forms.ComboBox comboBoxBindingFirstKey;
        private System.Windows.Forms.TextBox textBoxBindingSecondKey;
        private System.Windows.Forms.ListBox listBoxShaders;
        private System.Windows.Forms.Button buttonClearShader;
        private System.Windows.Forms.Button buttonAddProfile;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.Button buttonUpdateProfile;
        private System.Windows.Forms.Label labelShaderRootDirectory;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxShaderRootDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonUnsetComment;
        private System.Windows.Forms.Button buttonSetComment;
        private System.Windows.Forms.Label labelShaders;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelBindings;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.Label labelShaderCopyRootDirectory;
        private System.Windows.Forms.TextBox textBoxShaderCopyRootDirectory;
        private System.Windows.Forms.ComboBox comboBoxCopies;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelCopies;
        private System.Windows.Forms.Button buttonUpdate;
    }
}