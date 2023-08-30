namespace Loop{
    public static class Loop{
        public static void ForLoop(){
            for (int i = 0; i < 10; i++){

                if (i == 5){
                    break; // Exit the loop when i equals 5
                }

                if (i % 2 == 0){
                    continue; // Skip even numbers
                }

                Console.WriteLine(i);
            }
        }

        public static void SwitchFlow(){
            int day = 3; // Wednesday
            switch (day){
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }
        }

        public static void WhileLoop(){
            int i = 1;
            while (i <= 5){
                Console.WriteLine(i);
                i++;
            }

            int j = 1;
            do{
                Console.WriteLine(j);
                j++;
            } while (j <= 5);            
        }

    }
}