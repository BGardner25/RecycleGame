using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositScript : MonoBehaviour
{
    public static bool isItemCorrect = false;
    public HealthBarScript healthBar;
    public DisplayResultAnimation displayAnimation;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(this.gameObject.tag))
            isItemCorrect = true;
        else
            isItemCorrect = false;
    }

   void OnTriggerStay2D(Collider2D other)
   {
        
        if (ClickAndDrag.hasBeenDropped)
        {
            FindObjectOfType<ItemManager>().DestroyItem(other.gameObject);
            displayAnimation.DisplayCorrectAnim(transform.position);
            ScoreDisplay.score += 100;
        }
   }

    void OnTriggerExit2D(Collider2D other)
    {
        if (ClickAndDrag.hasBeenDropped)
            if (!isItemCorrect)
            {
                displayAnimation.DisplayIncorrectanim(transform.position);
                healthBar.RemoveHealth();
            }
        isItemCorrect = false;
    }
}
