using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour
{
    public void LoadLevel(int _levelIndex)
    {
        Application.LoadLevel(_levelIndex);
    }
}