using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();
  
  static void solve() {
    _ = Console.ReadLine();
    int[] Ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Console.WriteLine(Ar.Sum());
  }
}