using System;
using System.Linq;
using System.Collections.Generic;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    long N = input.getLong();

    List<int> ans = new List<int>();
    h(N, ans);

    foreach (var item in ans)
    {
      Console.Write(item+ " ");
    }
  }

  static void h(long N, List<int> list) {
    if (isPrime(N)) {
      list.add(N);
      return;
    }
    else {
      long T = calc(N);
      list.add(T);
      return h(N / T);
    }
  }

  static long calc(long N) {
    for (int i = 2; i <= Math.Sqrt(N); i++) {
      if (N % i == 0) return i;
    }
  }

    static bool isPrime(long N) {
    for (long i = 2; i * i <= N; i++) {
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

  public long getLong() {
    return long.Parse(Console.ReadLine());
  }

  public string getString() {
    return Console.ReadLine();
  }


}
