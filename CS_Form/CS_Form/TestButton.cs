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
        public TestButton(int x, int y)
        {
            //ClickイベントにOnClick関数を登録
            Click += OnClick;
            //ボタン内に文字を表示させる
            Text = "ボタン";
            Location = new Point(x,y);
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("しじみ");
        }
    }
}
