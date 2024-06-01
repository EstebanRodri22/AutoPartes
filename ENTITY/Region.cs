using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Region
    {
        public Region()
        {

        }
        public Region(int region_Id, string region_Name)
        {
            Region_Id = region_Id;
            Region_Name = region_Name;
        }

        public int Region_Id { get; set; }
        public string Region_Name { get; set; }
    }
}
