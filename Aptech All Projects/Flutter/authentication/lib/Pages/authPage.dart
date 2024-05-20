import 'package:flutter/material.dart';

class authPage extends StatelessWidget {
  const authPage({super.key});

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

        SizedBox(height: 30,)
      ]),
    );
  }
}
