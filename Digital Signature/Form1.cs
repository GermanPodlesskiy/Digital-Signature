using System;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Security.Cryptography;


namespace DigitalSignature
{
    
    public partial class Main : Form
    {
        byte[] currentFile;
        BigInteger plainSignature, cipherSignature;
        private string errorSelectedFile = "Open file.", errorCaption = "Error!",
            invalidData = "Check the entered data.", selectAction = "Select an action.",
            signatureTrue = "Signature is authentic.", signatureFalse = "Signature isn't authentic.",
            fileNoSignature = "File isn't a signature.", sucsess = "Sucsess";   

        private string fileFitler = "*.txt|*.txt";

        public Main()
        {
            InitializeComponent();
        }

        string ToHexString(uint[] arr)
        {
            return arr[0].ToString("X")+arr[1].ToString("X")+arr[2].ToString("X")+arr[3].ToString("X")+arr[4].ToString("X");
        }

        private bool SimpleNumber(BigInteger n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n < 2 || n % 2 == 0)
                return false;

            BigInteger t = n - 1;
            int s = 0;
            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }
            for (int i = 0; i < 100; i++)
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                byte[] _a = new byte[n.ToByteArray().LongLength];

                BigInteger a;

                do
                {
                    rng.GetBytes(_a);
                    a = new BigInteger(_a);
                }
                while (a < 2 || a >= n - 2);

                BigInteger x = FastExp(a, t, n);

                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = FastExp(x, 2, n);

                    if (x == 1)
                        return false;

                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        private void TextBoxP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (!(symbol >= '0' && symbol <= '9' || Convert.ToInt32(symbol) == Convert.ToInt32(Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private BigInteger FindFuncEl(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        bool CheckData()
        {
            if (textBoxP.Text == "" || textBoxQ.Text == "" || textBoxD.Text == "")
                return false;
            if (!SimpleNumber(BigInteger.Parse(textBoxP.Text)) || !SimpleNumber(BigInteger.Parse(textBoxQ.Text)) ||(BigInteger.Parse(textBoxP.Text) * BigInteger.Parse(textBoxQ.Text) <= byte.MaxValue))
                return false;
            if ((BigInteger.Parse(textBoxP.Text) * BigInteger.Parse(textBoxQ.Text)).ToByteArray().Length < 16)
                return false;
            BigInteger d = BigInteger.Parse(textBoxD.Text);
            BigInteger fi = FindFuncEl(BigInteger.Parse(textBoxP.Text), BigInteger.Parse(textBoxQ.Text));

            if ((Gcd(d, fi) != 1) || (d >= fi) || (d <= 1 ))
                return false;

            return true;
        }

        private BigInteger Gcd(BigInteger a, BigInteger b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

        void EuclideanAlgorithm(BigInteger p, BigInteger q, out BigInteger indexP, out BigInteger indexQ)
        {
            BigInteger d0 = p;
            BigInteger d1 = q;
            BigInteger d2, x2, y2;
            BigInteger x0 = new BigInteger(1), x1 = new BigInteger(0), y0 = new BigInteger(0);
            indexP = new BigInteger(1);

            while (d1 > 1)
            {
                q = d0 / d1;
                d2 = d0 % d1;
                x2 = x0 - q * x1;
                y2 = y0 - q * indexP;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = indexP;
                indexP = y2;
            }
            indexQ = x1;
        }

        private BigInteger FastExp(BigInteger a, BigInteger b, BigInteger n)
        {
            BigInteger aTemp = a, bTemp = b, x = 1;
            while (bTemp != 0)
            {
                while ((bTemp % 2) == 0)
                {
                    bTemp = bTemp / 2;
                    aTemp = (aTemp * aTemp) % n;
                }

                bTemp--;
                x = (x * aTemp) % n;
            }

            return x;
        }

        private void ButtonOpenF_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (comboBox1.SelectedIndex != -1)
                    if (comboBox1.SelectedIndex == 0)
                    {
                        label7.Text = openFileDialog1.FileName;
                        BinaryReader binReader = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open));
                        currentFile = new byte[0];
                        Array.Resize(ref currentFile, (int)binReader.BaseStream.Length);
                        currentFile = binReader.ReadBytes((int)binReader.BaseStream.Length);
                        binReader.Close();
                    }
                    else
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            string text = "";
                            int count = File.ReadAllLines(openFileDialog1.FileName).Length - 1;
                            while (count != 0)
                            {
                                text += sr.ReadLine();
                                count--;
                                text += count == 0 ? "" : "\r\n";
                            }

                            currentFile = Encoding.Default.GetBytes(text);
                        }
                    }
            }
        }

        private uint s;
        private void Button1_Click(object sender, EventArgs Obj)
        {
            if (comboBox1.SelectedIndex != -1)
                if (CheckData())
                    if (comboBox1.SelectedIndex == 0)
                    {
                        BigInteger fi = FindFuncEl(BigInteger.Parse(textBoxP.Text), BigInteger.Parse(textBoxQ.Text));
                        BigInteger d = BigInteger.Parse(textBoxD.Text);
                        BigInteger n = BigInteger.Parse(textBoxP.Text) * BigInteger.Parse(textBoxQ.Text);
                        textBoxR.Text = n.ToString();

                        BigInteger e, temp;
                        EuclideanAlgorithm(fi, d, out e, out temp);
                        if (e.Sign < 0)
                            e += fi;
                        textBoxE.Text = e.ToString();

                        SHA1.SHA1 sha1 = new SHA1.SHA1();
                        byte[] hash = sha1.ComputeHash(currentFile);
                        uint[] decHash = ArrBytesToArrUint(hash);
                        textBoxFH.Text = ToHexString(decHash);
                        plainSignature = BigInteger.Parse("0"+ToHexString(decHash), NumberStyles.HexNumber);
                        textBoxFD.Text = plainSignature.ToString();
                        plainSignature = FastExp(plainSignature, d, n);
                    }
                    else
                    {
                        SHA1.SHA1 sha1 = new SHA1.SHA1();
                        byte[] hash = sha1.ComputeHash(currentFile);
                        uint[] decHash = ArrBytesToArrUint(hash);
                        textBoxFH.Text = ToHexString(decHash);
                        plainSignature = BigInteger.Parse("0" + ToHexString(decHash), NumberStyles.HexNumber);
                        textBoxFD.Text = plainSignature.ToString();
                        
                        if (cipherSignature == plainSignature)
                        {
                            MessageBox.Show(signatureTrue, sucsess, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            Error(signatureFalse); ;
                        }

                    }
                else if (currentFile == null)
                {
                    Error(errorSelectedFile);
                }
                else
                    Error(invalidData);
            else
                Error(selectAction);
        }
        
        private uint[] ArrBytesToArrUint(byte[] arr)
        {
            uint[] res = new uint[5];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = BytesToUint(new byte[] {
                    arr[i*4], arr[i*4 + 1], arr[i*4 + 2], arr[i*4 + 3]
                });
            }

            return res;
        }

        
        private uint BytesToUint(byte[] masBytes)
        {
            uint res = 0;
            for (int i = 0; i < 4; i++)
            {
                res <<= 8;
                res += masBytes[i];
            }
            return res;
        }

        private void ButtonSaveK_Click(object sender, EventArgs e)
        {
            if (plainSignature != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog1.Filter = fileFitler;

                    File.WriteAllBytes(saveFileDialog1.FileName, currentFile);
                    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, true);
                    writer.WriteLine();
                    writer.Write(plainSignature.ToString());
                    writer.Close();
                }
            }
        }

        private void buttonOpenK_Click(object sender, EventArgs args)
        {
            if (textBoxE.Text != "" && textBoxR.Text != "" && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BigInteger fileHash = BigInteger.Parse(File.ReadLines(openFileDialog1.FileName).Last());

                    BigInteger e = BigInteger.Parse(textBoxE.Text);
                    BigInteger r = BigInteger.Parse(textBoxR.Text);

                    cipherSignature = FastExp(fileHash, e, r);

                    string str = cipherSignature.ToString("X");
                    if (str[0] == '0')
                        str = str.Remove(0, 1);
                    textBoxSH.Text = str;
                    textBoxSD.Text = cipherSignature.ToString();
                }
                catch (Exception)
                {
                    Error(fileNoSignature);
                }
            }
            else
            {
                Error(invalidData);
            }
        }

        private void Error(string error)
        {
            MessageBox.Show(error, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
