using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogueBoxManager : MonoBehaviour
{
    public SpriteRenderer DialogueSprite;
    public TextMesh DialogueText;

    List<String> TextLoadout;

    List<DialogueStruct> DiLoadout;


    int CurrTextIndex, currDiIndex;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void init2(Dialogue dialogue)
    {
        DialogueSprite.sprite = dialogue.Face;

        var bounds = DialogueSprite.sprite.bounds;
        var factor = 2.3f / bounds.size.y;
        DialogueSprite.transform.localScale = new Vector3(factor, factor, factor);

        TextLoadout = createLoadlout(dialogue.Text);

        CurrTextIndex = 0;

        DialogueText.text = TextLoadout[CurrTextIndex];

        gameObject.SetActive(true);
    }


    public void init(Dialogue dialogue)
    {
        DiLoadout = dialogue.Lines;
        currDiIndex = 0;

        TextLoadout = createLoadlout(DiLoadout[0].Text);

        PositionImage(DiLoadout[0].Face);


        CurrTextIndex = 0;

        DialogueText.text = TextLoadout[CurrTextIndex];

        gameObject.SetActive(true);
    }

    public void LoadDialogue()
    {
        currDiIndex++;

        TextLoadout = createLoadlout(DiLoadout[currDiIndex].Text);

        CurrTextIndex = 0;

        PositionImage(DiLoadout[currDiIndex].Face);
    }

    public void PositionImage(Sprite sprite)
    {
        DialogueSprite.sprite = sprite;

        var bounds = DialogueSprite.sprite.bounds;
        var factor = 2.3f / bounds.size.y;
        DialogueSprite.transform.localScale = new Vector3(factor, factor, factor);
    }

    public void LeafThrough()
    {
        CurrTextIndex++;

        if (CurrTextIndex >= TextLoadout.Count)
        {
            if (currDiIndex < DiLoadout.Count)
            {
                LoadDialogue();
            }
            else
            {
                CloseDialogueBox();
            }
        }
        else
        {
            DialogueText.text = TextLoadout[CurrTextIndex];
        }
    }


    private void OnMouseDown()
    {
        LeafThrough();
    }

    public List<String> createLoadlout(string BaseText)
    {
        return BaseText.Split(';').ToList<String>();
    }

    public void CloseDialogueBox()
    {
        TextLoadout.Clear();
        DialogueSprite.sprite = null;
        DialogueText.text = "";
        gameObject.SetActive(false);
    }
}
