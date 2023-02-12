using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    long N = input.getLong();

    string ans = "Yes";

    for (int i = 2; i < Math.Sqrt(N); i++) {
      if (N % i == 0) ans = "No";
    }

    Console.WriteLine(ans);
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
