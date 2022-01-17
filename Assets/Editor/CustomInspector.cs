using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestTest))]
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        DrawDefaultInspector();


        TestTest testTest = (TestTest)target;

        if (GUILayout.Button("Create"))
        {
            //testTest.CreateThings();
        }


        EditorGUILayout.HelpBox("This is helpbox", MessageType.Info);
    }

    public void OnSceneGUI()
    {
        Handles.RadiusHandle(Quaternion.identity, Vector3.zero, 7f);
    }
}
