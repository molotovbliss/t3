﻿using System;
using System.Numerics;
using T3.Gui.Graph.Interaction;
using T3.Gui.Selection;

namespace T3.Gui.Graph
{
    public class Annotation : ISelectableCanvasObject
    {
        public string Title = "Untitled Annotation";
        public Color Color = Color.Gray;
        public Guid Id { get; set; }
        public Vector2 PosOnCanvas { get; set; }
        public Vector2 Size { get; set; }
        public bool IsSelected => NodeSelection.IsNodeSelected(this);

        public Annotation Clone()
        {
            return new Annotation
                       {
                           Id = Guid.NewGuid(),
                           Title = this.Title = "Untitled Annotation",
                           Color = this.Color,
                           PosOnCanvas = this.PosOnCanvas,
                           Size = this.Size
                       };
        }
    }
}