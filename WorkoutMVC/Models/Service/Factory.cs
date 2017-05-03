using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Collections.Specialized;

namespace WorkoutMVC.Models.Service
{
    public class Factory
    {
        private Factory()
        {
        }

        private static Factory factory = new Factory();
        public static Factory GetInstance()
        {
            return factory;
        }


        public IService GetService(string serviceName)
        {
            Type type;
            object obj = null;

            try
            {
                type = Type.GetType(getImplName(serviceName));
                obj = Activator.CreateInstance(type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            return (IService)obj;

        }



        private string getImplName(string serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;

            return settings.Get(serviceName);
        }

    }
}