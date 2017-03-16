using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class Chase_1 : MonoBehaviour {
    //public variable in the inspector can pass FPS controller through it
    public Transform player;



	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        //test for the distance between the players position and the skeletons position

        if (Vector3.Distance(player.position, this.transform.position) < 10)
        {
            //direct line between enemy and player
            Vector3 direction = player.position - this.transform.position;
            //----->fix from Issue 1->Removing y axis out of equation<--//
            direction.y = 0;
            //rotate with slerp so it rotates slowly and doesn't snap toward position.
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            //->Go back into Unity and add this to the skeleton, then drag player to player in inspector<-//
            // ->Issues 1, moving forward causes him to tip over because your position is ontop of him.<--//
            

            if (direction.magnitude > 5)
            {
                //if that direction vector we calculated magnitude is greater than 5, translate skeleton in(See below)
                this.transform.Translate(0, 0, 0.05f);
            }
        }
    }
}
