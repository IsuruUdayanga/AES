using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class AES : Form
    {
        private string FileName { get; set; }
        private byte[] FileData { get; set; }
        private FileInfo FileDetails { get; set; }



        public AES()
        {
            InitializeComponent();
        }



        private void chShowKey_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowKey.Checked)
                txtMasterKey.UseSystemPasswordChar = false;
            else
                txtMasterKey.UseSystemPasswordChar = true;
        }
        private void AES_Load(object sender, EventArgs e)
        {
            cbHashAlgorithm.SelectedIndex = 0;
            FileName = string.Empty;
            FileData = null;
            FileDetails = null;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileSelector.ShowDialog() == DialogResult.OK)
                {
                    if (FileSelector.FileName != string.Empty)
                    {
                        FileName = FileSelector.FileName;
                        txtFileName.Text = FileName;

                        if (File.Exists(FileName))
                        {
                            var fileinfo = new FileInfo(FileName);
                            FileDetails = fileinfo;

                            lblName.Text = $"{fileinfo.Name}";
                            lblExtension.Text = $"{fileinfo.Extension}";
                            lblCreate.Text = $"{fileinfo.CreationTime}";
                            lblLastAccess.Text = $"{fileinfo.LastAccessTime}";
                            lblLastWrite.Text = $"{fileinfo.LastWriteTime}";
                            lblReadOnly.Text = $"{Convert.ToString(fileinfo.IsReadOnly)}";
                            lblSize.Text = $"{fileinfo.Length} Bytes";

                            rbDecrypt.Text = $"Decrypt {fileinfo.Name}";
                            rbEncrypt.Text = $"Encrypt {fileinfo.Name}";

                            FileData = File.ReadAllBytes(FileName);
                            if (FileData.Length > 0)
                            {
                                gbEncryption.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show($"Unable to read the {fileinfo.Name}. File damaged or contains invaild data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        txtFileName.Text = "Not Selected";
                        FileName = string.Empty;

                        lblName.Text = "Not Found";
                        lblExtension.Text = "Not found";
                        lblCreate.Text = "Not found";
                        lblLastAccess.Text = "Not found";
                        lblLastWrite.Text = "Not found";
                        lblReadOnly.Text = "Not found";
                        lblSize.Text = "Not found ";

                        rbDecrypt.Text = $"Decrypt FILE NOT FOUND";
                        rbEncrypt.Text = $"Decrypt FILE NOT FOUND";

                        gbEncryption.Enabled = false;
                    }

                }
                else
                {
                    txtFileName.Text = "Not Selected";
                    FileName = string.Empty;

                    lblName.Text = "Not Found";
                    lblExtension.Text = "Not found";
                    lblCreate.Text = "Not found";
                    lblLastAccess.Text = "Not found";
                    lblLastWrite.Text = "Not found";
                    lblReadOnly.Text = "Not found";
                    lblSize.Text = "Not found ";

                    rbDecrypt.Text = $"Decrypt FILE NOT FOUND";
                    rbEncrypt.Text = $"Decrypt FILE NOT FOUND";

                    gbEncryption.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }
        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecrypt.Checked)
                btnDecrypt.Enabled = true;
            else
                btnDecrypt.Enabled = false;
        }
        private void rbEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEncrypt.Checked)
                btnEncrypt.Enabled = true;
            else
                btnEncrypt.Enabled = false;
        }
        private void txtMasterKey_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMasterKey.Text) && txtMasterKey.Text.Length > 7)
                gbFileSelection.Enabled = true;
            else
                gbFileSelection.Enabled = false;
        }

        #region Encryption

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This process going to completely encrypt your file after that you won't be able to read or open this file. Do not lose your Master Key or forget about Hash algorithm that used. Without the key or hash algorithm you won't be able to decrypt the file. Think twice before encrypting the file. \nClick \"OK\" to continue.\nClick \"Cancel\" to abort.", "WARNING!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    if(!FileDetails.IsReadOnly)
                    {
                        byte[] AES_KEY = null;
                        byte[] AES_IV = null;

                        if (cbHashAlgorithm.SelectedIndex == 0)
                        {
                            AES_KEY = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(txtMasterKey.Text));
                            AES_IV = MD5.Create().ComputeHash(AES_KEY);
                        }

                        if (cbHashAlgorithm.SelectedIndex == 1)
                        {
                            AES_KEY = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(txtMasterKey.Text));
                            AES_IV = MD5.Create().ComputeHash(AES_KEY);
                        }

                        if (cbHashAlgorithm.SelectedIndex == 2)
                        {
                            AES_KEY = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(txtMasterKey.Text));
                            AES_IV = MD5.Create().ComputeHash(AES_KEY);
                        }

                        FileData = File.ReadAllBytes(FileName);

                        using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                        {
                            using (Aes aes = Aes.Create())
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(AES_KEY, AES_IV), CryptoStreamMode.Write))
                                {
                                    using (BinaryWriter encryptWriter = new BinaryWriter(cryptoStream))
                                    {
                                        encryptWriter.Write(FileData);
                                    }
                                }
                            }
                        }

                        MessageBox.Show($"{FileDetails.Name} encrypting completed.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{FileDetails.Name} is read only.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Decryption

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Make sure your file is encrypted using this software because different software uses different encryptions. You might not be able to decrypt the file that is encrypted using another software. Also decrypting files that are not encrypted could lead to file crashes. \nClick \"OK\" to continue.\nClick \"Cancel\" to abort.", "WARNING!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    if (!FileDetails.IsReadOnly)
                    {
                        byte[] AES_KEY = null;
                        byte[] AES_IV = null;

                        if (cbHashAlgorithm.SelectedIndex == 0)
                        {
                            AES_KEY = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(txtMasterKey.Text));
                            AES_IV = MD5.Create().ComputeHash(AES_KEY);
                        }

                        if (cbHashAlgorithm.SelectedIndex == 1)
                        {
                            AES_KEY = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(txtMasterKey.Text));
                            AES_IV = MD5.Create().ComputeHash(AES_KEY);
                        }

                        if (cbHashAlgorithm.SelectedIndex == 2)
                        {
                            AES_KEY = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(txtMasterKey.Text));
                            AES_IV = MD5.Create().ComputeHash(AES_KEY);
                        }

                        FileData = File.ReadAllBytes(FileName);

                        using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                        {
                            using (Aes aes = Aes.Create())
                            {
                                using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(AES_KEY, AES_IV), CryptoStreamMode.Write))
                                {
                                    using (BinaryWriter decryptReader = new BinaryWriter(cryptoStream))
                                    {
                                        decryptReader.Write(FileData);
                                    }
                                }
                            }
                        }

                        MessageBox.Show($"{FileDetails.Name} decrypting completed.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{FileDetails.Name} is read only.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMasterKey.ResetText();
            cbHashAlgorithm.SelectedIndex = 0;
            txtFileName.Text = "Not Selected";

            rbEncrypt.Checked = rbDecrypt.Checked = false;

            txtFileName.Text = "Not Selected";
            FileName = string.Empty;
            FileData = null;
            FileDetails = null;

            lblName.Text = "Not Found";
            lblExtension.Text = "Not found";
            lblCreate.Text = "Not found";
            lblLastAccess.Text = "Not found";
            lblLastWrite.Text = "Not found";
            lblReadOnly.Text = "Not found";
            lblSize.Text = "Not found ";

            rbDecrypt.Text = $"Decrypt FILE NOT FOUND";
            rbEncrypt.Text = $"Decrypt FILE NOT FOUND";

            gbFileSelection.Enabled = false;
            gbEncryption.Enabled = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/IsuruUdayanga");
        }
    }
}
