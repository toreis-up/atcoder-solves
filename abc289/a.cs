using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    string str = input.getString();
    for (int i = 0; i < str.Length; i++) {
      if (str.Substring(i, 1) == "0") {
        Console.Write("1");
      }else {
        Console.Write("0");
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
