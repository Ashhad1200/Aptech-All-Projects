import 'package:authentication/Compunents/buttons.dart';
import 'package:authentication/Compunents/inputs.dart';
import 'package:flutter/material.dart';

class authPage extends StatelessWidget {
  final TextEditingController emailController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();
  final void Function()? onTap;
  authPage({super.key , required this.onTap});

void login(){
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
        SizedBox(height: 20),
        MyButton(buttonText: "Login", onTap: login),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text("Not Registered?", style: TextStyle(color: Colors.black)),
            GestureDetector(
              onTap: onTap,
              child: Text("  Registered Now!",
                  style:
                      TextStyle(color: Colors.black, fontWeight: FontWeight.bold)),
            )
          ],
        )
      ]),
    );
  }
}
