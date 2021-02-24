public class Health
{
    public int health = 15;
    public int maxHealth = 100;

    public float CurrentHealthPercent()
    {
        return (float)health/maxHealth * 100;
    }

}