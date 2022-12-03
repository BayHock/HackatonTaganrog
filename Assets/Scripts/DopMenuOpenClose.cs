using UnityEngine;

public class DopMenuOpenClose : MonoBehaviour
{
    [SerializeField] private GameObject dopMenu;
    private bool isActive = false;

    public void CloseOrOpen()
    {
        if (!isActive )
        {
            dopMenu.SetActive(true);
            isActive = true;
        }
        else
        {
            dopMenu.SetActive(false);
            isActive = false;
        }
    }
}
