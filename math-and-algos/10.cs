using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int N = input.getInt();

    Console.WriteLine(fact(N));
  }

  static long fact(long N) {
    if (N == 1) return 1;
    return N * fact(N - 1);
  }
}

class Input {
  public int getInt() {
    return int.Parse(Console.ReadLine());
  }

  public int[] getIntArray() {
    return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
  }

  public string getString() {
    return Console.ReadLine();
  }

}
