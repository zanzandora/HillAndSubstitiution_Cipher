using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;



namespace SubstitiutionApp
{
    public partial class Form1 : Form
    {
        public Random random;
        private string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?";
        private string substitutionKey;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            
        }

        private void GenerateSubstitutionKey()
        {
            char[] shuffled = validChars.ToCharArray();
            for (int i = 0; i < shuffled.Length; i++)
            {
                int j = random.Next(i, shuffled.Length);
                
                char temp = shuffled[i];
                shuffled[i] = shuffled[j];
                shuffled[j] = temp;
            }
            
            substitutionKey = new string(shuffled);
            nmc.Text = substitutionKey.ToString();
        }

        private void encrypt(string input)
        {
            rtbDesc.Clear(); // Xóa nội dung trước đó
            rtbDesc.AppendText("Bắt đầu mã hóa:\n"); 
            if (string.IsNullOrEmpty(substitutionKey))
            {
                MessageBox.Show("Khóa không hợp lệ, vui lòng tạo lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (input.Any(ch => "áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ".Contains(ch)))
            {
                MessageBox.Show("Chuỗi không được chứa ký tự tiếng Việt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rc1.Clear();
                return;
            }

            

            // Chuyển input thành mảng ký tự
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                int index = validChars.IndexOf(letter);
                if (index >= 0)
                {
                    // Thay thế ký tự bằng ký tự trong bảng thay thế
                    buffer[i] = substitutionKey[index];
                    rtbDesc.AppendText($"'{letter}' -> '{substitutionKey[index]}'\n");
                }
            }
            rc2.Text = new string(buffer);
            rtbDesc.AppendText("Kết thúc mã hóa.\n");
        }

        private void decrypt(string input)
        {
            rtbDesc.AppendText("Bắt đầu giải mã:\n");
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                int index = substitutionKey.IndexOf(letter);
                if (index >= 0)
                {
                    // Thay thế ký tự bằng ký tự trong bảng gốc
                    buffer[i] = validChars[index];
                    rtbDesc.AppendText($"'{letter}' -> '{validChars[index]}'\n");
                }
            }
            rc1.Text = new string(buffer);
            rtbDesc.AppendText("Kết thúc giải mã.\n");
        }

        private void btnsinhK_Click(object sender, EventArgs e)
        {
            GenerateSubstitutionKey(); 
            MessageBox.Show("Khóa thay thế đã được tạo mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnEncypt_Click(object sender, EventArgs e)
        {
            substitutionKey = nmc.Text;
            
            /*if (substitutionKey.Length != validChars.Length)
            {
                MessageBox.Show($"Độ dài của khóa không hợp lệ. Khóa phải có đúng {validChars.Length} ký tự.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            // Kiểm tra xem khóa có ký tự bị thừa hoặc thiếu không
            var missingChars = validChars.Except(substitutionKey).ToList();
            var extraChars = substitutionKey.Where(c => !validChars.Contains(c)).ToList();

            if (missingChars.Any() || extraChars.Any())
            {
                StringBuilder message = new StringBuilder();
                if (missingChars.Any())
                {
                    message.AppendLine($"Các ký tự bị thiếu: {string.Join(", ", missingChars)}");
                }
                if (extraChars.Any())
                {
                    message.AppendLine($"Các ký tự thừa: {string.Join(", ", extraChars)}");
                }
                MessageBox.Show(message.ToString(), "Lỗi khóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem có ký tự nào bị lặp lại trong khóa không
            var duplicateChars = substitutionKey.GroupBy(c => c)
                                                .Where(g => g.Count() > 1)
                                                .Select(g => g.Key)
                                                .ToList();
            if (duplicateChars.Any())
            {
                MessageBox.Show($"Khóa có ký tự bị lặp lại: {string.Join(", ", duplicateChars)}", "Lỗi khóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Nếu khóa hợp lệ, tiếp tục mã hóa
            string input = rc1.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập chuỗi cần mã hóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            encrypt(input); // Gọi hàm mã hóa
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (substitutionKey.Length != validChars.Length)
            {
                MessageBox.Show("Độ dài của khóa không hợp lệ. Khóa phải có đúng " + validChars.Length + " ký tự.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = rc2.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập chuỗi mã hóa trước khi cần giải hóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decrypt(input); // Gọi hàm giải mã
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rc1.Clear();
            rc2.Clear();
            nmc.Clear();
            rtbDesc.Clear();
        }

        private void nmc_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
