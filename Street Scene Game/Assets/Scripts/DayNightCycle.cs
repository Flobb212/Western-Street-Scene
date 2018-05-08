using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour
{
    private float rotation;
    public bool canRotate = false;
    private float Timer = 0.0f;
    private int colourChange = 0;

    Color color1 = new Color();
    Color color2 = new Color();
    Color color3 = new Color();
    Color color4 = new Color();
    Color color5 = new Color();
    Color color6 = new Color();

    // Use this for initialization
    void Start () 
    {
        rotation = Time.deltaTime * 10;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (canRotate == true)
        {
            gameObject.transform.Rotate(rotation, 0, 0);

            Timer += Time.deltaTime;

            if(Timer >= 2.5)
            {
                canRotate = false;
                Timer = 0.0f;
            }

            //if(colourChange == 1)
            //{
            //    GameObject.Find("Directional Light").GetComponent<Light>().color = Color.Lerp(Color.blue, Color.cyan, 2);
                //FF9800FF
            //}
            //else if(colourChange == 2)
            //{
            //    GameObject.Find("Directional Light").GetComponent<Light>().color = Color.Lerp(Color.cyan, Color.yellow, 2);
                //C4BA2EFF
            //}
            //else if (colourChange == 3)
            //{
            //    GameObject.Find("Directional Light").GetComponent<Light>().color = Color.Lerp(Color.yellow, Color.white, 2);
                //EAFB81FF
            //}
            //else if (colourChange == 4)
            //{
            //    GameObject.Find("Directional Light").GetComponent<Light>().color = Color.Lerp(Color.white, Color.yellow, 2);
                //FFBA00FF
            //}
            //else if (colourChange == 5)
            //{
            //    GameObject.Find("Directional Light").GetComponent<Light>().color = Color.Lerp(Color.yellow, Color.magenta, 2);
                //AA98D7FF
            //}
            //else if (colourChange >= 6)
            //{
            //    GameObject.Find("Directional Light").GetComponent<Light>().color = Color.Lerp(Color.magenta, Color.blue, 2);
                //00001FFF
            //}
        }
	}

    public void Rotate()
    {
        canRotate = true;
        colourChange++;
    }
}
