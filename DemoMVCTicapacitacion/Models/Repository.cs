using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVCTicapacitacion.Models
{
    public class Repository
    {
        public Demo GetDemo()
        {
            return new Demo
            {
                Message = "hello world",
                MessageHtml = "<h1>hello world!!! Html</h1>"
            };
        }
    }
}