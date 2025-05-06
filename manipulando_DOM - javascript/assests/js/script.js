var Mode = 'L';
const button = document.getElementsByClassName('button-class');
const bodyStyle = document.body.style;
const h1 = document.getElementById('text_mode');

button[0].addEventListener('click', clicou);


function clicou() {
    if (Mode === 'D') {
        document.body.style.backgroundColor = "rgb(228, 223, 223)";
        document.body.style.color = "white";
        h1.innerHTML = "Dark Mode On";
        button[0].innerHTML = "light mode"
        Mode = 'L';
    }
    else {
        document.body.style.backgroundColor = "white";
        document.body.style.color = "black";
        h1.innerHTML = "Light Mode On";
        button[0].innerHTML = "dark mode"
        Mode = 'D';
    }

}
