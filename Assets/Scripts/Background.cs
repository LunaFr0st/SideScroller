using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SideScroller
{
    public class Background : MonoBehaviour
    {

        public Transform background1;
        public Transform background2;
        public Transform cam;

        private float currentWidth = 42f;
        private bool whichOne = true;


        void Update()
        {
            if (currentWidth < cam.position.x)
            {
                if (whichOne)
                {
                    background1.localPosition = new Vector3(background1.localPosition.x + 84, 0, 10);
                }
                else
                {
                    background2.localPosition = new Vector3(background2.localPosition.x + 84, 0, 10);
                }
                currentWidth += 42f;
                whichOne = !whichOne;
            }
            if (currentWidth > cam.position.x + 42)
            {
                if (whichOne)
                {
                    background2.localPosition = new Vector3(background2.localPosition.x - 84, 0, 10);
                }
                else
                {
                    background1.localPosition = new Vector3(background1.localPosition.x - 84, 0, 10);
                }
                currentWidth -= 42f;
                whichOne = !whichOne;
            }
        }
    }
}

