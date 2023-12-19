using System;

namespace ThreeExercises{
    class ThreeExercises{
        public static void Main(string[] args){
            Console.WriteLine("Enter your arrary length");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] user_in_arr = new int[l];

            for(int i=0; i<l; i++){
                user_in_arr[i] = i;
            }

            Console.WriteLine("Exercise 1");
            int sum = 0;
            int[] arr2 = new int[l];
            for(int i=l-1; i>=0; i--){
                Console.WriteLine(user_in_arr[i]);
                sum += user_in_arr[i];
                arr2[i] = user_in_arr[i];
            }
            Console.WriteLine($"Exercise 2 \n{sum}");
            Console.WriteLine("Exercise 3");
            foreach (int i in arr2){
                Console.WriteLine(i);
            }

        }
    }
}