import 'package:authentication/Compunents/buttons.dart';
import 'package:authentication/Compunents/inputs.dart';
import 'package:authentication/auth/authServices.dart';
import 'package:flutter/material.dart';

class Register extends StatelessWidget {
  final TextEditingController emailController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();
  final TextEditingController confirmPasswordController =
      TextEditingController();
  final void Function()? onTap;
  Register({super.key, required this.onTap});

  void signUp(BuildContext context) async {
    final auth = Authservice();

    if (passwordController.text == confirmPasswordController.text) {
      try {
       await auth.signupWithEmailPassword(
            emailController.text, passwordController.text);
      } catch (e) {
        showDialog(
            context: context,
            builder: (context) => AlertDialog(
                  title: Text(e.toString()),
                ));
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0xFF66BB6A),
      body: Column(mainAxisAlignment: MainAxisAlignment.center, children: [
        Icon(
          Icons.email_rounded,
          size: 80,
          color: Colors.black,
        ),
        SizedBox(height: 10),
        Text(
          "Welcome To Our Application Register Your Self Here",
          style: TextStyle(color: Colors.white),
        ),
        SizedBox(height: 10),
        MyInput(
            hintText: "Email",
            obscuretext: false,
            textController: emailController),
        SizedBox(height: 10),
        MyInput(
            hintText: "Password",
            obscuretext: true,
            textController: passwordController),
        SizedBox(height: 10),
        MyInput(
            hintText: " Confirm Password",
            obscuretext: true,
            textController: confirmPasswordController),
        SizedBox(height: 10),
        MyButton(buttonText: "SignUp !", onTap:()=> signUp(context)),
        SizedBox(height: 10),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text("Already Registered?", style: TextStyle(color: Colors.black)),
            GestureDetector(
              onTap: onTap,
              child: Text("  Login Now!",
                  style: TextStyle(
                      color: Colors.black, fontWeight: FontWeight.bold)),
            )
          ],
        )
      ]),
    );
  }
}
