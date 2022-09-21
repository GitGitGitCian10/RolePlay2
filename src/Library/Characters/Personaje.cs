namespace RoleplayGame
{
    public interface IPersonaje
    {
        int Health {get;}
        string Name {get;set;}
        int AttackValue {get;}
        int DefenseValue {get;}
        void ReceiveAttack(int power);
        void Cure();
    }
}