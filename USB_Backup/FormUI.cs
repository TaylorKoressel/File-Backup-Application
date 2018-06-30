using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

// Google Drive
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace USB_Backup
{
    public partial class FormUI : Form
    {
        String source = "";
        String target = "";
        String uploadType = "File";

        public FormUI()
        {
            InitializeComponent();
        }


        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                source = openFileDialog1.FileName;
                tbfile.Text = source;
            }
        }

        //private void btnFromChoose_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1 = new OpenFileDialog();

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        source = openFileDialog1.FileName;
        //        tbfile.Text = source;
        //    }
        //}


        private void btnchooseFolder_Click_1(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                source = folderBrowserDialog1.SelectedPath;
                tbFolder.Text = source;
            }
        }

        private void btnToChoose_Click_1(object sender, EventArgs e)
        {
            if (fbdTargetDir.ShowDialog() == DialogResult.OK)
            {
                target = fbdTargetDir.SelectedPath;
                tbTargetDir.Text = target;

            }
        }

        private void btnGoPage_2_Click(object sender, EventArgs e)
        {
            gbPage_1.Visible = false;
        }

        public static void CopyAll(String uploadType, FileInfo file, DirectoryInfo folder, DirectoryInfo target)
        {
            if (uploadType == "File")
            {
                Directory.CreateDirectory(target.FullName);
                String fileName = file.Name;
                fileName += DateTime.Now.ToString();
                
                file.CopyTo(Path.Combine(target.FullName, file.Name), false);
            }
            else
            {
                foreach (FileInfo fi in folder.GetFiles())
                {
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                }

                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in folder.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(uploadType, file, diSourceSubDir, nextTargetSubDir);
                }
            }

            //// Copy subDir's and files into the new directory.
            //foreach (FileInfo fi in source.GetFiles())
            //{
            //    Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
            //    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            //}

            //// Copy each subdirectory using recursion.
            //foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            //{
            //    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
            //    CopyAll(diSourceSubDir, nextTargetSubDir);
            //}
        }

        private void btnGoPage_3_Click(object sender, EventArgs e)
        {
            

            if (tbTargetDir.Text != "")
            {
                if (tbfile.Text == "" && tbFolder.Text == "")
                {
                    lblError.Visible = true;
                }
                else
                {
                    lblError.Visible = false;
                    gbPage_3.Visible = true;

                    if (uploadType == "File")
                    {
                        FileInfo Source = new FileInfo(source);
                        DirectoryInfo Target = new DirectoryInfo(target);
                        DirectoryInfo placeHolder = new DirectoryInfo("placeHolder");
                        CopyAll("File", Source, placeHolder, Target);
                    }
                    else
                    {
                        DirectoryInfo Source = new DirectoryInfo(source);
                        DirectoryInfo Target = new DirectoryInfo(target);
                        FileInfo placeHolder = new FileInfo("placeHolder");
                        CopyAll("Folder", placeHolder, Source, Target);
                    }
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }


        private void rbFile_CheckedChanged(object sender, EventArgs e)
        {
            if (gbFile.Enabled == true)
            {
                gbFile.Enabled = false;
                uploadType = "folder";
                Console.WriteLine(uploadType);
            }
            else
            {
                gbFile.Enabled = true;
            }
        }

        private void rbFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (gbFolder.Enabled == true)
            {
                gbFolder.Enabled = false;
                uploadType = "file";
                Console.WriteLine(uploadType);
            }
            else
            {
                gbFolder.Enabled = true;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
