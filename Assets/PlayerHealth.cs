using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public LifesPanel lifePanel;
    public int Lives { get; private set; }

    private void Awake()
    {
        Lives = 3;
    }

    public void decreaseLife()
    {
        Lives--;
        lifePanel.SetLifes(Lives);
    }
}
