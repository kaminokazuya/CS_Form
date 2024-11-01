using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_Form
{
    internal class TestButton :Button
    {
        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼びだされる
        /// </summary>
        public TestButton(int id,int x, int y, int width, int height)
        {
            //ClickイベントにOnClick関数を登録
            Click += OnClick;
            //ボタン内に文字を表示させる
            Text = id.ToString();
            //ボタンの生成位置を指定
            Location = new Point(x,y);
            //ボタンの大きさを指定
            Size = new Size(width,height);

        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);
        }
    }
}
