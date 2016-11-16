using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MSMQNoSecurityService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MSMQService : IMSMQService
    {
        public void GetData(string msg)
        {
            Debug.WriteLine(msg + "Received at:" + System.DateTime.Now.ToString());
        }


    }
}
