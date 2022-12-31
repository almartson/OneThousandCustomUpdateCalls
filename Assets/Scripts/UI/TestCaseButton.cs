using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TestCaseButton : MonoBehaviour
{

    [SerializeField] TMP_Text buttonText;
    [SerializeField] Button button;
    Action ButtonCallback;
    public void Initialize()
    {
        button = GetComponent<Button>();
    }

    public void SetText(string text)
    {
        buttonText.SetText(text);
    }

    public void SetListener(Action listener)
    {
        ButtonCallback= listener;
        button.onClick.AddListener(Callback);
    }
    private void Callback()
    {
        ButtonCallback?.Invoke();
    }
    private void OnDestroy()
    {
        button.onClick.RemoveListener(Callback);
    }
}
