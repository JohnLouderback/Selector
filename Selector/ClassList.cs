using System.Collections;
using System.Collections.Generic;
using DuoCode.Dom;

namespace Selector {
  public class ClassList : IEnumerable<string> {
    #region Fields
    private HTMLElement el;
    #endregion

    #region Properties
    private List<string> classList {
      get {
        if (el == null) return null;

        var classList = new List<string>();
        for (var i = 0; i < el.classList.length; i++) classList.Add(el.classList[i]);
        return classList;
      }
    }
    #endregion

    #region Indexers
    public string this[int i] {
      get { return el.classList[i]; }
      set { el.classList[i] = value; }
    }
    #endregion

    #region Constructors
    internal ClassList(Element forElement) : this(forElement.RawHtmlElement) {
    }

    private ClassList(HTMLElement forElement) {
      el = forElement;
    }
    #endregion

    #region Methods
    public void Add(string className) {
      el.classList.add_(className);
    }

    public bool Contains(string className) {
      return el.classList.contains(className);
    }

    public IEnumerator<string> GetEnumerator() {
      return classList.GetEnumerator();
    }

    public void Remove(string className) {
      el.classList.remove_(className);
    }

    public void ToggleClass(string className) {
      if (Contains(className)) Remove(className);
      else Add(className);
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return GetEnumerator();
    }
    #endregion
  }
}
