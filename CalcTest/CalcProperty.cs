using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTest
{
    /// <summary>
    /// プロパティクラス
    /// </summary>
    partial class CalcProperty
    {
        //入力数値
        public double InputNum { get; set; }
        //数値記憶
        public double MemNum { get; set; }
        //演算結果
        public double Result { get; set; }
        //数値キー押下フラグ
        public bool NumPush { get; set; }
        //演算キー押下フラグ
        public bool CalcPush { get; set; }
    }
}
