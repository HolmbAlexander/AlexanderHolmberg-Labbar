//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace ooplabb2
//{
//    class runtime
//    {
//        list<landanimals> landanimallist = new list<landanimals>();
//        list<birdanimals> birdanimallist = new list<birdanimals>();
//        list<wateranimals> wateranimallist = new list<wateranimals>();

//        public void start()
//        {

//        }
//        public void optionsmenu()
//        {
//            bool loop = false;
//            do
//            {
//                console.writeline("1. add land animal");
//                console.writeline("2. show list of land animals");
//                console.writeline("3. exit");

//                loop = true;
//                int optionsinput = int.parse(console.readline());
//                switch (optionsinput)
//                {
//                    case 1: addlandanimal(); break;
//                    case 2: showlandanimals(); break;
//                    case 3: environment.exit(0); break;
//                    default: break;
//                }
//            } while (loop);
//        }
//        public void addlandanimal()
//        {
//            console.write("enter the cats age: ");
//            int age = int.parse(console.readline());
//            console.write("what does this cat eat? ");
//            string food = console.readline();
//            console.write("how much does this cat weigh? ");
//            int weight = int.parse(console.readline());
//            console.write("enter the number of the cats legs: ");
//            int numberoflegs = int.parse(console.readline());
//            console.write("is this type of cat big or small?");
//            string size = console.readline();

//            cats addnewlandanimal = new cats
//            {
//                age = age,
//                food = food,
//                weight = weight,
//                numberoflegs = numberoflegs,
//                size = size
//            }; landanimallist.add(addnewlandanimal);
//        }
//        public void showlandanimals()
//        {
//            console.clear();
//            int i = 0;
//            foreach (var animal in landanimallist)
//            {
//                console.writeline(i + "# " + animal.introduction()); i++;
//            }
