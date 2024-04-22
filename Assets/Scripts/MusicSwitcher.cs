using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    public event Action ButtonClicked;

    public void ButtonClick()
    {
        ButtonClicked?.Invoke();
    }
}
