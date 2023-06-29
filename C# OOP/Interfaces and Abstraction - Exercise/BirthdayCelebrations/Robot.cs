using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Robot : IIdentity
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }
    }
}
