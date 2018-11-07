'use strict';
console.log('created');
var shouldPlay = true;
function play() {
    if (shouldPlay) {
        var audio = new Audio('../music/theme.wav');
        audio.play();
        setInterval(() => {
            audio.play();
        }, 16100);
    }
    shouldPlay = false;
}





