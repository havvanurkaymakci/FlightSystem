// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.onload = function() {
    var resim = document.getElementById("resim");
    var overlaydiv = document.querySelector(".overlay-div");

    var resimGenislik = resim.width;
    var resimYukseklik = resim.height;

    overlaydiv.style.height = resimYukseklik + "px";
};