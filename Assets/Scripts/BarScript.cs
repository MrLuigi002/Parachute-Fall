using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{

    public GameObject usageBar;

    public GameObject obstaclesWind;

    public bool canUse = true;

    private Vector3 scaleDown;
    private Vector3 scaleUp;
    public float scaleDecrease = 0.02f;
    public float scaleIncrease = 0.01f;

    private Vector3 minValue = new Vector3(0,0,0);
    private Vector3 maxValue = new Vector3(1,0,0);


    // Start is called before the first frame update
    void Start()
    {
        scaleDown = new Vector3(-scaleDecrease, 0, 0);
        scaleUp = new Vector3(scaleIncrease, 0 ,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            if(usageBar.transform.localScale.x > minValue.x)
            {
            usageBar.transform.localScale += scaleDown;
            }
        }

        if(usageBar.transform.localScale.x <= 0)
        {
            canUse = false;
        }

        else
        {
            canUse = true;
        }
    }

    void FixedUpdate()
    {
        if(usageBar.transform.localScale.x < maxValue.x)
        {
        usageBar.transform.localScale += scaleUp;
        }
    }

}
