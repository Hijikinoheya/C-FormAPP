using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;


namespace YukiFormAPP
{

    public partial class Form1 : Form
    {
        private int count;
        private object proc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Make with Microsoft Vsual Studio Code 2019 C# Lang.");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) => MessageBox.Show("Thank You");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YukiAPP Test Ver 0.4." +
                "");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Hisaki714/FormAPP-Test-");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!!");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // whileで無限ループする
            while (true)
            {
                //MessageBox.Show("負担中...");
                if (count == 8)
                {
                    // ループを抜ける
                    break;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't push!!");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Hello.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("This is a RAID of HDD,SSD");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
                    }

        private void button4_Click(object sender, EventArgs e)
        {
            //object p = proc.Kill();
            // 実行中のすべてのプロセスを取得する
            System.Diagnostics.Process[] hProcesses = System.Diagnostics.Process.GetProcesses();

            // コンピュータ名を指定すると、別のコンピュータのプロセスが取得可能です
            //hProcesses = System.Diagnostics.Process.GetProcesses("MachineName");

            string stPrompt = string.Empty;

            // 取得できたプロセスからプロセス名を取得する
            foreach (System.Diagnostics.Process hProcess in hProcesses)
            {
                stPrompt += hProcess.ProcessName + System.Environment.NewLine;
            }

            // 実行中のすべてのプロセス名を表示する
            MessageBox.Show(stPrompt);
        }
    }
}
