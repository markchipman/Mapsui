﻿using System;
using Mapsui.Geometries;
using Mapsui.Layers;
using Mapsui.Providers;

namespace Mapsui.UI
{
    public class InfoEventArgs : EventArgs
    {
        /// <summary>
        /// The layer to which the touched feature belongs
        /// </summary>
        public ILayer Layer { get; set; }
        /// <summary>
        ///  The feature touched but the user
        /// </summary>
        public IFeature Feature { get; set; }
        /// <summary>
        /// World position of the place the user touched
        /// </summary>
        public Point WorldPosition { get; set; }
        /// <summary>
        /// Screen position of the place the user touched
        /// </summary>
        public Point ScreenPosition { get; set; }
    }
}