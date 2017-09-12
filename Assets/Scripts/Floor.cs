using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SideScroller
{
    public class Floor : MonoBehaviour
    {
        public Transform Floor1;
        public Transform Floor2;
        public Transform cam;
        public float posY;
        public float lastPosY;

        private float currentWidth = 42f;
        private bool whichOne = true;



        void Update()
        {

            posY = Random.Range(-11.2f, 2);

            if (currentWidth < cam.position.x)
            {
                if (whichOne)
                {
                    Floor1.localPosition = new Vector3(Floor1.localPosition.x + 84, posY, 10);
                }
                else
                {
                    Floor2.localPosition = new Vector3(Floor2.localPosition.x + 84, posY, 10);
                }
                currentWidth += 42f;
                whichOne = !whichOne;
            }
            if (currentWidth > cam.position.x + 42)
            {
                if (whichOne)
                {
                    Floor2.localPosition = new Vector3(Floor2.localPosition.x - 84, posY, 10);
                }
                else
                {
                    Floor1.localPosition = new Vector3(Floor1.localPosition.x - 84, posY, 10);
                }
                currentWidth -= 42f;
                whichOne = !whichOne;
            }
        }
    }
}

