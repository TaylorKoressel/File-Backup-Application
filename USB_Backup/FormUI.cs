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
        String startDir = "C:\\Users\\TheSteadfastWog\\Desktop\\startDIR";
        String targetDir = "C:\\Users\\TheSteadfastWog\\Desktop\\targetDIR\\usbBackup";
        static string[] Scopes = { DriveService.Scope.Drive };

        public FormUI()
        {
            InitializeComponent();
        }

        private void FormUI_Load(object sender, EventArgs e)
        {
            tbStartDir.Text = startDir;
            tbTargetDir.Text = targetDir;

            // Add time stamp to targetDir
            DateTime Now = DateTime.Today;
            String timeStamp = Now.ToString("d");


            //// Define parameters of request.
            //FilesResource.ListRequest listRequest = driveService.Files.List();
            //listRequest.PageSize = 10;
            //listRequest.Fields = "nextPageToken, files(id, name)";

            //// List files.
            //IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
            //    .Files;
            //Console.WriteLine("Files:");
            //if (files != null && files.Count > 0)
            //{
            //    foreach (var file in files)
            //    {
            //        Console.WriteLine("{0} ({1})", file.Name, file.Id);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No files found.");
            //}
            //Console.Read();
        }

        private String DefaultTargetDir()
        {
            DateTime date = new DateTime();
            String now;
            now = date.ToString();
            now.Replace("/", ".");
            String TargetDir = "USB_Backup_" + now;
            return TargetDir;
        }

        private void btnFromChoose_Click(object sender, EventArgs e)
        {
            if (fbdStartDir.ShowDialog() == DialogResult.OK)
            {
                startDir = fbdStartDir.SelectedPath;
                tbStartDir.Text = startDir;
            }
        }

        private void btnToChoose_Click(object sender, EventArgs e)
        {
            if (fbdTargetDir.ShowDialog() == DialogResult.OK)
            {
                targetDir = fbdTargetDir.SelectedPath;
                tbTargetDir.Text = targetDir;
            }
        }

        //private void btnCopy_Click(object sender, EventArgs e)
        //{
        //    String newFolder = targetDir;

        //    DirectoryInfo diSource = new DirectoryInfo(startDir);
        //    DirectoryInfo diTarget = new DirectoryInfo(newFolder);
        //    CopyAll(diSource, diTarget);
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {

        }

        private void cbLocal_CheckedChanged(object sender, EventArgs e)
        {
            if(gbLocal.Enabled)
            {
                gbLocal.Enabled = false; 
            }
            else
            {
                gbLocal.Enabled = true;
            } 
        }

        private void cbCloud_CheckedChanged(object sender, EventArgs e)
        {
            if (gbCloud.Enabled)
            {
                gbCloud.Enabled = false;
            }
            else
            {
                gbCloud.Enabled = true;
            }
        }

        private void btnGoPage_2_Click(object sender, EventArgs e)
        {
            gbPage_2.Visible = true;
            gbPage_1.Visible = false;

            // Copy to local storage
            //String newFolder = targetDir;
            //DirectoryInfo diSource = new DirectoryInfo(startDir);
            //DirectoryInfo diTarget = new DirectoryInfo(newFolder);
            //CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);
            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void btnGoPage_3_Click(object sender, EventArgs e)
        {
            gbPage_3.Visible = true;
            gbPage_2.Visible = false;

            // Login and create credential file
            string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            credPath = Path.Combine(credPath, ".credentials/credential.json");

            UserCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Drive service
            DriveService driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "USB-Backup",
            });

            // Upload file
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "TryItOut.txt"
            };

            String filePath = "C:\\Users\\TheSteadfastWog\\Desktop\\GO-TIME\\File_Backup_App\\USB_Backup\\USB_Backup\\Files\\test.txt";

            FilesResource.CreateMediaUpload request;

            using (var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Open))
            {
                request = driveService.Files.Create(fileMetadata, stream, "text/plain");
                request.Fields = "id";
                request.Upload();
            }

            var file = request.ResponseBody;
            Console.WriteLine("File ID: " + file.Id);
        }
    }
}
