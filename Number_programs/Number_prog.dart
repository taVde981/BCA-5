import 'dart:io';
import 'dart:math';

void main() {
  while (true) {
    int? num;
    print("Enter a number:");
    String? input = stdin.readLineSync();
    if (input != null) {
      num = int.tryParse(input);
    }

    if (num == null) {
      print("Invalid number. Please try again.");
      continue;
    }

    Programs programs = Programs();
    print("Enter Choice:");
    print("1. Spy Number");
    print("2. Disarium Number");
    print("3. Pronic Number");
    print("4. Deficient Number");
    print("5. Krishnamurthy Number");
    print("6. Special 2 Digit Number");
    print("7. Super Perfect Number");
    print("8. Duck Number");
    print("9. Cyclic Number");
    print("10. Sunny Number");
    print("11. Show Information\n");

    String? choiceInput = stdin.readLineSync();
    int? ch = choiceInput != null ? int.tryParse(choiceInput) : null;

    if (ch == null) {
      print("Invalid choice. Please try again.");
      continue;
    }

    bool flag;
    switch (ch) {
      case 1:
        flag = programs.spyNum(num);
        if (flag) {
          print("Number is Spy Number");
        } else {
          print("Not Spy Number");
        }
        break;
      case 2:
        flag = programs.disariumNum(num);
        if (flag) {
          print("Number is Disarium Number");
        } else {
          print("Not Disarium Number");
        }
        break;
      case 3:
        flag = programs.pronicNum(num);
        if (flag) {
          print("Number is Pronic Number");
        } else {
          print("Not Pronic Number");
        }
        break;
      case 4:
        flag = programs.deficientNum(num);
        if (flag) {
          print("Number is Deficient Number");
        } else {
          print("Not Deficient Number");
        }
        break;
      case 5:
        flag = programs.krishnamNum(num);
        if (flag) {
          print("Number is Krishnamurthy Number");
        } else {
          print("Not Krishnamurthy Number");
        }
        break;
      case 6:
        flag = programs.spectwoNum(num);
        if (flag) {
          print("Number is Special Two Digit Number");
        } else {
          print("Not Special Two Digit Number");
        }
        break;
      case 7:
        flag = programs.supfectNum(num);
        if (flag) {
          print("Number is Super Perfect Number");
        } else {
          print("Not Super Perfect Number");
        }
        break;
      case 8:
        flag = programs.duckNum(input, num);
        if (flag) {
          print("Number is Duck Number");
        } else {
          print("Not Duck Number");
        }
        break;
      case 9:
        flag = programs.cyclicNum(num);
        if (flag) {
          print("Number is Cyclic Number");
        } else {
          print("Not Cyclic Number");
        }
        break;
      case 10:
        flag = programs.sunnyNum(num);
        if (flag) {
          print("Number is Sunny Number");
        } else {
          print("Not Sunny Number");
        }
        break;
      case 11:
        programs.showInformation();
        break;
      default:
        print("Invalid choice. Please try again.");
    }
  }
}

class Programs {
  bool spyNum(int num) {
    int sum = 0;
    int p = 1;
    int temp = num;
    while (temp != 0) {
      int d = temp % 10;
      sum += d;
      p *= d;
      temp ~/= 10;
    }
    return sum == p;
  }

  bool disariumNum(int num) {
    int temp = num;
    int count = 0;
    while (temp != 0) {
      temp ~/= 10;
      count++;
    }
    temp = num;
    int sum = 0;
    while (temp != 0) {
      int d = temp % 10;
      sum += pow(d, count).toInt();
      temp ~/= 10;
      count--;
    }
    return sum == num;
  }

  bool pronicNum(int num) {
    int i = 1;
    while (i < num) {
      if (i * (i + 1) == num) {
        return true;
      }
      i++;
    }
    return false;
  }

  bool deficientNum(int num) {
    int sum = 0;
    for (int i = 1; i <= num; i++) {
      if (num % i == 0) {
        sum += i;
      }
    }
    return sum < 2 * num;
  }

  bool krishnamNum(int num) {
    int sum = 0;
    int temp = num;
    while (temp != 0) {
      int d = temp % 10;
      sum += fact(d);
      temp ~/= 10;
    }
    return sum == num;
  }

  int fact(int d) {
    int p = 1;
    for (int i = 1; i <= d; i++) {
      p *= i;
    }
    return p;
  }

  bool spectwoNum(int num) {
    int temp = num;
    int count = 0;
    while (temp != 0) {
      temp ~/= 10;
      count++;
    }
    if (count != 2) {
      return false;
    }
    int sum = 0;
    int p = 1;
    temp = num;
    while (temp != 0) {
      int d = temp % 10;
      sum += d;
      p *= d;
      temp ~/= 10;
    }
    return sum + p == num;
  }

  bool supfectNum(int num) {
    int sum1 = 0;
    for (int i = 1; i <= num; i++) {
      if (num % i == 0) {
        sum1 += i;
      }
    }
    int sum2 = 0;
    for (int i = 1; i <= sum1; i++) {
      if (sum1 % i == 0) {
        sum2 += i;
      }
    }
    return sum2 == 2 * num;
  }

  bool duckNum(String str, int num) {
    if (str.startsWith('0')) {
      return false;
    }
    int temp = num;
    while (temp != 0) {
      int d = temp % 10;
      if (d == 0) {
        return true;
      }
      temp ~/= 10;
    }
    return false;
  }

  bool cyclicNum(int num) {
    return false; // Needs specific implementation
  }

  bool sunnyNum(int num) {
    int m = num + 1;
    int i = 1;
    while (i < num) {
      if (i * i == m) {
        return true;
      }
      i++;
    }
    return false;
  }

  void showInformation() {
    print("Information about number programs:");
    print("1. Spy Number: A number is a Spy number if the sum of its digits is equal to the product of its digits. (Example: 1124, 22)");
    print("2. Disarium Number: A number is a Disarium number if the sum of its digits powered with their respective positions is equal to the number itself. (Example: 89, 135)");
    print("3. Pronic Number: A number is a Pronic number if it is the product of two consecutive integers. (Example: 6, 12, 20)");
    print("4. Deficient Number: A number is a Deficient number if the sum of its proper divisors is less than the number itself. (Example: 15, 22)");
    print("5. Krishnamurthy Number: A number is a Krishnamurthy number if the sum of the factorial of its digits is equal to the number itself. (Example: 145, 40585)");
    print("6. Special Two Digit Number: A two-digit number is special if the sum of its digits plus the product of its digits equals the original number. (Example: 19, 29)");
    print("7. Super Perfect Number: A number is a Super Perfect number if twice the number is equal to the sum of the sum of its proper divisors. (Example: 6, 28)");
    print("8. Duck Number: A number is a Duck number if it contains a zero in it, but it should not be at the beginning. (Example: 102, 304)");
    print("9. Cyclic Number: A cyclic number is a number in which cyclic permutations of the digits are successive multiples of the number. (Example: 142857)");
    print("10. Sunny Number: A number is a Sunny number if the number plus one is a perfect square. (Example: 8, 15)");
  }
}
