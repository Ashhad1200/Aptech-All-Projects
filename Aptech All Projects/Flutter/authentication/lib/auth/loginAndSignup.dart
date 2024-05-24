import 'package:authentication/Pages/authPage.dart';
import 'package:authentication/Pages/register.dart';
import 'package:flutter/material.dart';

class loginOrRegister extends StatefulWidget {
  const loginOrRegister({super.key});

  @override
  State<loginOrRegister> createState() => _loginOrRegisterState();
}

class _loginOrRegisterState extends State<loginOrRegister> {
  bool showLoginPage = true;
  void togglePages() {
    setState(() {
      showLoginPage = !showLoginPage;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (showLoginPage) {
      return authPage(onTap: togglePages);
    } else {
      return Register(
        onTap: togglePages,
      );
    }
  }
}
