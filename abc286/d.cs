using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] NX = input.getIntArray();
    int N = NX[0], X = NX[1];
    int[,] coins = new int[N,2];
    int coinsum = 0;
    for (int i = 0; i < N; i++) {
      int[] tAr = input.getIntArray();
      coins[i,0] = tAr[0];
      coins[i,1] = tAr[1];
    }
    bool[,] dp = new bool[N+1, X+1]; 

    dp[0,0] = true; // 0なので到達できる
    for (int i = 0; i < N; i++) {
      for (int j = 0; j <= X; j++) {
        for (int k = 0; k <= coins[i, 1]; k++) { // とる、取らないかぎらない
          if (j >= coins[i, 0] * k) {
            if (dp[i, j-coins[i, 0] * k]) {
              dp[i+1, j] = true;
            }
          }
        }
      }
    }
    /*for (int i = 0; i < N; i++) {
      for (int j = 0; j <= X; j++) {
        Console.Write("{0}\t", dp[i, j]);
      }
      Console.WriteLine();
    }*/
    if (dp[N,X]) {
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
