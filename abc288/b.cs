using System;
using System.Linq;
using System.Collections.Generic;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] Ar = input.getIntArray();
    int N = Ar[0], K = Ar[1];
    List<String> list = new List<String>();

    for (int i = 0; i < K; i++) {
      list.Add(input.getString());
    }

    list.Sort();
    sort(list);

    for (int i = 0; i < K; i++) {
      Console.WriteLine(list[i]);
    }
  }

  static void sort(List<String> list) {
    for (int i = 0; i < list.Count - 1; i++) {
      if (list[i + 1].Contains(list[i]) && list[i+1].Length > list[i].Length) {
        string tmp = list[i + 1];
        list[i + 1] = list[i];
        list[i] = tmp;
      }
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
