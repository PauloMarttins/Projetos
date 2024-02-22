

namespace EnumeracoesCalculoFuncionario.Entities.Enums
{

    //WorkerLevel não é uma classe, é um Enum que deriva do tipo int.
    // ( : int) significa ( Deriva do tipo int)
    enum WorkerLevel : int
    {
        //valores e suas posiçoes
        //Para evitar erros, nao foi escrito utilizando PascalCase. Foi utilizado a ferramenta ToUpper. por isso, todas as referencias estão em caixa alta.
        JUNIOR = 0,
        PLENO = 1,
        SENIOR = 2,
    }
}
