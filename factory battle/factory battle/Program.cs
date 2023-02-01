class Program
{
    static void Main(string[] args)
    {
       
        Hero knight = new Hero(new knightFactory());
        Console.WriteLine("Рыцарь");
        knight.Hit();
        

        Console.ReadLine();
    }
}

//абстрактный класс - оружие
abstract class Weapon
{
    public abstract void Hit();
}
// класс арбалет
class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Стреляем из арбалета");
    }
}
// класс меч
class Sword : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Бьем мечом");
    }
}
// класс абстрактной фабрики
abstract class HeroFactory
{
    
    public abstract Weapon CreateWeapon();
}
// Фабрика создания героя с мечом
class knightFactory : HeroFactory
{
    

    public override Weapon CreateWeapon()
    {
        return new Sword();
    }
}
//  сам герой
class Hero
{
    private Weapon weapon;
    
    public Hero(HeroFactory factory)
    {
        weapon = factory.CreateWeapon();
        
    }
    public void Hit()
    {
        weapon.Hit();
    }
   
    
}