using UnityEngine;
using System.Collections;

public class FinishChecker : MonoBehaviour
{
    private StoryPoints[] points;

    public static int pointsGot = 0;
    private bool canExit = false;
    private FinishChecker myFinishChecker;
    public Camera cam;
    private AudioSource train;
    public AudioSource bellToll;

    void Awake()
    {
        train = GetComponent<AudioSource>();
    }

    public FinishChecker()
    {

    }

    public FinishChecker(int points)
    {
        pointsGot = points;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(pointsGot);

	    if(pointsGot == 6)
        {
            StartCoroutine("TrainHorn");
            pointsGot++; //So triggered only once
            activateEnding();            
        }
	}
        
    private void activateEnding()
    {
        GetComponent<MeshRenderer>().enabled = true;

        this.GetComponentInChildren<ParticleSystem>().Play();
        canExit = true;
        Debug.Log("exit open");
    }

    void OnTriggerEnter()
    {
        if (canExit == true)
        {
            Debug.Log("end");
            canExit = false; //So triggered only once
            cam.GetComponent<FadeOut>().FadingOut();
            train.Play();
            StartCoroutine("End");
        }
    }

    private IEnumerator End()
    {
        Debug.Log("End attempt");

        if (train.isPlaying == false)
        {
            Application.LoadLevel(0);
        }
        else
        {
            Debug.Log("Still Playing");
            yield return new WaitForSeconds(1);
            StartCoroutine("End");
        }
    }

    private IEnumerator TrainHorn()
    {
        yield return new WaitForSeconds(10);

        bellToll.Play();
    }
}
