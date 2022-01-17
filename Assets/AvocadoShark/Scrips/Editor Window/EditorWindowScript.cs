using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
public class EditorWindowScript : EditorWindow
{
    [MenuItem("OMT/OMT Help")]
    public static void ShowWindow()
    {
        GetWindow<EditorWindowScript>("OMT Help");
    }
    void OnGUI()
    {
        GUILayout.Label("Welcome!", EditorStyles.boldLabel);
        GUILayout.Label("Thank you for buying this asset!");
        if (GUILayout.Button("Tutorial Video"))
        {
            Application.OpenURL("https://www.youtube.com/watch?v=fa2H-kEp6GM");
        }
        if (GUILayout.Button("Learn how to change the character's skin"))
        {
            Application.OpenURL("https://www.youtube.com/watch?v=jEcYcR-g3gw&t");
        }
        if (GUILayout.Button("Learn how to change the car's skin (If you have the add-on)"))
        {
            Application.OpenURL("https://www.youtube.com/watch?v=WyPgJ5scclM&t");
        }
        if (GUILayout.Button("Discord Server"))
        {
            Application.OpenURL("https://discord.gg/mP4yfHxXPa");
        }
        if (GUILayout.Button("Add-ons"))
        {
            Application.OpenURL("https://assetstore.unity.com/publishers/52826");
        }
        if (GUILayout.Button("Review This Asset!"))
        {
            Application.OpenURL("https://assetstore.unity.com/packages/templates/packs/online-multiplayer-template-voice-chat-photon-190640#reviews");
        }
    }
}
#endif
