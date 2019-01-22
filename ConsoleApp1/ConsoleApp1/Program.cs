using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    /*
     * Απλό πρόγραμμα που έχει ως σκοπό να δείξει την λειτουργία των συλλογών (collections) και συγκεκριμένα
     * την λίστα (List). 
     */
    class Program
    {
        static void Main(string[] args)
        {

            // αυτή η εντολή είναι απλώς για να τυπώνονται σωστά οι ελληνικοί χαρακτήρες στο 
            // console (χρειάζεται βέβαια και να έχουν επιλεχθεί font που να το επιτρέπουν). 
            // αν έχετε πρόβλημα - απλά αλλάξτε τα writeline μηνύματα :)
            Console.OutputEncoding = Encoding.UTF8;

            /* Πρώτα θα δούμε μια απλή λίστα από ακέραιους αριθμούς
             * 
             * (μην ξεχνάτε πως τα πάντα είναι αντικείμενα στην C# - 
             * και ένας απλός ακέραιος αριθμός (int) είναι αντικείμενο).
             * 
             */

            // Δημιουργώ μια νέα λίστα με όνομα intList - και ΄δηλώνω πως θα περιέχει ακέραιους αριθμούς (int). 
            List<int> intList = new List<int>();

            // Βάζω μερικούς αριθμούς στην λίστα:
            intList.Add(5);
            intList.Add(21);
            intList.Add(12);
            intList.Add(-3);
            intList.Add(0);


            // κάνω loop την λίστα και τυπώνω κάθε αριθμό σε νέα γραμμή

            // με for loop: 

            Console.WriteLine();
            Console.WriteLine("--- typwnw kathe arithmo tis listas intList ΜΕ FDOR LOOP ---");

            for (int i = 0; i < intList.Count; i++)
            {

                // χρησιμοποιώ την σύνταξη με τις αγκύλες - και μέσα στις αγκύλες την θέση (index) του αντικειμένου. 
                // Μην ξεχνάτε πως οι λίστες είναι zero-based, δηλαδή η πρώτη θέση είναι η θέση μηδέν (0). 
                Console.WriteLine("Ο αριθμός στην θέση " + i + " της λίστας είναι ο: " + intList[i]);

                // εναλλακτικός τρόπος θα ήταν το: 
                // Console.WriteLine("Ο αριθμός στην θέση " + i + " της λίστας είναι ο: " + intList.ElementAt(i));
                // το οποίο χρησιμοποιεί τη μέθοδο elementAt
            }


            // με foreach: 

            Console.WriteLine();
            Console.WriteLine("--- ΤΥΠΩΝΩ ΚΑΘΕ ΑΡΙΘΜΟ ΤΗΣ ΛΙΣΤΑΣ intList ΜΕ FOREACH LOOP ---");

            foreach (int number in intList)
            {
                Console.WriteLine("Ο αριθμός είναι ο: " + number);
            }


            // αν ήθελα να έχω και την θέση του αριθμού, θα έπρεπε να φτιάξω άλλη μια μεταβλητή η οποία θα άρχιζε με 0 
            // και θα αυξανόταν σε κάθε βήμα του loop - από μόνο του το foreach δεν έχει κάποιον τρόπο να το παρέχει αυτό. 
            // Ωστόσο είναι πιο απλό στην γραφή - για όποιον ενδιαφέρεται για περισσότερες λεπτομέρειες, 
            // εδώ: https://stackoverflow.com/questions/43021/how-do-you-get-the-index-of-the-current-iteration-of-a-foreach-loop



            // Ας δούμε κάτι χρήσιμο σε μια λίστα. 

            // με αυτήν την απλή μέθοδο, ταξινομώ την λίστα αυτόματα (από το μικρότερο στο μεγαλύτερο). 
            intList.Sort();

            Console.WriteLine();
            Console.WriteLine("--- ΤΥΠΩΝΩ ΤΗΝ ΤΑΞΙΝΟΜΗΜΕΝΗ ΛΙΣΤΑ ---");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine("Ο αριθμός στην θέση " + i + " της λίστας είναι ο: " + intList[i]);
            }



            // Χρησιμοποιώ την remove μέθοδο για να αφαιρέσω έναν συγκεκριμένο αριθμό 
            // (δηλαδή ένα συγκεκριμένο αντικείμενο, που σε αυτή την περίπτωση είναι ο αριθμός 12)

            intList.Remove(12);

            // ξανατυπώνω τη λίστα να δω αν όντως αφαιρέθηκε:

            Console.WriteLine();
            Console.WriteLine("--- ΤΥΠΩΝΩ ΤΗΝ ΤΑΞΙΝΟΜΗΜΕΝΗ ΛΙΣΤΑ --- ΧΩΡΙΣ ΤΟΝ ΑΡΙΘΜΟ 12 ΠΟΥ ΑΦΑΙΡΕΣΑ");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine("Ο αριθμός στην θέση " + i + " της λίστας είναι ο: " + intList[i]);
            }


            List<string> onomata = new List<string>()
            {
                "Thomas", "Babis", "Alex", "Maria", "George", "Dimitris", "Katerina"
            };

            Console.WriteLine();
            Console.WriteLine("Ας τυπώσω όλα τα ονόματα: ");
            foreach (string name in onomata)
            {
                Console.WriteLine(name);
            }

            // ταξινόμησε σε αλφαβητική σειρά
            onomata.Sort();

            // κάνε αντιστροφή της λίστας
            onomata.Reverse();

            Console.WriteLine();
            Console.WriteLine("Ας τυπώσω όλα τα ονόματα σε ανάποδη αλφαβητική σειρά: ");
            foreach (string name in onomata)
            {
                Console.WriteLine(name);
            }


            /*
                    Υπάρχουν πάρα πολλές χρήσιμες μέθοδοι για λίστες ... Από απλές (να βάλεις/βγάλεις αντικείμενο σε συγκεκριμένη θέση)
                    μέχρι πολύπλοκες ..
                 
                    Περισσότερα εδώ: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2
                    και εδώ: http://www.tutorialsteacher.com/csharp/csharp-list

                    αλλά και πολλά παραδείγματα αν ψάξετε για 'List C#' στο google ...  
             */



            /*
             * 
             *      Από εδώ και πέρα θα δούμε το παράδειγμα του εργαστηρίου, στο οποίο έχουμε δυο κλάσεις - 
             *      τον Student και τα Courses, και θα δούμε πως ο Student έχει σαν property μια λίστα 
             *      από Courses.   
             *      
             *      Θυμηθείτε πάλι, τα πάντα είναι αντικείμενα - και η λίστα είναι αντικείμενο. 
             *      
             *      Κάθε αντικείμενο έχει properties, και μπορούν να είναι 'απλά' αντικείμενα, 
             *      πχ ένα string ή ένα int - ή πιο 'πολύπλοκα' όπως μια λίστα, όπως πχ το παράδειγμα 
             *      του Student που έχει λίστα από Courses. 
             *      
             *      Είτε είναι απλά είτε όχι, εφόσον είναι properties, πρέπει να έχουν get/set ... 
             *      
            */


            // φτιάχνω έναν φοιτητή για να παίξω λίγο με τις λίστες

            Student stu1 = new Student("Thomas");



            // φτιάχνω μερικά μαθήματα
            Course c1 = new Course("Information Systems");
            Course c2 = new Course("Studio 1");
            Course c3 = new Course("Mathematics");
            Course c4 = new Course("Physics");
            Course c5 = new Course("Chemistry");


            // προσθέτω μερικά μαθήματα στον stu1, χρησιμοποιώντας την κατάλληλη μέθοδο που έχω φτιάξει
            // στην κλάση Student

            // βάζω τα c1, c2, c3 στον stu1
            stu1.AddCourse(c1);
            stu1.AddCourse(c2);
            stu1.AddCourse(c3);

            // το παρακάτω δεν είναι λάθος - βάζω 2 φορές το ίδιο μάθημα, και θα το βγάλω μετά. 
            stu1.AddCourse(c3);

            // για να δούμε τα μαθήματα του stu1: (θα δω δυο φορές το Mathematics)
            stu1.PrintAllCourses();


            // ΩΠ - ΕΚΑΝΑ ΛΑΘΟΣ ΚΑΙ ΕΒΑΛΑ ΤΟ ΜΑΘΗΜΑ 'MATHEMATICS' ΔΥΟ ΦΟΡΕΣ... 
            // Ας το βγάλω λοιπόν ... 
            stu1.RemoveCourse(c3);

            // Για να δω αν βγήκε σωστά: (πρέπει να δω μόνο μια φορά το μάθημα Mathematics)
            stu1.PrintAllCourses();



            /* Όντως το έβγαλε, αλλά αυτό θέλει λίγο εξήγηση: 
            * 
            * Αν διαβάσετε τον ορισμό της μεθόδου Remove, λέει πάνω πάνω: 
            * 
            * Removes the first occurrence of a specific object from the List<T>.
            * 
            * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=netframework-4.7.2
            * 
            * άρα έβγαλε το πρώτο 'Mathematics' που βρήκε, και άφησε το επόμενο. 
            */


            // για να προσπαθήσω να αφαιρέσω ένα μάθημα από τον stu1 το οποίο ομως ΔΕΝ ΕΧΕΙ ΣΤΗ ΛΙΣΤΑ ΤΟΥ. 
            stu1.RemoveCourse(c5);
            
            // για να δούμε τα μαθήματα που έχει περάσει ο φοιτητής stu1
            stu1.PrintPassedCourses();

            // για να δούμε τα μαθήματα που χρωστάει ο φοιτητής stu1
            stu1.PrintCoursesOwed();


            // για να περασω τον stu1 στο μάθημα c1
            stu1.PassCourse(c1);


            // για να δω αν όντως δείχνει οτι έχει περάσει ο stu1 το c1
            stu1.PrintPassedCourses();




            /*
             * 
            * Εδώ μπορούμε με την ευκαιρία να αναφέρουμε και κάτι σημαντικό.
            * 
            * Το c1 / c2 / c3 κλπ είναι συγκεκριμένα αντικείμενα της κλάσης Course - καταλαμβάνουν συγκεκριμένο χώρο στην μνήμη του υπολογιστή 
            * όπου και καταχωρούνται κατά την δημιουργία τους.  
            * 
            * Αν βάλω δυο φορές κάποιο (πχ το c1) σε κάποιον φοιτητή - ουσιαστικά έχω βάλει δυο φορές το reference (την αναφορά) του ΙΔΙΟΥ ΑΝΤΙΚΕΙΜΕΝΟΥ. 
            * 
            * Αυτό μπορεί να δημιουργήσει προβλήματα - πχ κάνω το εξής: 
            * 
            *   stu1.AddCourse(c1);
            *   stu2.AddCourse(c1);
            *   
            *   δίνω δηλαδή το c1 και στον stu1 και στον stu2. 
            *   
            *   και μετά αποφασίζω να "περάσω" τον φοιτητή stu1 στο μάθημα c1
            *   
            *   stu1.PassCourse(c1); 
            *   
            *   αν αμέσως μετά δω τα μαθήματα που έχει περάσει ο φοιτητής stu2, θα ΔΩ ΠΩΣ ΕΧΕΙ ΠΕΡΑΣΕΙ ΚΑΙ ΑΥΤΟΣ ΤΟ c1 !!!
            *   
            *   Δείτε το παρακάτω:
            */

            // φτιαχνω δευτερο φοιτητη
            Student stu2 = new Student("Babis");

            // του δίνω το μάθημα c1
            stu2.AddCourse(c1);

            // βλέπω ποια μαθήματα έχει περάσει ο φοιτητής stu2 (κανονικά δεν πρέπει να έχει περάσει κανένα) 
            // Ωστόσο αν το τρέξετε θα δείτε πως έχει 'περάσει' το μάθημα c1 (επειδή έχει αλλάξει η τιμή του Property Passed για το 
            // c1 σε true, φαίνεται πως το έχει περάσει και ο stu2. 
            stu2.PrintPassedCourses();

            //βγαζω το c1 από τον stu2
            stu2.RemoveCourse(c1);

            //για να δω τώρα όλα τα μαθήματα του stu2
            stu2.PrintAllCourses();

            //ένας τρόπος να το παρακάμψω αυτό είναι να κάνω: 
            // δίνω δηλαδή ΝΕΟ ΑΝΤΙΚΕΙΜΕΝΟ, όχι το ήδη φτιαγμένο c1
            stu2.AddCourse(new Course("Information Systems"));

            //για να δω τώρα ΠΑΛΙ όλα τα μαθήματα του stu2 (έχει προστεθεί το νέο information systems)
            stu2.PrintAllCourses();

            // αλλά φαίνεται πως το χρωστάει κανονικά
            stu2.PrintPassedCourses();

        }
    }
}
