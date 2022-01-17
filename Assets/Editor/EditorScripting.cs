using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class EditorScripting : EditorWindow
{
    GUIStyle guiStyle = new GUIStyle();

    [MenuItem("Quan/Test %g" , priority = 1)]
    static void QuanTest()
    {
        EditorWindow.GetWindow(typeof(EditorScripting));
    }

    [MenuItem("CONTEXT/Rigidbody/Edit Mass")]
    private static void NewMenuOption(MenuCommand menuCommand)
    {
        // The RigidBody component can be extracted from the menu command using the context field.
        var rigid = menuCommand.context as Rigidbody;
        rigid.mass = 1000f;
    }


    bool state;

    private void OnGUI()
    {
        GUI.color = Color.green;
        EditorGUILayout.LabelField("Editor Scene", EditorStyles.boldLabel);

        state = EditorGUILayout.BeginToggleGroup("Scene Editor", state);
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Event Test Scene");
        if (GUILayout.Button("Open"))
        {
            OpenScene("EventTestScene");
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Test Scene");
        if (GUILayout.Button("Open"))
        {
            OpenScene("Test");
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndToggleGroup();

        guiStyle.alignment = TextAnchor.MiddleCenter;
        
        EditorGUILayout.LabelField(state ? "Open Scene" : "OK" , guiStyle);
    }

    void OpenScene(string name)
    {
        EditorSceneManager.OpenScene("Assets/Scenes/" +name+".unity");
        state = false;
    }
}
