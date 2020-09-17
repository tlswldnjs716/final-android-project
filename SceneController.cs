using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class SceneController : MonoBehaviour {
    public const int gridRows = 2;
    public const int gridCols = 4;
    //카드의 위치, 간격 조절
    public const float offsetX = 19f;
    public const float offsetY = 25f;

    [SerializeField] private MainCard originalCard;
    [SerializeField] private Sprite[] images;
    private void Start()
    {
        //if (GameObject.Find("ImageTarget") == true)
        Vector3 startPos = originalCard.transform.position;
            int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3 };
            numbers = shuffleArray(numbers);

            for (int i = 0; i < gridCols; i++)
            {
                for (int j = 0; j < gridRows; j++)
                {
                    MainCard card;
                    if (i == 0 && j == 0)
                    {
                        card = originalCard;
                        int index = 0;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    if (i == 0 && j == 1)
                    {
                        card = Instantiate(originalCard) as MainCard;
                        card.transform.position = new Vector3(-15, -12, 100);
                        card.transform.localScale = new Vector3(5, 5, 5);
                        card.transform.rotation = new Quaternion(0, 0, 0, 0);
                        int index = 1;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    if (i == 1 && j == 0)
                    {
                        card = Instantiate(originalCard) as MainCard;
                        card.transform.position = new Vector3(4, -12, 100);
                        card.transform.localScale = new Vector3(5, 5, 5);
                        card.transform.rotation = new Quaternion(0, 0, 0, 0);
                        int index = 2;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    if (i == 1 && j == 1)
                    {
                        card = Instantiate(originalCard) as MainCard;
                        card.transform.position = new Vector3(23, -12, 100);
                        card.transform.localScale = new Vector3(5, 5, 5);
                        card.transform.rotation = new Quaternion(0, 0, 0, 0);
                        int index = 3;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    if (i == 2 && j == 0)
                    {
                        card = Instantiate(originalCard) as MainCard;
                        card.transform.position = new Vector3(-34, 13, 100);
                        card.transform.localScale = new Vector3(5, 5, 5);
                        card.transform.rotation = new Quaternion(0, 0, 0, 0);
                        int index = 4;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    if (i == 2 && j == 1)
                    {
                        card = Instantiate(originalCard) as MainCard;
                        card.transform.position = new Vector3(-15, 13, 100);
                        card.transform.localScale = new Vector3(5, 5, 5);
                        card.transform.rotation = new Quaternion(0, 0, 0, 0);
                        int index = 5;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    if (i == 3 && j == 0)
                    {
                        card = Instantiate(originalCard) as MainCard;
                        card.transform.position = new Vector3(4, 13, 100);
                        card.transform.localScale = new Vector3(5, 5, 5);
                        card.transform.rotation = new Quaternion(0, 0, 0, 0);
                        int index = 6;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    if (i == 3 && j == 1)
                    {
                        card = Instantiate(originalCard) as MainCard;
                        card.transform.position = new Vector3(23, 13, 100);
                        card.transform.localScale = new Vector3(5, 5, 5);
                        card.transform.rotation = new Quaternion(0, 0, 0, 0);
                        int index = 7;
                        int id = numbers[index];
                        card.ChangeSprite(id, images[id]);
                    }
                    else
                    {
                        //card = Instantiate(originalCard) as MainCard;
                    }
                }
            }
    }
    //카드의 위치를 바꾸는 부분, 섞기
    private int[] shuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    //------------------------------------------------------------------------------------------------

    //카드 2개
    private MainCard _firstRevealed;
    private MainCard _secondRevealed;

    private int _score = 0;
    [SerializeField] private TextMesh scoreLabel;
    private GameObject clone;

    public bool canReveal
    {
        get { return _secondRevealed == null; }
    }

    public void CardRevealed(MainCard card)
    {
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
        }
        else
        {
            _secondRevealed = card;
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {
        //카드가 같을 경우
        if (_firstRevealed.id == _secondRevealed.id)
        {
            _score++;
            scoreLabel.text = "score: " + _score;
        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            _firstRevealed.Unreveal();
            _secondRevealed.Unreveal();
        }

        _firstRevealed = null;
        _secondRevealed = null;
    }
    public void ChangeGameScene()
    {
        if (scoreLabel.text == "score: " + "4")
        {
            SceneManager.LoadScene("toyAO");
        }
        else
        {
            SceneManager.LoadScene("toyAW");
        }
    }
}

