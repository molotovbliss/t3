﻿using System;
using System.Numerics;
using ImGuiNET;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using T3.Core;
using T3.Core.Animation;
using T3.Core.Logging;
using t3.Gui.InputUi.CombinedInputs;
using T3.Gui.UiHelpers;
using T3.Gui.Windows.TimeLine;

namespace T3.Gui.InputUi
{
    public class CurveInputUi : InputValueUi<T3.Core.Animation.Curve>
    {
        public override IInputUi Clone()
        {
            return new CurveInputUi
                   {
                       InputDefinition = InputDefinition,
                       Parent = Parent,
                       PosOnCanvas = PosOnCanvas,
                       Relevancy = Relevancy,
                       Size = Size,
                   };
        }
        
        protected override InputEditStateFlags DrawEditControl(string name, ref Curve curve)
        {
            if (curve == null)
            {
                // value was null!
                ImGui.TextUnformatted(name + " is null?!");
                return InputEditStateFlags.Nothing;
            }
            
            ImGui.Dummy(Vector2.One);    // Add Line Break

            return CurveInputEditing.DrawCanvasForCurve(curve, T3Ui.EditingFlags.PreventZoomWithMouseWheel);
        }
        
        protected override void DrawReadOnlyControl(string name, ref Curve value)
        {
        }
    }
}
