using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selector {
  public interface ISelection {
    /// <summary>
    /// Get a class representing the HTML markup of this element
    /// </summary>
    Html Html { get; }

    /// <summary>
    /// Add a class to this element
    /// </summary>
    /// <param name="className">The class name string to add to this element</param>
    /// <returns> Returns this for chaining </returns>
    ISelection AddClass(string className);

    /// <summary>
    /// Removes a class from this element
    /// </summary>
    /// <param name="className">The class name string to remove from this element</param>
    /// <returns> Returns this for chaining </returns>
    ISelection RemoveClass(string className);

    /// <summary>
    /// Appends an element within this element
    /// </summary>
    /// <param name="element"></param>
    /// <returns> Returns this for chaining </returns>
    ISelection Append(Element element);

    /// <summary>
    /// Gets the inner HTML of this element
    /// </summary>
    /// <returns> string of this element's inner HTML </returns>
    string InnerHtml();

    /// <summary>
    /// Set this element's inner HTML
    /// </summary>
    /// <param name="innerHtml"> A string of HTML </param>
    /// <returns> Returns this for chaining </returns>
    ISelection InnerHtml(string innerHtml);

    /// <summary>
    /// Gets the outer HTML of this element
    /// </summary>
    /// <returns> string of this element's outer HTML </returns>
    string OuterHtml();

    /// <summary>
    /// Set this element's outer HTML
    /// </summary>
    /// <param name="outerHtml"> A string of HTML </param>
    /// <returns> Returns this for chaining </returns>
    ISelection OuterHtml(string outerHtml);
  }
}
