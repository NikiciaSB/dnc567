// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var userCount = 0;
function changeUser(id){
    userCount ++
    console.log("What What", userCount);
    if(userCount % 2 === 1){
        document.getElementById('user-button').value = "Register as a Student";
        document.getElementById('student').style.display = 'none';
        document.getElementById('instructor').style.display = 'block';
    }
    if(userCount % 2 === 0){
        document.getElementById('user-button').value = "Register as an Instructor";
        document.getElementById('student').style.display = 'block';
        document.getElementById('instructor').style.display = 'none';
    }
}