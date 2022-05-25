using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class UnitCreator : EditorWindow
{
    private VisualElement _root;

    [MenuItem("Tools/UnitCreator")]
    public static void ShowExample()
    {
        UnitCreator wnd = GetWindow<UnitCreator>();
        wnd.titleContent = new GUIContent("UnitCreator");
        wnd.minSize = new Vector2(0, 600);
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        _root = rootVisualElement;

        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Brzusko/UI/UIDocs/UnitCreator/UnitCreator.uxml");
        _root.Add(visualTree.Instantiate());

        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Brzusko/UI/UIDocs/UnitCreator/UnitCreator.uss");
        _root.styleSheets.Add(styleSheet);
    }

}