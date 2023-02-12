using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] tAr = input.getIntArray();
    int N =tAr[0], M = tAr[1];
    int[] retAr = new int[M];
    if (M > 0) retAr = input.getIntArray();
    for (int i = 0; i < N; i++) {
      i+=reten(i + 1, retAr) - 1;
    }
  }

  static int reten(int num, int[] retAr) {
    int cnt = 1;
    if (retAr.Contains(num)) {
      cnt += reten(num+1, retAr);
    }
    Console.Write(num + " ");
    return cnt;
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
