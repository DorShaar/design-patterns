using System;
using System.Collections.Generic;
using System.Text;

namespace _02_StaticFactoryMethod
{
    public abstract class FullName
    {
        public static FullName Create(string i_FullName)
        {
            /// NOTE:
            /// This code could be easily replaced with
            /// a code that reads a configuration file
            /// which holds information (that can be updated/modified)
            /// regarding which instance to create in respect to i_FullName

            int i = i_FullName.IndexOf(",");
            if (i > 0)
            {
                return new FullName_En_US(i_FullName);
            }
            else
            {
                return new FullName_He_IL(i_FullName);
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class FullName_En_US : FullName
    {
        public FullName_En_US(string i_FullName)
        {
            int i = i_FullName.IndexOf(",");
            if (i > 0)
            {
                LastName = i_FullName.Substring(0, i);
                FirstName = i_FullName.Substring(i + 1).Trim();
            }
            else
            {
                LastName = i_FullName;
                FirstName = string.Empty;
            }
        }
    }

    public class FullName_He_IL : FullName
    {
        public FullName_He_IL(string i_FullName)
        {
            int i = i_FullName.IndexOf(" ");
            if (i > 0)
            {
                FirstName = i_FullName.Substring(0, i).Trim();
                LastName = i_FullName.Substring(i + 1).Trim();
            }
            else
            {
                FirstName = i_FullName;
                LastName = "";
            }
        }
    }
}
