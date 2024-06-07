import 'package:authentication/auth/authServices.dart';
import 'package:flutter/material.dart';

class HomePage extends StatelessWidget {
  const HomePage({super.key});

  void signOut() {
    final auth = Authservice();
    auth.signOut();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Tu Kesy Hn app Log"),
        actions: [IconButton(onPressed: signOut, icon: Icon(Icons.logout))],
      ),
    );
  }
}
