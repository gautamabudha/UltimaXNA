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
using UltimaXNA.Core.Graphics;
using UltimaXNA.Core.UI;
using UltimaXNA.Ultima.World.Entities;
using UltimaXNA.Ultima.World.Input;
using UltimaXNA.Ultima.World.Maps;
#endregion

namespace UltimaXNA.Ultima.World.EntityViews
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
            m_Texture = new RenderedText(Entity.Text);
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
