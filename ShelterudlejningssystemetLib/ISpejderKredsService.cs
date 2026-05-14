using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterudlejningssystemetLib
{
    public interface ISpejderKredsService
    {
        public void AddKreds(SpejderKreds newKreds);
        public SpejderKreds Remove(int kredsId);
        public SpejderKreds Get(int kredsID);
        public List<SpejderKreds> GetAll();
        public SpejderKreds Edit(int kredsID, string newName, int newStørrelse);
        
    }
}
