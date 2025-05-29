using System.Collections.Generic;

public class EnemyFactory
{
    private List<Enemy> enemyList = new List<Enemy>();

    public Enemy CreateEnemy(string name)
    {
        Enemy newEnemy = new Enemy(name);
        enemyList.Add(newEnemy);
        return newEnemy;
    }

    public List<Enemy> GetAllEnemies()
    {
        return enemyList;
    }

    public void CreateDefaultEnemies()
    {
        CreateEnemy("Muhammad");
        CreateEnemy("Abdul");
        CreateEnemy("Yusuf");
        CreateEnemy("AbuHaya");
        CreateEnemy("Mahmoud");
    }
}
