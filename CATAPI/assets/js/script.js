const BASE_URL = "https://api.thecatapi.com/v1/images/search";
const btnCat = document.getElementById('button');

async function loadCat() {


    try {
        const data = await fetch(BASE_URL);
        const json = await data.json();
        let url2 = json[0].url;
        document.getElementById("img_gato").src = url2;

    } catch (error) {
        console.log(error.message);
    }


};


const loadImg = async () => {

    try {
        const data = await fetch(BASE_URL);
        const json = await data.json();
        let url2 = json[0].url;
        document.getElementById("img_gato").src = url2;


    } catch (error) {
        console.log(error.message);
    }

}

if (btnCat)
    btnCat.addEventListener('click', loadCat);


loadImg();