using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC2013_Installer
{
    public partial class main_form : Form
    {
        public Point MouseLoc { get; private set; }
        private int toChk = 0;
        private int Chkd = 0;

        private string status_text;

        public List<string> SortedFiles = new List<string>();
        public List<string> NeedToDownload = new List<string>();

        file_hash Hasher = new file_hash();

        Timer progresssr = new Timer();
        Timer downloader = new Timer();
        Timer animator = new Timer();

        public main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prog_name.Text = "EC2013 MOD INSTALLER ver" + ProductVersion;
            LoadLocalization();

            DisableDefaultHover();
        }

        private void DisableDefaultHover() //disabling default hover event for every button in form
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    var b = (Button)c;

                    b.FlatAppearance.MouseOverBackColor = b.BackColor;
                    b.BackColorChanged += (s, e) => {
                        b.FlatAppearance.MouseOverBackColor = b.BackColor;
                    };
                }

            }
        }

        private void LoadLocalization() //WIP
        {
            
        }

        //FormMOVING//
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseLoc.X;
                this.Top += e.Y - MouseLoc.Y;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLoc = e.Location;
            }
        }
        //FormMOVING//

        private void ext_button_Click(object sender, EventArgs e) //closing 
        {
            this.Close();
        }

        private bool devmode;

        private static int countProgress(int thisVal, int maxVal, int maxWidth)
        {
            decimal prcnt;

            if (maxVal > 0)
                prcnt = Convert.ToDecimal(thisVal) / Convert.ToDecimal(maxVal); //getting percentage
            else
                prcnt = 0;

            int wdth = Convert.ToInt16( Math.Round(prcnt * maxWidth, 0)); // basic math

            return wdth - 4; // returning value and -4 because of paddings
        }

        private void test_hash_button_Click(object sender, EventArgs e)
        {
            NeedToDownload.Clear();

            beginCount();
        }

        private void beginCount()
        {
            if (Vars.mod_path != "")
            {
                toChk = 0;
                Chkd = 0;

                status_bar.Text = "Status: Counting files to check";

                progresssr.Interval = 20;
                progresssr.Tick += Progresssr_Tick;
                progresssr.Start();

                status_text = "Counting: ";

                string[] files =  Directory.GetFiles(Vars.mod_path, "*", SearchOption.AllDirectories); //getting filelist from selected directory
                foreach (string f in files)
                {
                    Application.DoEvents();
                    toChk++;
                }

                status_bar.Text = "Status: Counting files to check COMPLETE";

                if (File.Exists(".\\dev_txt.txt") && devmode == false)
                {
                    beginFileSort(files);
                }
                else if (devmode == true)
                {
                    SortedFiles.Clear();
                    SortedFiles.AddRange(files);

                    generateHash(false);
                }
            }
            
        }

        private void beginFileSort(string[] files)
        {
            SortedFiles.Clear();
            string[] originalfiles = File.ReadAllLines(".\\dev_txt_1.txt"); //getting original filelist from file/internet

            status_text = "Sorted: ";

            foreach (string f in files) //checking if files exsists in original filelist
            {
                Application.DoEvents();
                if (originalfiles.Contains(f.Substring(Vars.mod_path.Length - 3)) && !f.Contains(".git"))
                {
                    Chkd++;
                    SortedFiles.Add(f);
                }
            }

            if (devmode == true)
                generateHash(true); //next step with dev mode on
            else
                generateHash(false); //next step in normal mode
        }

        private void generateHash(bool develop)
        {
            Hasher.clearHash();

            toChk = SortedFiles.Count;
            Chkd = 0;

            progresssr.Interval = 20;
            progresssr.Tick += Progresssr_Tick;
            progresssr.Start();

            status_text = "Hashed files: ";

            foreach (string s in SortedFiles)
            {
                Hasher.generateHash(s, Vars.mod_path);  
                Chkd++;
                //debugS.Add((Chkd).ToString() + ". Hashed: " + s); //just debbuging
            }

            if (develop == true)
            {
                File.WriteAllText(".\\dev_txt.txt", String.Join(Environment.NewLine, file_hash.FinishedHash.ToArray()));
            }

            CompareHash();
        }

        private void CompareHash()
        {
            string[] originalfiles = File.ReadAllLines(".\\dev_txt.txt"); //getting original filelist from file/internet
            NeedToDownload.Clear(); //cleaning list 
            //MessageBox.Show("Comparing");

            //setting values for progress indicator
            toChk = originalfiles.Length;   
            Chkd = 0;

            //starting progress indicator
            progresssr.Interval = 20;
            progresssr.Tick += Progresssr_Tick;
            progresssr.Start();

            status_text = "Compared: "; //Just a text for status bar

            foreach (string f in originalfiles)
            {
                //Application.DoEvents(); //doing other work while in each loop

                if (!file_hash.FinishedHash.ToArray().Contains(f)) //checkung if sting exsists in user files = we can get what we need to download
                    NeedToDownload.Add(f.Remove(0,33)); //adding files names in list for further interaction

                Chkd++; //making progress
            }

           
            if (NeedToDownload.Count > 0)
                MessageBox.Show("Complete comparing. Files needs to be downloaded: " + NeedToDownload.Count );
            else
                MessageBox.Show("You are using the latest version of the mod ;)");
        }

        private void dev_button_Click(object sender, EventArgs e) //DEV THINGs
        {
            progresssr.Interval = 50;
            progresssr.Tick += Progresssr_Tick;
            progresssr.Start();

            SortedFiles.Clear();

            Vars.mod_path = Path.Combine(Application.StartupPath, "need", "ec");

            string[] dev_files;
            string ffiles = "";

            dev_files = Directory.GetFiles(Path.Combine(Application.StartupPath, "need", "ec"), "*", SearchOption.AllDirectories);

            toChk = dev_files.Length;

            foreach (string s in dev_files)
            {
                if (ffiles.Length > 0)
                {
                    Application.DoEvents();
                    ffiles = ffiles + Environment.NewLine + s.Substring(Path.Combine(Application.StartupPath, "need").Length, s.Length - Path.Combine(Application.StartupPath, "need").Length);
                    Chkd++;

                    SortedFiles.Add(s);
                }
                else
                {
                    Application.DoEvents();
                    ffiles = s.Substring(Path.Combine(Application.StartupPath, "need").Length, s.Length - Path.Combine(Application.StartupPath, "need").Length);
                    Chkd++;

                    SortedFiles.Add(s);
                }
                   
            }

            File.WriteAllText(".\\dev_txt_1.txt", ffiles);

          //  MessageBox.Show("Complete");

            generateHash(true);
        }

        private void Progresssr_Tick(object sender, EventArgs e) //progress show
        {
            prgrsBar_pt2.Width = countProgress(Chkd, toChk, prgrsBar_pt1.Width);
            status_bar.Text = status_text + Chkd.ToString() + "\\" + toChk.ToString();

            if (Chkd == toChk)
            {
                progresssr.Tick -= Progresssr_Tick;
                progresssr.Stop();

                Chkd = 0;
                toChk = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (devmode == false)
            {
                devmode = true;
                dev_mode_but.BackColor = Color.Lime;
                dev_button.Visible = true;
            }
            else
            {
                devmode = false;
                dev_mode_but.BackColor = Color.Red;
                dev_button.Visible = false;
            }
        }

        downloader dwn = new downloader();

        private void dwnld_but_Click(object sender, EventArgs e)
        {

            dwn.DownloadComplete = false;

            if (devmode == true)
            {
                dwn.download_list.Enqueue("EC2013_Installer.exe | https://www.dropbox.com/s/bmjgvvzelcqezh2/MusicBot.rar?dl=1");
                dwn.download_list.Enqueue("ec_background.jpg | https://www.dropbox.com/s/bh6176p5575klja/JobMakerUpdate.zip?dl=1");
                dwn.StartPath = Application.StartupPath;
                dwn.isAppUpdate = true;
            }
                

            dwn.prepare_download();

            downloader.Interval = 50;
            downloader.Tick += Downloader_Tick;
            downloader.Start();
        }

        private void Downloader_Tick(object sender, EventArgs e)
        {
            if (dwn.DownloadComplete == false)
            {
                prgrsBar_pt2.Width = countProgress(dwn.f_recieved, dwn.f_to_recieve, prgrsBar_pt1.Width);
                status_bar.Text = "Downloading: " + dwn.MakeProperPostFix(dwn.f_recieved) + "/" + dwn.MakeProperPostFix(dwn.f_to_recieve) + "    " + dwn.files_downloaded.ToString() + "/" + dwn.files_to_download.ToString();
            }
            else
            {
                downloader.Tick -= Downloader_Tick;
                downloader.Stop();
            }
        }

        bool openMode = false; 

        private void settings_but_Click(object sender, EventArgs e)
        {
            settings_but.Enabled = false;

            if (openMode == false) //use open/close mode
            {
                settings_menu_panel.Visible = true;
                openMode = true;
            }           
            else
                openMode = false;

            animator.Interval = 15;
            animator.Tick += Animator_Tick;
            animator.Start();


            
        }

        private void Animator_Tick(object sender, EventArgs e)
        {
            decimal height_persentage;
            decimal width_persentage;

            if (settings_menu_panel.Height > 0)
                height_persentage = Convert.ToDecimal(settings_menu_panel.Height) / Convert.ToDecimal(this.Height); //getting percentage
            else
                height_persentage = 0;

            if (settings_menu_panel.Width > 0)
                width_persentage = Convert.ToDecimal(settings_menu_panel.Width) / Convert.ToDecimal(this.Width); //getting percentage
            else
                width_persentage = 0;

            if (width_persentage < 1 && height_persentage < 1 && openMode == true)
            {
                settings_menu_panel.Height = Convert.ToInt16(Math.Round((height_persentage + new decimal(0.10)) * this.Height, 0));
                settings_menu_panel.Width = Convert.ToInt16(Math.Round((width_persentage + new decimal(0.10)) * this.Width, 0));
            }
            else if (width_persentage > 0 && height_persentage > 0 && openMode == false)
            {
                settings_menu_panel.Height = Convert.ToInt16(Math.Round((height_persentage - new decimal(0.10)) * this.Height, 0));
                settings_menu_panel.Width = Convert.ToInt16(Math.Round((width_persentage - new decimal(0.10)) * this.Width, 0));
            }
            else
            {
                animator.Tick -= Animator_Tick;
                animator.Stop();
                settings_but.Enabled = true;

                if (openMode == false)
                    settings_menu_panel.Visible = false;
            }


        }

    }
}
