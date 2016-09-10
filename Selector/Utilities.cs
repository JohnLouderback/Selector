using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selector {
  public static class Utilities {
    /// <summary>
    /// Utility method for getting a selection of elements
    /// </summary>
    /// <param name="selectorString"> The selector string for the selection </param>
    /// <returns></returns>
    public static Selection Select(string selectorString) {
      return new Selection(selectorString);
    }

    /// <summary>
    /// Utility method for getting a selection of elements.
    /// Shortcut alias for "Select"
    /// </summary>
    /// <param name="selectorString"> The selector string for the selection </param>
    /// <returns></returns>
    public static Selection S(string selectorString) {
      return Select(selectorString);
    }
  }
}
