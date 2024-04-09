// Yiping He 04/08/2024

using Assignment_0408;

// Assignment 01 Introduction to C# and Data Types

// Playing with Console App
// 1. hacker name generator
Console.WriteLine("\nTest: hacker name generator");
HackerNameGenerator hackerNameGenerator = new HackerNameGenerator();
hackerNameGenerator.generateHackerName();

// Practice number sizes and ranges
// 1. understanding types
Console.WriteLine("\nTest: understanding types");
UnderstandingTypes understandingTypes = new UnderstandingTypes();
understandingTypes.understandTypes();

// 2. century converter
Console.WriteLine("\nTest: century converter");
CenturyConverter centuryConverter = new CenturyConverter();
centuryConverter.convertCentury();

// Practice loops and operators
// 1. fizz buzz
Console.WriteLine("\nTest: fizz buzz");
FizzBuzz fizzBuzz = new FizzBuzz();
fizzBuzz.fizzBuzz();

// 2. pyramid printer
Console.WriteLine("\nTest: pyramid printer");
PyramidPrinter pyramidPrinter = new PyramidPrinter();
pyramidPrinter.printPyramid();

// 3. number guessing
Console.WriteLine("\nTest: number guessing");
NumberGuessing numberGuessing = new NumberGuessing();
numberGuessing.guessNumber();

// 4. age calculator
Console.WriteLine("\nTest: age calculator");
AgeCalculator ageCalculator = new AgeCalculator();
ageCalculator.calculateAgeInDays();

// 5. proper greeting 
Console.WriteLine("\nTest: proper greeting");
ProperGreeting properGreeting = new ProperGreeting();
properGreeting.greetProperly();

// 6. different counting
Console.WriteLine("\nTest: different counting");
DifferentCounting differentCounting = new DifferentCounting();
differentCounting.countTo24();

// Assignment 02 Arrays and Strings

// Practice Arrays
ArraySolutions arraySolutions = new ArraySolutions();

// 1. copy array
Console.WriteLine("\nTest copy array");
int[] orig = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
arraySolutions.copyArray(orig);

// 2. manage list
Console.WriteLine("\nTest manage list");
arraySolutions.manageList();

// 3. find all primes
Console.WriteLine("\nTest find all primes");
arraySolutions.FindPrimesInRange(1, 100);

// 4. rotate and sum
Console.WriteLine("\nTest rotate and sum");
int[] array1 = { 3, 2, 4, -1 };
arraySolutions.rotateAndSum(array1, 2);
int[] array2 = { 1, 2, 3, 4, 5 };
arraySolutions.rotateAndSum(array2, 3);

// 5. find longest sequence
Console.WriteLine("\nTest find longest sequence");
int[] sequence = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
arraySolutions.findLongestSequence(sequence);

// 7. find most frequent number
Console.WriteLine("\nTest find most frequent number");
int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
arraySolutions.findMostFrequentNumber(numbers);

// Practice Strings
StringSolutions stringSolutions = new StringSolutions();

// 1. reverse string
Console.WriteLine("\nTest reverse string");
stringSolutions.reverseString("sample");

// 2. reverse words
Console.WriteLine("\nTest reverse words");
stringSolutions.reverseWords("C# is not C++, and PHP is not Delphi!");
stringSolutions.reverseWords("The quick brown fox jumps over the lazy dog /Yes! Really!!!/.");

// 3. find palindromes
Console.WriteLine("\nTest find palindromes");
stringSolutions.findPalindromes("Hi,exe? ABBA! Hog fully a string: ExE. Bob");

// 4. parse url
Console.WriteLine("\nTest parse url");
stringSolutions.parseURL("https://www.apple.com/iphone");
stringSolutions.parseURL("ftp://www.example.com/employee");
stringSolutions.parseURL("https://google.com");
