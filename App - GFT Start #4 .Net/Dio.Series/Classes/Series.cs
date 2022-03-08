namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }


    public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano)
    {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = Titulo;
        this.Descricao = Descricao;
        this.Ano = Ano;
        this.Excluido = false;

    }

    public override string ToString()
        {
        string retorno = " ";
        retorno += "Genero: " + this.Genero + Environment.NewLine;
        retorno += "Titulo: " + this.Titulo + Environment.NewLine;
        retorno += "Descricao: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
        retorno += "Excluido:" + this.Excluido + Environment.NewLine;

        return retorno;
        }

    public string retornaTitulo()
    {
        return this.Titulo;
    }

    public int RetornaPorId()
    {
        return this.Id;
    }
    
    public void Excluir()
    {
        this.Excluido = true;
    }
    }
}