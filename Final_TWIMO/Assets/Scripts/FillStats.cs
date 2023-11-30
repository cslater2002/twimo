using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FillStats : MonoBehaviour
{
    [SerializeField] Image happyLevel;
    [SerializeField] Image hungerLevel;
    [SerializeField] Image healthLevel;
    [SerializeField] int step = 64;
    [SerializeField] int height = 81;
    [SerializeField] int lstep, lheight = 100;
    [SerializeField] Text nameLabel;
    [SerializeField] Image fishPreview;
    [SerializeField] Image level;
    [SerializeField] Text levelLabel;
    public FishStats stats;
    public int index;

    public void fillStatsMenu(){
        index = stats.currentIndex;
        happyLevel.GetComponent<RectTransform>().sizeDelta = new Vector2(stats.list[index].happiness * step, height);
        hungerLevel.GetComponent<RectTransform>().sizeDelta = new Vector2(stats.list[index].hunger * step, height);  
        healthLevel.GetComponent<RectTransform>().sizeDelta = new Vector2(stats.list[index].health * step, height); 
        float levelRatio = (float) stats.list[index].levelProgress / (10 * stats.list[index].level);
        level.GetComponent<RectTransform>().sizeDelta = new Vector2(820 * levelRatio, 105);
        nameLabel.text = stats.list[index].fishName;
        levelLabel.text = "level " + stats.list[index].level;
        nameLabel.color = stats.list[index].color;
        fishPreview.GetComponent<Image>().sprite = stats.list[index].fishImage;
    }
}
