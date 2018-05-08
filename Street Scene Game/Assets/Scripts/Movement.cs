using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    private Transform m_transform;
    public float speed = 3.0f;

	// Use this for initialization
	void Start ()
    {
        m_transform = transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        m_transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
}
