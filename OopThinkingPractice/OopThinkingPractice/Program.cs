using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OopThinkingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /* public class TV
     {
         private bool _isOn;
         private int _volume;

         public void TurnOn()
         {
             _isOn = true;
         }

         public void TurnOff()
         {
             _isOn = false;
         }

         public void IncreaseVolume()
         {
             if(!_isOn)

                 throw new InvalidOperationException("Tv is OFF.");

             if (_volume + 10 > 100)
                 _volume = 100;
             else
                 _volume += 10;


         }
         public void DecreaseVolume()
         {
             if (!_isOn) throw new InvalidOperationException("Tv is OFF");
             if (_volume - 10 > 0)
                 _volume = 0;
             else
                 _volume -= 10;


         }
     }*/

    /* public class MusicPlayer
     {
        private bool _isPlaying;
        private string _currentSong;
        private int _volume;

         public void Play()

         { 
             if (_isPlaying)
                 throw new InvalidOperationException("Music is already on");
             _isPlaying = true;
         }
         public void Stop()

         {
             if (!_isPlaying)
                 throw new InvalidOperationException("Music is already off");
             _isPlaying = false;
         }

         public void IncreaseVolumn()
         {
             if (!_isPlaying)
                 throw new InvalidOperationException("Music is off");
             if (_volume + 5 > 100)
                 _volume = 100;
             else
             _volume += 5;

         }
         public void DecreaseVolumn()
         {
             if (!_isPlaying)
                 throw new InvalidOperationException("Music is off");
             if (_volume - 5 < 0)
                 _volume = 0;
             else
                 _volume -= 5;

         }

     }*/

    /* public class BankAccount
     {
         private int _balance;
         private string _accountHolder;

         public void Deposit(int amount)
         {
             if (amount <= 0)
             { throw new ArgumentException("Cannot deposit 0 or negative money"); }
             else
             _balance += amount;
         }
         public void Withdraw(int amount)
         {
                 if (amount <= 0)
             { throw new ArgumentException("Cannot withdraw 0 or negative money"); }

             if (amount > _balance)

             { throw new ArgumentException("Cannot withdraw more than balance"); }

                 _balance -= amount;
         }
         public void ShowBalance(int amount)
         {
             Console.WriteLine(_balance);
         }

     }*/

  /*  public class GameCharacter
    {
        private string _name;
        private int _health;
        private bool _isAlive;

        public void Attack()
        {
            if (!_isAlive)
                throw new InvalidOperationException("Game Over!");

            Console.WriteLine("Character attacks!");
        }

        public void TakeDamage(int damage)
        {
            if (!_isAlive)
                throw new InvalidOperationException("Game over");

            if (_health - damage <= 0)
            {
                _health = 0;
                _isAlive = false;
            }
            else
            {
                _health -= damage;
            }
        }
        public void Heal(int healAmount)
        {
            if (!_isAlive)
                throw new InvalidOperationException("Game over");

            if (_health + healAmount > 100)
                _health = 100;
            else
                _health += healAmount;
        }
        public void Die()
        {
            _health = 0;
            _isAlive = false;
        }
    }*/

        /* public class Car
         {
             private string _model;
             private bool _isEngineOn;
             private int _speed;
             private int _fuel;

             public void StartEngine()
             {
                 if(_isEngineOn)

                     throw new InvalidOperationException("Engine already started");

                     _isEngineOn = true;

             }

             public void Accelerate(int accelerate)
             {
                 if (!_isEngineOn)
                 {
                     throw new InvalidOperationException("Start Engine");

                 }
                 if (_fuel == 0)
                 {
                     throw new InvalidOperationException("Need fuel");
                 }
                 if (_speed + accelerate > 250)
                     _speed = 250;
                 else
                 _speed += accelerate;

             }
             public void Brake()
             {
                 if (!_isEngineOn)
                 {
                     throw new InvalidOperationException("Start Engine");
                 }


                 if (_speed - 50 < 0)
                     _speed = 0;
                 else
                      _speed -= 50;

             }
         }*/
    
}
