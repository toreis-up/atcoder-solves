using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int N = input.getInt();
    
    for (int i = 2; i <= N; i++) {
      if (isPrime(i)) Console.Write(i + " ");
    }
  }
  
  static bool isPrime(int N) {
    for (int i = 2; i * i <= N; i++) {
      if (N % i == 0) return false;
    }
    return true;
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
