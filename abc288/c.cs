/*
  解決手法
  無向グラフを記録し、連結成分の個数から残さなければならない本数をカウント
  総本数からそれを減らして答え？
*/

using System;
using System.Linq;
using System.Collections.Generic;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    int[] Ar = input.getIntArray();
    int N = Ar[0], M = Ar[1];
    List<List<int>> graph = new List<List<int>>();
    bool[] isVisited = new bool[N];
    for (int i = 0; i < N; i++) {
      graph.Add(new List<int>());
    }
    for (int i = 0; i < M; i++) {
      int[] tAr = input.getIntArray();
      int A = tAr[0] - 1, B = tAr[1] - 1;
      graph[A].Add(B);
      graph[B].Add(A);
    }
    
    int s = 0; // 連結成分の数
    for (int i = 0; i < N; i++) { // 連結成分探す
      if (!isVisited[i]) { // 新しい連結成分が見つかった
        s++;
        dfs(i, graph, isVisited);
      }
    }
    Console.WriteLine(M - (N - s));
  }
  
  static void dfs(int N, List<List<int>> graph, bool[] isVisited) {
    for (int i = 0; i < graph[N].Count; i++) {
      if (!isVisited[graph[N][i]]) {
        isVisited[graph[N][i]] = true;
        dfs(graph[N][i], graph, isVisited);
      }
    }
    return;
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
