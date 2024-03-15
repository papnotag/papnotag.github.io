function changeBG() {
    let rgb_possibilities = "0123456789ABCDEF"
    let rgb = "#";
    for(let i = 0; i < 6; i++) {
        rgb += rgb_possibilities[Math.floor(Math.random() * rgb_possibilities.length)];
    }
    document.body.style.backgroundColor = rgb;
    document.getElementById("rgb-info").innerHTML = rgb
}