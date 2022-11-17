using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public List<Card> cardController;
    public List<ShowCard> allCards;
<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
=======
>>>>>>> 7358d2d83fd856e534604605e0a0e97c862541ea

    public void GetCard(int optionSelected)
    {
        Card selectedCard = cardController[optionSelected];
        allCards[0].exibeCarta(selectedCard);
<<<<<<< HEAD
=======
        //se usuario escolher a carta, enviar seu indice para outro array para uso no resgate de cartas
        //se o usuário recusar a carta, manter o indice no array (ou em outro com possibilidade de reaver)
>>>>>>> 7358d2d83fd856e534604605e0a0e97c862541ea
    }
}
