using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CloseDialogueBtn : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick(PointerEventData eventData) {
        GetComponentInParent<UIManager>().CloseDialogue();
    }

}
