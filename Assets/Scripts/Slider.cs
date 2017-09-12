using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SideScroller
{
    public class Slider : MonoBehaviour
    {
        public Transform cam;
        float speed;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            cam.localPosition = new Vector3(speed, 0, 0);
            speed += 0.1f;
        }
    }
}

