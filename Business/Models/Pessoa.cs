using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Pessoa:GenericModel,IComparable<Pessoa>
    {
        [Key]
        public long PessoaId { get; set; }

        public String Name { get; set; }
        public String CPF { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string name)
        {
            this.Name = name;
        }

        public Pessoa(string name, string cpf):this(name)
        {
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            //Testar CPF
            if(obj is Pessoa)
            {
                Pessoa other = obj as Pessoa;
                return this.CPF.Equals(other.CPF);
            }

            return false;
            
        }

        public override int GetHashCode()
        {
            return this.CPF.GetHashCode();
        }

        public int CompareTo(Pessoa other)
        {
            return this.Name.CompareTo(other.Name);
        }
        
    }
    
}
