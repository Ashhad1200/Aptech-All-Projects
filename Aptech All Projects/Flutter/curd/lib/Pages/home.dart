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

                return HoverCard(
                  dataText: dataText,
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

class HoverCard extends StatefulWidget {
  final String dataText;

  HoverCard({required this.dataText});

  @override
  _HoverCardState createState() => _HoverCardState();
}

class _HoverCardState extends State<HoverCard> {
  bool _isHovered = false;

  @override
  Widget build(BuildContext context) {
    return InkWell(
      onTap: () {
        // You can add actions on tap if needed
      },
      onHover: (hovering) {
        setState(() {
          _isHovered = hovering;
        });
      },
      child: IntrinsicHeight(
        child: Card(
          color: _isHovered ? const Color.fromARGB(255, 114, 157, 233) : Colors.lightBlueAccent,
          elevation: 4.0,
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(15.0),
          ),
          child: Center(
            child: Padding(
              padding: const EdgeInsets.all(16.0),
              child: Text(
                widget.dataText,
                textAlign: TextAlign.center,
                style: TextStyle(fontSize: 16.0),
              ),
            ),
          ),
        ),
      ),
    );
  }
}