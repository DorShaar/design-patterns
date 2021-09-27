using System;
using System.Collections.Generic;
using System.Text;

namespace _03_StaticFactoryClass
{

    public abstract class FullName
    {
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
