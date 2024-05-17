import 'package:flutter/material.dart';

class home extends StatelessWidget {
  const home({super.key});
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: Colors.red[300],
        appBar: AppBar(
          title: Text("Welcome to My Shopping Store"),
          centerTitle: true,
        ),
        body: Column(
          children: [
            Row(
              children: [
                Expanded(
                  flex: 1,
                  child: Container(
                    child: Text("One"),
                    color: Colors.blueGrey,
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(15),
                  ),
                ),
                Expanded(
                  flex: 1,
                  child: Container(
                    child: Text("One"),
                    color: Colors.blueGrey,
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(15),
                  ),
                ),
              ],
            ),
            Row(children: [
              Expanded(
                flex: 1,
                child: Container(
                  child: Text("One"),
                  color: Colors.blueGrey,
                  padding: EdgeInsets.all(40),
                  margin: EdgeInsets.all(15),
                ),
              ),
            ])
          ],
        ));
  }
}
