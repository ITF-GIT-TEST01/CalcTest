using System;
using System.Collections.Generic;
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

            BtnEnable();
        }

        #region 数字ボタンイベント
        private void Num1_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num1);
        }
        private void Num2_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num2);
        }
        private void Num3_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num3);
        }
        private void Num4_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num4);
        }
        private void Num5_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num5);
        }
        private void Num6_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num6);
        }
        private void Num7_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num7);
        }
        private void Num8_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num8);
        }
        private void Num9_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num9);
        }
        private void Num0_Click(object sender, EventArgs e)
        {
            BtnEnable();
            logic.DispNumLogic(MainDisp, NumKeyCode.Num0);
        }
        #endregion

        #region 演算ボタンイベント
        private void Sum_Click(object sender, EventArgs e)
        {
            BtnEnable(logic.CalcMain(MainDisp, CalcKeyCode.Sum));
        }
        private void Diff_Click(object sender, EventArgs e)
        {
            BtnEnable(logic.CalcMain(MainDisp, CalcKeyCode.Diff));
        }
        private void Pro_Click(object sender, EventArgs e)
        {
            BtnEnable(logic.CalcMain(MainDisp, CalcKeyCode.Pro));
        }
        private void Quoti_Click(object sender, EventArgs e)
        {
            BtnEnable(logic.CalcMain(MainDisp, CalcKeyCode.Quoti));
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            BtnEnable();
            BtnEnable(logic.CalcMain(MainDisp, CalcKeyCode.Equals));
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

        #region キーダウンイベント
        /// <summary>
        /// キーダウンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCalc_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                //数字キー
                case Keys.NumPad0:
                case Keys.D0:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num0);
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num1);
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num2);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num3);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num4);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num5);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num6);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num7);
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num8);
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    logic.DispNumLogic(MainDisp, NumKeyCode.Num9);
                    break;

                //演算キー
                case Keys.Add:
                case Keys.Oemplus | Keys.Shift:
                    logic.CalcMain(MainDisp, CalcKeyCode.Sum);
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    logic.CalcMain(MainDisp, CalcKeyCode.Diff);
                    break;
                case Keys.Multiply:
                case Keys.Oem1 | Keys.Shift:
                    logic.CalcMain(MainDisp, CalcKeyCode.Pro);
                    break;
                case Keys.Divide:
                case Keys.Oem2:
                    logic.CalcMain(MainDisp, CalcKeyCode.Quoti);
                    break;

                default:
                    break;
            }
        }
        #endregion


        #region 内部処理
        /// <summary>
        /// 画面表示時にフォーカスを枠外のダミーに飛ばす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCalc_Load(object sender, EventArgs e)
        {
            ActiveControl = Dummy;
        }
        /// <summary>
        /// 演算ボタン活性非活性制御処理
        /// </summary>
        /// <param name="Enable"></param>
        private void BtnEnable(bool Enable = true)
        {
            Sum.Enabled = Enable;
            Diff.Enabled = Enable;
            Pro.Enabled = Enable;
            Quoti.Enabled = Enable;
        }
        #endregion


    }
}
