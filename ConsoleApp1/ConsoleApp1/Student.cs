using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Student
    {

        // constructor για την κλάση Student - δέχεται ένα string που το χρησιμοποιώ για να δώσω τιμή στην Property Name
        // και επίσης αρχικοποιεί (δημιουργεί) μια λίστα με μαθήματα - πάλι χρησιμοποιώντας το αντίστοιχο Property.
        public Student(String name)
        {
            Name = name;

            Courses = new List<Course>();
        }

        public string Name { get; set; }

        public List<Course> Courses { get; set; }



        // Απλή μέθοδος που δέχεται ένα αντικείμενο τύπου Course και το προσθέτει στην λίστα Courses του φοιτητή
        // χρησιμοποιώντας την μέθοδο Add που υπάρχει για ΚΑΘΕ ΛΙΣΤΑ και προσθέτει ένα νέο αντικείμενο στο τέλος της λίστας. 
        public void AddCourse(Course c)
        {
            Courses.Add(c);
        }

        // Απλή μέθοδος που αφαιρεί το αντικείμενο c τύπου Course από την λίστα.  Θα αφαιρέσει το ΠΡΩΤΟ αντικείμενο που θα βρει
        // και θα είναι ίδιο με το c που έρχεται ως παράμετρος.  Η μέθοδος Remove που υπάρχει για όλες τις λίστες, γυρνάει ένα 
        // bool ανάλογα αν πέτυχε η αφαίρεση ή όχι.  Δεν είναι απαραίτητο, αλλά χρησιμοποιώ αυτό το bool για να τυπώσω ένα 
        // κατάλληλο μήνυμα. 
        public void RemoveCourse(Course c)
        {
            bool removed = Courses.Remove(c);

            if (removed)
            {
                Console.WriteLine("Αφαίρεσα το μάθημα " + c.Title + " από την λίστα μαθημάτων του φοιτητή " + Name);
            }
            else
            {
                Console.WriteLine("Δεν βρέθηκε το μάθημα " + c.Title + " στην λίστα μαθημάτων του φοιτητή " + Name);
            }
        }

        /*
         *  Λίγο πιο πολύπλοκη μέθοδος - χρησιμοποιεί τα lambda expressions που δεν έχουμε πει.  
         *  
         *  Με απλά λόγια όμως, τι κάνει:
         *  
         *  Παίρνει σαν input ένα αντικείμενο Course, τσεκάρει να βρει αν υπάρχει παρόμοιο αντικείμενο 
         *  στην λίστα Courses του φοιτητή, και αν υπάρχει τότε αλλάζει την τιμή του Passed για το συγκεκριμένο
         *  και την κάνει true. 
         *  
         *  Θα μπορούσα να μην έχω τον έλεγχο με το FindIndex, αλλά τότε αν πήγαινα κατά λάθος να περάσω τον 
         *  φοιτητή δεν μάθημα που ΔΕΝ έχει δηλωμένο, το πρόγραμμα θα έβγαζε λάθος και θα τερμάτιζε την λειτουργία του. 
         *  Με τον έλεγχο όμως, μπορώ να τυπωσω κατάλληλο μήνυμα και να συνεχίσει η λειτουργία του προγράμματος. 
         */
        public void PassCourse(Course c)
        {
            Console.WriteLine();
            Console.WriteLine("Αποφάσισα να περάσω τον φοιτητή " + Name + " στο μάθημα " + c.Title);

            // εδώ ψάχνω να δω αν υπάρχει παρόμοιο αντικείμενο στην λίστα - αν υπάρχει, το index που δείχνει 
            // την θέση του θα είναι μεγαλύτερο ή ίσο με το μηδέν.  Αν ΔΕΝ υπάρχει, σημαίνει πως προσπάθησα 
            // να περάσω τον φοιτητή σε μάθημα που δεν έχει δηλώσει - η τιμή του index θα είναι -1.  
            // Το έβαλα εδώ για να σας δείξω ακόμα μια μέθοδο στις λίστες, την FindIndex. 

            // το 'x' που είναι μέρος της lambda expression x => x.Equals(c) που δεν έχετε ξαναδεί, 
            // με απλά ελληνικά κάνει το εξής - λέει, έστω ένα αντικείμενο 'x' τύπου Course, 
            // ΥΠΑΡΧΕΙ ΣΤΗ ΛΙΣΤΑ ΚΑΠΟΙΟ 'x' ΓΙΑ ΤΟ ΟΠΟΙΟ ΝΑ ΙΣΧΥΕΙ x.Equals(c) ?? - δώσε μου το index (την θέση) 
            // αυτού του αντικειμένου.  ΨΑΧΝΕΙ ΟΛΗ ΤΗ ΛΙΣΤΑ και για το ΠΡΩΤΟ που θα βρει να ισχύει το Equals, 
            // θα γυρίσει την θέση του μέσω της μεταβλητής index.  Αν δεν βρει κανένα, το index θα πάρει τιμή -1. 
            int index = Courses.FindIndex(x => x.Equals(c));

            // αν index>=0 σημαίνει πως το μάθημα όντως υπάρχει κάπου στην λίστα
            if (index >= 0)
            {
                // οπότε, αλλάζω την τιμή του σε true
                Courses.Find(x => x.Equals(c)).Passed = true;
            }
            // αν το index<0, τότε το Course c δεν υπάρχει στην λίστα.  Τυπώνω κατάλληλο μήνυμα. 
            else
            {
                Console.WriteLine("Ο φοιτητής " + Name + " δεν έχει στην λίστα του το μάθημα " + c.Title);
                Console.WriteLine("η τιμή του index είναι: " + index);
            }
        }

        // εναλλακτική μέθοδος της PassCourse - κάνει ακριβώς το ίδιο πράγμα, αλλά αντί να δέχεται αντικείμενο 
        // Course, παίρνει ένα string και ψάχνει να αφαιρέσει μάθημα που έχει αυτό το string σαν τίτλο. 
        // ΔΕΝ έβαλα κάποιον έλεγχο, πράγμα που σημαίνει πως αν κατα λάθος πάμε να αφαιρέσουμε μάθημα με λάθος 
        // τίτλο, τότε το πρόγραμμα θα τερματιστεί με μήνυμα λάθους - για να μην συμβεί αυτό θα έπρεπε να είχα 
        // κάποιον έλεγχο όπως έκανα στην PassCourse. 
        public void PassCourseMeTitlo(string titlosMathimatos)
        {
            Courses.Find(x => x.Title.Contains(titlosMathimatos)).Passed = true;
        }

        // σχετικά απλή μέθοδος που τυπώνει όλα τα μαθήματα που έχει στην λίστα του ο φοιτητής - χρησιμοποιεί το 
        // Courses.Any() που γυρνάει ένα bool - true αν υπάρχει έστω ένα μάθημα, false αν δεν υπάρχει κανένα μάθημα. 
        public void PrintAllCourses()
        {

            Console.WriteLine();

            if (Courses.Any())
            {

                Console.WriteLine("Courses for student " + Name + ": ");

                foreach (Course c in Courses)
                {

                    Console.WriteLine(c.Title);

                }
            }
            else
            {
                Console.WriteLine("Student " + Name + " has no courses yet");
            }


        }

        // Αυτή είναι λίγο advanced μέθοδος - αλλά με απλά λόγια θα χρησιμοποιήσει την λίστα με τα μαθήματα
        // για να βρει πόσα έχει ΠΕΡΑΣΕΙ ο φοιτητής (σε πόσα το Passed Property είναι ίσο με true) 
        // και θα φτιάξει μια αντίστοιχη υπο-λίστα, την passedCourses, που μετά θα ανατρέξει με ένα foreach
        // για να τυπώσει κατάλληλα μηνύματα. 
        public void PrintPassedCourses()
        {
            Console.WriteLine();
            Console.WriteLine("Τυπώνω τα μαθήματα που έχει ΠΕΡΑΣΕΙ ο φοιτητής " + Name);
            List<Course> passedCourses = Courses.FindAll(x => x.Passed == true);

            if (passedCourses.Any())
            {
                foreach (Course c in passedCourses)
                {
                    Console.WriteLine("Έχει περάσει το μάθημα: " + c.Title);
                }
            }
            else
            {
                Console.WriteLine("Λυπάμαι, αλλά ο φοιτητής " + Name + " δεν έχει περάσει κανένα μάθημα !!!");
            }
        }

        // παρόμοια με την πιο πάνω, απλά εδώ θα τυπώσει τα μαθήματα που ΧΡΩΣΤΑΕΙ ο φοιτητής (πάλι φτιάχνοντας 
        // μια υπο-λίστα, την owedCourses). 
        public void PrintCoursesOwed()
        {
            Console.WriteLine();
            Console.WriteLine("Τυπώνω τα μαθήματα που ΧΡΩΣΤΑΕΙ ο φοιτητής " + Name);
            List<Course> owedCourses = Courses.FindAll(x => x.Passed == false);

            if (owedCourses.Any())
            {
                foreach (Course c in owedCourses)
                {
                    Console.WriteLine("Ο φοιτητής " + Name + " χρωστάει το μάθημα: " + c.Title);
                }
            }
            else
            {
                Console.WriteLine("Ο φοιτητής " + Name + " δεν χρωστάει κανένα μάθημα στην λίστα των μαθημάτων του !!!");
            }
        }
    }
}
