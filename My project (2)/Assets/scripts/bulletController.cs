using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
   public float speed = 0.1f;
   // Use this for initialization
   void Start() {
      Destroy(this.gameObject,3.0f);    
   }

   // Update is called once per frame
   void Update() {
       this.transform.Translate(new Vector3(0, -speed, 0));
       }

   private void OnCollisionEnter(Collision collision){  
   if(collision.gameObject.tag == "Target"){
         Destroy(this.gameObject);
         Destroy(collision.gameObject);
      }
   }
}
