import 'package:authentication/Pages/authPage.dart';
import 'package:authentication/Pages/register.dart';
import 'package:authentication/auth/loginAndSignup.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: loginOrRegister(),
      debugShowCheckedModeBanner: false,
    );
  }
}
