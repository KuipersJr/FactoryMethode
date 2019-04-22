using System;

namespace FactoryMethod
{
    class FactoryMethod
    {
        public IPersonagem Escolher_Pesonagem(String personagem)
        {
            switch(personagem)
            {
                case "LiuKeng": return new LiuKeng();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
