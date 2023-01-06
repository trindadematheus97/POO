using POO;

var professor = new Professor("João", "1234", new DateTime(1980, 1, 1), 5000);
var estudante = new Estudante("A", "Marcio", "231232", new DateTime(2002, 2, 3));

var pessoas = new List<Pessoa> { estudante, professor };

foreach (var pessoa in pessoas)
{
    pessoa.SeApresentar();
}
