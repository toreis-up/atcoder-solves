using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] Ar = input.getIntArray();

    int N = Ar[0];
    int X = Ar[1];
    int Y = Ar[2];

    int count = 0;

    for (int i = 1; i <= N; i++) {
      if (i % X == 0 || i % Y == 0) count += 1;
    }

    Console.WriteLine(count);
  }
}

class Input {
  public int getInt() {
    return int.Parse(Console.ReadLine());
  }

  public int[] getIntArray() {
    return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
  }
}
