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

        private void Chen_modify_Click(object sender, EventArgs e)
        {
            string foldername;
            int i = 1;
            foreach (ListViewItem item in this.folder_listView.Items)
            {
                if (i < 10)
                {
                    foldername = '0'+i.ToString();
                }
                else
                {
                    foldername =  i.ToString();
                }
                item.SubItems[1].Text = foldername + item.SubItems[1].Text.Remove(0, 2);
                i++;
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
