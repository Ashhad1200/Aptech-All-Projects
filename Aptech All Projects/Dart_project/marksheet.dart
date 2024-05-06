import 'dart:io';

void main() {
  print("Input Your Marks Of  Maths");
  int? maths = int.parse(stdin.readLineSync()!);

  print("Input Your Marks Of  Urdu");
  int? urdu = int.parse(stdin.readLineSync()!);

  print("Input Your Marks Of  English");
  int? english = int.parse(stdin.readLineSync()!);

  print("Input Your Marks Of PST ");
  int? pst = int.parse(stdin.readLineSync()!);

  print("Input Your Marks Of Sindhi ");
  int? sindhi = int.parse(stdin.readLineSync()!);

  int total = maths + sindhi + urdu + english + pst;

  double persentage = total / 500 * 100;

  if (persentage >= 80) {
    print("You Got A+ Grade With The Total Marks Of : $total and your persentage is $persentage%");
    print("Marks Obtain in Maths $maths ");
    print("Marks Obtain in Urdu $urdu");
    print("Marks Obtain in PST $pst");
    print("Marks Obtain in English $english");
    print("Marks Obtain in Sindhi $sindhi");
  } else if (persentage >= 70) {
    print("You Got A Grade With The Total Marks Of : $total and your persentage is $persentage%");
    print("Marks Obtain in Maths $maths ");
    print("Marks Obtain in Urdu $urdu");
    print("Marks Obtain in PST $pst");
    print("Marks Obtain in English $english");
    print("Marks Obtain in Sindhi $sindhi");
  } else if (persentage >= 60) {
    print("You Got B Grade With The Total Marks Of : $total and your persentage is $persentage%");
    print("marks Obtain in Maths $maths ");
    print("marks Obtain in Urdu $urdu");
    print("marks Obtain in PST $pst");
    print("marks Obtain in English $english");
    print("marks Obtain in Sindhi $sindhi");
  } else if (persentage >= 50) {
    print("You Got C Grade With The Total Marks Of : $total and your persentage is $persentage%");
    print("Marks Obtain in Maths $maths ");
    print("Marks Obtain in Urdu $urdu");
    print("Marks Obtain in PST $pst");
    print("Marks Obtain in English $english");
    print("Marks Obtain in Sindhi $sindhi");
  } else if (persentage >= 40) {
    print("You Got D Grade With The Total Marks Of : $total and your persentage is $persentage%");
    print("Marks Obtain in Maths $maths ");
    print("Marks Obtain in Urdu $urdu");
    print("Marks Obtain in PST $pst");
    print("Marks Obtain in English $english");
    print("Marks Obtain in Sindhi $sindhi");
  } else {
    print("You Faild With The Total Marks Of : $total and your persentage is $persentage%");
    print("Marks Obtain in Maths $maths ");
    print("Marks Obtain in Urdu $urdu");
    print("Marks Obtain in PST $pst");
    print("Marks Obtain in English $english");
    print("Marks Obtain in Sindhi $sindhi");
  }
}
