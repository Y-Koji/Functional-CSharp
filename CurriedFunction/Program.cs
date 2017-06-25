using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriedFunction
{
    /// <summary>
    /// C#でカリー化をしてみる
    /// カリー化: 複数の引数がある関数の一部の引数を任意の値で束縛した
    /// 新しい関数を生成する機能
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            // 引数にxとyを受け取って「x + y」の演算を行う関数
            Func<int, Func<int, int>> f = x => y => x + y;
            // xに10を定義した関数を生成
            Func<int, int> g = f(10);
            // xに50を定義した関数を生成
            Func<int, int> h = f(50);

            Console.WriteLine("定義");
            Console.WriteLine("f = int -> (int -> int)");
            Console.WriteLine("g = f(10) = int -> int");
            Console.WriteLine("h = f(50) = int -> int");

            Console.WriteLine();

            // それぞれの関数を実行してみる
            Console.WriteLine($"f(10)(20) = {f(10)(20)}");
            Console.WriteLine($"g(50) = {g(50)}");
            Console.WriteLine($"h(100) = {h(100)}");

            Console.ReadLine();
        }
    }
}
