using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EC2013_Installer
{
    class downloader
    {
        public Queue<string> download_list = new Queue<string>();
        WebClient client = new WebClient();

        public string progress = "0%";

        public int f_recieved = 0;
        public int f_to_recieve = 0;
        public int files_downloaded = 0;
        public int files_to_download = 0;

        public bool isAppUpdate = false;

        public string debugged = "";

        public bool DownloadComplete = false;

        public string StartPath = "";

        public void prepare_download()
        {
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            files_to_download = download_list.Count();

            do_download();
        }

        public void do_download()
        {

            if (isAppUpdate == true)
            {
                if (download_list.Any())
                {
                    files_downloaded++;

                    var rawLink = download_list.Dequeue();
                    var nextUrl = rawLink.Remove(0, rawLink.IndexOf("|") + 2);
                    var filePath = Path.Combine(StartPath, "downloaded", "downloaded" + files_downloaded.ToString() + ".zip");

                    client.DownloadFileAsync(new Uri(nextUrl), filePath);
                }
                else
                {
                    clean_shit();
                }
            }

            if (isAppUpdate == false)
            {
                if (download_list.Any())
                {
                    files_downloaded++;

                    var rawLink = download_list.Dequeue();
                    var nextUrl = rawLink.Remove(0, rawLink.IndexOf("|") + 2);
                    var filePath = Path.Combine(StartPath, rawLink.Substring(0, rawLink.IndexOf("|")));

                    //client.DownloadFileAsync(new Uri(nextUrl), filePath);
                }
                else
                {
                    clean_shit();
                }
            }
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            do_download();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress = e.ProgressPercentage.ToString() + "%";
            f_to_recieve = Convert.ToInt32( e.TotalBytesToReceive );
            f_recieved = Convert.ToInt32( e.BytesReceived );
        }

        public string MakeProperPostFix(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB"};
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        public void clean_shit() // cleaning all the shit 
        {
            download_list.Clear();

            debugged = "";
            files_downloaded = 0;
            files_to_download = 0;

            StartPath = "";

            client.DownloadProgressChanged -= Client_DownloadProgressChanged;
            client.DownloadFileCompleted -= Client_DownloadFileCompleted;

            DownloadComplete = true;
            isAppUpdate = false;
        }
    }
}
