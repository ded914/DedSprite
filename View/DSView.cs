using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DedSprite.Nodes;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace DedSprite.View {
    public class DSView : SKCanvasView {
        double savedWidth = 0;
        double saveHeight = 0;

        DSNode baseLayer = new DSNode();

        public void AddChild(DSNode node) {
            baseLayer.AddChild(node);
        }
        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e) {
            if (savedWidth != Width || saveHeight != Height) {
                savedWidth = Height >= Width ? Width : Height;
                saveHeight = Height >= Width ? Height : Width;
                baseLayer.SetSize(savedWidth, saveHeight);
            }
            base.OnPaintSurface(e);
            baseLayer.Draw(e.Surface);
        }
    }
}
