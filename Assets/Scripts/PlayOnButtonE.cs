using UnityEngine;

public class PlayOnButtonE : MonoBehaviour
{
    [SerializeField] private ParticleSystem _ps;
    [SerializeField] private float _cooldown;

    private float _currCooldown;
    
    
    private void Update()
    {
        _currCooldown = Mathf.Clamp(_currCooldown - Time.deltaTime, 0f, _cooldown);

        if (Input.GetKeyDown(KeyCode.E))
            TryPlay();
    }

    private void TryPlay()
    {
        if (_currCooldown != 0)
            return;

        _ps.Play();
        _currCooldown = _cooldown;
    }
}