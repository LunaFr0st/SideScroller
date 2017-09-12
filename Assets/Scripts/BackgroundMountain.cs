using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SideScroller
{
    public class BackgroundMountain : MonoBehaviour
    {

        public Transform background1;
        public Transform background2;
        public Transform cam;
        public float speed = 108;
        private float currentWidth = 54f;
        private bool whichOne = true;


        void Update()
        {
            if (currentWidth < cam.position.x)
            {
                if (whichOne)
                {
                    background1.localPosition = new Vector3(background1.localPosition.x + speed, -4.4f, 10);
                }
                else
                {
                    background2.localPosition = new Vector3(background2.localPosition.x + speed, -4.4f, 10);
                }
                currentWidth += 54;
                whichOne = !whichOne;
            }
            if (currentWidth > cam.position.x + 54)
            {
                if (whichOne)
                {
                    background2.localPosition = new Vector3(background2.localPosition.x - speed, -4.4f, 10);
                }
                else
                {
                    background1.localPosition = new Vector3(background1.localPosition.x - speed, -4.4f, 10);
                }
                currentWidth -= 54;
                whichOne = !whichOne;
            }
        }
    }
}

