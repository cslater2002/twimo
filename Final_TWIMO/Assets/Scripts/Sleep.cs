using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleep : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Image overlay;
    public bool sleeping = false;
    public FishStats stats;
    public int moneyEarned = 0;
    public Inventory inventory;
    [SerializeField] Transform character;

    public void OnTriggerEnter2D(Collider2D other){
        sleeping = true;
    }

    public void OnTriggerExit2D(){
        sleeping = false;
    }

    void Update(){
        if(overlay.GetComponent<Image>().color.a > 2){
            foreach(FishData fish in stats.list){
                moneyEarned += fish.happiness;
                moneyEarned += fish.hunger;
            }
            inventory.money += moneyEarned;
            character.position = new Vector3(character.position.x + 1.5f, character.position.y, character.position.z);
            overlay.GetComponent<Image>().color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, 0);
            sleeping = false;
        }
        if(sleeping == true){
            overlay.GetComponent<Image>().color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, overlay.color.a + (1 * Time.deltaTime));
        }
        if(sleeping == false && overlay.GetComponent<Image>().color.a != 0){
            overlay.GetComponent<Image>().color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, overlay.color.a - (1 * Time.deltaTime));
        }

    }
}