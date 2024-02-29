// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

    function toggleAnswer(answerId) {
        var answer = document.getElementById(answerId);
    if (answer.style.display === 'none' || answer.style.display === '') {
        answer.style.display = 'block';
        } else {
        answer.style.display = 'none';
        }
    }
    
