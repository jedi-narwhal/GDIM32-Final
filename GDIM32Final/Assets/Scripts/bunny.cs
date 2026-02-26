using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoodState {
    calm, agitated, angry
}

public class bunny : MonoBehaviour
{

protected Animator _animator;
   public float _timer;
   protected MoodState _currentactivity;
    [SerializeField] private Transform _player;
    [SerializeField] private float _calm;
    [SerializeField] private float _agitated;
     [SerializeField] private float _angry;





    // Start is called before the first frame update
    void Start()
    {
        _animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
        RunState(); 
    }

        void UpdateState()
    {
        //decide what state bird is in -_current activity
        if (_timer<= _angry)
        {
           _currentactivity= MoodState.angry;
        }
        else if (_timer<=_agitated)
        {
           _currentactivity= MoodState.agitated;
        }
        else
        {
            _currentactivity= MoodState.calm;
        }
    }
   public  virtual void RunState()
    {
        switch (_currentactivity)
        {
            case MoodState.calm:
                PlayCalmAnimation();
                break;
            case MoodState.agitated:
                PlayAgitatedAnimation();
                break;
            case MoodState.angry:
                PlayAngryAnimation();
                break;

        }
        
    }

    private void PlayCalmAnimation()
    {
       _animator.SetBool("agitated", false);
       _animator.SetBool("angry", false);

       
    }
    private void PlayAgitatedAnimation()
    {
     _animator.SetBool("agitated", true);
      _animator.SetBool("angry", false);

    }
    private void PlayAngryAnimation()
    {
     _animator.SetBool("angry", true);
     _animator.SetBool("agitated", false);

    }



}
