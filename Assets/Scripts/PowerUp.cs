using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum Type
    {
        Coin,
        ExtraLife,
        MagicMushroom,
        Starpower,
    }
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public Type type;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Player player)) {
            Collect(player);
        }
    }

    private void Collect(Player player)
    {
        switch (type)
        {
            case Type.Coin:
                audioManager.PlaySFX(audioManager.collectingCoins);
                GameManager.Instance.AddCoin();
                break;

            case Type.ExtraLife:
                audioManager.PlaySFX(audioManager.extraLife);
                GameManager.Instance.AddLife();
                break;

            case Type.MagicMushroom:
                audioManager.PlaySFX(audioManager.powerUp);
                player.Grow();
                break;

            case Type.Starpower:
                audioManager.PlaySFX(audioManager.invincible);
                player.Starpower();
                break;
        }

        Destroy(gameObject);
    }

}
