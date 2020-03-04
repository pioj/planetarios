using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetario1 : MonoBehaviour
{
	public Transform CentroUniverso;
	public Transform Sol;
	public Transform Satelite1;
	public Transform Satelite2;

	public float speedSol;
	public float speedSatelite1;
	public float SpeedSatelite2;

	// Start is called before the first frame update
    void Start()
    {
	    Sol.LookAt(CentroUniverso); 
    }

    // Update is called once per frame
    void Update()
    {
	    Sol.RotateAround(CentroUniverso.position, Vector3.up, speedSol * Time.deltaTime);
	    Satelite1.RotateAround( Sol.position, Vector3.right,  speedSatelite1 * Time.deltaTime);
	    Satelite2.RotateAround(Satelite1. position, Vector3.forward, SpeedSatelite2 * Time.deltaTime);

	    Debug.DrawLine(CentroUniverso.position, Sol.position, Color.red);
	    Debug.DrawLine(Sol.position, Satelite1.position, Color.cyan);
	    Debug.DrawLine(Satelite1.position, Satelite2.position, Color.green);
	    

    }

}
