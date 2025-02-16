using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingInCSharp
{
    //sealed class  AppDev:Dev
    public class AppDev:Dev
    {

        string osType;

        public AppDev()
        {
            Console.WriteLine("app developer constructor");
            osType = "unknown";

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("operating system type :\t"+osType);
        }

        public override void Register()
        {
            base.Register();

            Console.WriteLine("enter os type");

            osType=Console.ReadLine();

        }

    }
}
