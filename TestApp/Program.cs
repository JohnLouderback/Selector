using System;
using Selector;
using static Selector.Utilities;
using static DuoCode.Dom.Global;

namespace HelloDuoCode {
  public class Greeter {
    private readonly Selection element;
    private readonly Element span;
    private int timerToken;

    public Greeter(Selection el) {
      element = el;
      span = Element.FromElementName("span");
      element.Append(span);
      Tick();
    }

    public void Start() {
      timerToken = window.setInterval((Action)Tick, 500);
    }

    public void Stop() {
      window.clearTimeout(timerToken);
    }

    private void Tick() {
      span.Html.Inner = $"The time is: {DateTime.Now}"; // try to put a breakpoint here
    }
  }

  static class Program {
    static void Run() // HTML body.onload event entry point, see index.html
    {
      System.Console.WriteLine("Hello DuoCode");

      var greeter = new Greeter(new Selection("#content"));
      greeter.Start();
    }
  }
}
