namespace BlazorApp_StandAntiquariato.Models
{
	public class Oggetto
	{
        public int idOggetto { get; set; }
        public string? tipo { get; set; }
        public string? materialePrincipale { get; set; }
        public string? epoca { get; set; }
        public decimal prezzoEsposto { get; set; }
        public int standId { get; set; }
        public string? percorsoImmagine { get; set; }
    }
}
