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
using System.Windows.Forms.VisualStyles;

namespace 文件读写2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt(*.txt) | *.txt";//是不是这个filter只能接受最后一个文件类型？
            openFileDialog1.Title = "请选择您要打开的文件";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader fin = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = "文件路径为：\n" + openFileDialog1.FileName + "\n原文为：\n" + fin.ReadToEnd();//好像textbox不支持换行的
                    
                    fin.Close();
                }
                catch
                {
                    MessageBox.Show("读入错误！");
                }
                
            }
            
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "doc(*.doc) | *.doc  | txt(*.txt) | *.txt | docx(*.docx) | *.docx | pdf(*.pdf) | *.pdf";
            saveFileDialog1.Title = "请选择您要保存的路径和命名文件名";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter fout = new StreamWriter(saveFileDialog1.FileName);
                    fout.Write(textBox1.Text);
                    fout.Close();                    
                    MessageBox.Show("存入成功！");
                }
                catch
                {
                    MessageBox.Show("存入失败！");
                }
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
