# Book IPL Training

## Overview
This repository contains my training work for C# and .NET as part of the Book IPL project.  
I practiced fundamental programming concepts using Cheat Codes and implemented them step by step.

---

## Project Structure

### CheatCodesPractice
- CheatCode1 → Assignment vs Comparison
- CheatCode2 → Execution Order
- CheatCode3 → Methods and Reusability
- CheatCode4 → Variable Scope and Return Values
- CheatCode5 → Collections (List)

### Exercises
- Will be implemented next

---

## Progress

- CheatCode1 Completed ✅
- CheatCode2 Completed ✅
- CheatCode3 Completed ✅
- CheatCode4 Completed ✅
- CheatCode5 Completed ✅

---

## Learning Summary

### CheatCode1: Assignment vs Comparison
- Learned difference between `=` and `==`
- Understood that `=` assigns value and `==` compares values

Error:
Used `if (score = 6)` which caused error
Replaced with `if (score == 6)`

---

### CheatCode2: Execution Flow
- Learned that program executes from top to bottom
- Order of statements directly affects output

Mistake:
Expected logical order instead of written order
Understood that execution follows code sequence

---

### CheatCode3: Methods and Reusability
- Learned how to create and use methods
- Avoided repeating code by using a method

Difficulty:
Did not understand how method returns value
Used `return` to send value from method

---

### CheatCode4: Variable Scope and Memory
- Learned that variables inside methods are temporary
- Understood scope and lifetime of variables
Error:
Tried to access variable outside method

---

### CheatCode5: Collections (List)
- Learned how to store multiple values using List
- Understood how to use collections instead of multiple variables
- Used loop to iterate through values
- Calculated total score using loop

Difficulty:
Initially tried using separate variables for each value which is not scalable

Example:
int score1 = 4;
int score2 = 6;
int score3 = 0;

This approach becomes difficult when handling many values

Used List collection:
List<int> scores = new List<int>();
scores.Add(4);
scores.Add(6);
scores.Add(0);
Used foreach loop to iterate:
foreach (int s in scores)
{
    Console.WriteLine(s);
}
Calculated total:
int total = 0;
foreach (int s in scores)
{
    total += s;
}