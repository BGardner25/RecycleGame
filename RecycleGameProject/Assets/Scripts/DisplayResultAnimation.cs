using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayResultAnimation : MonoBehaviour
{
    public GameObject correctAnim;
    public GameObject incorrectAnim;
    private GameObject cloneObject;

    // create
    // play anim
    // destroy

    public void DisplayCorrectAnim(Vector2 pos)
    {
        if (cloneObject)
            Destroy(cloneObject);
        cloneObject = Instantiate(correctAnim, pos, Quaternion.identity);
        Destroy(cloneObject, cloneObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }

    public void DisplayIncorrectanim(Vector2 pos)
    {
        if (cloneObject)
            Destroy(cloneObject);
        cloneObject = Instantiate(incorrectAnim, pos, Quaternion.identity);
        Destroy(cloneObject, cloneObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
}
