using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.entity
{
    internal class entity
    {
        public Guid Id { get; set; }

    }
    class owner: entity
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
    class Address : entity
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
    }
    class portfolioitem : entity
    {

        public string ProjectName { get; set; }
       
        public string Description {  get; set; }     
        public string ImgeUrl{ get; set; }
    }
}
