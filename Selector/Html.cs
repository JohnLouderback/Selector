using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoCode.Dom;

namespace Selector {
  public class Html {
    private HTMLElement el;

    public string Inner {
      get { return el.innerHTML; }
      set { el.innerHTML = value; }
    }

    public string Outer {
      get { return el.outerHTML; }
      set { el.outerHTML = value; }
    }

    internal Html(Element forElement) : this(forElement.RawHtmlElement) { }

    private Html(HTMLElement forElement) {
      el = forElement;
    }

    public static implicit operator string(Html html) {
      return html.Outer;
    }
  }
}
