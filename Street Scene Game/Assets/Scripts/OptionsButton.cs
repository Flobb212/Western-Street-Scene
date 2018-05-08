using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour
{
    public Image optionsBox;

	public void onClick()
    {
        optionsBox.enabled = true;
    }
}
