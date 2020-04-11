using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Steps
    {
        List<Step> steps = new List<Step>()
        {
            new Step
            (
                Instruction = "Visit https://studentpartners.microsoft.com/",
                Img = "/Assets/Certificate/SignIn.jpg",
                Caption = "Log in in the top right"
            ),

        }
    }
}
