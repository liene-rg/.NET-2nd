using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Computer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string OSFamily { get; set; }
        public string LatestVersion { get; set; }

        public override string ToString()
        {
            return "ID:" + this.ID + ";Name:" + this.Name + ",Developer:" + this.Developer + ",OS Family:" + this.OSFamily + ",Latest Version:" + this.LatestVersion;
        }



    }
}
