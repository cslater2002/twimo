using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateFish : MonoBehaviour
{
    public FishStats stats;
    [SerializeField] Sprite windowImg;
    [SerializeField] Sprite normalImg;
    [SerializeField] Button window1;
    [SerializeField] Button window2;
    [SerializeField] Button window3;
    [SerializeField] Button window4;
    [SerializeField] Button window5;
    [SerializeField] Button window6;
    [SerializeField] Button window7;
    [SerializeField] Button window8;
    [SerializeField] Button window9;
    [SerializeField] Button window10;
    [SerializeField] Button window11;
    [SerializeField] Button window12;
    [SerializeField] Button window13;
    [SerializeField] Button window14;
    [SerializeField] Button window15;
    [SerializeField] Button window16;
    [SerializeField] Button window17;
    [SerializeField] Button window18;
    [SerializeField] Button window19;
    [SerializeField] Button window20;

    void Start(){
        List<Button> windows = new List<Button> {window1, window2, window3, window4, window5, window6, window7, window8, window9, window10, window11, window12, window13, window14, window15, window16, window17, window18, window19, window20};
        int i = 0;
        foreach(FishData fish in stats.list){
            if(fish.isUnlocked != 1){
                windows[i].enabled = false;
                windows[i].image.sprite = windowImg;
            }
            else{
                windows[i].enabled = true;
                windows[i].image.sprite = normalImg;
            }
            i++;
        }
    }

    public void updateCurrentFish(int roomNum){
        stats.currentIndex = roomNum;
    }
}
