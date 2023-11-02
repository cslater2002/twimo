using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseController : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    [SerializeField] Canvas inventory;
    [SerializeField] Text moneyLabel;
    [SerializeField] GameObject item1;
    [SerializeField] GameObject item2;
    [SerializeField] GameObject item3;
    [SerializeField] Image optionsMenu;
    [SerializeField] Slider musicSlider;
    public Inventory playerInventory;

    void Start(){
        canvas.enabled = false;
        optionsMenu.gameObject.SetActive(false);
        if(inventory != null){        
            inventory.enabled = false;
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            canvas.enabled = true;
            optionsMenu.gameObject.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.T) && SceneManager.GetActiveScene().name != "FishWorld" && SceneManager.GetActiveScene().name != "FishRoom"){
            if(inventory.enabled == false){
                var items = new List<GameObject> {item1, item2, item3};
                foreach(GameObject item in items){
                    item.active = true;
                }
                moneyLabel.text = "$";
                moneyLabel.text += playerInventory.money;
                int itemCount = 0;
                for(int i = 0; i < 16; i++){
                    if(itemCount < playerInventory.items.Count && playerInventory.items[itemCount].quantityOwned > 0){
                        items[i].GetComponent<SpriteRenderer>().sprite = playerInventory.items[itemCount].itemImage;
                        itemCount++;
                    }
                }
                inventory.enabled = true;
            }
            else{
                var items = new List<GameObject> {item1, item2, item3};
                foreach(GameObject item in items){
                    item.active = false;
                }
                inventory.enabled = false;
            }
        }
    }

    public void PauseOn(){
        canvas.enabled = true;
    }
    public void PauseOff(){
        canvas.enabled = false;
    }

    public void OptionsMenuOn(){
        optionsMenu.gameObject.SetActive(true);
    }
    public void OptionsMenuOff(){
        optionsMenu.gameObject.SetActive(false);
    }

    public void SliderOnValueChanged(string slider){
        if(slider == "music"){
            //musicSlider.value;
        }
        if(slider == "sfx"){

        }
        if(slider == "ambient"){

        }

    }
}
