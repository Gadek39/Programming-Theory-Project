using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUnit : Unit
{
    // Start is called before the first frame update


    // Update is called once per frame

    public override void Working()
    {
        if (!startedWorking)
        {
            StartCoroutine(MilkGathering(workEfficency, arbitraryRateNumber));
        }
    }
    IEnumerator MilkGathering(float productionRate, float productionSpeed)
    {
        startedWorking = true;
        GameManager.instance.milk += productionRate;
        yield return new WaitForSeconds(productionSpeed); 
        startedWorking = false;
        
    }
}
