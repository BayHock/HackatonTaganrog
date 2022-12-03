using UnityEngine;

public class HideOkna : MonoBehaviour
{
    [SerializeField] private GameObject raspOkno;
    private bool isActiveRasp = true;
    [SerializeField] private GameObject ProfOkno;
    private bool isActiveProf = true;
    [SerializeField] private GameObject OprosOkno;
    private bool isActiveOpros = true;

    public void CloseRaspOkno()
    {
        if (isActiveRasp)
        {
            isActiveRasp = false;
            raspOkno.SetActive(false);
        }
        else
        {
            isActiveRasp = true;
        }
    }
    public void CloseProfOkno()
    {
        if (isActiveProf)
        {
            isActiveProf = false;
            ProfOkno.SetActive(false);
        }
        else
        {
            isActiveProf = true;
        }
    }
    public void CloseOprosOkno()
    {
        if (isActiveOpros)
        {
            isActiveOpros = false;
            OprosOkno.SetActive(false);
        }
        else
        {
            isActiveOpros = true;
        }
    }
}
