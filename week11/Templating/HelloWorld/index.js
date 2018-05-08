const express = require('express');
const app = express();
const port = 3000;

app.set('view engine', 'ejs');

app.get('/', function(req, res) {
    res.render('home', { title: 'Hello World' });
});

app.get('/contacts/:name', function(req, res) {
    const name = req.params.name;

    if (name === 'mj') {
        res.render('contact', {
            name: 'Michael Jordan',
            age: 55,
            height: 198,
            contacts: ['twitter: @mj', 'instagram: official_michael_jordan', 'linkedin: arguably_the_greatest_player_ever_aka_mj']
        });
    } else if (name === 'lj') {
        res.render('contact', {
            name: 'LeBron James',
            age: 33,
            height: 203,
            contacts: ['twitter: @lj', 'instagram: official_lebron_james', 'linkedin: arguably_the_greatest_player_ever_aka_lj']
        });
    } else {
        res.status(404).send('Not Found... Only the arguably best players can be contacted!');
    }
});

app.listen(port, function() {
    console.log(`Listening on port ${port}`);
});
