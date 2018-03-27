# CsWhileStatement
while文

## 処理
<dl>
  <dt>ケース１</dt>
  <dd>１～５の数字を昇順に「**だよ。」と出力する。</dd>
  <dt>ケース２</dt>
  <dd>１～５の数字を降順に「**だよ。」と出力する。</dd>
</dl>

## コード
```
using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** ケース１ **");
            var i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i + "だよ。");
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("** ケース２ **");
            i = 5;
            while (i >= 1)
            {
                Console.WriteLine(i + "だよ。");
                i--;
            }    
        }
    }
}
```

## 出力例  
```
** ケース１ **
1だよ。
2だよ。
3だよ。
4だよ。
5だよ。

** ケース２ **
5だよ。
4だよ。
3だよ。
2だよ。
1だよ。
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
