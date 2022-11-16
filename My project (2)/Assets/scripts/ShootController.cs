using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
   public GameObject BulletPrefab;
   float time = 0f;
   public float destroyTime = 3f;
   // Use this for initialization
   void Start() {

   }

   // Update is called once per frame
   void Update() {
       time += Time.deltaTime;
       if (Input.GetKeyUp(KeyCode.Space)) {
           if (time > 0.5f) {
               Instantiate(BulletPrefab, this.transform.position, this.transform.rotation);
               time = 0;
           }

       }
   }

}
