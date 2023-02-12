using System;
using System.Linq;
using System.Collections.Generic;

/*
  bit全探索
*/

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] tAr = input.getIntArray();
    int N = tAr[0], M = tAr[1];

    List<List<int>> list = new List<List<int>>();

    for (int i = 0; i < M; i++) {
      list.Add(new List<int>());
      int C = input.getInt();
      int[] Ar = input.getIntArray();
      for (int j = 0; j < C; j++) {
        list[i].Add(Ar[j]);
      }
    }

    int answer = 0;

    for (int i = 0; i < (1 << M); i++) { // 集合(M)の選び方
      bool[] tmp = new bool[N];
      for (int j = 0; j < M; j++) {
        if ((i & (1 << j)) != 0) {
          for (int k = 0; k < list[j].Count; k++) {
            Console.WriteLine(list[j][k] - 1);
            tmp[list[j][k] - 1] = true;
          }
        }
      }
      Console.WriteLine();
      int tAns = 1;
      for (int j = 0; j < N; j++) {
        if (!tmp[j]) {
          tAns = 0;
        }
      }
      answer += tAns;
    }

    Console.WriteLine(answer);
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
