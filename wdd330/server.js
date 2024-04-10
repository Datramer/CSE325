const express = require("express");
const app = express();
const mongoose = require("mongoose");
const bodyParser = require("body-parser");

app.use(express.static(__dirname + '/public'));

app.use(bodyParser.urlencoded({extended: true}));

mongoose.connect("mongodb+srv://Datramer:Goober1234!!@cluster0.dfekkct.mongodb.net/Books", {useNewUrlParser: true},{useUnifiedTopology: true})
//                mongodb+srv://Datramer:Goober1234!!@cluster0.dfekkct.mongodb.net/Books

const booksSchema = {
    title: String,
    rating: String
}

const Book = mongoose.model("Book", booksSchema)

app.get("/", function(req, res) {
    res.sendFile(__dirname+ "/index.html")
})

app.post("/", function(req, res) {
    let NewBook = new Book({
        title: req.body.title,
        rating: req.body.rating
    })
    NewBook.save();
    res/redirect('/');
})

app.listen(3000, function() {
    console.log("running on 3000");
})