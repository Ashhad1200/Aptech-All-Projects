import 'dart:io';

void main() {
  print("Input Your Unites Mary Piyary Bhai");
  int? userUnits = int.parse(stdin.readLineSync()!);

  if (userUnits <= 100) {
    print("According To Your Units : $userUnits Your Bill Is ");
    print(userUnits * 15);
  } else if (userUnits <= 200) {
    print("According To Your Units : $userUnits Your Bill Is ");
    print(userUnits * 20);
  } else if (userUnits <= 300) {
    print("According To Your Units : $userUnits Your Bill Is ");
    print(userUnits * 30);
  } else {
    print("According To Your Units : $userUnits Your Bill Is ");
    print(userUnits * 35);
  }
}
