using UnityEngine.UIElements;

namespace EditorExtensions.UnityToolbarExtension
{
    public interface IToolbarElement
    {
        ToolbarElementLayoutType DefaultLayoutType { get; }
        VisualElement CreateElement();
    }

    public enum ToolbarElementLayoutType
    {
        LeftSideLeftAlign,
        LeftSideRightAlign,
        RightSideLeftAlign,
        RightSideRightAlign
    }
}