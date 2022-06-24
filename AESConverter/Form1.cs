using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace AESConverter
{
    
    
    public partial class Form1 : Form
    {
        FileInformation infFile;
        AES AESConverter = null;
        SaveFileDialog fileSaveUnsafe = null;
        string Extension = string.Empty;

        Thread ThreadConvert;
        public Form1()
        {
            InitializeComponent();
            AESConverter = new AES();
            fileSaveUnsafe = new SaveFileDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.FileName = "New AES File " + Extension;
            file.Filter = "AES Files | *.AES";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtPathForSaveAES_File.Text = file.FileName;
        }

        private void SaveAES_Click(object sender, EventArgs e)
        {
            ThreadConvert = new Thread(new ThreadStart(ThreadSave));
            ThreadConvert.Start();
        }

        void ThreadSave()
        {
            try
            {
                byte[] b = File.ReadAllBytes(TxtLoadFile.Text);
                string s = Encoding.Default.GetString(b);

                infFile.MainInformationFile = s;
                //ToJson
                string StrJson = JsonConvert.SerializeObject(infFile);
                //

                //coding
                string StrCode = Encrypt(StrJson, SetPasswordFile.Text);
                //

                if (StrCode != "This Is Null")
                {
                    File.WriteAllText(txtPathForSaveAES_File.Text, StrCode);
                    MessageBox.Show(txtPathForSaveAES_File.Text + ":فایل شما در این مسیر ذخیره شد ");
                }
                Thread.Sleep(200);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ذخیره یا تبدیل کردن فایل:" + ex.ToString());
            }
        }

        private void SearchForInportFileAES_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                TxtLoadFile.Text = file.FileName;
                Extension = Path.GetExtension(TxtLoadFile.Text);
                Extension = Extension.Remove(0, 1);
                infFile.FormatFile = Extension;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblErrorConvertToAES.Text = string.Empty;
            LblErrorConvertToBase.Text = string.Empty;
        }

        private void LoadAES_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "AES Files | *.AES";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtLoadFileConvertToBase.Text = file.FileName;
                //Extension = TxtLoadFileConvertToBase.Text.EndsWith();
            }
        }

        private void SetUnsafeFilePath_Click(object sender, EventArgs e)
        {
            
            if (fileSaveUnsafe.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                TxtSaveFileConvertToBase.Text = fileSaveUnsafe.FileName;
        }

        private void SaveUnsafeFile_Click(object sender, EventArgs e)
        {
            ThreadConvert = new Thread(new ThreadStart(ThreadSaveUnsafe));
            ThreadConvert.Start();
        }

        void ThreadSaveUnsafe()
        {

            string str = File.ReadAllText(TxtLoadFileConvertToBase.Text);

            //DeCode
            string StrCode = Decript(str, TxtPasswordLoadFileConvertToBase.Text);
            //
            if (StrCode == "")
            {
                infFile = new FileInformation();
            }
            else
            {
                try
                {
                    //json
                    //object OBJFile = JsonConvert.DeserializeObject(StrCode) as object;
                    infFile = JsonConvert.DeserializeObject<FileInformation>(StrCode);
                    //

                    byte[] b = Encoding.Default.GetBytes(infFile.MainInformationFile);

                    File.WriteAllBytes(TxtSaveFileConvertToBase.Text + "." + infFile.FormatFile, b);
                    MessageBox.Show(TxtSaveFileConvertToBase.Text + ":فایل شما در این مسیر ذخیره شد ");
                }
                catch
                {
                    MessageBox.Show("فایل شما ذخیره نشد!");
                }
            }

        }

        bool HasImageExtension(string source)
        {
            return (source.EndsWith(".png") || source.EndsWith(".jpg") || source.EndsWith(".tga") || source.EndsWith(".bmp") || source.EndsWith(".jpeg") || source.EndsWith(".jpeg2000") || source.EndsWith(".tiff") || source.EndsWith(".svg"));
        }
        

        string Encrypt(string EnValue , string key)
        {
            AESConverter.txtToEncript = EnValue;
            AESConverter.txtKey = key;
            AESConverter.Encrypt();
            if (AESConverter.lblResult == string.Empty)
            {
                return AESConverter.txtResult;
            }
            else
            {
                MessageBox.Show(AESConverter.lblResult);
                return "";
            }
            
        }


        string Decript(string EnValue, string key)
        {
            AESConverter.txtResult = EnValue;
            AESConverter.txtKey = key;
            AESConverter.Decript();
            if (AESConverter.lblResult == string.Empty)
            {
                return AESConverter.txtToEncript;
            }
            else
            {
                MessageBox.Show(AESConverter.lblResult);
                return "";
            }

        }
    }

    public struct FileInformation
    {
        public string MainInformationFile { get; set; }
        public string FormatFile { get; set; }
    }

    class AES
    {
        public  string txtKey = null;
        public  string txtToEncript = null;
        public  string txtResult = null;
        public  string lblResult = null;

        static string key = "edfg431", EnValue = "sf23re4";
        public void Encrypt()
        {
            key = Convert.ToString(txtKey);
            EnValue = Convert.ToString(txtToEncript);

            if (key != "" && EnValue != "")
            {

                txtResult= EncryptStringAES(EnValue, key);
                lblResult = string.Empty;
            }
            else
            {

                lblResult = "متن را برای رمزگزاری وارد کنید";
                return;
            }
        }

        public void Decript()
        {
            EnValue = Convert.ToString(txtResult);
            key = Convert.ToString(txtKey);


            if (key != "" && EnValue != "")
            {
                txtToEncript = DecryptStringAES(EnValue, key);
                lblResult = string.Empty;
            }
            else
            {
                lblResult = "متن را برای رمزگشایی وارد کنید";
                return;
            }
        }

        public void btnExit_Click()
        {
            Application.Exit();
        }



        private static byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");

        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        public static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr = null;                       // Encrypted string to return
            RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            catch (Exception ex)
            {
                string l1 = "کلید مناسب را وارد کنید";
                MessageBox.Show(l1);
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create the streams used for decryption.                
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                string l1 = "کلید مناسب را وارد کنید";
                MessageBox.Show(l1);
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("آرایه بایت شامل فرمت صحیح نمی باشد");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("آرایه بایت به درستی خوانده نشده است");
            }

            return buffer;
        }
    }

    /*struct HuffmanCompressText
    {
        private string compression(String text, Compression compress)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (compress == Compression.Compress)
                {
                    huffman(text);
                    for (int i = 0; i < usedCharCount; i++)
                        codeTable.Items.Add(((TreeNode)map_table[i]).ToolTipText + " >> " + ((TreeNode)map_table[i]).Name);

                    string result = string.Empty;
                    for (int i = 0; i < text.Length; i++)
                        result += search_char(text.Substring(i, 1));
                    return result;
                }
                else
                {
                    string result = string.Empty;
                    for (int i = 0, index = 0, len = 1; i < text.Length; i++)
                        search_binaryText(ref result, text.Substring(index, len), ref index, ref len);

                    return result;
                }
            }
            return null;
        }
    }*/
}
