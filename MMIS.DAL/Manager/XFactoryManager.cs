using System;
using System.Collections.Generic;
using System.Text;
using CM = System.Configuration.ConfigurationManager;
using System.Reflection;

namespace MMIS.DAL
{
    public class XFactoryManager
    {
        private static XFactory m_Factory;

        public static XFactory CreateFactory()
        {
            if (m_Factory == null)
            {
                string dataBaseType = CM.AppSettings["DataBaseType"];
                m_Factory = Assembly.Load("MMIS.DAL." + dataBaseType).CreateInstance("MMIS.DAL." + dataBaseType + ".X" + dataBaseType + "Factory") as XFactory;
            }
            return m_Factory;
        }
    }
}
