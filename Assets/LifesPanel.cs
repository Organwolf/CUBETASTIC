using UnityEngine;
using UnityEngine.UI;

public class LifesPanel : MonoBehaviour
{
    public Image life1;
    public Image life2;
    public Image life3;

    public void SetLifes(int value)
    {
        if (value == 0)
        {
            life1.enabled = false;
            life2.enabled = false;
            life3.enabled = false;
        }
        else if (value == 1)
        {
            life1.enabled = true;
            life2.enabled = false;
            life3.enabled = false;
        }
        else if (value == 2)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = false;
        }
        else if (value == 3)
        {
            life1.enabled = true;
            life2.enabled = true;
            life3.enabled = true;
        }
    }
}
