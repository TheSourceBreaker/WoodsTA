using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Text changingText;

    public GameObject changingText2;

    public void TextChange()
    {
        changingText.text = "2";
        changingText2.GetComponent<Text>().text = "2";
    }
}
