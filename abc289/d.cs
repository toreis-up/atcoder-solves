using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int N = input.getInt();
    int[] A = input.getIntArray();
    int M = input.getInt();
    int[] B = input.getIntArray();
    int X = input.getInt();
    bool[] torimochi = new bool[X + 1];
    for (int i = 0; i < M; i++) {
      torimochi[B[i]] = true; // 動けなくする
    }

    bool[] dp = new bool[X + 1];

    dp[0] = true; // 0なので到達できる

    for (int i = 1; i <= X; i++) {
      for (int j = 0; j < N; j++) {
        if (i >= A[j] && !torimochi[i]) {
          if (dp[i - A[j]]) dp[i] = true;
        }
      }
    }

    if (dp[X]) {
      Console.WriteLine("Yes");
    } else {
      Console.WriteLine("No");
    }
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
