var express = require('express');
var bodyParser = require('body-parser');
var app = express();
var urlencodedParser = bodyParser.urlencoded({ extended: false });

app.use('/assets', express.static('assets'));

app.get('/', function(req, res) {
    res.sendFile(__dirname + '/index.html');
});

app.get('/doubling', function(req, res) {
    const userInput = req.query.input;

    if (userInput === undefined || userInput == null) {
        const errorObject = { "error": "Please provide an input!" };
        res.send(JSON.stringify(errorObject));
    } else {
        const resultObject = { "received": Number(userInput), "result": userInput * 2 };
        res.send(JSON.stringify(resultObject));
    }
});

app.get('/greeter', function(req, res) {
    const name = req.query.name;
    const title = req.query.title;

    if (name === undefined || name === null) {
        const errorObject = { "error": "Please provide a name!" };
        res.json(errorObject);
    } else if (title === undefined || title === null) {
        const errorObject = { "error": "Please provide a title!" };
        res.json(errorObject);
    } else {
        const welcomeMessage = { "welcome_message": `Oh, hi there ${name}, my dear ${title}!` };
        res.json(welcomeMessage);
    }
});

app.get('/appenda', function(req, res) {
    res.sendStatus(404).send('404 - Not Found');
});

app.get('/appenda/:appendable', function(req, res) {
    const appendable = req.params.appendable;
    res.json({ "appended": appendable + 'a' });
});

app.listen(8080, function() { console.log('Frontend Exercise listening on port number 8080.')});
