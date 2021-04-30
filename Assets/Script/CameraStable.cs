using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour{    
    public GameObject TheCar;
    public float CarX, CarY, CarZ;



    // Update is called once per frame
    void Update(){
        CarX = TheCar.transform.eulerAngles.x;
        CarY = TheCar.transform.eulerAngles.y;
        CarZ = TheCar.transform.eulerAngles.z;
        // make the camera static
        transform.eulerAngles = new Vector3(0f,CarY,0f);
    }
}
