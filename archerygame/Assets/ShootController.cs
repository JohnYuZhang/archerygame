using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BowObject;
    public BowChargeIndicator BowCharge;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void eventThingy()
    {
        BowCharge.SetPower(5);
    }
}
