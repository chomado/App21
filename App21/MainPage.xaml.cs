using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace App21
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // 酒のデータを格納する配列
        ObservableCollection<string> SakeCollection = new ObservableCollection<string>();

        public MainPage()
        {
            this.InitializeComponent();

            // UI (ListView) と データの配列を、ひも付け
            this.listView.ItemsSource = SakeCollection;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var sakeName = this.textBox.Text;
            //this.listView.Items.Add(sakeName);
            SakeCollection.Add(sakeName);
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.listView.Items.Remove(this.listView.SelectedItem);

            if (this.listView.SelectedIndex > -1) // -1になるのは、消した瞬間と、ListView が新しく作られた時
            {
                // ユーザの選択したアイテム(酒)を、データ配列から消す
                this.SakeCollection.RemoveAt(this.listView.SelectedIndex);
            }
        }
    }
}
