using System;
using System.Collections.Generic;
using System.Linq;
using DuoCode.Dom;

namespace Selector {
  public class Selection : List<Element>, ISelection {
    #region Properties
    /// <summary>
    ///   Retrieves the Html of the first element of this selection
    /// </summary>
    public Html Html => this.First().Html;
    #endregion

    #region Constructors
    public Selection(string selectorString) {
      Select(selectorString);
    }
    #endregion

    #region Methods
    public ISelection AddClass(string className) => DoForAllElements((el) => el.AddClass(className));

    public ISelection Append(Element element) => DoForAllElements((el) => el.Append(element));

    public string InnerHtml() => this.First().Html.Inner;

    public ISelection InnerHtml(string innerHtml) => DoForAllElements((el) => el.Html.Inner = innerHtml);

    public string OuterHtml() => this.First().Html.Outer;

    public ISelection OuterHtml(string outerHtml) => DoForAllElements((el) => el.Html.Outer = outerHtml);

    public ISelection RemoveClass(string className) => DoForAllElements((el) => el.RemoveClass(className));

    public static implicit operator Element(Selection selection) {
      return selection.First();
    }

    /// <summary>
    /// </summary>
    /// <param name="action"> An action to perform on each element in this collection </param>
    /// <returns> </returns>
    private Selection DoForAllElements(Action<Element> action) {
      foreach (var el in this) action(el);

      return this;
    }

    private void Select(string selectorString) {
      var nodeList = Global.document.querySelectorAll(selectorString);
      for (var i = 0; i < nodeList.length; i++) {
        var node = nodeList[i];
        Add(Element.FromNode(node));
      }
    }
    #endregion
  }
}
