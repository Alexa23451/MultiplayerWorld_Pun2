using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTextScript : MonoBehaviour
{
    [SerializeField] private GameObject Panel_With_Text;
    public void CloseText()
    {
        Panel_With_Text.SetActive(false);
    }
}
