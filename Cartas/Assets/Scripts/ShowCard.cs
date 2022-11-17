using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCard : MonoBehaviour
{

    public Card _card;
    public TMP_Text fieldName;
    public TMP_Text fieldCost;
    public TMP_Text fieldPower;
    public TMP_Text fieldLife;
    // public Image fieldImage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exibeCarta(Card exibirCarta)
    {
        _card = exibirCarta;
        fieldName.text = _card.CardName;
        fieldCost.text = _card.Cost.ToString();
        fieldPower.text = _card.Power.ToString();
        fieldLife.text = _card.Life.ToString();

        GetComponent<Image>().color = _card.Cor;

        gameObject.SetActive(true);
    }
}
