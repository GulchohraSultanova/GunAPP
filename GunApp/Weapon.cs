using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunApp
{
    internal class Weapon
    {
        public int BulletCapacity { get; set; }
        public int BulletCount { get; set; }
        public bool ShootingMode{ get; set; }
        public Weapon(int bulletCapacity,int bulletCount,bool shootingMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            ShootingMode = shootingMode;
        }
        public void Shoot()
        {
            if(BulletCount >= 0)
            {
                BulletCount=BulletCount-1;
                Console.WriteLine("Silah gulle atdi");
            }
            else
            {

                Console.WriteLine("Silahda gulle sayi sifirdir");
              
            }
            
            
        }
        public void Fire()
        {
            BulletCount = 0;
            Console.WriteLine("Daraqdaki butun gulleler atelsendi"); ;
        }
        public int GetRemainBulletCount()
        {
            return BulletCapacity-BulletCount;
        }
        public void Reload()
        {
            BulletCount = BulletCapacity;
            Console.WriteLine("Daraq yeniden doldu");
        }
        public void ChangeFireMode()
        {
            if(ShootingMode==false)
            {

                ShootingMode=true;
                Console.WriteLine("Daragin atis modu tekliye cevrildi.");
            }
            else
            {
                ShootingMode = false;
                Console.WriteLine("daragin atis modu avtomatike cevrildi"); ;
            }
        }



    }
}
