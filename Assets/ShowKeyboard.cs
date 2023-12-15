using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class ShowKeyboard : MonoBehaviour
{
    // Start is called before the first frame update
    private TMP_InputField inputField;
    
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        inputField.onSelect.AddListener(x=>OpenKeyboard());

    }

    // Update is called once per frame
    public void OpenKeyboard()

    {
        NonNativeKeyboard.Instance.InputField=inputField;
        NonNativeKeyboard.Instance.PresentKeyboard(inputField.text);
    }
}
