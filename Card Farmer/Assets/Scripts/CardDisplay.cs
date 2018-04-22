using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

    public Card card;

    public Text nameText;
    public Text descripitionText;
    public Text costText;
    public Text costText2;
    public Text benefitText;
    public Text benefitText2;
    public Image artworkImage;

	void Start () {

        nameText.text = card.name;
        descripitionText.text = card.description;
        costText.text = card.cost.ToString();
        costText2.text = card.cost.ToString();
        benefitText.text = card.benefit.ToString();
        benefitText2.text = card.benefit.ToString();
        artworkImage.sprite = card.artwork;
	}
	
}
