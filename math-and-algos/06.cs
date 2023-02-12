using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();
  
  static void solve() {
    Input input = new Input();
    int N = input.getInt();
    Console.WriteLine(N * 2 + 3);
  }
}
                      
class Input {
  public int getInt() {
    return int.Parse(Console.ReadLine());
  }
}