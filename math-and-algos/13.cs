using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    long N = input.getLong();

    for (long i = 1; i * i <= N; i++) {
      if (N % i == 0) {
        Console.WriteLine(i); // Nを割り切ったならiはNの約数
        if (i != N / i) // i * i = Nならiだけしか出力しないフィルター
          Console.WriteLine(N / i);
      }
    }
  }
}

class Input {
  public int getInt() {
    return int.Parse(Console.ReadLine());
  }

  public long getLong() {
    return long.Parse(Console.ReadLine());
  }

  public int[] getIntArray() {
    return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
  }

  public string getString() {
    return Console.ReadLine();
  }

}
