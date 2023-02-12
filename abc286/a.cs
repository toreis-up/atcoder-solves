using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] npqrs = input.getIntArray();
    int N = npqrs[0];
    int[] Ar = input.getIntArray();
    for (int i = 0; i < N; i++) {
      if (i == p) {
        int diff = npqrs[2] - npqrs[1];
        for (int j = 0; j < diff; j++) {
          Console.Write(i + j);
        }
        i += diff;
      }
      if (i == r) {
        int diff = npqrs[4] - npqrs[3];
        for (int j = 0; j < diff; j++) {
          Console.Write(i + j);
        }
        i += diff;
      }
      else Console.Write("{0} ", Ar[i]);
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
