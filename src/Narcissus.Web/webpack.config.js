/// <binding />
const path = require('path');

module.exports = {
    entry: './wwwroot/typescript/main.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/js'),
        filename: 'bundle.js'
    }
};