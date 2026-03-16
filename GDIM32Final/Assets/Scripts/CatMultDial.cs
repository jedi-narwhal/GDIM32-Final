using TMPro;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;


public class CatMultDial : MonoBehaviour
{
    [SerializeField] private float _interactionDistance = 2.0f;
    [SerializeField] private Sprite _interactionPromptSprite;
    [SerializeField] private Image _thoughtBubble;
    [SerializeField] private DialogueUI _dialogue;
    [SerializeField] private DialogueNode _dialogueStartNode;
    [SerializeField] private DialogueNode _hasBatteryStartNode;
    [SerializeField] private GameObject _battery;
    [SerializeField] private GameObject _key;

    private DialogueNode _currentNode;
    private int _currentLine = 0;
    private bool _runningDialogue;
    private bool _waitingForPlayerResponse;
    private bool _timerstart;
    private bool keyspawn;
    private bool batteryspawn;

    private void Awake()
    {
        _key.SetActive(false);
        _battery.SetActive(false);
    }

    private void Start()
    {
        _currentNode = _dialogueStartNode;        
    }

    private void Update()
    {
        if (player.Instance == null) return;

        if (Vector3.Distance(transform.position, player.Instance.transform.position) < _interactionDistance)
        {
            _thoughtBubble.gameObject.SetActive(true);

            if (!_waitingForPlayerResponse && Input.GetKeyDown(KeyCode.Space))
            {
                if (!_runningDialogue)
                {
                    SetDialogue();
                }
                player.Instance._dialogueUI.gameObject.SetActive(true);
                AdvanceDialogue();
            }
            else if (!_runningDialogue)
            {
                _thoughtBubble.sprite = _interactionPromptSprite;
            }
            else
            {
              //  EndDialogue();
            }
        }
    }

    private void AdvanceDialogue()
    {
        _timerstart = false;
        _runningDialogue = true;
        _thoughtBubble.sprite = _currentNode._thoughtBubbleSprite;

        if (_currentNode == _dialogueStartNode &&_battery != null && !batteryspawn) 
        {
            _battery.SetActive(true);
            batteryspawn = true;
        }

        if (_currentLine < _currentNode._lines.Length)
        {
            // if we still have NPC lines left, keep playing NPC lines
            _dialogue.ShowDialogue(_currentNode._lines[_currentLine]);
            _currentLine++;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (_currentNode._playerReplyOptions != null && _currentNode._playerReplyOptions.Length > 0)
        {
            // show player dialogue options, if there are any
            _waitingForPlayerResponse = true;
            _dialogue.ShowPlayerOptions(_currentNode._playerReplyOptions);
        }
        else
        {
            // if there are no NPC or player lines left, close dialogue UI
            EndDialogue();
            _timerstart = true;
        }
    }

    private void EndDialogue()
    {
        _runningDialogue = false;
        _waitingForPlayerResponse = false;

        if(player.Instance._hasBattery && !keyspawn) 
        {
            _key.SetActive(true);
            keyspawn = true;
        }

        SetDialogue();
        _currentLine = 0;

        _dialogue.HideDialogue();
        _thoughtBubble.gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void SelectedOption(int option)
    {
        _currentLine = 0;
        _waitingForPlayerResponse = false;

        _currentNode = _currentNode._npcReplies[option];

        AdvanceDialogue();
    }

    public void SetDialogue() 
    {
        if (player.Instance != null && player.Instance._hasBattery)
        {
            _currentNode = _hasBatteryStartNode;
        }
        else 
        {
            _currentNode = _dialogueStartNode;
        }
    }
}
