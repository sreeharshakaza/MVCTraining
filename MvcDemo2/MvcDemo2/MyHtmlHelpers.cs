using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo2.Helpers
{
    public class MyHtmlHelpers
    {
        public static IHtmlString CustomeImage()
        {
            string htmlString = "<img alt='Danam' src='/Images/bullet.png' width='200' height='200'/>";
            return new HtmlString(htmlString);
        }
    }
}