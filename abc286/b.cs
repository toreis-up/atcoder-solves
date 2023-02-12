using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    _ = input.getInt();
    string S = input.getString();
    string ans = S.Replace("na", "nya");
    Console.WriteLine(ans);
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
