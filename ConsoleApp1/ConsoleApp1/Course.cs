using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{

    /*
     *  Εδώ έκανα μια αλλαγή για να δόύμε κάτι ενδιαφέρον. 
     *  
     *  Έφτιαξα έναν constructor που παίρνει ένα string για τον τίτλο του μαθήματος 
     *  (δεν έχει νόημα ένα μάθημα χωρίς τίτλο). 
     *  
     *  Στο property έχω μόνο get - δεν είναι υποχρεωτικό να έχω και τα δυο. 
     *  
     *  Βέβαια δεν θα μπορώ να αλλάξω τίτλο σε μάθημα ... αλλά δεν με νοιάζει. 
     *  
     *  Επίσης, πρόσθεσα μια bool τιμή για το αν έχει περάσει το μάθημα.  
     *  
     *  Στον constructor την αρχικοποιώ με τιμή false.  Όταν φτιάχνω το μάθημα για να 
     *  το 'δώσω' σε έναν φοιτητή (να περαστεί στην λίστα του) θεωρώ πως δεν το έχει 
     *  περάσει ακόμα, οπότε θέλω η τιμή να είναι false.
     *  
     */
    class Course
    {

        public Course(string title)
        {
            Title = title;
            Passed = false;
        }

        public string Title { get; }

        public bool Passed { get; set; }
    }
}
