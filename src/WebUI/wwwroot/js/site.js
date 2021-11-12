// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function RefreshPageEveryFiveSeconds()
{
    var timeout = 5 * 1000;
    setTimeout(function () { location.reload(true); }, timeout);
}
