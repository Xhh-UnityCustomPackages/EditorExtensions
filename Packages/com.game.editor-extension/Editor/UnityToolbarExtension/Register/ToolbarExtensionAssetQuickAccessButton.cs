using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Toolbars;
using UnityEngine;
using UnityEngine.UIElements;

namespace EditorExtensions.UnityToolbarExtension.Register
{
    public class ToolbarExtensionAssetQuickAccessButton : IToolbarElement
    {
        public ToolbarElementLayoutType DefaultLayoutType => ToolbarElementLayoutType.RightSideRightAlign;


        public VisualElement CreateElement()
        {
            var button = new EditorToolbarButton(AssetQuickAssess);
            button.name = nameof(AssetQuickAssess);
            button.icon = (Texture2D)EditorGUIUtility.IconContent("d_SignalAsset Icon").image;
            button.tooltip = "Asset Quick Assess";
            button.SetEnabled(true);
            return button;
        }

        private static void AssetQuickAssess()
        {
            EditorApplication.ExecuteMenuItem("Window/Asset Management/Asset Quick Access");
        }
    }
}