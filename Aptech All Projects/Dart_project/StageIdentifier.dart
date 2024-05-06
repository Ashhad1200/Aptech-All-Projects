import 'dart:io';

void main() {
  print("Input Your Age Mary Piyary Bhai");
  int? userAge = int.parse(stdin.readLineSync()!);

  if (userAge <= 13) {
    print("According To Your Age : $userAge You Are Bacha ");
  } else if (userAge <= 19) {
    print("According To Your Age : $userAge You Are Teen ");
  } else if (userAge <= 30) {
    print("According To Your Age : $userAge You Are Young ");
  } else if (userAge <= 40) {
    print("According To Your Age : $userAge You Are Adult ");
  } else {
    print("Enjoy Your Life");
  }
}
