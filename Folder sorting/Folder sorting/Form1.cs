using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folder_sorting
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void openfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folder_listView.Items.Clear();
                path = dialog.SelectedPath;
                DirectoryInfo root = new DirectoryInfo(path);
         
                foreach (DirectoryInfo dChild in root.GetDirectories("*"))
                {

                    ListViewItem lvi = new ListViewItem();

                    lvi.Text = dChild.Name;

                    lvi.SubItems.Add(dChild.Name);

                    this.folder_listView.Items.Add(lvi);
                }
            }
        }

        private int DisplayLength(string str)
        {
            int lengthCount = 0;
            var splits = str.ToCharArray();
            for (int i = 0; i < splits.Length; i++)
            {
                if (splits[i] == '\t')
                {
                    lengthCount += 8 - lengthCount % 8;
                }
                else
                {
                    lengthCount += Encoding.GetEncoding("GBK").GetByteCount(splits[i].ToString());
                }
            }
            return lengthCount;
        }

        private void Chen_modify_Click(object sender, EventArgs e)
        {
            string foldername;
            string[] stringname = new string[100];
            int num;
            string str,str1;
            num = 0;
            foreach (ListViewItem item in this.folder_listView.Items)
            {
                stringname[num++] = item.SubItems[1].Text;
            }
            for (int i = 0; i < num-1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                {
                    if (DisplayLength(stringname[j]) > DisplayLength(stringname[j+1]))
                    {
                        str = stringname[j];
                        stringname[j] = stringname[j + 1];
                        stringname[j + 1] = str;
                    }
                }
            }

            int q = 0;
            foreach (ListViewItem item in this.folder_listView.Items)
            {

                for (q = 0; q < num; q++)
                {
                    if (item.SubItems[1].Text == stringname[q])
                        break;
                }

                if (q < 10)
                {
                    foldername = '0'+q.ToString();
                }
                else
                {
                    foldername =  q.ToString();
                }
                if (item.SubItems[1].Text.Length > 2)
                {
                    str = item.SubItems[1].Text.Substring(2, 1);
                    if (str != "-")
                    {
                        item.SubItems[1].Text = foldername + "-" + item.SubItems[1].Text;
                    }
                    else
                    {
                        item.SubItems[1].Text = foldername + item.SubItems[1].Text.Remove(0, 2);
                    }
                }
                else
                {
                    item.SubItems[1].Text = foldername + "-" + item.SubItems[1].Text;
                }
                q++;
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            string foldername;
            foreach (ListViewItem item in this.folder_listView.Items)
            {
                foldername = item.SubItems[0].Text;

                DirectoryInfo root = new DirectoryInfo(path);
                foreach (DirectoryInfo dChild in root.GetDirectories("*"))
                {
                    if(dChild.Name == foldername)
                    {
                        if (item.SubItems[0].Text != item.SubItems[1].Text)
                        {
                            Directory.Move(path + "\\" + item.SubItems[0].Text, path + "\\" + item.SubItems[1].Text);
                        }
                    }
                }
            }
            MessageBox.Show("修改完毕", "提示");
        }

        private void Current_folder_Click(object sender, EventArgs e)
        {
            folder_listView.Items.Clear();
            path = Directory.GetCurrentDirectory();
            DirectoryInfo root = new DirectoryInfo(path);

            foreach (DirectoryInfo dChild in root.GetDirectories("*"))
            {

                ListViewItem lvi = new ListViewItem();

                lvi.Text = dChild.Name;

                lvi.SubItems.Add(dChild.Name);

                this.folder_listView.Items.Add(lvi);
            }
        }

        private void folder_listView_Click(object sender, EventArgs e)
        {
            string sPID;
            sPID = folder_listView.SelectedItems[0].SubItems[1].Text;//第2列
        }
    }
}
