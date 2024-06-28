import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:curd/firestore.dart';
import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  FirestoreServices _firestoreServices = FirestoreServices();
  final TextEditingController _textEditingController = TextEditingController();
  Map<int, bool> hoverMap = {};

  void openNoteBox() {
    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        content: TextField(
          controller: _textEditingController,
        ),
        actions: [
          ElevatedButton(
            onPressed: () {
              _firestoreServices.addNote(_textEditingController.text);
              _textEditingController.clear();
              Navigator.pop(context);
            },
            child: Text("Add"),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: const Color.fromARGB(255, 128, 143, 228),
        title: Text("Your Cart"),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: openNoteBox,
        child: Icon(Icons.add),
      ),
      body: StreamBuilder<QuerySnapshot>(
        stream: _firestoreServices.getData(),
        builder: (context, snapshot) {
          if (snapshot.hasData) {
            List<DocumentSnapshot> dataList = snapshot.data!.docs;
            return GridView.builder(
              gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                crossAxisCount: 4, // Number of columns in the grid
                crossAxisSpacing: 8.0, // Spacing between columns
                mainAxisSpacing: 8.0, // Spacing between rows
              ),
              padding: const EdgeInsets.all(8.0),
              itemCount: dataList.length,
              itemBuilder: (context, index) {
                DocumentSnapshot document = dataList[index];
                String docId = document.id;
                Map<String, dynamic> data =
                    document.data() as Map<String, dynamic>;
                String dataText = data['note'];

                return MouseRegion(
                  onEnter: (event) {
                    setState(() {
                      hoverMap[index] = true;
                    });
                  },
                  onExit: (event) {
                    setState(() {
                      hoverMap[index] = false;
                    });
                  },
                  child: AnimatedContainer(
                    duration: Duration(milliseconds: 300), // Smooth transition duration
                    decoration: BoxDecoration(
                      color: hoverMap[index] == true
                          ? Colors.blueAccent
                          : Colors.lightBlueAccent,
                      borderRadius: BorderRadius.circular(15.0),
                    ),
                    child: Center(
                      child: Padding(
                        padding: const EdgeInsets.all(16.0),
                        child: Text(
                          dataText,
                          textAlign: TextAlign.center,
                          style: TextStyle(fontSize: 16.0),
                        ),
                      ),
                    ),
                  ),
                );
              },
            );
          } else {
            return Center(child: Text("No Data"));
          }
        },
      ),
    );
  }
}