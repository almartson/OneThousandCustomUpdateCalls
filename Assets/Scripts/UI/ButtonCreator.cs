using UnityEngine;

public class ButtonCreator : MonoBehaviour
{
    [SerializeField] Transform TestCaseParent;
    [SerializeField] TestCaseButton buttonPrefab;
    private void Awake()
    {
        for (int i = 0; i < TestCaseParent.childCount; i++)
        {
            var testcase = TestCaseParent.GetChild(i);
            var newButton = Instantiate(buttonPrefab,transform);

            newButton.Initialize();
            newButton.SetText(testcase.name);
            newButton.SetListener(delegate { testcase.gameObject.SetActive(true); });
        }
    }
}
