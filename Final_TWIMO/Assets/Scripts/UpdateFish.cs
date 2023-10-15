using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFish : MonoBehaviour
{
    // Start is called before the first frame update
    public FishStats stats;

    public void updateCurrentFish(int roomNum){
        stats.currentIndex = roomNum;
    }
}
