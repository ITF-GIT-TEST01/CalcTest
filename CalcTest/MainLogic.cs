using System;
using System.Windows.Forms;

namespace CalcTest
{
    #region 初期化　自動生成
    internal static class MainLogic
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCalc());
        }
    }
    #endregion

    #region メイン処理
    public class Logic
    {
        /// <summary>
        /// プロパティクラスインスタンス
        /// </summary>
        private CalcTest.CalcProperty Prop = new CalcProperty();

        #region 数字表示処理
        /// <summary>
        /// 数字表示処理
        /// </summary>
        /// <param name="md">メインディスプレイTextBox</param>
        /// <param name="keycode">数字キー</param>
        public void DispNumLogic(TextBox md, NumKeyCode keycode)
        {
            //フォームテキスト
            var dispnum = md.Text;
            //演算キー押下後の処理
            if (Prop.CalcPush == true)
            {
                if (double.TryParse(md.Text, out var res))
                {
                    Prop.Result = res;
                }
                md.Text = "";
                //演算キー押下フラグＯＦＦ
                Prop.CalcPush = false;
            }
            //数字キー押下処理
            switch (keycode)
            {
                //０押下
                case NumKeyCode.Num0:
                    if (dispnum == "0")
                    {
                        //表示が０の時は０のまま
                        md.Text = "0";
                        return;
                    }
                    break;
                //０以外
                default:
                    if (dispnum == "0" || !double.TryParse(md.Text, out _))
                    {
                        //表示が０または数値以外の時は画面クリア
                        md.Text = "";
                    }
                    break;
            }
            //メインディスプレイに数字を表示
            md.Text += ((int)keycode).ToString();
            //計算用入力値確保
            if (double.TryParse(md.Text, out var InNum))
            {
                Prop.InputNum = InNum;
            }
        }
        #endregion

        #region 計算処理
        /// <summary>
        /// 計算処理
        /// </summary>
        /// <param name="md">メインディスプレイTextBox</param>
        /// <param name="keyCode">演算キー</param>
        public bool CalcMain(TextBox md, CalcKeyCode keyCode)
        {
            //前回の計算結果を左辺にシフト
            Prop.MemNum = Prop.Result;
            //前回押下された演算キーをシフト
            Prop.CalcKeyMem2 = Prop.CalcKeyMem1;
            if (keyCode != CalcKeyCode.Equals)
            {
                //今回押下された演算キーを記憶 イコールは記憶しない
                Prop.CalcKeyMem1 = keyCode;
            }
            //演算キー連続押下はイコール以外は計算しない
            if (Prop.CalcPush == false || keyCode == CalcKeyCode.Equals)
            {
                //前回押下された演算キーで計算
                switch (Prop.CalcKeyMem2)
                {
                    //加算
                    case CalcKeyCode.Sum:
                        Prop.Result = Prop.MemNum + Prop.InputNum;
                        break;
                    //減算
                    case CalcKeyCode.Diff:
                        Prop.Result = Prop.MemNum - Prop.InputNum;
                        break;
                    //乗算
                    case CalcKeyCode.Pro:
                        Prop.Result = Prop.MemNum * Prop.InputNum;
                        break;
                    //除算　0
                    case CalcKeyCode.Quoti when Prop.InputNum == 0:
                        //0で除算
                        md.Text = "0で割ることはできません";
                        Prop = new CalcProperty();
                        return false;
                    //除算
                    case CalcKeyCode.Quoti:
                        Prop.Result = Prop.MemNum / Prop.InputNum;
                        if (double.IsNaN(Prop.Result))
                        {
                            //演算結果が非数の場合０
                            md.Text = "結果が定義されていません";
                            Prop = new CalcProperty();
                            return false;
                        }
                        break;
                    //前回押下演算キーなし
                    case CalcKeyCode.None:
                        if (double.TryParse(md.Text, out var res))
                        {
                            Prop.Result = res;
                        }
                        break;
                }
            }
            //計算結果表示
            md.Text = Prop.Result.ToString();

            //演算キー押下フラグON
            Prop.CalcPush = true;
            return true;
        }
        #endregion

        #region クリア、クリアエントリー
        /// <summary>
        /// クリアキー
        /// </summary>
        /// <param name="md">メインディスプレイTextBox</param>
        public void Clear(TextBox md)
        {
            //全ての値を初期化
            Prop = new CalcProperty();
            md.Text = "0";
        }
        /// <summary>
        /// ＣＥキー
        /// </summary>
        /// <param name="md">メインディスプレイTextBox</param>
        public void ClearEntry(TextBox md)
        {
            //入力された値を０に
            md.Text = "0";
            Prop.InputNum = 0;
        }
        #endregion

        #region 小数点ボタン
        /// <summary>
        /// 小数点ボタン
        /// </summary>
        /// <param name="md"></param>
        public void Dot(TextBox md)
        {
            if (md.Text.Contains("."))
            {
                //すでに"."が表示済みの場合表示しない
                return;
            }
            md.Text += ".";
        }
        #endregion

        #region 符号ボタン
        public void PorM(TextBox md)
        {
            if (double.TryParse(md.Text, out var val))
            {
                //符号
                val *= -1;
                //入力値と表示を変更
                Prop.InputNum = val;
                md.Text = val.ToString();
            }
        }
        #endregion
    }
    #endregion

    #region 画面制御クラス
    public class EnableControl
    {

        public void BtnEnable()
        {

        }

    }
    #endregion
}
