using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFish : MonoBehaviour
{
    public FishStats stats;

    public void updateCurrentFish(int roomNum){
        stats.currentIndex = roomNum;
    }
}
