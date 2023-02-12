using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] Ar = input.getIntArray();

    int N = Ar[0], S = Ar[1];

    int Ans = 0;
    
    for (int i = 1; i <= N; i++) {
      for (int j = 1; j <= N; j++) {
        if (i + j <= S) Ans++;
      }
    }

    Console.WriteLine(Ans);
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
