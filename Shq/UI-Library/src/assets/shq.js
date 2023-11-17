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

    var shqElement = document.querySelector("#shq");
    var shqPopoverElement = document.querySelector("#shq-popover");

    (function setup() {
        shqPopoverElement.style.transition = "opacity 0.25s linear";

        shqElement.addEventListener("click", function(_){
            shqPopoverElement.style.display = "block";
            setTimeout(function () {
                shqPopoverElement.style.opacity = "1";
            }, 200);
        });
        shqPopoverElement.addEventListener("click", function(event){
            if(event.target.id === "shq-popover"){
                shqPopoverElement.style.opacity = "0";
                setTimeout(function() {
                    shqPopoverElement.style.display = "none";
                }, 200);
            }
        })
    })();

    return function () {
        return { };
    }();
}();