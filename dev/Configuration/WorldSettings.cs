﻿/***************************************************************************
 *   WorldSettings.cs
 *   Copyright (c) 2015 UltimaXNA Development Team
 * 
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region Usings
using UltimaXNA.Core.Input.Windows;
using UltimaXNA.Core.Configuration;
#endregion

namespace UltimaXNA.Configuration
{
    public class WorldSettings : ASettingsSection
    {
        public const string SectionName = "world";

        private Resolution m_WindowResolution;
        private Resolution m_WorldGumpResolution;
        private bool m_IsFullScreen;
        private MouseSettings m_Mouse;
        private bool m_AlwaysRun;

        public WorldSettings()
        {
            WindowResolution = new Resolution(800, 600);
            GumpResolution = new Resolution(800, 600);
            IsMaximized = false;
            Mouse = new MouseSettings(MouseButton.Left, MouseButton.Right);
            AlwaysRun = false;
        }

        public bool IsMaximized
        {
            get { return m_IsFullScreen; }
            set { SetProperty(ref m_IsFullScreen, value); }
        }

        public MouseSettings Mouse
        {
            get { return m_Mouse; }
            set { SetProperty(ref m_Mouse, value); }
        }

        public Resolution WindowResolution
        {
            get { return m_WindowResolution; }
            set { SetProperty(ref m_WindowResolution, value); }
        }

        public Resolution GumpResolution
        {
            get { return m_WorldGumpResolution; }
            set { SetProperty(ref m_WorldGumpResolution, value); }
        }

        public bool AlwaysRun
        {
            get { return m_AlwaysRun; }
            set { SetProperty(ref m_AlwaysRun, value); }
        }
    }
}
