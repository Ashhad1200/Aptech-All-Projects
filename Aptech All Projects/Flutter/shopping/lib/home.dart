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
            Container(
              margin: EdgeInsets.all(20.0), // Adjust the margin as needed
              padding:
                  EdgeInsets.all(10.0), // Optional: Adjust padding if needed
              decoration: BoxDecoration(
                color: Colors.blue, // Background color
                borderRadius:
                    BorderRadius.circular(8.0), // Optional: Rounded corners
              ),
              child: Image.asset(
                'assets/16.jpg',
                fit: BoxFit.cover,
              )
            ),
            Row(
              children: [
                Expanded(
                  flex: 1,
                  child: Container(
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(10),
                    decoration: BoxDecoration(
                      color: Colors.blueGrey,
                      borderRadius: BorderRadius.circular(
                          15.0), // Adjust the radius as needed
                    ),
                    child: Text(
                      "One1",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 20.0, // Adjust the font size as needed
                      ),
                    ),
                  ),
                ),
                Expanded(
                  flex: 1,
                  child: Container(
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(10),
                    decoration: BoxDecoration(
                      color: Colors.blueGrey,
                      borderRadius: BorderRadius.circular(
                          15.0), // Adjust the radius as needed
                    ),
                    child: Text(
                      "One1",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 20.0, // Adjust the font size as needed
                      ),
                    ),
                  ),
                ),
              ],
            ),
            Row(
              children: [
                Expanded(
                  flex: 1,
                  child: Container(
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(10),
                    decoration: BoxDecoration(
                      color: Colors.blueGrey,
                      borderRadius: BorderRadius.circular(
                          15.0), // Adjust the radius as needed
                    ),
                    child: Text(
                      "One1",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 20.0, // Adjust the font size as needed
                      ),
                    ),
                  ),
                ),
                Expanded(
                  flex: 1,
                  child: Container(
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(10),
                    decoration: BoxDecoration(
                      color: Colors.blueGrey,
                      borderRadius: BorderRadius.circular(
                          15.0), // Adjust the radius as needed
                    ),
                    child: Text(
                      "One1",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 20.0, // Adjust the font size as needed
                      ),
                    ),
                  ),
                ),
              ],
            ),
             Row(
              children: [
                Expanded(
                  flex: 1,
                  child: Container(
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(10),
                    decoration: BoxDecoration(
                      color: Colors.blueGrey,
                      borderRadius: BorderRadius.circular(
                          15.0), // Adjust the radius as needed
                    ),
                    child: Text(
                      "One1",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 20.0, // Adjust the font size as needed
                      ),
                    ),
                  ),
                ),
                Expanded(
                  flex: 1,
                  child: Container(
                    padding: EdgeInsets.all(40),
                    margin: EdgeInsets.all(10),
                    decoration: BoxDecoration(
                      color: Colors.blueGrey,
                      borderRadius: BorderRadius.circular(
                          15.0), // Adjust the radius as needed
                    ),
                    child: Text(
                      "One1",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 20.0, // Adjust the font size as needed
                      ),
                    ),
                  ),
                ),
              ],
            ),
           
          ],
        ));
  }
}
