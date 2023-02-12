using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.Solve();

  static void Solve() {
    FullSearch();
  }

  static void FullSearch() {
    Input input = new Input();
    int[] Ar1 = input.GetIntArray();
    int N = Ar1[0], S = Ar1[1];

    int[] A = input.GetIntArray();

    // bit全探索を使う
    for (long i = 0; i < (2 << N); i++) {
      long tmp = 0;
      for (int j = 0; j < N; j++) { // j+1枚目の選択を表す
       	if ((i & (1 << j)) != 0) tmp += A[j];
      }
      if (tmp == S) {
        Console.WriteLine("Yes");
        return;
      }
    }
    Console.WriteLine("No");
  }
}

class Input {
  public int GetInt() {
    return int.Parse(Console.ReadLine());
  }

  public int[] GetIntArray() {
    return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
  }

  public string GetString() {
    return Console.ReadLine();
  }

}
