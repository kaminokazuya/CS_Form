using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        TestTextBox _textBox;

        TestButton _testButton;
        public Form1()
        {
            InitializeComponent();

            string[] strs =
            {
                "あ",
                "い",
                "う",
                "え",
                "お",
                "か",
                "き",
                "く",
                "け",
                "こ",

            };
           
            
            for (int i = 0; i < 10; i++)
            {
                _testButton = new TestButton(this,_textBox, strs[i],(i%5)*100, (i/5)*100, 100, 100);
                Controls.Add(_testButton);
            }

            _testLabel = new TestLabel("らべるです。",10,300,100,500);

            Controls.Add(_testLabel);
            //テキストボックスの作成
            _textBox = new TestTextBox("テキストボックスです", 10, 300, 500, 100);

            Controls.Add(_textBox);
            /*
            Label label = new Label();
            label.Location = new Point(30, 400);
            label.Text = "ラベルです。";
            Controls.Add(label);
            */
        }

        /// <summary>
        /// ラベルの文字を更新
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

        public void TestButtonUpdate(string str)
        {
            _testButton.TextUpdate(str);
        }

        public void TestTextUpdate(string str)
        {
            _textBox.TextUpdate(str);
        }

     
    }
}
