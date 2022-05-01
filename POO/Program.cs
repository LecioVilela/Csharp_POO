using POO;

var professor = new Professor(5000m, "Lecio", "12345", new DateTime(1989, 03, 22));
var estudante = new Estudante("A", "Daniela", "54321", new DateTime(1986, 03, 24));

var pessoas = new List<Pessoa> {estudante, professor};

foreach (var pessoa in pessoas) {
    pessoa.SeApresentar();
}

Console.ReadKey();