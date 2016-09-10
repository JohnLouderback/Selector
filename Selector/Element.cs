using DuoCode.Dom;
using DuoCode.Runtime;

namespace Selector {
  public class Element : ISelection {
    #region Fields
    /// <summary>
    ///   The underlying HTMLElement that this performs on.
    /// </summary>
    private HTMLElement el;
    #endregion

    #region Properties
    /// <summary>
    ///   The underlying HTMLElement that this performs on.
    /// </summary>
    public HTMLElement RawHtmlElement {
      get { return el; }
      private set { el = value; }
    }

    public ClassList ClassList => new ClassList(this);


    public Html Html => new Html(this);
    #endregion

    #region Methods
    /// <summary>
    ///   Creates a new instance from a element name string
    /// </summary>
    /// <param name="elementName"> The name of an HTML element from which this will be created </param>
    /// <returns> </returns>
    public static Element FromElementName(string elementName) {
      return new Element {
        RawHtmlElement = Global.document.createElement(elementName)
      };
    }

    /// <summary>
    ///   Creates a new instance from a DOM node
    /// </summary>
    /// <param name="node"> The existing node to create this element from </param>
    public static Element FromNode(Node node) {
      return new Element {
        RawHtmlElement = node.As<HTMLElement>()
      };
    }

    public ISelection AddClass(string className) {
      ClassList.Add(className);
      return this;
    }

    public ISelection Append(Element element) {
      el.appendChild(element.RawHtmlElement);
      return this;
    }

    public string InnerHtml() => Html.Inner;

    public ISelection InnerHtml(string innerHtml) {
      Html.Inner = innerHtml;
      return this;
    }

    public string OuterHtml() => Html.Outer;

    public ISelection OuterHtml(string outerHtml) {
      Html.Outer = outerHtml;
      return this;
    }

    public ISelection RemoveClass(string className) {
      ClassList.Remove(className);
      return this;
    }
    #endregion
  }
}
