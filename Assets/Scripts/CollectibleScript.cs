using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public int collectibleScore = 0; // Store the score value of this collectible, editable from the Unity Inspector. (this allows different collectibles to be worth different amounts of points)

    public void Collect() // Custom method to handle the collection of this item, called from the PlayerScript when the player interacts with it
    {
        Destroy(gameObject);
    }
}
