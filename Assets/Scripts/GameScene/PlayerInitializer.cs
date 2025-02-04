using System.Collections.Generic;
using UnityEngine;

public class PlayerInitializer : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> _personSprites = new List<Sprite>();

    [SerializeField]
    private SpriteRenderer _playerSprite;

	[SerializeField]
	private Animator _playerAnimator;

	[SerializeField]
	private List<RuntimeAnimatorController> _personControllers = new List<RuntimeAnimatorController>();

	private readonly string _currentCharacterKey = "CharacterKey";

	private int currentCharacter;


	private void Awake()
    {
        if (!PlayerPrefs.HasKey(_currentCharacterKey))
            PlayerPrefs.SetInt(_currentCharacterKey, 0);

        currentCharacter = PlayerPrefs.GetInt(_currentCharacterKey, 0);
	}

	private void Start()
	{
		_playerSprite.sprite = _personSprites[currentCharacter];

		_playerAnimator.runtimeAnimatorController = _personControllers[currentCharacter];
	}
}
