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
        
        Form1 _form1;
        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼びだされる
        /// </summary>
        public TestButton(Form1 form1, string str,int x, int y, int width, int height)
        {
            _form1 = form1;
            //ClickイベントにOnClick関数を登録
            Click += OnClick;
            //ボタン内に文字を表示させる
            Text =(str);
            //ボタンの生成位置を指定
            Location = new Point(x,y);
            //ボタンの大きさを指定
            Size = new Size(width,height);

        }

        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdate(Text);
        }

    }
}
