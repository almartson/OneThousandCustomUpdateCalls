using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatDisplay : MonoBehaviour
{
    public static StatDisplay Instance;

    [SerializeField] TMP_InputField AvarageFPSField;
    [SerializeField] TMP_InputField AvarageUpdateLength;
    [SerializeField] TMP_InputField Initialization;
    [SerializeField] TMP_Text runningTestText;
    [SerializeField] TMP_Text InitializingText;
    [SerializeField] Image RunningStatusBackground;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        HideRunningStatus();

    }

    public void SetAvarageFpsText(string fps)
    {
        AvarageFPSField.text = fps;
    }

    public void HideRunningStatus()
    {
        runningTestText.gameObject.SetActive(false);
        InitializingText.gameObject.SetActive(false);
        RunningStatusBackground.gameObject.SetActive(false);
    }
    public void ShowInitializingText()
    {
        InitializingText.gameObject.SetActive(true);
        RunningStatusBackground.gameObject.SetActive(true);
        runningTestText.gameObject.SetActive(false);
    }
    public void ShowRunningText()
    {
        InitializingText.gameObject.SetActive(false);
        RunningStatusBackground.gameObject.SetActive(true);
        runningTestText.gameObject.SetActive(true);
    }
    public void SetAvarageUpdateLenghtText(string lenght)
    {
        AvarageUpdateLength.text = lenght;
    }
    public void SetInitializationTime(string lenght)
    {
        Initialization.text = lenght;
    }

}
