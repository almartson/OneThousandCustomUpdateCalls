using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using ObserverManager;
using System.Collections.Generic;

public class TestCaseButton : MonoBehaviour
{
    public static event Action OnAnyTestButtonClicked;
    [SerializeField] TMP_Text buttonText;
    [SerializeField] Button button;

    public TMP_InputField amountInputField;
    Action ButtonCallback;
    private GameObject testCaseGameObject;

    public void Initialize()
    {
        button = GetComponent<Button>();
        OnAnyTestButtonClicked += BlockButtonPress;
        UpdateTimer.OnAnyTestCompleted += EnableButtonPress;
        button.onClick.AddListener(TestStart);
        
    }

    private void BlockButtonPress()
    {
        button.enabled= false;
    }
    private void EnableButtonPress()
    {
        button.enabled = true;
    }


    private void TestStart()
    {
        OnAnyTestButtonClicked?.Invoke();
        StatDisplay.Instance.ShowInitializingText();
        SetSpawnAmount();
    }

    void SetSpawnAmount()
    {

        List<ICreate> childs = testCaseGameObject.transform.GetComponentsInChildrenRecursively<ICreate>();

        foreach (var item in childs)
        {
            if (int.TryParse(amountInputField.text, out int spawnAmount))
            {
                item.SpawnAmount(spawnAmount);
            }
        }
    }

    public void SetText(string text)
    {
        buttonText.SetText(text);
    }

    public void SetListener(Action listener)
    {
        ButtonCallback = listener;
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

    internal void SetAmountInputField(TMP_InputField inputFieldToPassToButtons)
    {
        amountInputField = inputFieldToPassToButtons;
    }

    internal void SetGameObject(GameObject gameObject)
    {
        testCaseGameObject = gameObject;
    }
}
