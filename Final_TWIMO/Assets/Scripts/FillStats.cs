using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FillStats : MonoBehaviour
{
    [SerializeField] Image happyLevel;
    [SerializeField] Image hungerLevel;
    [SerializeField] int step = 64;
    [SerializeField] int height = 81;
    [SerializeField] Text nameLabel;
    [SerializeField] Image fishPreview;
    public FishStats stats;
    public int index;

    public void fillStatsMenu(){
        index = stats.currentIndex;
        happyLevel.GetComponent<RectTransform>().sizeDelta = new Vector2(stats.list[index].happiness * step, height);
        hungerLevel.GetComponent<RectTransform>().sizeDelta = new Vector2(stats.list[index].hunger * step, height);  
        nameLabel.text = stats.list[index].fishName;
        fishPreview.GetComponent<Image>().sprite = stats.list[index].fishImage;
    }
}
