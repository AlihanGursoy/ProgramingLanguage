using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Technology : Entity
    {
        public int ProgramingLanguageID { get; set; }
        public string Name { get; set; }
        public virtual ProgramingLanguage? ProgramingLanguage { get; set; }

        public Technology()
        {

        }

        public Technology(int id, int programingLanguageID, string name) : this()
        {
            Id = id;
            ProgramingLanguageID = programingLanguageID;
            Name = name;
        }
    }
}
