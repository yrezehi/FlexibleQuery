/*
    search item specification

    {
        id: identifier,
        title: name 
        link: url
    }

*/

var shq = function () {
    var history = [];

    (function setup() {
        document.querySelector("#shq").addEventListener("click", function(_){
            var popoverElement = document.querySelector("#shq-popover");
            popoverElement.style.display = "block";
            popoverElement.style.transition = "opacity 0.1s linear";

            setInterval(function () {
                popoverElement.style.opacity = "1";
            }, 200);
        });
    })();

    return function () {
        return { };
    }();
}();