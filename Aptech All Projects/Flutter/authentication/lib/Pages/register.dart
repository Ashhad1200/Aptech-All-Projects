import 'package:authentication/Compunents/buttons.dart';
import 'package:authentication/Compunents/inputs.dart';
import 'package:flutter/material.dart';

class Register extends StatelessWidget {
  final TextEditingController emailController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();
  final TextEditingController confirmPasswordController = TextEditingController();
   Register({super.key});
  void onTap() {
    //
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0xFF66BB6A),
      body: Column(mainAxisAlignment: MainAxisAlignment.center, children: [
        Icon(
          Icons.message,
          size: 40,
          color: Colors.black,
        ),
        SizedBox(height: 30),
        Text(
          "Welcome Here",
          style: TextStyle(color: Colors.white),
        ),
        SizedBox(height: 30),
        MyInput(hintText: "Email", obscuretext: false , textController: emailController),
        SizedBox(height: 30),
        MyInput(hintText: "Password", obscuretext: true , textController: passwordController),
        SizedBox(height: 30),
        MyInput(hintText: " Confirm Password", obscuretext: true ,textController: confirmPasswordController),
        SizedBox(height: 20),
        MyButton(buttonText: "SignUp", onTap: onTap),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text("Already Registered?", style: TextStyle(color: Colors.black)),
            Text("  Login Now!",
                style:
                    TextStyle(color: Colors.black, fontWeight: FontWeight.bold))
          ],
        )
      ]),
    );
  }
}
