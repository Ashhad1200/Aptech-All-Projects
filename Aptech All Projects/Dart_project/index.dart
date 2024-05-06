import 'dart:io';

void main(){

print("Enter Your Number one");
int? num1 = int.parse(stdin.readLineSync()!);

print("Enter Your Number Two");
int? num2 = int.parse(stdin.readLineSync()!);
print(num1+num2);

}