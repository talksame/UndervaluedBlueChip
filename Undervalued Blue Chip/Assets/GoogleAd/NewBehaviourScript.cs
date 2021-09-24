using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public void clclcl()
    {
        GameObject.Find("AD").GetComponent<AdmobInterstitialScript>().show();
    }

}
