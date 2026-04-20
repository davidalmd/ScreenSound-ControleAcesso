using ScreenSound.Modelos;

namespace ScreenSound.Shared.Modelos.Modelos;

public class AvaliacaoArtista(int artistaId, int pessoaId, int nota)
{
    public int ArtistaId { get; set; } = artistaId;
    public virtual Artista? Artista { get; set; }
    public int PessoaId { get; set; } = pessoaId;
    public int Nota { get; set; } = nota;
}
