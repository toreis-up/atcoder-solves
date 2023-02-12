using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int T = input.getInt();
    for (int TCount = 0; TCount < T; T++) {
      int answer = -1;
      int[] tAr = input.getIntArray();
      int N = tAr[0], M = tAr[1];
      List<List<int>> graph = new List<List<int>>();
      int[] color = input.getIntArray();
      for (int i = 0; i < M; i++) {
        graph.Add(new List<int>());
        int[] tmpAr = input.getIntArray();
        for (int j = 0; j < tmpAr.Length; j++) {
          graph[i].Add(tmpAr[j]);
        }
      }
    // グラフの作成↑

    int taka = 0, aoki = N - 1;
    for (int i = 0; i < N; i++) {
      // 移動できる点列挙
      int[] takaPoint = CanMovePoints(taka, graph).ToArray();
      int[] aokiPoint = CanMovePoints(aoki, graph).ToArray();

      int[] finTakaPoint = new int[];

      for (int j = 0; j < takaPoint.Length; j++) {
        for (int k = 0; k < aokiPoint.Length; k++) {
          if (color[takaPoint[j]] == color[aokiPoint[j]]) continue;

        }
      }
    }
    }
  }

  static int[] CanMovePoints(int N, List<List<int>> graph) {
    return graph[N];
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
