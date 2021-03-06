﻿/***************************************************************************
 *   ServiceRegistry.cs
 *   Copyright (c) 2015 UltimaXNA Development Team
 * 
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region usings
using System;
using System.Collections.Generic;
using UltimaXNA.Core.Diagnostics.Tracing;
#endregion

namespace UltimaXNA
{
    public static class ServiceRegistry
    {
        private static Dictionary<Type, object> m_Services = new Dictionary<Type, object>();

        public static T Register<T>(T service)
        {
            Type type = typeof(T);

            if (m_Services.ContainsKey(type))
            {
                Tracer.Critical(string.Format("Attempted to register service of type {0} twice.", type.ToString()));
                m_Services.Remove(type);
            }

            m_Services.Add(type, service);
            return service;
        }

        public static void Unregister<T>()
        {
            Type type = typeof(T);

            if (m_Services.ContainsKey(type))
            {
                m_Services.Remove(type);
            }
            else
            {
                Tracer.Critical(string.Format("Attempted to unregister service of type {0}, but no service of this type (or type and equality) is registered.", type.ToString()));
            }
        }

        public static bool ServiceExists<T>()
        {
            Type type = typeof(T);

            if (m_Services.ContainsKey(type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static T GetService<T>()
        {
            Type type = typeof(T);

            if (m_Services.ContainsKey(type))
            {
                return (T)m_Services[type];
            }
            else
            {
                Tracer.Critical(string.Format("Attempted to get service service of type {0}, but no service of this type is registered.", type.ToString()));
                return default(T);
            }
        }
    }
}
