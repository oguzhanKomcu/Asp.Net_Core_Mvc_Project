using System.Net;

namespace Hospital_System_Mvc.Project.Infrastructure.Utilities
{
    public static class RemoteIP
    {

         public static string GetIpAddress()
         {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(var ip in host.AddressList)
            {

                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            }

            return "Local ip address havent ben found..!!";

         }

        public static string IpAddress
        {
            get { return GetIpAddress(); }
        }



    }
}
