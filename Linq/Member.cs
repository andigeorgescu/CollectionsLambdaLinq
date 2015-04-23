using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BandId { get; set; }

        public Member(int id, string name, int bandId)
        {
            this.Id = id;
            this.Name = name;
            this.BandId = bandId;
        }
    }
   
}

