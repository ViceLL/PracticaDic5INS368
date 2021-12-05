using System;

namespace GrabacionTareaDic5INS368
{
    internal class Door
    {
        public bool Opened, Locked;
        Door objeto;

        public Door(bool Opened, bool Locked)
        {
            this.Opened = Opened;
            this.Locked = Locked;
        }
        public bool isOpen
        {
            get
            {
                return Opened;
            }
        }
        public bool isClosed
        {
            get
            {
                return !Opened;
            }
        }

        public bool isLocked
        {
            get
            {
                return Locked;
            }
        }
        public bool isUnlocked
        {
            get
            {
                return !Locked;
            }
        }

        public bool Open()
        {
            objeto = new Door(isOpen, isUnlocked);
            return true;
        }

        public bool Close()
        {
            objeto = new Door(isClosed, isUnlocked);
            return true;
        }

        public bool Lock(string key)
        {
            objeto = new Door(isClosed, isLocked);
            return true;
        }

        public bool Unlock(string key)
        {
            if (key == "strongKey")
            {
                objeto = new Door(isOpen, isUnlocked);
                return true;
            }
            objeto = new Door(isClosed, isUnlocked);
            return false;
        }

        public bool OpenAndUnlocked(string key)
        {
            if(objeto.Open() && objeto.Unlock(key) && key == "strongKey")
            {
                Console.WriteLine("The door is now opened and unlocked.");
                objeto = new Door(isOpen, isLocked);
                return true;
            }
            else 
            {
                Console.WriteLine("The door could not be opened and unlocked.");
                return false;
            }
        }

        public bool ClosedAndUnlocked(string key)
        {
            if(objeto.Close() && objeto.Unlock(key) && key == "strongKey")
                {
                Console.WriteLine("The door is now closed and unlocked.");
                objeto = new Door(isOpen, isLocked);
                return true;
            }
            else
            {
                Console.WriteLine("The door could not be closed and unlocked.");
                return false;
            }
        }

        public bool OpenAndLocked(string key)
        {
            if (objeto.Open() && objeto.Lock(key) && key == "Locked")
            {
                Console.WriteLine("The door is now open and locked.");
                objeto = new Door(isOpen, isLocked);
                return true;
            }
            else 
            {
                Console.WriteLine("The door could not be opened and locked.");
                return false;
            }
        }

        public bool ClosedAndLocked(string key)
        {
            if(objeto.Close() && objeto.Lock(key) && key == "Locked")
            {
                Console.WriteLine("The door is now closed and locked.");
                objeto = new Door(isOpen, isLocked);
                return true;
            }
            else
            {
                Console.WriteLine("The door could not be closed and locked.");
                return false;
            }
        }

    }
}