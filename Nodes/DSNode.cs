using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DedSprite.Nodes {
    public class DSNode {
        bool Visible { get; set; } = true;

        SKSurface _surface = null;

        

        Point _position;
        Point Position {
            get {
                return _position;
            }
            set {
                _position = value;
            }
        }

        Size Size { get; set; }

        public virtual void SetSize(double width, double height) { }

        public List<DSNode> Children { get; set; } = new List<DSNode>();

        public void AddChild(DSNode node) {
            Children.Add(node);
        }

        public virtual void Draw(SKSurface surface) { }
    }
}
