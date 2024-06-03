// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const { Button } = require("../lib/bootstrap/dist/js/bootstrap.esm");

// Write your JavaScript code.

function showMessage(message) {
    if (message) {
        alert(message);
        window.location.href = '/';
    }
}
function redirectPage(url) {
    window.open(url, '_blank');
}