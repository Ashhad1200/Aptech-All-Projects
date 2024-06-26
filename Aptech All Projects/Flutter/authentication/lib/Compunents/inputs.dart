import 'package:flutter/material.dart';

class MyInput extends StatelessWidget {
  final String hintText;
  final bool obscuretext;
  final TextEditingController  textController;
  const MyInput({
    super.key,
    required this.hintText,
    required this.obscuretext,
    required this.textController
  });

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 20),
      child: TextField(
        obscureText: obscuretext,
        controller: textController,
        decoration: InputDecoration(
            enabledBorder: OutlineInputBorder(
                borderSide: BorderSide(
              color: Color(0xFFDCEDC8),
            )),
            focusedBorder: OutlineInputBorder(
                borderSide: BorderSide(color: Color(0xFF8BC34A))),
            fillColor: Color(0xFFA5D6A7),
            filled: true,
            hintText: hintText,
            hintStyle: TextStyle(color: Colors.blueGrey)),
      ),
    );
  }
}
