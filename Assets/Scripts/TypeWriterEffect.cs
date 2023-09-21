using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text;
using TMPro;

public class TypeWriterEffect : MonoBehaviour
{
    [SerializeField] List<GameObject> characters;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public float autoSpeed;
    private int index;
    private int _characterIndex = 0;

    bool isAuto = false;

    [SerializeField] Button nextButton;
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    public void NextLineButton()
    {
        isAuto = false;
        if (textComponent.text == lines[index])
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            textComponent.text = lines[index];
        }
    }

    public void SetAutoText()
    {
        isAuto = true;
        if (textComponent.text == lines[index])
        {
            NextLine();
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        if (isAuto)
        {
            yield return new WaitForSeconds(autoSpeed);
            NextLine();
        }
    }
    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            ChangeCharacter();
            StartCoroutine(TypeLine());
        }
        if(index == lines.Length - 1)
        {
            nextButton.onClick.RemoveAllListeners();
            nextButton.onClick.AddListener(NextScene);
        }
    }

    void ChangeCharacter()
    {
        foreach (var character in characters)
        {
            character.SetActive(false);
        }
        
        _characterIndex++;
        if (_characterIndex == characters.Count) _characterIndex = 0;
        characters[_characterIndex].SetActive(true);
    }

    void NextScene()
    {
        Buttons buttons = FindObjectOfType<Buttons>();
        buttons.NextScene();
    }
}
 