array = [
    {
        nome: "porra",
        media: 7,
        turma: "ryr"
    },
    {
        nome: "porra2",
        media: 72,
        turma: "ryr2"
    },

];


function alunosAprovados(alunos, mediaFinal) {
    let aprovados = [];
    for (let i = 0; i < alunos.length; i++) {

        const { media: nota, nome } = alunos[i]; // destructuring
        if (nota >= mediaFinal)
            aprovados.push(nome);
    }
    return console.log(aprovados);
};

alunosAprovados(array, 8);





const obj1 = {
    nome: "cacete",
    idade: 2
};

const obj2 = {
    nome: "amante giletão",
    idade: 32
};

function calculaIdade(anos) {
    return `daqui a ${anos} anos, ${this.nome} terá ${this.idade + anos} anos de idade`;
}

console.log(calculaIdade.call(obj2, 3));
console.log(calculaIdade.apply(obj2, [3]));

//tratamento de exceções

function verificaPalavra(string) {
    if (!string) throw "leitada master";

    return "lula 2022";
}



function verPalavra(string) {
    try {
        verificaPalavra();
    }
    catch (e) {
        // console.log(e);
        throw e;
    }
}

verPalavra();

const megaErro = new Error('super problema sério mêo');
megaErro.name = "superErro";

throw megaErro;

