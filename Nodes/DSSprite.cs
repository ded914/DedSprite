using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DedSprite.Nodes {
    public class DSSprite : DSNode {
        SKBitmap _image = null;

        public DSSprite(string recourceId) {
            Assembly assembly = GetType().GetTypeInfo().Assembly;

            using (Stream stream = assembly.GetManifestResourceStream(recourceId)) {
                _image = SKBitmap.Decode(stream);
            }
        }

        public override void Draw(SKSurface surface) {
            
        }
    }
}
