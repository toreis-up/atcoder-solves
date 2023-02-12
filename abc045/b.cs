using System;
using System.Linq;

static class Solver {
  public static void Main() => Solver.solve();

  static void solve() {
    Input input = new Input();
    string A = input.getString();
    string B = input.getString();
    string C = input.getString();

    int ACount = A.Length;
    int BCount = B.Length;
    int CCount = C.Length;

    string turn = "A";

    while (true) {
            if (ACount == 0) {
        Console.WriteLine('A');
        break;
      }
            if (BCount == 0) {
        Console.WriteLine('B');
        break;
      }
            if (CCount == 0) {
        Console.WriteLine('C');
        break;
      }
      switch (turn) {
        case 'A':
          string nextPlayer = A.Substring(A.Length - ACount, 1);
          turn = next(nextPlayer);
          ACount --;
          break;
        case 'B':
          string nextPlayer = B.Substring(B.Length - BCount, 1);
          turn = next(nextPlayer);
          BCount --;
          break;
        case 'C':
          string nextPlayer = C.Substring(C.Length - CCount, 1);
          turn = next(nextPlayer);
          CCount --;
          break;
        default: break;
      }


    }
  }

  static string next(string player) {
    return player.ToUpper();
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
