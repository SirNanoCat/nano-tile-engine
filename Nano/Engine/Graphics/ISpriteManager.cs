﻿using System;
using Microsoft.Xna.Framework;
using Nano.Engine.Graphics.Sprites;

namespace Nano.Engine.Graphics
{
    public interface ISpriteManager
    {
        ISprite CreateSprite(string texture);
        ISprite CreateSprite(string texture, Rectangle sourceRectangle);

        /// <summary>
        /// Draws the sprite.
        /// Must be preceeded by a call to StartBatch()
        /// </summary>
        /// <param name="sprite">Sprite.</param>
        void DrawSprite(ISprite sprite);

        void StartBatch();

        void EndBatch();

        ITexture2D CreateTexture2D(string texture);

        /// <summary>
        /// Draws the texture2D.
        /// </summary>
        /// <param name="texture">Texture.</param>
        /// <param name="position">Position.</param>
        /// <param name="sourceRectangle">Source rectangle.</param>
        /// <param name="rotation">Rotation.</param>
        /// <param name="origin">Rotation Origin.</param>
        void DrawTexture2D(ITexture2D texture, Vector2 position, Rectangle sourceRectangle, float rotation, Vector2 origin);
    }
}
