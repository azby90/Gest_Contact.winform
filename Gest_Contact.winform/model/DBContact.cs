using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Contact.winform.model
{
    internal class DBContact
    {
        //on va declrer un liste de contact
        //nom de variable listContact
        //pour rendre cette variable goblal pour quel ne depende pas de l'instante
        //pour pouvoir l'utiliser sans creer préalablement l'objet j'utilise static


        public static List<Contact> listContact;
        //creation d'une fonction pour ajouter un contact
        // le type de la methode est "int" car je veux recperr le dernier id creer
        public static int AddContact(Contact c)
        {
            //si la liste n'est pas initialiser 
            if (listContact == null)
            {

                listContact = new List<Contact>();  
            }
            //pour recuperer l"id et l'incrementer
            //"Any()" verifier si il y a au moin contact
            //si l"objet contient au - 1 element on recupere le max
            //a voir expression lambda
            //Sinon l'identifiant prends la valeur 100

            c.Id = listContact.Any() ? listContact.Max(x => x.Id)+1: 100;

            //on ajoute le contact

            listContact.Add(c);
            return c.Id ;
        }
    }
    //recuperer la liste des contacts
    
}
