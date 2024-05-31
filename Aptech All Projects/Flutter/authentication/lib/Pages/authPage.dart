import 'package:authentication/Compunents/buttons.dart';
import 'package:authentication/Compunents/inputs.dart';
import 'package:authentication/auth/authServices.dart';
import 'package:flutter/material.dart';

class authPage extends StatelessWidget {
  final TextEditingController emailController = TextEditingController();
  final TextEditingController passwordController = TextEditingController();
  final void Function()? onTap;
  authPage({super.key, required this.onTap});

  void login  (BuildContext context) async {
    final authService = Authservice();
    try{
      await authService.signInWithEmailAndPassword(emailController.text, passwordController.text);
    }catch(e){
      showDialog(context: context, builder: (context) => AlertDialog(title: Text(e.toString()),));
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color(0xFF66BB6A),
      body: Column(mainAxisAlignment: MainAxisAlignment.center, children: [
        Icon(
          Icons.person,
          size: 80,
          color: Colors.black,
        ),
        SizedBox(height: 30),
        Text(
          "LogIn Here To Get In The Application",
          style: TextStyle(color: Colors.white),
        ),
        SizedBox(height: 20),
        MyInput(
            hintText: "Email",
            obscuretext: false,
            textController: emailController),
        SizedBox(height: 20),
        MyInput(
            hintText: "Password",
            obscuretext: true,
            textController: passwordController),
        SizedBox(height: 20),
        MyButton(buttonText: "Login !", onTap: () => login(context)),
        SizedBox(height: 10),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text("Not Registered?", style: TextStyle(color: Colors.black)),
            GestureDetector(
              onTap: onTap,
              child: Text("  Registered Now!",
                  style: TextStyle(
                      color: Colors.black, fontWeight: FontWeight.bold)),
            )
          ],
        )
      ]),
    );
  }
}
