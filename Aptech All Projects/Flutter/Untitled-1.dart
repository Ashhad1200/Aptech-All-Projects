import 'package:flutter/material.dart';

class homePage extends StatelessWidget {
  const homePage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: Colors.red[300],
        appBar: AppBar(
          title: Text("Welcome to My App"),
          centerTitle: true,
        ),
        floatingActionButton: FloatingActionButton(onPressed: () {}),
        body: Column(
          children: [
            ElevatedButton(
              onPressed: () {},
              child: Text("Tap Here"),
            ),
            Icon(Icons.person),
            ElevatedButton.icon(
                onPressed: () {},
                icon: Icon(Icons.person),
                label: Text("Person")),
            IconButton(
              onPressed: () {},
              icon: Icon(Icons.email),
              color: Colors.amber,
            ),
            GestureDetector(
              child: Container(
                child: Text("Click me"),
              ),
            )
          ],
        )
        Row(
          children: [
            Expanded(
              flex: 1,
              child: Container(
                child: Text("One"),
                color: Colors.amber,
                padding: EdgeInsets.all(25),
                // width: 40,
                // height: 40,
              ),
            ),
            Expanded(
              flex: 3,
              child: Container(
                child: Text("Two"),
                color: Colors.red,
                padding: EdgeInsets.all(25),
                // width: 40,
                // height: 40,
              ),
            ),
            Expanded(
              child: Container(
                child: Text("Three"),
                color: Colors.green,
                padding: EdgeInsets.all(25),
                // width: 40,
                // height: 40,
              ),
            )
          ],
        ),

        // Column(
        //   mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        //   crossAxisAlignment: CrossAxisAlignment.stretch,
        //   children: [
        //     Text("data 1"),
        //     Text("data 2"),
        //     Image(image: AssetImage("assets/image.jpg")),
        //   ],
        // ),

        //     // Text("This is body section"),
        //     //   Padding(
        //     // padding: const EdgeInsets.all(40.0),
        //     // child: Container(
        //     //   child: Text("This is container"),
        //     Column(
        //   children: [
        //     // Container(
        //     //   child: Text("This container "),
        //     // ),
        //     Text(
        //       "This is simple ",
        //       style: TextStyle(
        //           color: Colors.red, fontSize: 25, letterSpacing: 2.0),
        //     ),

        //     ElevatedButton(onPressed: () {}, child: Text("Tap me")),
        //     Image(
        //         image: NetworkImage(
        //             "https://img.freepik.com/free-photo/wide-angle-shot-single-tree-growing-clouded-sky-during-sunset-surrounded-by-grass_181624-22807.jpg")),
        //     Image(image: AssetImage("assets/image.jpg")),
        //     Image(image: AssetImage("assets/image2.jpg"))
        //   ],
        // )
        );
  }
}
