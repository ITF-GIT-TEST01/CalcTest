using System;
using System.Windows.Forms;

namespace CalcTest
{
    public partial class frmCalc : Form
    {
        /// <summary>
        /// 処理クラス
        /// </summary>
        private readonly Logic logic;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmCalc()
        {
            //自動生成
            InitializeComponent();
            //メインロジックインスタンス
            logic = new Logic();
            //初期化
            MainDisp.Text = "0";
        }

        #region 数字ボタンイベント
        private void Num1_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num1);
        }
        private void Num2_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num2);
        }
        private void Num3_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num3);
        }
        private void Num4_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num4);
        }
        private void Num5_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num5);
        }
        private void Num6_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num6);
        }
        private void Num7_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num7);
        }
        private void Num8_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num8);
        }
        private void Num9_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num9);
        }
        private void Num0_Click(object sender, EventArgs e)
        {
            logic.DispNumLogic(MainDisp, NumKeyCode.Num0);
        }
        #endregion

        #region 演算ボタンイベント
        private void Sum_Click(object sender, EventArgs e)
        {
            logic.CalcMain(MainDisp, CalcKeyCode.Sum);
        }
        private void Diff_Click(object sender, EventArgs e)
        {
            logic.CalcMain(MainDisp, CalcKeyCode.Diff);
        }
        private void Pro_Click(object sender, EventArgs e)
        {
            logic.CalcMain(MainDisp, CalcKeyCode.Pro);
        }
        private void Quoti_Click(object sender, EventArgs e)
        {
            logic.CalcMain(MainDisp, CalcKeyCode.Quoti);
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            logic.CalcMain(MainDisp, CalcKeyCode.Equals);
        }
        #endregion

        #region クリアボタンイベント
        private void Clear_Click(object sender, EventArgs e)
        {
            logic.Clear(MainDisp);
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            logic.ClearEntry(MainDisp);
        }
        #endregion

        #region 小数点ボタンイベント
        private void Dot_Click(object sender, EventArgs e)
        {
            logic.Dot(MainDisp);
        }
        #endregion

        #region 符号ボタンイベント
        private void PorM_Click(object sender, EventArgs e)
        {
            logic.PorM(MainDisp);
        }
        #endregion
    }
}
