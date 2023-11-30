using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayHandler : MonoBehaviour
{
    public Day dayIndex;
    [SerializeField] GameObject day;
    [SerializeField] Sprite day1;
    [SerializeField] Sprite day2;
    [SerializeField] Sprite day3;
    [SerializeField] Sprite day4;
    [SerializeField] Sprite day5;
    List<Sprite> dayImages;

    void Awake(){
        dayImages = new List<Sprite>();
        dayImages.Add(day1);
        dayImages.Add(day2);
        dayImages.Add(day3);
        dayImages.Add(day4);
        dayImages.Add(day5);
    }

    void Start()
    {
        DisplayDay();
    }

    public void DisplayDay(){
        day.GetComponent<Image>().sprite = dayImages[dayIndex.dayIndex];
    }
    public void UpdateDay(){
        dayIndex.dayIndex++;
        if(dayIndex.dayIndex >= 5){
            dayIndex.dayIndex = 0;
        }
         DisplayDay();
    }
    public void UpdateDay(int newIndex){
        dayIndex.dayIndex = newIndex;
         DisplayDay();
    }
}
