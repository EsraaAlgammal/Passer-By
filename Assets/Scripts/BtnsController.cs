using UnityEngine;
using System.Collections;

public class BtnsController : MonoBehaviour, IVirtualButtonEventHandler {

    VirtualButtonBehaviour[] vb;
    public GameObject myObj;

	// Use this for initialization
	void Start () {
        vb = GetComponentsInChildren<VirtualButtonBehaviour>();
        foreach (VirtualButtonBehaviour btn in vb)
        {
            btn.RegisterEventHandler(this);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        GameObject walker = GameObject.FindGameObjectWithTag("Player");
        switch (vb.VirtualButtonName)
        {
            case "btnBanzeen":
                
                walker.rigidbody.velocity = new Vector3(0, 0, 50);
                myObj.renderer.material.color = Color.red;

                break;
            case "btnFaramel":
                walker.rigidbody.velocity = new Vector3(0, 0, -50);

                myObj.renderer.material.color = Color.green;
                break;

        }
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
    }
}
