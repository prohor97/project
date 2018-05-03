using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    public abstract class BasePageSingleton<S, M>: ThreadSafeNestedConstructorsBaseSingleton<S>
        where M : BasePageElementMap, new()
        where S : BasePageSingleton<S, M>
    {
        protected M Map
        {
            get { return new M(); }
        }

        public virtual void Navigate(string url = "")
        {
            Driver.Browser.Navigate().GoToUrl(string.Concat(url));
        }
    }

    public abstract class BasePageSingleton<S, M, V> : BasePageSingleton<S, M>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new()
        where S : BasePageSingleton<S, M, V>
    {
        public V Validate()
        {
            return new V();
        }
    }
}
