using UnityEngine;

public class InputFieldListener : MonoBehaviour
{
    public void OnChangedInputField(string input)
    {
        Debug.Log("[OnChangedInputField] " + input);
    }

    public void OnEndedInputField(string input)
    {
        Debug.Log("[OnEndedInputField] " + input);
    }

    public void OnSelectedInputField(string input)
    {
        Debug.Log("[OnSelectedInputField] " + input);
    }

    public void OnDeslectedInputField(string input)
    {
        Debug.Log("[OnDeslectedInputField] " + input);
    }
}
