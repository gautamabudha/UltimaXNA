﻿/***************************************************************************
 *   OverheadView.cs
 *   
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 3 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/
#region usings
using Microsoft.Xna.Framework;
using UltimaXNA.Core.Rendering;
using UltimaXNA.UltimaGUI;
using UltimaXNA.UltimaWorld;
using UltimaXNA.UltimaWorld.Maps;
using UltimaXNA.UltimaWorld.Controllers;
#endregion

namespace UltimaXNA.UltimaEntities.EntityViews
{
    class OverheadView : AEntityView
    {
        new Overhead Entity
        {
            get { return (Overhead)base.Entity; }
        }

        public OverheadView(Overhead entity)
            : base(entity)
        {
            m_Texture = new RenderedText(Entity.Text, true);
            DrawTexture = m_Texture.Texture;
        }

        public override bool Draw(SpriteBatch3D spriteBatch, Vector3 drawPosition, MouseOverList mouseOverList, Map map)
        {
            HueVector = Utility.GetHueVector(Entity.Hue);
            return base.Draw(spriteBatch, drawPosition, mouseOverList, map);
        }

        private RenderedText m_Texture = null;
    }
}
