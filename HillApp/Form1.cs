using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Collections;

namespace HillApp
{
    public partial class Form1 : Form
    {
        /*Dictionary là một kiểu dữ liệu key - value*/
        private static Dictionary<string, string> dic1;//mã hóa
        private static Dictionary<string, string> dic2;//giải mã
        


        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void check()
        {
            if (nmc.Text.Any(ch => "áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ".Contains(ch)))
            {
                MessageBox.Show("Chuỗi không được chứa ký tự tiếng Việt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rc1.Clear();
                return;
            }
        }
        //Hàm Init() giúp thiết lập cấu trúc dữ liệu cần thiết để thực hiện mã hóa và giải mã
        public static void Init()
        {
            dic1 = new Dictionary<string, string>();
            dic2 = new Dictionary<string, string>();
            // chứa các kí tự bạn muốn giải mã
            string[] str = new string[]{
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
                "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-",
                "_", "+", "=", "|", "\\", "\"", "\n", "\t", "{", "[", "]", "}", ":", ";", "'", "<", ",", ".", ">", "?", "/",
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            };

            for (int i = 0; i < str.Length; i++)
            {
                dic1[str[i]] = i.ToString(); //điền vào dic1 ánh xạ từng kí tự == i dưới dạng chuỗi
            }
            // đảo ngược ánh xạ sau khi dic1 được tạo xong
            foreach (var entry in dic1)
            {
                dic2[entry.Value] = entry.Key;
            }
        }
        //kiểm tra input có hợp lệ không 
        private bool IsValidInput(string input)
        {
            string[] validCharacters = new string[]{
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
        "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
        "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-",
        "_", "+", "=", "|", "\\", "\"", "\n", "\t", "{", "[", "]", "}", ":", ";", "'", "<", ",", ".", ">", "?", "/",
        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
    };

            foreach (char c in input)
            {
                if (!validCharacters.Contains(c.ToString()))
                {
                    return false; //không hợp lệ
                }
            }

            return true; // hợp lệ đầu vào 
        }
        //biến đổi text thành array
        public static string[] TextToArr(string text)
        {
            text = text.Trim();
            char[] arr = text.ToCharArray();
            string[] arr1 = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i].ToString();
            }
            return arr1;
        }
        // hàm mã hóa
        public static string Encrypto(string strIn, int[][] K, RichTextBox rtbDes)
        {
            rtbDes.AppendText("\nBắt đầu mã hóa với chuỗi: " + strIn + Environment.NewLine);
            string[] lines = strIn.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            List<string> encryptedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] arrP = TextToArr(line);
                List<int[]> dicP = new List<int[]>();
                int[] arrLP = new int[K.Length];
                int validCount = 0;

                for (int i = 0; i < arrP.Length; i++)
                {
                    rtbDes.AppendText($"Ký tự {arrP[i]} chuyển thành {dic1[arrP[i]]}" + Environment.NewLine);
                    arrLP[validCount] = int.Parse(dic1[arrP[i]]);
                    validCount++;

                    if (validCount == K.Length)
                    {
                        dicP.Add((int[])arrLP.Clone());

                        arrLP = new int[K.Length];
                        validCount = 0;
                    }
                }

                // Pad with 'a' if necessary
                if (validCount > 0)
                {
                    while (validCount < K.Length)
                    {
                        arrLP[validCount] = int.Parse(dic1["a"]);
                        validCount++;
                    }
                    dicP.Add(arrLP);
                }

                List<int[]> dicC = new List<int[]>();
                foreach (int[] item in dicP)
                {
                    int[] result = MyMatrix.Multiply(K, item);
                    dicC.Add(result);
                    rtbDes.AppendText("Mã hóa một khối: " + string.Join(", ", result) + Environment.NewLine);
                }

                string encryptedLine = "";
                foreach (int[] item in dicC)
                {
                    foreach (int value in item)
                    {
                        encryptedLine += dic2[value.ToString()];
                        rtbDes.AppendText($"Ký tự {value} mã hóa thành {dic2[value.ToString()]}" + Environment.NewLine);
                    }
                }
                encryptedLines.Add(encryptedLine);
            }

            string strOut = string.Join(Environment.NewLine, encryptedLines);
            rtbDes.AppendText("Chuỗi sau khi mã hóa: " + strOut + Environment.NewLine);
            return strOut;
        }
        // giải mã
        public static string Decrypto(string strIn, int[][] IK, RichTextBox rtbDes)
        {
            rtbDes.AppendText("\nBắt đầu giải mã với chuỗi: " + strIn + Environment.NewLine);
            string[] lines = strIn.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            List<string> decryptedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] arrP = TextToArr(line);
                List<int[]> dicP = new List<int[]>();
                int[] arrLP = new int[IK.Length];
                int validCount = 0;

                for (int i = 0; i < arrP.Length; i++)
                {
                    string value = dic1[arrP[i]];
                    if (value == null)
                    {
                        rtbDes.AppendText("Invalid character: " + arrP[i] + Environment.NewLine);
                        return null;
                    }
                    arrLP[validCount] = int.Parse(value);
                    validCount++;
                    rtbDes.AppendText($"Ký tự {arrP[i]} giải mã thành {value}" + Environment.NewLine);

                    if (validCount == IK.Length)
                    {
                        dicP.Add((int[])arrLP.Clone());
                        arrLP = new int[IK.Length];
                        validCount = 0;
                    }
                }

                if (validCount > 0)
                {
                    dicP.Add(arrLP);
                }

                string decryptedLine = "";
                foreach (int[] item in dicP)
                {
                    int[] decryptedBlock = MyMatrix.Multiply(IK, item);
                    foreach (int value in decryptedBlock)
                    {
                        decryptedLine += dic2[value.ToString()];
                        rtbDes.AppendText($"Ký tự {value} giải mã thành {dic2[value.ToString()]}" + Environment.NewLine);
                    }
                }
                // Remove padding 'a' characters
                decryptedLine = decryptedLine.TrimEnd('a');
                decryptedLines.Add(decryptedLine);
            }

            string strOut = string.Join(Environment.NewLine, decryptedLines);
            rtbDes.AppendText("Chuỗi sau khi giải mã và loại bỏ padding: " + strOut + Environment.NewLine);
            return strOut;
        }
        private static int Mod(int a, int m)
        {
            int result = a % m;
            return result < 0 ? result + m : result;
        }
        //Tìm nghịch đảo modulo của một số a trong một modulo cho trước mod
        //nó đảm bảo rằng có thể tính được ma trận nghịch đảo modulo để khôi phục bản rõ.
        public static int ModInverse(int a, int mod)
        {
            for (int i = 1; i < mod; i++)
            {
                if ((a * i) % mod == 1)
                {
                    return i; //trả về i là nghịch đảo modulo của a
                }
            }
            throw new ArgumentException("No modular inverse found.");
        }
        private static void PrintMatrix(int[][] matrix, RichTextBox rtbDesc)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                rtbDesc.AppendText(string.Join("\t", matrix[i]) + "\n");
            }
        }
        public static int[][] InvertMatrix(int[][] matrix, RichTextBox rtbDesc)
        {
            int n = matrix.Length;
            rtbDesc.AppendText("\nBắt đầu tìm ma trận nghịch đảo.\n");
            int[][] augmentedMatrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                augmentedMatrix[i] = new int[2 * n];
            }

            int mod = 97;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i][j] = Mod(matrix[i][j], mod);
                }
                augmentedMatrix[i][i + n] = 1;
            }
            rtbDesc.AppendText("Ma trận mở rộng (augmented matrix) sau khi khởi tạo:\n");
            PrintMatrix(augmentedMatrix, rtbDesc);

            for (int i = 0; i < n; i++)
            {
                if (augmentedMatrix[i][i] == 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (augmentedMatrix[j][i] != 0)
                        {
                            int[] temp = augmentedMatrix[i];
                            augmentedMatrix[i] = augmentedMatrix[j];
                            augmentedMatrix[j] = temp;
                            rtbDesc.AppendText($"Hoán đổi dòng {i} và dòng {j}.\n");
                            break;
                        }
                    }
                }

                if (augmentedMatrix[i][i] == 0)
                {
                    throw new ArgumentException("Matrix has no inverse.");
                }
                int pivotInverse = ModInverse(augmentedMatrix[i][i], mod);
                rtbDesc.AppendText($"Phần tử chéo (pivot) tại vị trí ({i}, {i}) có giá trị {augmentedMatrix[i][i]}. Tính nghịch đảo: {pivotInverse}.\n");

                for (int j = 0; j < 2 * n; j++)
                {
                    augmentedMatrix[i][j] = Mod(augmentedMatrix[i][j] * pivotInverse, mod);
                }
                rtbDesc.AppendText($"Chia dòng {i} cho {augmentedMatrix[i][i]} để chuẩn hóa.\n");
                PrintMatrix(augmentedMatrix, rtbDesc);

                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        int factor = augmentedMatrix[j][i];
                        for (int k = 0; k < 2 * n; k++)
                        {
                            augmentedMatrix[j][k] = Mod(augmentedMatrix[j][k] - factor * augmentedMatrix[i][k], mod);
                        }
                        rtbDesc.AppendText($"Trừ {factor} lần dòng {i} từ dòng {j}.\n");
                    }
                }
            }

            int[][] inverseMatrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                inverseMatrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    inverseMatrix[i][j] = augmentedMatrix[i][j + n];
                }
            }
            rtbDesc.AppendText("Ma trận nghịch đảo đã tìm được:\n");
            PrintMatrix(inverseMatrix, rtbDesc);

            return inverseMatrix;
        }
        //tính định thức
        public static int Determinant(int[][] matrix)
        {
            int n = matrix.Length;
            int mod = 97;
            int det = 0;

            if (n == 2)
            {
                return Mod(matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0], mod);
            }

            for (int i = 0; i < n; i++)
            {
                int[][] subMatrix = new int[n - 1][];
                for (int j = 0; j < n - 1; j++)
                {
                    subMatrix[j] = new int[n - 1];
                }

                for (int j = 1; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (k < i)
                        {
                            subMatrix[j - 1][k] = matrix[j][k];
                        }
                        else if (k > i)
                        {
                            subMatrix[j - 1][k - 1] = matrix[j][k];
                        }
                    }
                }
                det = Mod(det + matrix[0][i] * Determinant(subMatrix) * (i % 2 == 0 ? 1 : -1), mod);
            }

            return det;
        }
        static class MyMatrix
        {
            public static int[] Multiply(int[][] matrix, int[] vector)
            {
                int n = matrix.Length;
                int mod = 97;
                int[] result = new int[n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i] = Mod(result[i] + matrix[i][j] * vector[j], mod);
                    }
                }
                return result;
            }

        }



        private void btnsinhK_Click(object sender, EventArgs e)
        {
            int n;

            try
            {
                n = Convert.ToInt32(nmc.Text);

                if (n >= 2)
                {
                    int[][] keyMatrix = new int[n][];
                    Random rand = new Random();
                    rtbDes.AppendText("\nBắt đầu sinh khóa ma trận" + Environment.NewLine);

                    while (true)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            keyMatrix[i] = new int[n];
                            for (int j = 0; j < n; j++)
                            {
                                keyMatrix[i][j] = rand.Next(-96, 97); // Allow negative numbers
                                rtbDes.AppendText($"[{i}, {j}] = {keyMatrix[i][j]}" + Environment.NewLine);
                            }
                        }

                        int det = Determinant(keyMatrix);
                        rtbDes.AppendText("Định thức của ma trận: " + det + Environment.NewLine);
                        det = Mod(det, 97);
                        if (det != 0)
                        {
                            break;
                        }
                    }
                    rtbDes.AppendText("Ma trận khóa đã được tạo thành công:" + Environment.NewLine);
                    StringBuilder matrixText = new StringBuilder();
                    for (int i = 0; i < n; i++)
                    {
                        rtbDes.AppendText(string.Join(" ", keyMatrix[i]) + Environment.NewLine);
                        matrixText.AppendLine(string.Join(" ", keyMatrix[i]));
                    }

                    rcMt.Text = matrixText.ToString();
                }
                else
                {
                    MessageBox.Show("Cấp ma trận phải lớn hơn hoặc bằng 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập ma trận hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnsinhIk_Click(object sender, EventArgs e)
        {
            try
            {
                String rc1 = rcMt.Text.ToString();
                if (!string.IsNullOrEmpty(rc1))
                {
                    rtbDes.AppendText("\nBắt đầu sinh ma trận nghịch đảo từ ma trận khóa K:\n");
                    rtbDes.AppendText(rc1 + Environment.NewLine);

                    string[] matrixLines = rcMt.Text.Trim().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    int n = matrixLines.Length;
                    int[][] keyMatrix = new int[n][];
                    for (int i = 0; i < n; i++)
                    {
                        keyMatrix[i] = matrixLines[i].Split(' ').Select(int.Parse).ToArray();
                        for (int j = 0; j < n; j++)
                        {
                            rtbDes.AppendText($"[{i}, {j}] = {keyMatrix[i][j]}\n");
                        }
                    }
                    rtbDes.AppendText("Tính toán ma trận nghịch đảo...\n");
                    int[][] inverseMatrix = InvertMatrix(keyMatrix,rtbDes);

                    StringBuilder inverseMatrixText = new StringBuilder();
                    for (int i = 0; i < n; i++)
                    {
                        string line = string.Join(" ", inverseMatrix[i]);
                        rtbDes.AppendText(line + Environment.NewLine);
                        inverseMatrixText.AppendLine(line);
                    }
                    rtKn.Text = inverseMatrixText.ToString();
                }
                else
                {
                    MessageBox.Show(" Ma trận khóa K không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tính ma trận nghịch đảo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rc1.Clear();
            rc2.Clear();
            nmc.Clear();
            rcMt.Clear();
            rtKn.Clear();
            rtbDes.Clear();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        //mã hóa
        private void button7_Click(object sender, EventArgs e)
        {
            check();

            if (!string.IsNullOrEmpty(rc1.Text) && !string.IsNullOrEmpty(rcMt.Text))
            {
                if (IsValidInput(rc1.Text))
                {
                    string plainText = rc1.Text;
                    string[] matrixLines = rcMt.Text.Trim().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                    int n = matrixLines.Length;
                    // Kiểm tra xem ma trận có phải là n x n không
                    if (matrixLines.Any(line => line.Split(' ').Length != n))
                    {
                        MessageBox.Show("Ma trận khóa không hợp lệ. Mỗi hàng của ma trận phải có " + n + " phần tử. Hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int[][] keyMatrix = new int[n][];
                    for (int i = 0; i < n; i++)
                    {
                        keyMatrix[i] = matrixLines[i].Split(' ').Select(int.Parse).ToArray();
                    }

                    string cipherText = Encrypto(plainText, keyMatrix, rtbDes);

                    rc2.Text = cipherText;
                }
                else
                {
                    MessageBox.Show("Kí tự nhập bản rõ P không hợp lệ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống bản rõ P và ma trận khóa K ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // giai ma
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(rc2.Text) && !string.IsNullOrEmpty(rtKn.Text))
                {
                    if (IsValidInput(rc2.Text))
                    {
                        string cipherText = rc2.Text;

                        string[] matrixLines = rtKn.Text.Trim().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                        int n = matrixLines.Length;
                        int[][] inverseKeyMatrix = new int[n][];
                        for (int i = 0; i < n; i++)
                        {
                            inverseKeyMatrix[i] = matrixLines[i].Split(' ').Select(int.Parse).ToArray();
                        }

                        string plainText = Decrypto(cipherText, inverseKeyMatrix, rtbDes);

                        rc1.Text = plainText;
                    }
                    else
                    {
                        MessageBox.Show("Kí tự nhập không hợp lệ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống bản mã C và ma trận khóa Khả nghịch K ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi giải mã: " + ex.Message);
            }
        }

        private void btnSaveK_Click(object sender, EventArgs e)
        {

        }

        
        

    }
}

