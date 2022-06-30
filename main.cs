// using System;

//Task 1: Palindrome

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    string input = "abab";
    int minusCount = 1;
    int characterCount = 0;
    Console.WriteLine((int)(input.Length/2));
    for(int i=0;i<(int)(input.Length/2);i++){
      if(input[i] == input[input.Length - minusCount++]){
        characterCount++;
      }
      else
      {
        break;
      }
    }
    Console.WriteLine(characterCount);
    if(characterCount == input.Length/2){
      Console.WriteLine("true");
    }else{
      Console.WriteLine("false");
    }    
  }
}

//Task 2: Two Sum
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

 

// Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]

using System;
class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    int minus = 1;
    int target = 17;
    int[] input = {2,7,11,15};
    for(int i = 0; i<input.Length; i++){
      /*for(int j=i;j<input.Length;j++){
        if(input[i] + input[j] == target){
          Console.WriteLine(i + "+" + j);
        }
      }*/
      if(input[i] + input[input.Length - minus] == target){
        
      }
    }
  }
}