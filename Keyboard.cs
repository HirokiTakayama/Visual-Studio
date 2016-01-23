# Form.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_del_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button_del1_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Text = textBox1.Text.Remove(
                textBox1.SelectionStart, textBox1.SelectionLength);
                return;
            }
            if (textBox1.SelectionStart > 0)
            {
                textBox1.SelectionStart--;
                int index = textBox1.SelectionStart;
                textBox1.Text = textBox1.Text.Remove(index, 1);
                textBox1.SelectionStart = index;
                return;
            }
        }

        private void button_021_Click(object sender, EventArgs e)
        {
            textBox1.Text += '!';
        }

        private void button_022_Click(object sender, EventArgs e)
        {
            textBox1.Text += '"';
        }

        private void button_023_Click(object sender, EventArgs e)
        {
            textBox1.Text += '#';
        }

        private void button_024_Click(object sender, EventArgs e)
        {
            textBox1.Text += '$';
        }

        private void button_025_Click(object sender, EventArgs e)
        {
            textBox1.Text += '%';
        }

        private void button_026_Click(object sender, EventArgs e)
        {
            textBox1.Text += '&';
        }

        private void button_027_Click(object sender, EventArgs e)
        {
            textBox1.Text += '\'';
        }

        private void button_028_Click(object sender, EventArgs e)
        {
            textBox1.Text += '(';
        }

        private void button_029_Click(object sender, EventArgs e)
        {
            textBox1.Text += ')';
        }

        private void button_02A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '*';
        }

        private void button_02B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '+';
        }

        private void button_02C_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }

        private void button_02D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '-';
        }

        private void button_02E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }

        private void button_02F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '/';
        }

        private void button_030_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button_031_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button_032_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button_033_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button_034_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button_035_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button_036_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button_037_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button_038_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button_039_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button_03A_Click(object sender, EventArgs e)
        {
            textBox1.Text += ':';
        }

        private void button_03B_Click(object sender, EventArgs e)
        {
            textBox1.Text += ';';
        }

        private void button_03C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '<';
        }

        private void button_03D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '=';
        }

        private void button_03E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '>';
        }

        private void button_03F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '?';
        }

        private void button_040_Click(object sender, EventArgs e)
        {
            textBox1.Text += '@';
        }

        private void button_041_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'A';
        }

        private void button_042_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'B';
        }

        private void button_043_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'C';
        }

        private void button_044_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'D';
        }

        private void button_045_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'E';
        }

        private void button_046_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'F';
        }

        private void button_047_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'G';
        }

        private void button_048_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'H';
        }

        private void button_049_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'I';
        }

        private void button_04A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'J';
        }

        private void button_04B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'K';
        }

        private void button_04C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'L';
        }

        private void button_04D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'M';
        }

        private void button_04E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'N';
        }

        private void button_04F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'O';
        }

        private void button_050_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'P';
        }

        private void button_051_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Q';
        }

        private void button_052_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'R';
        }

        private void button_053_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'S';
        }

        private void button_054_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'T';
        }

        private void button_055_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'U';
        }

        private void button_056_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'V';
        }

        private void button_057_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'W';
        }

        private void button_058_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'X';
        }

        private void button_059_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Y';
        }

        private void button_05A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Z';
        }

        private void button_05B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '[';
        }

        private void button_05C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '\\';
        }

        private void button_05D_Click(object sender, EventArgs e)
        {
            textBox1.Text += ']';
        }

        private void button_05E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '^';
        }

        private void button_05F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '_';
        }

        private void button_060_Click(object sender, EventArgs e)
        {
            textBox1.Text += '`';
        }

        private void button_061_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'a';
        }

        private void button_062_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'b';
        }

        private void button_063_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'c';
        }

        private void button_064_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'd';
        }

        private void button_065_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'e';
        }

        private void button_066_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'f';
        }

        private void button_067_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'g';
        }

        private void button_068_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'h';
        }

        private void button_069_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'i';
        }

        private void button_06A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'j';
        }

        private void button_06B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'k';
        }

        private void button_06C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'l';
        }

        private void button_06D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'm';
        }

        private void button_06E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'n';
        }

        private void button_06F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'o';
        }

        private void button_070_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'p';
        }

        private void button_071_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'q';
        }

        private void button_072_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'r';
        }

        private void button_073_Click(object sender, EventArgs e)
        {
            textBox1.Text += 's';
        }

        private void button_074_Click(object sender, EventArgs e)
        {
            textBox1.Text += 't';
        }

        private void button_075_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'u';
        }

        private void button_076_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'v';
        }

        private void button_077_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'w';
        }

        private void button_078_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'x';
        }

        private void button_079_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'y';
        }

        private void button_07A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'z';
        }

        private void button_07B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '{';
        }

        private void button_07C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '|';
        }

        private void button_07D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '}';
        }

        private void button_07E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '~';
        }

        private void button_0A1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '｡';
        }

        private void button_0A2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '｢';
        }

        private void button_0A3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '｣';
        }

        private void button_0A4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '､';
        }

        private void button_0A5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '･';
        }

        private void button_0A7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｧ';
        }

        private void button_0A8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｨ';
        }

        private void button_0A9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｩ';
        }

        private void button_0AA_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｪ';
        }

        private void button_0AB_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｫ';
        }

        private void button_0AC_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｬ';
        }

        private void button_0AD_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｭ';
        }

        private void button_0AE_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｮ';
        }

        private void button_0AF_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｯ';
        }

        private void button_0B0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｰ';
        }

        private void button_0B1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｱ';
        }

        private void button_0B2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｲ';
        }

        private void button_0B3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｳ';
        }

        private void button_0B4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｴ';
        }

        private void button_0B5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｵ';
        }

        private void button_0B6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｶ';
        }

        private void button_0B7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｷ';
        }

        private void button_0B8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｸ';
        }

        private void button_0B9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｹ';
        }

        private void button_0BA_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｺ';
        }

        private void button_0BB_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｻ';
        }

        private void button_0BC_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｼ';
        }

        private void button_0BD_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｽ';
        }

        private void button_0BE_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｾ';
        }

        private void button_0BF_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｿ';
        }

        private void button_0C0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾀ';
        }

        private void button_0C1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾁ';
        }

        private void button_0C2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾂ';
        }

        private void button_0C3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾃ';
        }

        private void button_0C4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾄ';
        }

        private void button_0C5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾅ';
        }

        private void button_0C6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾆ';
        }

        private void button_0C7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾇ';
        }

        private void button_0C8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾈ';
        }

        private void button_0C9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾉ';
        }

        private void button_0CA_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾊ';
        }

        private void button_0CB_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾋ';
        }

        private void button_0CC_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾌ';
        }

        private void button_0CD_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾍ';
        }

        private void button_0CE_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾎ';
        }

        private void button_0CF_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾏ';
        }

        private void button_0D0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾐ';
        }

        private void button_0D1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾑ';
        }

        private void button_0D2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾒ';
        }

        private void button_0D3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾓ';
        }

        private void button_0D4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾔ';
        }

        private void button_0D5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾕ';
        }

        private void button_0D6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾖ';
        }

        private void button_0D7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾗ';
        }

        private void button_0D8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾘ';
        }

        private void button_0D9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾙ';
        }

        private void button_0DA_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾚ';
        }

        private void button_0DB_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾛ';
        }

        private void button_0DC_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾜ';
        }

        private void button_0DD_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾝ';
        }

        private void button_0DE_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾞ';
        }

        private void button_0DF_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ﾟ';
        }

        private void button_101_Click(object sender, EventArgs e)
        {
            textBox1.Text += '、';
        }

        private void button_102_Click(object sender, EventArgs e)
        {
            textBox1.Text += '。';
        }

        private void button_103_Click(object sender, EventArgs e)
        {
            textBox1.Text += '，';
        }

        private void button_104_Click(object sender, EventArgs e)
        {
            textBox1.Text += '．';
        }

        private void button_105_Click(object sender, EventArgs e)
        {
            textBox1.Text += '・';
        }

        private void button_106_Click(object sender, EventArgs e)
        {
            textBox1.Text += '：';
        }

        private void button_107_Click(object sender, EventArgs e)
        {
            textBox1.Text += '；';
        }

        private void button_108_Click(object sender, EventArgs e)
        {
            textBox1.Text += '？';
        }

        private void button_109_Click(object sender, EventArgs e)
        {
            textBox1.Text += '！';
        }

        private void button_10A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '゛';
        }

        private void button_10B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '゜';
        }

        private void button_10C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '´';
        }

        private void button_10D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '｀';
        }

        private void button_10E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '¨';
        }

        private void button_10F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＾';
        }

        private void button_10G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '￣';
        }

        private void button_10H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＿';
        }

        private void button_10I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヽ';
        }

        private void button_110_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヾ';
        }

        private void button_111_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゝ';
        }

        private void button_112_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゞ';
        }

        private void button_113_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〃';
        }

        private void button_114_Click(object sender, EventArgs e)
        {
            textBox1.Text += '仝';
        }

        private void button_115_Click(object sender, EventArgs e)
        {
            textBox1.Text += '々';
        }

        private void button_116_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〆';
        }

        private void button_117_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〇';
        }

        private void button_118_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ー';
        }

        private void button_119_Click(object sender, EventArgs e)
        {
            textBox1.Text += '―';
        }

        private void button_11A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '‐';
        }

        private void button_11B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '／';
        }

        private void button_11C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＼';
        }

        private void button_11D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '～';
        }

        private void button_11E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '∥';
        }

        private void button_11F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '｜';
        }

        private void button_11G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '…';
        }

        private void button_11H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '‥';
        }

        private void button_11I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '‘';
        }

        private void button_120_Click(object sender, EventArgs e)
        {
            textBox1.Text += '’';
        }

        private void button_121_Click(object sender, EventArgs e)
        {
            textBox1.Text += '“';
        }

        private void button_122_Click(object sender, EventArgs e)
        {
            textBox1.Text += '”';
        }

        private void button_123_Click(object sender, EventArgs e)
        {
            textBox1.Text += '（';
        }

        private void button_124_Click(object sender, EventArgs e)
        {
            textBox1.Text += '）';
        }

        private void button_125_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〔';
        }

        private void button_126_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〕';
        }

        private void button_127_Click(object sender, EventArgs e)
        {
            textBox1.Text += '［';
        }

        private void button_128_Click(object sender, EventArgs e)
        {
            textBox1.Text += '］';
        }

        private void button_129_Click(object sender, EventArgs e)
        {
            textBox1.Text += '｛';
        }

        private void button_12A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '｝';
        }

        private void button_12B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〈';
        }

        private void button_12C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〉';
        }

        private void button_12D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '《';
        }

        private void button_12E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '》';
        }

        private void button_12F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '「';
        }

        private void button_12G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '」';
        }

        private void button_12H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '『';
        }

        private void button_12I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '』';
        }

        private void button_130_Click(object sender, EventArgs e)
        {
            textBox1.Text += '【';
        }

        private void button_131_Click(object sender, EventArgs e)
        {
            textBox1.Text += '】';
        }

        private void button_132_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＋';
        }

        private void button_133_Click(object sender, EventArgs e)
        {
            textBox1.Text += '－';
        }

        private void button_134_Click(object sender, EventArgs e)
        {
            textBox1.Text += '±';
        }

        private void button_135_Click(object sender, EventArgs e)
        {
            textBox1.Text += '×';
        }

        private void button_136_Click(object sender, EventArgs e)
        {
            textBox1.Text += '÷';
        }

        private void button_137_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＝';
        }

        private void button_138_Click(object sender, EventArgs e)
        {
            textBox1.Text += '≠';
        }

        private void button_139_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＜';
        }

        private void button_13A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＞';
        }

        private void button_13B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '≦';
        }

        private void button_13C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '≧';
        }

        private void button_13D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '∞';
        }

        private void button_13E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '∴';
        }

        private void button_13F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '♂';
        }

        private void button_13G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '♀';
        }

        private void button_13H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '°';
        }

        private void button_13I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '′';
        }

        private void button_140_Click(object sender, EventArgs e)
        {
            textBox1.Text += '″';
        }

        private void button_141_Click(object sender, EventArgs e)
        {
            textBox1.Text += '℃';
        }

        private void button_142_Click(object sender, EventArgs e)
        {
            textBox1.Text += '￥';
        }

        private void button_143_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＄';
        }

        private void button_144_Click(object sender, EventArgs e)
        {
            textBox1.Text += '￠';
        }

        private void button_145_Click(object sender, EventArgs e)
        {
            textBox1.Text += '￡';
        }

        private void button_146_Click(object sender, EventArgs e)
        {
            textBox1.Text += '％';
        }

        private void button_147_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＃';
        }

        private void button_148_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＆';
        }

        private void button_149_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＊';
        }

        private void button_14A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '＠';
        }

        private void button_14B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '§';
        }

        private void button_14C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '☆';
        }

        private void button_14D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '★';
        }

        private void button_14E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '○';
        }

        private void button_14F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '●';
        }

        private void button_14G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '◎';
        }

        private void button_14H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '◇';
        }

        private void button_14I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '◆';
        }

        private void button_150_Click(object sender, EventArgs e)
        {
            textBox1.Text += '□';
        }

        private void button_151_Click(object sender, EventArgs e)
        {
            textBox1.Text += '■';
        }

        private void button_152_Click(object sender, EventArgs e)
        {
            textBox1.Text += '△';
        }

        private void button_153_Click(object sender, EventArgs e)
        {
            textBox1.Text += '▲';
        }

        private void button_154_Click(object sender, EventArgs e)
        {
            textBox1.Text += '▽';
        }

        private void button_155_Click(object sender, EventArgs e)
        {
            textBox1.Text += '▼';
        }

        private void button_156_Click(object sender, EventArgs e)
        {
            textBox1.Text += '※';
        }

        private void button_157_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〒';
        }

        private void button_158_Click(object sender, EventArgs e)
        {
            textBox1.Text += '→';
        }

        private void button_159_Click(object sender, EventArgs e)
        {
            textBox1.Text += '←';
        }

        private void button_15A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '↑';
        }

        private void button_15B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '↓';
        }

        private void button_15C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '〓';
        }

        private void button_210_Click(object sender, EventArgs e)
        {
            textBox1.Text += '０';
        }

        private void button_211_Click(object sender, EventArgs e)
        {
            textBox1.Text += '１';
        }

        private void button_212_Click(object sender, EventArgs e)
        {
            textBox1.Text += '２';
        }

        private void button_213_Click(object sender, EventArgs e)
        {
            textBox1.Text += '３';
        }

        private void button_214_Click(object sender, EventArgs e)
        {
            textBox1.Text += '４';
        }

        private void button_215_Click(object sender, EventArgs e)
        {
            textBox1.Text += '５';
        }

        private void button_216_Click(object sender, EventArgs e)
        {
            textBox1.Text += '６';
        }

        private void button_217_Click(object sender, EventArgs e)
        {
            textBox1.Text += '７';
        }

        private void button_218_Click(object sender, EventArgs e)
        {
            textBox1.Text += '８';
        }

        private void button_219_Click(object sender, EventArgs e)
        {
            textBox1.Text += '９';
        }

        private void button_221_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ａ';
        }

        private void button_222_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｂ';
        }

        private void button_223_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｃ';
        }

        private void button_224_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｄ';
        }

        private void button_225_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｅ';
        }

        private void button_226_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｆ';
        }

        private void button_227_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｇ';
        }

        private void button_228_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｈ';
        }

        private void button_229_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｉ';
        }

        private void button_22A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｊ';
        }

        private void button_22B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｋ';
        }

        private void button_22C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｌ';
        }

        private void button_22D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｍ';
        }

        private void button_22E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｎ';
        }

        private void button_22F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｏ';
        }

        private void button_22G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｐ';
        }

        private void button_22H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｑ';
        }

        private void button_22I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｒ';
        }

        private void button_230_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｓ';
        }

        private void button_231_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｔ';
        }

        private void button_232_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｕ';
        }

        private void button_233_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｖ';
        }

        private void button_234_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｗ';
        }

        private void button_235_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｘ';
        }

        private void button_236_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｙ';
        }

        private void button_237_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'Ｚ';
        }

        private void button_241_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ａ';
        }

        private void button_242_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｂ';
        }

        private void button_243_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｃ';
        }

        private void button_244_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｄ';
        }

        private void button_245_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｅ';
        }

        private void button_246_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｆ';
        }

        private void button_247_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｇ';
        }

        private void button_248_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｈ';
        }

        private void button_249_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｉ';
        }

        private void button_24A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｊ';
        }

        private void button_24B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｋ';
        }

        private void button_24C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｌ';
        }

        private void button_24D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｍ';
        }

        private void button_24E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｎ';
        }

        private void button_24F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｏ';
        }

        private void button_24G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｐ';
        }

        private void button_24H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｑ';
        }

        private void button_24I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｒ';
        }

        private void button_250_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｓ';
        }

        private void button_251_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｔ';
        }

        private void button_252_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｕ';
        }

        private void button_253_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｖ';
        }

        private void button_254_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｗ';
        }

        private void button_255_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｘ';
        }

        private void button_256_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｙ';
        }

        private void button_257_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ｚ';
        }

        private void button_301_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぁ';
        }

        private void button_302_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'あ';
        }

        private void button_303_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぃ';
        }

        private void button_304_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'い';
        }

        private void button_305_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぅ';
        }

        private void button_306_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'う';
        }

        private void button_307_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぇ';
        }

        private void button_308_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'え';
        }

        private void button_309_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぉ';
        }

        private void button_30A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'お';
        }

        private void button_30B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'か';
        }

        private void button_30C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'が';
        }

        private void button_30D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'き';
        }

        private void button_30E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぎ';
        }

        private void button_30F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'く';
        }

        private void button_30G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぐ';
        }

        private void button_30H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'け';
        }

        private void button_30I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'げ';
        }

        private void button_310_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'こ';
        }

        private void button_311_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ご';
        }

        private void button_312_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'さ';
        }

        private void button_313_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ざ';
        }

        private void button_314_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'し';
        }

        private void button_315_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'じ';
        }

        private void button_316_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'す';
        }

        private void button_317_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ず';
        }

        private void button_318_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'せ';
        }

        private void button_319_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぜ';
        }

        private void button_31A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'そ';
        }

        private void button_31B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぞ';
        }

        private void button_31C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'た';
        }

        private void button_31D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'だ';
        }

        private void button_31E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ち';
        }

        private void button_31F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぢ';
        }

        private void button_31G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'っ';
        }

        private void button_31H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'つ';
        }

        private void button_31I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'づ';
        }

        private void button_320_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'て';
        }

        private void button_321_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'で';
        }

        private void button_322_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'と';
        }

        private void button_323_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ど';
        }

        private void button_324_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'な';
        }

        private void button_325_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'に';
        }

        private void button_326_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぬ';
        }

        private void button_327_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ね';
        }

        private void button_328_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'の';
        }

        private void button_329_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'は';
        }

        private void button_32A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ば';
        }

        private void button_32B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぱ';
        }

        private void button_32C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ひ';
        }

        private void button_32D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'び';
        }

        private void button_32E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぴ';
        }

        private void button_32F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ふ';
        }

        private void button_32G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぶ';
        }

        private void button_32H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぷ';
        }

        private void button_32I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'へ';
        }

        private void button_330_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'べ';
        }

        private void button_331_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぺ';
        }

        private void button_332_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ほ';
        }

        private void button_333_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぼ';
        }

        private void button_334_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ぽ';
        }

        private void button_335_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ま';
        }

        private void button_336_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'み';
        }

        private void button_337_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'む';
        }

        private void button_338_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'め';
        }

        private void button_339_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'も';
        }

        private void button_33A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゃ';
        }

        private void button_33B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'や';
        }

        private void button_33C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゅ';
        }

        private void button_33D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゆ';
        }

        private void button_33E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ょ';
        }

        private void button_33F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'よ';
        }

        private void button_33G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ら';
        }

        private void button_33H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'り';
        }

        private void button_33I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'る';
        }

        private void button_340_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'れ';
        }

        private void button_341_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ろ';
        }

        private void button_342_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゎ';
        }

        private void button_343_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'わ';
        }

        private void button_344_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゐ';
        }

        private void button_345_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゑ';
        }

        private void button_346_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'を';
        }

        private void button_347_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ん';
        }

        private void button_401_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ァ';
        }

        private void button_402_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ア';
        }

        private void button_403_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ィ';
        }

        private void button_404_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'イ';
        }

        private void button_405_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゥ';
        }

        private void button_406_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ウ';
        }

        private void button_407_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ェ';
        }

        private void button_408_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'エ';
        }

        private void button_409_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ォ';
        }

        private void button_40A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'オ';
        }

        private void button_40B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'カ';
        }

        private void button_40C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ガ';
        }

        private void button_40D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'キ';
        }

        private void button_40E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ギ';
        }

        private void button_40F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ク';
        }

        private void button_40G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'グ';
        }

        private void button_40H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ケ';
        }

        private void button_40I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゲ';
        }

        private void button_410_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'コ';
        }

        private void button_411_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゴ';
        }

        private void button_412_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'サ';
        }

        private void button_413_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ザ';
        }

        private void button_414_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'シ';
        }

        private void button_415_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ジ';
        }

        private void button_416_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ス';
        }

        private void button_417_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ズ';
        }

        private void button_418_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'セ';
        }

        private void button_419_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゼ';
        }

        private void button_41A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ソ';
        }

        private void button_41B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ゾ';
        }

        private void button_41C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'タ';
        }

        private void button_41D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ダ';
        }

        private void button_41E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'チ';
        }

        private void button_41F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヂ';
        }

        private void button_41G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ッ';
        }

        private void button_41H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ツ';
        }

        private void button_41I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヅ';
        }

        private void button_420_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'テ';
        }

        private void button_421_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'デ';
        }

        private void button_422_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ト';
        }

        private void button_423_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ド';
        }

        private void button_424_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ナ';
        }

        private void button_425_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ニ';
        }

        private void button_426_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヌ';
        }

        private void button_427_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ネ';
        }

        private void button_428_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ノ';
        }

        private void button_429_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ハ';
        }

        private void button_42A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'バ';
        }

        private void button_42B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'パ';
        }

        private void button_42C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヒ';
        }

        private void button_42D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ビ';
        }

        private void button_42E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ピ';
        }

        private void button_42F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'フ';
        }

        private void button_42G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ブ';
        }

        private void button_42H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'プ';
        }

        private void button_42I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヘ';
        }

        private void button_430_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ベ';
        }

        private void button_431_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ペ';
        }

        private void button_432_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ホ';
        }

        private void button_433_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ボ';
        }

        private void button_434_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ポ';
        }

        private void button_435_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'マ';
        }

        private void button_436_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ミ';
        }

        private void button_437_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ム';
        }

        private void button_438_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'メ';
        }

        private void button_439_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'モ';
        }

        private void button_43A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ャ';
        }

        private void button_43B_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヤ';
        }

        private void button_43C_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ュ';
        }

        private void button_43D_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ユ';
        }

        private void button_43E_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ョ';
        }

        private void button_43F_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヨ';
        }

        private void button_43G_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ラ';
        }

        private void button_43H_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'リ';
        }

        private void button_43I_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ル';
        }

        private void button_440_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'レ';
        }

        private void button_441_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ロ';
        }

        private void button_442_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヮ';
        }

        private void button_443_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ワ';
        }

        private void button_444_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヰ';
        }

        private void button_445_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヱ';
        }

        private void button_446_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヲ';
        }

        private void button_447_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ン';
        }

        private void button_448_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヴ';
        }

        private void button_449_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヵ';
        }

        private void button_44A_Click(object sender, EventArgs e)
        {
            textBox1.Text += 'ヶ';
        }

        private void button_A01_Click(object sender, EventArgs e)
        {
            textBox1.Text += '和';
        }

        private void button_A02_Click(object sender, EventArgs e)
        {
            textBox1.Text += '夜';
        }

        private void button_A03_Click(object sender, EventArgs e)
        {
            textBox1.Text += '野';
        }

        private void button_A04_Click(object sender, EventArgs e)
        {
            textBox1.Text += '話';
        }

        private void button_A05_Click(object sender, EventArgs e)
        {
            textBox1.Text += '愛';
        }

        private void button_A06_Click(object sender, EventArgs e)
        {
            textBox1.Text += '役';
        }

        private void button_A07_Click(object sender, EventArgs e)
        {
            textBox1.Text += '約';
        }

        private void button_A08_Click(object sender, EventArgs e)
        {
            textBox1.Text += '悪';
        }

        private void button_A09_Click(object sender, EventArgs e)
        {
            textBox1.Text += '薬';
        }

        private void button_A0A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '安';
        }

        private void button_A0B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '案';
        }

        private void button_A0C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '暗';
        }

        private void button_A0D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '以';
        }

        private void button_A0E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '衣';
        }

        private void button_A0F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '位';
        }

        private void button_A0G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '医';
        }

        private void button_A0H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '囲';
        }

        private void button_A0I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '委';
        }

        private void button_A10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '胃';
        }

        private void button_A11_Click(object sender, EventArgs e)
        {
            textBox1.Text += '意';
        }

        private void button_A12_Click(object sender, EventArgs e)
        {
            textBox1.Text += '育';
        }

        private void button_A13_Click(object sender, EventArgs e)
        {
            textBox1.Text += '一';
        }

        private void button_A14_Click(object sender, EventArgs e)
        {
            textBox1.Text += '引';
        }

        private void button_A15_Click(object sender, EventArgs e)
        {
            textBox1.Text += '印';
        }

        private void button_A16_Click(object sender, EventArgs e)
        {
            textBox1.Text += '員';
        }

        private void button_A17_Click(object sender, EventArgs e)
        {
            textBox1.Text += '院';
        }

        private void button_A18_Click(object sender, EventArgs e)
        {
            textBox1.Text += '飲';
        }

        private void button_A19_Click(object sender, EventArgs e)
        {
            textBox1.Text += '右';
        }

        private void button_A1A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '由';
        }

        private void button_A1B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '有';
        }

        private void button_A1C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '羽';
        }

        private void button_A1D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '油';
        }

        private void button_A1E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '雨';
        }

        private void button_A1F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '勇';
        }

        private void button_A1G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '遊';
        }

        private void button_A1H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '運';
        }

        private void button_A1I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '雲';
        }

        private void button_A20_Click(object sender, EventArgs e)
        {
            textBox1.Text += '工';
        }

        private void button_A21_Click(object sender, EventArgs e)
        {
            textBox1.Text += '功';
        }

        private void button_A22_Click(object sender, EventArgs e)
        {
            textBox1.Text += '泳';
        }

        private void button_A23_Click(object sender, EventArgs e)
        {
            textBox1.Text += '英';
        }

        private void button_A24_Click(object sender, EventArgs e)
        {
            textBox1.Text += '栄';
        }

        private void button_A25_Click(object sender, EventArgs e)
        {
            textBox1.Text += '駅';
        }

        private void button_A26_Click(object sender, EventArgs e)
        {
            textBox1.Text += '円';
        }

        private void button_A27_Click(object sender, EventArgs e)
        {
            textBox1.Text += '園';
        }

        private void button_A28_Click(object sender, EventArgs e)
        {
            textBox1.Text += '塩';
        }

        private void button_A29_Click(object sender, EventArgs e)
        {
            textBox1.Text += '遠';
        }

        private void button_A2A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '予';
        }

        private void button_A2B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '王';
        }

        private void button_A2C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '央';
        }

        private void button_A2D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '用';
        }

        private void button_A2E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '羊';
        }

        private void button_A2F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '洋';
        }

        private void button_A2G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '要';
        }

        private void button_A2H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '葉';
        }

        private void button_A2I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '陽';
        }

        private void button_A30_Click(object sender, EventArgs e)
        {
            textBox1.Text += '様';
        }

        private void button_A31_Click(object sender, EventArgs e)
        {
            textBox1.Text += '横';
        }

        private void button_A32_Click(object sender, EventArgs e)
        {
            textBox1.Text += '養';
        }

        private void button_A33_Click(object sender, EventArgs e)
        {
            textBox1.Text += '曜';
        }

        private void button_A34_Click(object sender, EventArgs e)
        {
            textBox1.Text += '屋';
        }

        private void button_A35_Click(object sender, EventArgs e)
        {
            textBox1.Text += '浴';
        }

        private void button_A36_Click(object sender, EventArgs e)
        {
            textBox1.Text += '億';
        }

        private void button_A37_Click(object sender, EventArgs e)
        {
            textBox1.Text += '音';
        }

        private void button_A38_Click(object sender, EventArgs e)
        {
            textBox1.Text += '温';
        }

        private void button_A39_Click(object sender, EventArgs e)
        {
            textBox1.Text += '力';
        }

        private void button_A3A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '下';
        }

        private void button_A3B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '化';
        }

        private void button_A3C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '火';
        }

        private void button_A3D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '加';
        }

        private void button_A3E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '何';
        }

        private void button_A3F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '花';
        }

        private void button_A3G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '果';
        }

        private void button_A3H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '科';
        }

        private void button_A3I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '夏';
        }

        private void button_A40_Click(object sender, EventArgs e)
        {
            textBox1.Text += '家';
        }

        private void button_A41_Click(object sender, EventArgs e)
        {
            textBox1.Text += '荷';
        }

        private void button_A42_Click(object sender, EventArgs e)
        {
            textBox1.Text += '貨';
        }

        private void button_A43_Click(object sender, EventArgs e)
        {
            textBox1.Text += '歌';
        }

        private void button_A44_Click(object sender, EventArgs e)
        {
            textBox1.Text += '課';
        }

        private void button_A45_Click(object sender, EventArgs e)
        {
            textBox1.Text += '画';
        }

        private void button_A46_Click(object sender, EventArgs e)
        {
            textBox1.Text += '芽';
        }

        private void button_A47_Click(object sender, EventArgs e)
        {
            textBox1.Text += '会';
        }

        private void button_A48_Click(object sender, EventArgs e)
        {
            textBox1.Text += '回';
        }

        private void button_A49_Click(object sender, EventArgs e)
        {
            textBox1.Text += '改';
        }

        private void button_A4A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '海';
        }

        private void button_A4B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '界';
        }

        private void button_A4C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '械';
        }

        private void button_A4D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '絵';
        }

        private void button_A4E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '開';
        }

        private void button_A4F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '階';
        }

        private void button_A4G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '外';
        }

        private void button_A4H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '害';
        }

        private void button_A4I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '街';
        }

        private void button_A50_Click(object sender, EventArgs e)
        {
            textBox1.Text += '各';
        }

        private void button_A51_Click(object sender, EventArgs e)
        {
            textBox1.Text += '角';
        }

        private void button_A52_Click(object sender, EventArgs e)
        {
            textBox1.Text += '客';
        }

        private void button_A53_Click(object sender, EventArgs e)
        {
            textBox1.Text += '覚';
        }

        private void button_A54_Click(object sender, EventArgs e)
        {
            textBox1.Text += '学';
        }

        private void button_A55_Click(object sender, EventArgs e)
        {
            textBox1.Text += '楽';
        }

        private void button_A56_Click(object sender, EventArgs e)
        {
            textBox1.Text += '活';
        }

        private void button_A57_Click(object sender, EventArgs e)
        {
            textBox1.Text += '完';
        }

        private void button_A58_Click(object sender, EventArgs e)
        {
            textBox1.Text += '官';
        }

        private void button_A59_Click(object sender, EventArgs e)
        {
            textBox1.Text += '寒';
        }

        private void button_A5A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '間';
        }

        private void button_A5B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '感';
        }

        private void button_A5C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '漢';
        }

        private void button_A5D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '管';
        }

        private void button_A5E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '関';
        }

        private void button_A5F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '館';
        }

        private void button_A5G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '観';
        }

        private void button_A5H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '丸';
        }

        private void button_A5I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '岸';
        }

        private void button_A60_Click(object sender, EventArgs e)
        {
            textBox1.Text += '岩';
        }

        private void button_A61_Click(object sender, EventArgs e)
        {
            textBox1.Text += '顔';
        }

        private void button_A62_Click(object sender, EventArgs e)
        {
            textBox1.Text += '願';
        }

        private void button_A63_Click(object sender, EventArgs e)
        {
            textBox1.Text += '気';
        }

        private void button_A64_Click(object sender, EventArgs e)
        {
            textBox1.Text += '希';
        }

        private void button_A65_Click(object sender, EventArgs e)
        {
            textBox1.Text += '汽';
        }

        private void button_A66_Click(object sender, EventArgs e)
        {
            textBox1.Text += '季';
        }

        private void button_A67_Click(object sender, EventArgs e)
        {
            textBox1.Text += '紀';
        }

        private void button_A68_Click(object sender, EventArgs e)
        {
            textBox1.Text += '帰';
        }

        private void button_A69_Click(object sender, EventArgs e)
        {
            textBox1.Text += '記';
        }

        private void button_A6A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '起';
        }

        private void button_A6B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '喜';
        }

        private void button_A6C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '期';
        }

        private void button_A6D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '旗';
        }

        private void button_A6E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '器';
        }

        private void button_A6F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '機';
        }

        private void button_A6G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '議';
        }

        private void button_A6H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '近';
        }

        private void button_A6I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '金';
        }

        private void button_A70_Click(object sender, EventArgs e)
        {
            textBox1.Text += '銀';
        }

        private void button_A71_Click(object sender, EventArgs e)
        {
            textBox1.Text += '九';
        }

        private void button_A72_Click(object sender, EventArgs e)
        {
            textBox1.Text += '弓';
        }

        private void button_A73_Click(object sender, EventArgs e)
        {
            textBox1.Text += '区';
        }

        private void button_A74_Click(object sender, EventArgs e)
        {
            textBox1.Text += '休';
        }

        private void button_A75_Click(object sender, EventArgs e)
        {
            textBox1.Text += '求';
        }

        private void button_A76_Click(object sender, EventArgs e)
        {
            textBox1.Text += '究';
        }

        private void button_A77_Click(object sender, EventArgs e)
        {
            textBox1.Text += '泣';
        }

        private void button_A78_Click(object sender, EventArgs e)
        {
            textBox1.Text += '空';
        }

        private void button_A79_Click(object sender, EventArgs e)
        {
            textBox1.Text += '苦';
        }

        private void button_A7A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '急';
        }

        private void button_A7B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '級';
        }

        private void button_A7C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '宮';
        }

        private void button_A7D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '救';
        }

        private void button_A7E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '球';
        }

        private void button_A7F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '給';
        }

        private void button_A7G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '牛';
        }

        private void button_A7H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '具';
        }

        private void button_A7I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '君';
        }

        private void button_A80_Click(object sender, EventArgs e)
        {
            textBox1.Text += '訓';
        }

        private void button_A81_Click(object sender, EventArgs e)
        {
            textBox1.Text += '軍';
        }

        private void button_A82_Click(object sender, EventArgs e)
        {
            textBox1.Text += '郡';
        }

        private void button_A83_Click(object sender, EventArgs e)
        {
            textBox1.Text += '兄';
        }

        private void button_A84_Click(object sender, EventArgs e)
        {
            textBox1.Text += '形';
        }

        private void button_A85_Click(object sender, EventArgs e)
        {
            textBox1.Text += '径';
        }

        private void button_A86_Click(object sender, EventArgs e)
        {
            textBox1.Text += '係';
        }

        private void button_A87_Click(object sender, EventArgs e)
        {
            textBox1.Text += '型';
        }

        private void button_A88_Click(object sender, EventArgs e)
        {
            textBox1.Text += '計';
        }

        private void button_A89_Click(object sender, EventArgs e)
        {
            textBox1.Text += '景';
        }

        private void button_A8A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '軽';
        }

        private void button_A8B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '芸';
        }

        private void button_A8C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '欠';
        }

        private void button_A8D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '血';
        }

        private void button_A8E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '決';
        }

        private void button_A8F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '結';
        }

        private void button_A8G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '月';
        }

        private void button_A8H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '犬';
        }

        private void button_A8I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '見';
        }

        private void button_A90_Click(object sender, EventArgs e)
        {
            textBox1.Text += '建';
        }

        private void button_A91_Click(object sender, EventArgs e)
        {
            textBox1.Text += '研';
        }

        private void button_A92_Click(object sender, EventArgs e)
        {
            textBox1.Text += '県';
        }

        private void button_A93_Click(object sender, EventArgs e)
        {
            textBox1.Text += '健';
        }

        private void button_A94_Click(object sender, EventArgs e)
        {
            textBox1.Text += '験';
        }

        private void button_A95_Click(object sender, EventArgs e)
        {
            textBox1.Text += '元';
        }

        private void button_A96_Click(object sender, EventArgs e)
        {
            textBox1.Text += '言';
        }

        private void button_A97_Click(object sender, EventArgs e)
        {
            textBox1.Text += '原';
        }

        private void button_A98_Click(object sender, EventArgs e)
        {
            textBox1.Text += '公';
        }

        private void button_A99_Click(object sender, EventArgs e)
        {
            textBox1.Text += '戸';
        }

        private void button_A9A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '去';
        }

        private void button_A9B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '古';
        }

        private void button_A9C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '広';
        }

        private void button_A9D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '交';
        }

        private void button_A9E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '光';
        }

        private void button_A9F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '共';
        }

        private void button_A9G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '向';
        }

        private void button_A9H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '好';
        }

        private void button_A9I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '考';
        }

        private void button_AA0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '行';
        }

        private void button_AA1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '京';
        }

        private void button_AA2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '協';
        }

        private void button_AA3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '固';
        }

        private void button_AA4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '幸';
        }

        private void button_AA5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '候';
        }

        private void button_AA6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '庫';
        }

        private void button_AA7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '挙';
        }

        private void button_AA8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '校';
        }

        private void button_AA9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '航';
        }

        private void button_AAA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '高';
        }

        private void button_AAB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '康';
        }

        private void button_AAC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '強';
        }

        private void button_AAD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '教';
        }

        private void button_AAE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '黄';
        }

        private void button_AAF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '湖';
        }

        private void button_AAG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '港';
        }

        private void button_AAH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '橋';
        }

        private void button_AAI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '鏡';
        }

        private void button_AB0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '競';
        }

        private void button_AB1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '五';
        }

        private void button_AB2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '午';
        }

        private void button_AB3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '号';
        }

        private void button_AB4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '合';
        }

        private void button_AB5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '後';
        }

        private void button_AB6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '魚';
        }

        private void button_AB7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '業';
        }

        private void button_AB8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '漁';
        }

        private void button_AB9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '語';
        }

        private void button_ABA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '曲';
        }

        private void button_ABB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '告';
        }

        private void button_ABC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '局';
        }

        private void button_ABD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '谷';
        }

        private void button_ABE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '国';
        }

        private void button_ABF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '黒';
        }

        private void button_ABG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '極';
        }

        private void button_ABH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '玉';
        }

        private void button_ABI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '今';
        }

        private void button_AC0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '根';
        }

        private void button_AC1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '写';
        }

        private void button_AC2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '左';
        }

        private void button_AC3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '社';
        }

        private void button_AC4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '車';
        }

        private void button_AC5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '者';
        }

        private void button_AC6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '差';
        }

        private void button_AC7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '才';
        }

        private void button_AC8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '祭';
        }

        private void button_AC9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '細';
        }

        private void button_ACA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '菜';
        }

        private void button_ACB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '最';
        }

        private void button_ACC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '材';
        }

        private void button_ACD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '作';
        }

        private void button_ACE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '昨';
        }

        private void button_ACF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '借';
        }

        private void button_ACG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '弱';
        }

        private void button_ACH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '札';
        }

        private void button_ACI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '刷';
        }

        private void button_AD0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '殺';
        }

        private void button_AD1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '察';
        }

        private void button_AD2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '三';
        }

        private void button_AD3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '山';
        }

        private void button_AD4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '参';
        }

        private void button_AD5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '産';
        }

        private void button_AD6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '散';
        }

        private void button_AD7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '算';
        }

        private void button_AD8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '残';
        }

        private void button_AD9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '士';
        }

        private void button_ADA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '子';
        }

        private void button_ADB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '止';
        }

        private void button_ADC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '氏';
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '仕';
        }

        private void button_ADE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '史';
        }

        private void button_ADF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '司';
        }

        private void button_ADG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '四';
        }

        private void button_ADH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '市';
        }

        private void button_ADI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '矢';
        }

        private void button_AE0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '死';
        }

        private void button_AE1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '糸';
        }

        private void button_AE2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '使';
        }

        private void button_AE3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '始';
        }

        private void button_AE4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '姉';
        }

        private void button_AE5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '思';
        }

        private void button_AE6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '指';
        }

        private void button_AE7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '紙';
        }

        private void button_AE8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '歯';
        }

        private void button_AE9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '試';
        }

        private void button_AEA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '詩';
        }

        private void button_AEB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '字';
        }

        private void button_AEC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '寺';
        }

        private void button_AED_Click(object sender, EventArgs e)
        {
            textBox1.Text += '次';
        }

        private void button_AEE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '耳';
        }

        private void button_AEF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '自';
        }

        private void button_AEG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '児';
        }

        private void button_AEH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '事';
        }

        private void button_AEI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '持';
        }

        private void button_AF0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '時';
        }

        private void button_AF1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '辞';
        }

        private void button_AF2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '式';
        }

        private void button_AF3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '七';
        }

        private void button_AF4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '失';
        }

        private void button_AF5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '室';
        }

        private void button_AF6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '実';
        }

        private void button_AF7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '心';
        }

        private void button_AF8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '申';
        }

        private void button_AF9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '臣';
        }

        private void button_AFA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '身';
        }

        private void button_AFB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '信';
        }

        private void button_AFC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '神';
        }

        private void button_AFD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '真';
        }

        private void button_AFE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '深';
        }

        private void button_AFF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '進';
        }

        private void button_AFG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '森';
        }

        private void button_AFH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '新';
        }

        private void button_AFI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '親';
        }

        private void button_AG0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '人';
        }

        private void button_AG1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '手';
        }

        private void button_AG2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '主';
        }

        private void button_AG3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '守';
        }

        private void button_AG4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '州';
        }

        private void button_AG5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '取';
        }

        private void button_AG6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '周';
        }

        private void button_AG7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '拾';
        }

        private void button_AG8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '秋';
        }

        private void button_AG9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '首';
        }

        private void button_AGA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '酒';
        }

        private void button_AGB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '終';
        }

        private void button_AGC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '習';
        }

        private void button_AGD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '週';
        }

        private void button_AGE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '集';
        }

        private void button_AGF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '数';
        }

        private void button_AGG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '種';
        }

        private void button_AGH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '十';
        }

        private void button_AGI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '受';
        }

        private void button_AH0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '水';
        }

        private void button_AH1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '祝';
        }

        private void button_AH2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '宿';
        }

        private void button_AH3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '出';
        }

        private void button_AH4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '春';
        }

        private void button_AH5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '順';
        }

        private void button_AH6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '世';
        }

        private void button_AH7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '正';
        }

        private void button_AH8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '生';
        }

        private void button_AH9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '成';
        }

        private void button_AHA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '西';
        }

        private void button_AHB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '声';
        }

        private void button_AHC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '青';
        }

        private void button_AHD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '星';
        }

        private void button_AHE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '省';
        }

        private void button_AHF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '清';
        }

        private void button_AHG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '晴';
        }

        private void button_AHH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '静';
        }

        private void button_AHI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '整';
        }

        private void button_AI0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '石';
        }

        private void button_AI1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '赤';
        }

        private void button_AI2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '昔';
        }

        private void button_AI3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '席';
        }

        private void button_AI4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '積';
        }

        private void button_AI5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '切';
        }

        private void button_AI6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '折';
        }

        private void button_AI7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '雪';
        }

        private void button_AI8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '節';
        }

        private void button_AI9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '説';
        }

        private void button_AIA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '千';
        }

        private void button_AIB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '川';
        }

        private void button_AIC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '先';
        }

        private void button_AID_Click(object sender, EventArgs e)
        {
            textBox1.Text += '浅';
        }

        private void button_AIE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '船';
        }

        private void button_AIF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '戦';
        }

        private void button_AIG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '線';
        }

        private void button_AIH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '選';
        }

        private void button_AII_Click(object sender, EventArgs e)
        {
            textBox1.Text += '全';
        }

        private void button_B01_Click(object sender, EventArgs e)
        {
            textBox1.Text += '前';
        }

        private void button_B02_Click(object sender, EventArgs e)
        {
            textBox1.Text += '然';
        }

        private void button_B03_Click(object sender, EventArgs e)
        {
            textBox1.Text += '小';
        }

        private void button_B04_Click(object sender, EventArgs e)
        {
            textBox1.Text += '少';
        }

        private void button_B05_Click(object sender, EventArgs e)
        {
            textBox1.Text += '争';
        }

        private void button_B06_Click(object sender, EventArgs e)
        {
            textBox1.Text += '早';
        }

        private void button_B07_Click(object sender, EventArgs e)
        {
            textBox1.Text += '初';
        }

        private void button_B08_Click(object sender, EventArgs e)
        {
            textBox1.Text += '走';
        }

        private void button_B09_Click(object sender, EventArgs e)
        {
            textBox1.Text += '所';
        }

        private void button_B0A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '松';
        }

        private void button_B0B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '昭';
        }

        private void button_B0C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '相';
        }

        private void button_B0D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '草';
        }

        private void button_B0E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '送';
        }

        private void button_B0F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '倉';
        }

        private void button_B0G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '書';
        }

        private void button_B0H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '消';
        }

        private void button_B0I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '笑';
        }

        private void button_B10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '唱';
        }

        private void button_B11_Click(object sender, EventArgs e)
        {
            textBox1.Text += '商';
        }

        private void button_B12_Click(object sender, EventArgs e)
        {
            textBox1.Text += '巣';
        }

        private void button_B13_Click(object sender, EventArgs e)
        {
            textBox1.Text += '章';
        }

        private void button_B14_Click(object sender, EventArgs e)
        {
            textBox1.Text += '組';
        }

        private void button_B15_Click(object sender, EventArgs e)
        {
            textBox1.Text += '勝';
        }

        private void button_B16_Click(object sender, EventArgs e)
        {
            textBox1.Text += '暑';
        }

        private void button_B17_Click(object sender, EventArgs e)
        {
            textBox1.Text += '焼';
        }

        private void button_B18_Click(object sender, EventArgs e)
        {
            textBox1.Text += '象';
        }

        private void button_B19_Click(object sender, EventArgs e)
        {
            textBox1.Text += '想';
        }

        private void button_B1A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '照';
        }

        private void button_B1B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '箱';
        }

        private void button_B1C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '賞';
        }

        private void button_B1D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '上';
        }

        private void button_B1E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '助';
        }

        private void button_B1F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '乗';
        }

        private void button_B1G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '色';
        }

        private void button_B1H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '束';
        }

        private void button_B1I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '足';
        }

        private void button_B20_Click(object sender, EventArgs e)
        {
            textBox1.Text += '食';
        }

        private void button_B21_Click(object sender, EventArgs e)
        {
            textBox1.Text += '息';
        }

        private void button_B22_Click(object sender, EventArgs e)
        {
            textBox1.Text += '速';
        }

        private void button_B23_Click(object sender, EventArgs e)
        {
            textBox1.Text += '側';
        }

        private void button_B24_Click(object sender, EventArgs e)
        {
            textBox1.Text += '植';
        }

        private void button_B25_Click(object sender, EventArgs e)
        {
            textBox1.Text += '族';
        }

        private void button_B26_Click(object sender, EventArgs e)
        {
            textBox1.Text += '続';
        }

        private void button_B27_Click(object sender, EventArgs e)
        {
            textBox1.Text += '卒';
        }

        private void button_B28_Click(object sender, EventArgs e)
        {
            textBox1.Text += '村';
        }

        private void button_B29_Click(object sender, EventArgs e)
        {
            textBox1.Text += '孫';
        }

        private void button_B2A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '夕';
        }

        private void button_B2B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '他';
        }

        private void button_B2C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '多';
        }

        private void button_B2D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '茶';
        }

        private void button_B2E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '打';
        }

        private void button_B2F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '太';
        }

        private void button_B2G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '体';
        }

        private void button_B2H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '対';
        }

        private void button_B2I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '街';
        }

        private void button_B30_Click(object sender, EventArgs e)
        {
            textBox1.Text += '帯';
        }

        private void button_B31_Click(object sender, EventArgs e)
        {
            textBox1.Text += '隊';
        }

        private void button_B32_Click(object sender, EventArgs e)
        {
            textBox1.Text += '大';
        }

        private void button_B33_Click(object sender, EventArgs e)
        {
            textBox1.Text += '代';
        }

        private void button_B34_Click(object sender, EventArgs e)
        {
            textBox1.Text += '台';
        }

        private void button_B35_Click(object sender, EventArgs e)
        {
            textBox1.Text += '第';
        }

        private void button_B36_Click(object sender, EventArgs e)
        {
            textBox1.Text += '題';
        }

        private void button_B37_Click(object sender, EventArgs e)
        {
            textBox1.Text += '着';
        }

        private void button_B38_Click(object sender, EventArgs e)
        {
            textBox1.Text += '達';
        }

        private void button_B39_Click(object sender, EventArgs e)
        {
            textBox1.Text += '単';
        }

        private void button_B3A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '炭';
        }

        private void button_B3B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '短';
        }

        private void button_B3C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '男';
        }

        private void button_B3D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '談';
        }

        private void button_B3E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '地';
        }

        private void button_B3F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '池';
        }

        private void button_B3G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '知';
        }

        private void button_B3H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '置';
        }

        private void button_B3I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '治';
        }

        private void button_B40_Click(object sender, EventArgs e)
        {
            textBox1.Text += '竹';
        }

        private void button_B41_Click(object sender, EventArgs e)
        {
            textBox1.Text += '中';
        }

        private void button_B42_Click(object sender, EventArgs e)
        {
            textBox1.Text += '仲';
        }

        private void button_B43_Click(object sender, EventArgs e)
        {
            textBox1.Text += '虫';
        }

        private void button_B44_Click(object sender, EventArgs e)
        {
            textBox1.Text += '注';
        }

        private void button_B45_Click(object sender, EventArgs e)
        {
            textBox1.Text += '昼';
        }

        private void button_B46_Click(object sender, EventArgs e)
        {
            textBox1.Text += '柱';
        }

        private void button_B47_Click(object sender, EventArgs e)
        {
            textBox1.Text += '通';
        }

        private void button_B48_Click(object sender, EventArgs e)
        {
            textBox1.Text += '住';
        }

        private void button_B49_Click(object sender, EventArgs e)
        {
            textBox1.Text += '図';
        }

        private void button_B4A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '重';
        }

        private void button_B4B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '追';
        }

        private void button_B4C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '低';
        }

        private void button_B4D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '弟';
        }

        private void button_B4E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '定';
        }

        private void button_B4F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '底';
        }

        private void button_B4G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '庭';
        }

        private void button_B4H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '停';
        }

        private void button_B4I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '的';
        }

        private void button_B50_Click(object sender, EventArgs e)
        {
            textBox1.Text += '笛';
        }

        private void button_B51_Click(object sender, EventArgs e)
        {
            textBox1.Text += '鉄';
        }

        private void button_B52_Click(object sender, EventArgs e)
        {
            textBox1.Text += '天';
        }

        private void button_B53_Click(object sender, EventArgs e)
        {
            textBox1.Text += '典';
        }

        private void button_B54_Click(object sender, EventArgs e)
        {
            textBox1.Text += '店';
        }

        private void button_B55_Click(object sender, EventArgs e)
        {
            textBox1.Text += '点';
        }

        private void button_B56_Click(object sender, EventArgs e)
        {
            textBox1.Text += '転';
        }

        private void button_B57_Click(object sender, EventArgs e)
        {
            textBox1.Text += '田';
        }

        private void button_B58_Click(object sender, EventArgs e)
        {
            textBox1.Text += '伝';
        }

        private void button_B59_Click(object sender, EventArgs e)
        {
            textBox1.Text += '電';
        }

        private void button_B5A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '丁';
        }

        private void button_B5B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '刀';
        }

        private void button_B5C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '冬';
        }

        private void button_B5D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '兆';
        }

        private void button_B5E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '当';
        }

        private void button_B5F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '灯';
        }

        private void button_B5G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '投';
        }

        private void button_B5H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '町';
        }

        private void button_B5I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '豆';
        }

        private void button_B60_Click(object sender, EventArgs e)
        {
            textBox1.Text += '東';
        }

        private void button_B61_Click(object sender, EventArgs e)
        {
            textBox1.Text += '長';
        }

        private void button_B62_Click(object sender, EventArgs e)
        {
            textBox1.Text += '島';
        }

        private void button_B63_Click(object sender, EventArgs e)
        {
            textBox1.Text += '徒';
        }

        private void button_B64_Click(object sender, EventArgs e)
        {
            textBox1.Text += '帳';
        }

        private void button_B65_Click(object sender, EventArgs e)
        {
            textBox1.Text += '都';
        }

        private void button_B66_Click(object sender, EventArgs e)
        {
            textBox1.Text += '鳥';
        }

        private void button_B67_Click(object sender, EventArgs e)
        {
            textBox1.Text += '朝';
        }

        private void button_B68_Click(object sender, EventArgs e)
        {
            textBox1.Text += '湯';
        }

        private void button_B69_Click(object sender, EventArgs e)
        {
            textBox1.Text += '登';
        }

        private void button_B6A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '答';
        }

        private void button_B6B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '等';
        }

        private void button_B6C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '貯';
        }

        private void button_B6D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '腸';
        }

        private void button_B6E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '調';
        }

        private void button_B6F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '頭';
        }

        private void button_B6G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '土';
        }

        private void button_B6H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '女';
        }

        private void button_B6I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '同';
        }

        private void button_B70_Click(object sender, EventArgs e)
        {
            textBox1.Text += '努';
        }

        private void button_B71_Click(object sender, EventArgs e)
        {
            textBox1.Text += '度';
        }

        private void button_B72_Click(object sender, EventArgs e)
        {
            textBox1.Text += '動';
        }

        private void button_B73_Click(object sender, EventArgs e)
        {
            textBox1.Text += '堂';
        }

        private void button_B74_Click(object sender, EventArgs e)
        {
            textBox1.Text += '場';
        }

        private void button_B75_Click(object sender, EventArgs e)
        {
            textBox1.Text += '童';
        }

        private void button_B76_Click(object sender, EventArgs e)
        {
            textBox1.Text += '道';
        }

        private void button_B77_Click(object sender, EventArgs e)
        {
            textBox1.Text += '働';
        }

        private void button_B78_Click(object sender, EventArgs e)
        {
            textBox1.Text += '直';
        }

        private void button_B79_Click(object sender, EventArgs e)
        {
            textBox1.Text += '特';
        }

        private void button_B7A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '得';
        }

        private void button_B7B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '毒';
        }

        private void button_B7C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '読';
        }

        private void button_B7D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '内';
        }

        private void button_B7E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '南';
        }

        private void button_B7F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '二';
        }

        private void button_B7G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '肉';
        }

        private void button_B7H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '日';
        }

        private void button_B7I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '入';
        }

        private void button_B80_Click(object sender, EventArgs e)
        {
            textBox1.Text += '友';
        }

        private void button_B81_Click(object sender, EventArgs e)
        {
            textBox1.Text += '熱';
        }

        private void button_B82_Click(object sender, EventArgs e)
        {
            textBox1.Text += '年';
        }

        private void button_B83_Click(object sender, EventArgs e)
        {
            textBox1.Text += '念';
        }

        private void button_B84_Click(object sender, EventArgs e)
        {
            textBox1.Text += '農';
        }

        private void button_B85_Click(object sender, EventArgs e)
        {
            textBox1.Text += '八';
        }

        private void button_B86_Click(object sender, EventArgs e)
        {
            textBox1.Text += '波';
        }

        private void button_B87_Click(object sender, EventArgs e)
        {
            textBox1.Text += '馬';
        }

        private void button_B88_Click(object sender, EventArgs e)
        {
            textBox1.Text += '配';
        }

        private void button_B89_Click(object sender, EventArgs e)
        {
            textBox1.Text += '敗';
        }

        private void button_B8A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '売';
        }

        private void button_B8B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '貝';
        }

        private void button_B8C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '倍';
        }

        private void button_B8D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '梅';
        }

        private void button_B8E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '買';
        }

        private void button_B8F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '白';
        }

        private void button_B8G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '百';
        }

        private void button_B8H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '博';
        }

        private void button_B8I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '麦';
        }

        private void button_B90_Click(object sender, EventArgs e)
        {
            textBox1.Text += '畑';
        }

        private void button_B91_Click(object sender, EventArgs e)
        {
            textBox1.Text += '発';
        }

        private void button_B92_Click(object sender, EventArgs e)
        {
            textBox1.Text += '反';
        }

        private void button_B93_Click(object sender, EventArgs e)
        {
            textBox1.Text += '半';
        }

        private void button_B94_Click(object sender, EventArgs e)
        {
            textBox1.Text += '坂';
        }

        private void button_B95_Click(object sender, EventArgs e)
        {
            textBox1.Text += '板';
        }

        private void button_B96_Click(object sender, EventArgs e)
        {
            textBox1.Text += '飯';
        }

        private void button_B97_Click(object sender, EventArgs e)
        {
            textBox1.Text += '番';
        }

        private void button_B98_Click(object sender, EventArgs e)
        {
            textBox1.Text += '皮';
        }

        private void button_B99_Click(object sender, EventArgs e)
        {
            textBox1.Text += '飛';
        }

        private void button_B9A_Click(object sender, EventArgs e)
        {
            textBox1.Text += '悲';
        }

        private void button_B9B_Click(object sender, EventArgs e)
        {
            textBox1.Text += '費';
        }

        private void button_B9C_Click(object sender, EventArgs e)
        {
            textBox1.Text += '美';
        }

        private void button_B9D_Click(object sender, EventArgs e)
        {
            textBox1.Text += '鼻';
        }

        private void button_B9E_Click(object sender, EventArgs e)
        {
            textBox1.Text += '必';
        }

        private void button_B9F_Click(object sender, EventArgs e)
        {
            textBox1.Text += '筆';
        }

        private void button_B9G_Click(object sender, EventArgs e)
        {
            textBox1.Text += '品';
        }

        private void button_B9H_Click(object sender, EventArgs e)
        {
            textBox1.Text += '不';
        }

        private void button_B9I_Click(object sender, EventArgs e)
        {
            textBox1.Text += '夫';
        }

        private void button_BA0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '父';
        }

        private void button_BA1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '付';
        }

        private void button_BA2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '府';
        }

        private void button_BA3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '負';
        }

        private void button_BA4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '風';
        }

        private void button_BA5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '部';
        }

        private void button_BA6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '服';
        }

        private void button_BA7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '副';
        }

        private void button_BA8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '福';
        }

        private void button_BA9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '物';
        }

        private void button_BAA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '粉';
        }

        private void button_BAB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '分';
        }

        private void button_BAC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '文';
        }

        private void button_BAD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '聞';
        }

        private void button_BAE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '平';
        }

        private void button_BAF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '兵';
        }

        private void button_BAG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '皿';
        }

        private void button_BAH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '米';
        }

        private void button_BAI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '別';
        }

        private void button_BB0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '辺';
        }

        private void button_BB1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '返';
        }

        private void button_BB2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '変';
        }

        private void button_BB3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '便';
        }

        private void button_BB4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '勉';
        }

        private void button_BB5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '方';
        }

        private void button_BB6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '包';
        }

        private void button_BB7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '氷';
        }

        private void button_BB8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '放';
        }

        private void button_BB9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '歩';
        }

        private void button_BBA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '法';
        }

        private void button_BBB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '表';
        }

        private void button_BBC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '票';
        }

        private void button_BBD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '標';
        }

        private void button_BBE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '母';
        }

        private void button_BBF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '秒';
        }

        private void button_BBG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '病';
        }

        private void button_BBH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '望';
        }

        private void button_BBI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '北';
        }

        private void button_BC0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '木';
        }

        private void button_BC1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '牧';
        }

        private void button_BC2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '本';
        }

        private void button_BC3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '毎';
        }

        private void button_BC4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '妹';
        }

        private void button_BC5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '脈';
        }

        private void button_BC6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '末';
        }

        private void button_BC7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '万';
        }

        private void button_BC8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '満';
        }

        private void button_BC9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '未';
        }

        private void button_BCA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '味';
        }

        private void button_BCB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '民';
        }

        private void button_BCC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '無';
        }

        private void button_BCD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '名';
        }

        private void button_BCE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '命';
        }

        private void button_BCF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '明';
        }

        private void button_BCG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '鳴';
        }

        private void button_BCH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '面';
        }

        private void button_BCI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '毛';
        }

        private void button_BD0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '目';
        }

        private void button_BD1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '門';
        }

        private void button_BD2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '問';
        }

        private void button_BD3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '来';
        }

        private void button_BD4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '落';
        }

        private void button_BD5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '利';
        }

        private void button_BD6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '里';
        }

        private void button_BD7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '理';
        }

        private void button_BD8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '陸';
        }

        private void button_BD9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '立';
        }

        private void button_BDA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '林';
        }

        private void button_BDB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '輪';
        }

        private void button_BDC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '流';
        }

        private void button_BDD_Click(object sender, EventArgs e)
        {
            textBox1.Text += '類';
        }

        private void button_BDE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '令';
        }

        private void button_BDF_Click(object sender, EventArgs e)
        {
            textBox1.Text += '礼';
        }

        private void button_BDG_Click(object sender, EventArgs e)
        {
            textBox1.Text += '冷';
        }

        private void button_BDH_Click(object sender, EventArgs e)
        {
            textBox1.Text += '例';
        }

        private void button_BDI_Click(object sender, EventArgs e)
        {
            textBox1.Text += '歴';
        }

        private void button_BE0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '列';
        }

        private void button_BE1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '連';
        }

        private void button_BE2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '練';
        }

        private void button_BE3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '口';
        }

        private void button_BE4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '両';
        }

        private void button_BE5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '老';
        }

        private void button_BE6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '労';
        }

        private void button_BE7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '良';
        }

        private void button_BE8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '料';
        }

        private void button_BE9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '旅';
        }

        private void button_BEA_Click(object sender, EventArgs e)
        {
            textBox1.Text += '量';
        }

        private void button_BEB_Click(object sender, EventArgs e)
        {
            textBox1.Text += '路';
        }

        private void button_BEC_Click(object sender, EventArgs e)
        {
            textBox1.Text += '六';
        }

        private void button_BED_Click(object sender, EventArgs e)
        {
            textBox1.Text += '緑';
        }

        private void button_BEE_Click(object sender, EventArgs e)
        {
            textBox1.Text += '録';
        }
    }
}

