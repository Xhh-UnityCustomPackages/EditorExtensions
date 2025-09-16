using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Toolbars;
using UnityEngine;
using UnityEngine.UIElements;

namespace EditorExtensions.UnityToolbarExtension.Register
{
    public class ToolbarExtensionFrameDebugButton : IToolbarElement
    {
        public ToolbarElementLayoutType DefaultLayoutType => ToolbarElementLayoutType.RightSideRightAlign;


        public VisualElement CreateElement()
        {
            var button = new EditorToolbarButton(FrameDebugger);
            button.name = nameof(FrameDebugger);
            button.icon = (Texture2D)EditorGUIUtility.IconContent("d_Profiler.Rendering").image;
            button.tooltip = "Frame Debug";
            button.SetEnabled(true);
            return button;
        }

        private static void FrameDebugger()
        {
            EditorApplication.ExecuteMenuItem("Window/Analysis/Frame Debugger");
        }
    }
}