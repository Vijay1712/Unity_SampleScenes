using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingIfGrabbed : MonoBehaviour {

    private SimpleShoot simpleShoot;
    private OVRGrabbable ovrGrabbale;
    public OVRInput.Button shootingButton;
    public int maxNumberOfBullets = 15;
    public Text bulletText;

	// Use this for initialization
	void Start () {
        simpleShoot = GetComponent < SimpleShoot>();
        ovrGrabbale = GetComponent<OVRGrabbable>();
        bulletText.text = maxNumberOfBullets.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		if(ovrGrabbale.isGrabbed && OVRInput.GetDown(shootingButton, ovrGrabbale.grabbedBy.GetController()) && maxNumberOfBullets > 0)
        {
            //Shoot!!
            simpleShoot.TriggerShoot();
            maxNumberOfBullets--;
            bulletText.text = maxNumberOfBullets.ToString();
                
        }
	}
}
