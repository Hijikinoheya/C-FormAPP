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
            MessageBox.Show("YukiAPP Test Ver 0.5." +
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

        private void button6_Click(object sender, EventArgs e)
        {
            // OpenFileDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // ダイアログのタイトルを設定する
            openFileDialog1.Title = "OpenFile";

            // 初期表示するディレクトリを設定する
            openFileDialog1.InitialDirectory = @"C:\";

            // 初期表示するファイル名を設定する
            openFileDialog1.FileName = "Hello!";

            // ファイルのフィルタを設定する
            openFileDialog1.Filter = "テキスト ファイル|*.txt;*.log|すべてのファイル|*.*";

            // ファイルの種類 の初期設定を 2 番目に設定する (初期値 1)
            openFileDialog1.FilterIndex = 2;

            // ダイアログボックスを閉じる前に現在のディレクトリを復元する (初期値 false)
            openFileDialog1.RestoreDirectory = true;

            // 複数のファイルを選択可能にする (初期値 false)
            openFileDialog1.Multiselect = true;

            // [ヘルプ] ボタンを表示する (初期値 false)
            openFileDialog1.ShowHelp = true;

            // [読み取り専用] チェックボックスを表示する (初期値 false)
            openFileDialog1.ShowReadOnly = true;

            // [読み取り専用] チェックボックスをオンにする (初期値 false)
            openFileDialog1.ReadOnlyChecked = true;

            // 存在しないファイルを指定した場合は警告を表示する (初期値 true)
            //openFileDialog1.CheckFileExists = true;

            // 存在しないパスを指定した場合は警告を表示する (初期値 true)
            //openFileDialog1.CheckPathExists = true;

            // 拡張子を指定しない場合は自動的に拡張子を付加する (初期値 true)
            //openFileDialog1.AddExtension = true;

            // 有効な Win32 ファイル名だけを受け入れるようにする (初期値 true)
            //openFileDialog1.ValidateNames = true;

            // ダイアログを表示し、戻り値が [OK] の場合は、選択したファイルを表示する
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);

                // Multiselect が true の場合はこのように列挙する
                //foreach (string nFileName in openFileDialog1.FileNames) {
                //    MessageBox.Show(nFileName);
                //}
            }

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            openFileDialog1.Dispose();
        }

        private void 名前を付けて保存_Click(object sender, EventArgs e)
        {
            // SaveFileDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // ダイアログのタイトルを設定する
            saveFileDialog1.Title = "名前を付けて保存";

            // 初期表示するディレクトリを設定する
            saveFileDialog1.InitialDirectory = @"C:\";

            // 初期表示するファイル名を設定する
            saveFileDialog1.FileName = "Hello.txt";

            // ファイルのフィルタを設定する
            saveFileDialog1.Filter = "テキスト ファイル|*.txt;*.log|すべてのファイル|*.*";

            // ファイルの種類 の初期設定を 2 番目に設定する (初期値 1)
            saveFileDialog1.FilterIndex = 2;

            // ダイアログボックスを閉じる前に現在のディレクトリを復元する (初期値 false)
            saveFileDialog1.RestoreDirectory = true;

            // [ヘルプ] ボタンを表示する (初期値 false)
            saveFileDialog1.ShowHelp = true;

            // 存在しないファイルを指定した場合は、
            // 新しく作成するかどうかの問い合わせを表示する (初期値 false)
            saveFileDialog1.CreatePrompt = true;

            // 存在しているファイルを指定した場合は、
            // 上書きするかどうかの問い合わせを表示する (初期値 true)
            //saveFileDialog1.OverwritePrompt = true;

            // 存在しないファイル名を指定した場合は警告を表示する (初期値 false)
            //saveFileDialog1.CheckFileExists = true;

            // 存在しないパスを指定した場合は警告を表示する (初期値 true)
            //saveFileDialog1.CheckPathExists = true;

            // 拡張子を指定しない場合は自動的に拡張子を付加する (初期値 true)
            //saveFileDialog1.AddExtension = true;

            // 有効な Win32 ファイル名だけを受け入れるようにする (初期値 true)
            //saveFileDialog1.ValidateNames = true;

            // ダイアログを表示し、戻り値が [OK] の場合は、選択したファイルを表示する
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            saveFileDialog1.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // FolderBrowserDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            // ダイアログの説明を設定する
            folderBrowserDialog1.Description = "Select Folder";

            // ルートになる特殊フォルダを設定する (初期値 SpecialFolder.Desktop)
            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;

            // 初期選択するパスを設定する
            folderBrowserDialog1.SelectedPath = @"C:\Program Files\";

            // [新しいフォルダ] ボタンを表示する (初期値 true)
            //folderBrowserDialog1.ShowNewFolderButton = true;

            // ダイアログを表示し、戻り値が [OK] の場合は、選択したディレクトリを表示する
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            folderBrowserDialog1.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // PageSetupDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            PageSetupDialog pageSetupDialog1 = new PageSetupDialog();

            // PageSetting の新しいインスタンスを生成する (必須)
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();

            // [プリンタの設定] で利用するプリンタを設定する
            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();

            // 余白の最小値を設定する
            pageSetupDialog1.MinMargins = new System.Drawing.Printing.Margins(100, 100, 250, 200);

            // [用紙] セクションを有効にする (初期値 true)
            //pageSetupDialog1.AllowPaper = true;

            // [印刷の向き] セクションを有効にする (初期値 true)
            //pageSetupDialog1.AllowOrientation = true;

            // [余白] セクションを有効にする (初期値 true)
            //pageSetupDialog1.AllowMargins = true;

            // [印刷] ボタンを有効にする (初期値 true)
            //pageSetupDialog1.AllowPrinter = true;

            // [ヘルプ] ボタンを表示する (初期値 false)
            pageSetupDialog1.ShowHelp = true;

            // [ネットワーク] ボタンを表示する (初期値 true)
            //pageSetupDialog1.ShowNetwork = true;

            // ダイアログを表示し、戻り値が [OK] の場合は、何らかの処理を実行する
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("ここに、ページ設定終了後の処理を実装してください");
            }

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            pageSetupDialog1.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // PrintPreviewDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

            // PrintDocument の新しいインスタンスを生成する
            // 実際に実装する場合は、完成した PrintDocument を設定するようにしてください
            // ここでは、空の PrintDocument を使っています
            printPreviewDialog1.Document = new System.Drawing.Printing.PrintDocument();

            // System.Windows.Forms.Form からの派生なので Form にあるプロパティなどが使えます
            // ウィンドウのタイトルを設定する
            printPreviewDialog1.Text = "ここにタイトルを書いてください";

            // 最小化ボタンを表示する
            printPreviewDialog1.MinimizeBox = true;

            // 最大化で表示する
            printPreviewDialog1.WindowState = FormWindowState.Maximized;

            // ダイアログを表示する
            printPreviewDialog1.Show();

            // モーダルで表示したい場合
            //printPreviewDialog1.ShowDialog();

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            printPreviewDialog1.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {


        }
    }
}
