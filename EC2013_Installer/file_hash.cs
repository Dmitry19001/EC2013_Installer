using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC2013_Installer
{
    class file_hash
    {
        public static List<string> FinishedHash = new List<string>();

        public void generateHash(string filepath, string modpath)
        {
            byte[] buffer;
            int byetsread;
            long size;
            long totalBytesRead = 0;

            using (Stream file = File.OpenRead(filepath))
            {
                size = file.Length;
                using (HashAlgorithm hasher = MD5.Create())
                {
                    do
                    {
                        Application.DoEvents();

                        buffer = new byte[4098];

                        byetsread = file.Read(buffer, 0, buffer.Length);

                        totalBytesRead += byetsread;

                        hasher.TransformBlock(buffer, 0, byetsread, null, 0);

                    }
                    while (byetsread != 0);

                    hasher.TransformFinalBlock(buffer, 0, 0);
                    FinishedHash.Add(MakeHashString(hasher.Hash) + " " + filepath.Remove(0, modpath.Length + 1)  );
                }
            }
        }

        private static string MakeHashString(byte[] hashbytes)
        {
            StringBuilder hash = new StringBuilder(32);

            foreach (byte b in hashbytes)
                hash.Append(b.ToString("X2").ToLower());

            return hash.ToString();
        }

        public void clearHash()
        {
            FinishedHash.Clear();
        }

        
    }
}
