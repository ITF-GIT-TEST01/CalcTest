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
            double res;
            //演算キー押下後の処理
            if (Prop.CalcPush == true)
            {
                if (double.TryParse(md.Text, out res))
                {
                    Prop.Result = res;
                }
                md.Text = "";
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
                        //表示が０の時は画面クリア
                        md.Text = "";
                    }
                    break;
            }
            //メインディスプレイに数字を表示
            md.Text += ((int)keycode).ToString();
            //計算用入力値確保
            if (double.TryParse(md.Text, out res))
            {
                Prop.InputNum = res;
            }
        }
        #endregion

        #region 計算処理
        /// <summary>
        /// 計算処理
        /// </summary>
        /// <param name="md">メインディスプレイTextBox</param>
        /// <param name="keyCode">演算キー</param>
        public void CalcMain(TextBox md, CalcKeyCode keyCode)
        {
            //前回の計算結果を左辺にシフト
            Prop.MemNum = Prop.Result;
            //前回押下された演算キーをシフト
            Prop.CalcKeyMem2 = Prop.CalcKeyMem1;

            if (keyCode != CalcKeyCode.Equals)
            {
                //今回押下された演算キーを記憶
                Prop.CalcKeyMem1 = keyCode;
            }
            //演算キー連続押下はイコール以外は計算しない
            if (Prop.CalcPush != true || keyCode == CalcKeyCode.Equals)
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
                        md.Text = "0で割ることはできません";
                        Prop = new CalcProperty();
                        return;
                    //除算
                    case CalcKeyCode.Quoti:
                        Prop.Result = Prop.MemNum / Prop.InputNum;
                        if (double.IsNaN(Prop.Result))
                        {
                            //演算結果が非数の場合０
                            Prop.Result = 0;
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

            md.Text = Prop.Result.ToString();

            //演算キー押下フラグON
            Prop.CalcPush = true;

        }
        #endregion

        #region クリア、クリアエントリー
        /// <summary>
        /// クリアキー
        /// </summary>
        /// <param name="md">メインディスプレイTextBox</param>
        public void Clear(TextBox md)
        {
            //プロパティ初期化
            Prop = new CalcProperty();
            md.Text = "0";
        }
        /// <summary>
        /// ＣＥキー
        /// </summary>
        /// <param name="md">メインディスプレイTextBox</param>
        public void ClearEntry(TextBox md)
        {
            md.Text = "0";
            Prop.InputNum = 0;
        }
        #endregion
    }
    #endregion

}
