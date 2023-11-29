using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleSceneTransition : MonoBehaviour
{
    [SerializeField] Image hole;
    [SerializeField] Transform target;
    [SerializeField] float speed = 5; 
    // Start is called before the first frame update
    void Start(){
        OpeningTransition();
    }
    public void OpeningTransition(){
        RectTransform holeTransform = hole.GetComponent<RectTransform>();
        holeTransform.sizeDelta = new Vector2(0,0);
        StartCoroutine(OpeningTransitionRoutine());
        IEnumerator OpeningTransitionRoutine(){
            //holeTransform.position = new Vector2(target.position.x, target.position.y);
            while(holeTransform.sizeDelta.x  < 3000 ){
                holeTransform.sizeDelta = new Vector2(holeTransform.sizeDelta.x + (1*speed),holeTransform.sizeDelta.y + (1 * speed));
                yield return null;
            }
            yield return null;
        }
    }
    public void ClosingTransition(){
        RectTransform holeTransform = hole.GetComponent<RectTransform>();
        StartCoroutine(ClosingTransitionRoutine());
        IEnumerator ClosingTransitionRoutine(){
            while(holeTransform.sizeDelta.x != 0 ){
                holeTransform.sizeDelta = new Vector2(holeTransform.sizeDelta.x - (1*speed),holeTransform.sizeDelta.y - (1 * speed));
                yield return null;
            }
            yield return null;
        }
    }
}
