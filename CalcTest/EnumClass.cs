
/// <summary>
/// 列挙体
/// </summary>
namespace CalcTest
{
    /// <summary>
    /// 数字キー
    /// </summary>
    public enum NumKeyCode
    {
        Num0 = 0, Num1 = 1, Num2 = 2, Num3 = 3, Num4 = 4,
        Num5 = 5, Num6 = 6, Num7 = 7, Num8 = 8, Num9 = 9,
    }
    /// <summary>
    /// 演算キー
    /// </summary>
    public enum CalcKeyCode
    {
        None = 0,
        Sum = 1,
        Diff = 2,
        Pro = 3,
        Quoti = 4,
        Equals = 5
    }
    partial class CalcProperty
    {
        //演算キー１
        public CalcKeyCode CalcKeyMem1 { get; set; }
        //演算キー２
        public CalcKeyCode CalcKeyMem2 { get; set; }

    }
}
