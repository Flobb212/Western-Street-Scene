using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour
{
    public Texture2D fadeTexture;
    public float fadeTime = 4.0f;
    private float alpha = 1.0f;
    private float fadeVar = -1.0f;
    Color texCol;
    
    public void OnGUI()
    {
        alpha += fadeVar * fadeTime * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        texCol = GUI.color;
        texCol.a = alpha;
        GUI.color = texCol;
        
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);
    }

    public void FadingOut()
    {
        fadeVar = 1;
    }
}