using System;
using System.Collections.Generic;
using WallSwitch.Properties;
using System.Windows.Forms;

namespace WallSwitch
{
    public partial class Form1 : Form
    {
        Dictionary<string, WallpaperStyle> StyleList = new Dictionary<string, WallpaperStyle>() {
            {"中央に表示", WallpaperStyle.Center },
            {"並べて表示", WallpaperStyle.Tile },
            {"拡大して表示", WallpaperStyle.Stretch },
            {"ページ縦幅に合わせる", WallpaperStyle.ResizeFit },
            {"ページ横幅に合わせる", WallpaperStyle.ResizeFill }
        };
        int disp_h, disp_w;
        string normal_path, fake_path;
        string style = "";
        Timer checker = new Timer();
        bool connect_flag = false;

        public Form1()
        {
            setting_Load();
            InitializeComponent();
            // フォームの設定
            form_Reset();
            selStyle.DisplayMember = "Key";
            selStyle.ValueMember = "Value";
            selStyle.DataSource = new BindingSource(StyleList, null);
            selStyle.SelectedValue = StyleList[style];
            // 解像度チェッカー
            checker.Interval = 300;
            checker.Tick += new EventHandler(disp_Checker);
            checker.Enabled = false;
        }

        /// <summary>
        /// 設定の読み込み＆初期化
        /// </summary>
        private void setting_Load()
        {
            disp_h = (int)Settings.Default["DispH"];
            disp_w = (int)Settings.Default["DispW"];
            if (disp_h == 0 || disp_w == 0)
            {
                disp_h = Screen.PrimaryScreen.Bounds.Height;
                disp_w = Screen.PrimaryScreen.Bounds.Width;
            }
            normal_path = (string)Settings.Default["NormalPath"];
            fake_path = (string)Settings.Default["FakePath"];
            style = (string)Settings.Default["Style"];
            if (style == "") style = "中央に表示";
        }

        /// <summary>
        /// 設定の書き込み
        /// </summary>
        private void setting_Save()
        {
            disp_h = (int)dispHeight.Value;
            disp_w = (int)dispWidth.Value;
            normal_path = normalImagePath.Text;
            fake_path = fakeImagePath.Text;
            style = ((KeyValuePair<string, WallpaperStyle>)selStyle.SelectedItem).Key;
            Settings.Default["DispH"] = disp_h;
            Settings.Default["DispW"] = disp_w;
            Settings.Default["NormalPath"] = normal_path;
            Settings.Default["FakePath"] = fake_path;
            Settings.Default["Style"] = style;
            Settings.Default.Save();
        }

        /// <summary>
        /// フォーム表示のリセット
        /// </summary>
        private void form_Reset()
        {
            dispHeight.Value = disp_h;
            dispWidth.Value = disp_w;
            normalImagePath.Text = normal_path;
            fakeImagePath.Text = fake_path;
            selStyle.SelectedValue = StyleList[style];
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            form_Reset();
            this.Visible = false;
            checker.Enabled = true;
        }

        private void normalImageSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "画像ファイル(*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            ofd.Title = "標準壁紙画像を選択してください";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK) normalImagePath.Text = ofd.FileName;
        }

        private void fakeImageSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "画像ファイル(*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            ofd.Title = "フェイク壁紙画像を選択してください";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK) fakeImagePath.Text = ofd.FileName;
        }

        private void disp_Checker(object sender, EventArgs e)
        {
            int current_w = Screen.PrimaryScreen.Bounds.Width;
            int current_h = Screen.PrimaryScreen.Bounds.Height;
            if ((current_w != disp_w || current_h != disp_h) && connect_flag == false)
            {
                Wallpaper.SetWallpaper(fake_path, StyleList[style]);
                connect_flag = true;
            }
            if (current_w == disp_w && current_h == disp_h && connect_flag == true)
            {
                Wallpaper.SetWallpaper(normal_path, StyleList[style]);
                connect_flag = false;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if(fakeImagePath.Text == "" || normalImagePath.Text == "")
            {
                MessageBox.Show("ファイルパスを正しく設定してください");
                return;
            }
            setting_Save();
            checker.Enabled = true;
            this.Visible = false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            checker.Enabled = false;
            this.Visible = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Application.Exit();
        }
    }
}
