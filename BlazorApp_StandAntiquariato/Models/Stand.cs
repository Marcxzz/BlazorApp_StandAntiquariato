namespace BlazorApp_StandAntiquariato.Models
{
	public class Stand
	{
        public int IdStand { get; set; }
        public char ZonaEsposizione { get; set; }
        public int Superficie { get; set; }
        public string? NomeAntiquario { get; set; }
        public string? CognomeAntiquario { get; set; }
        public bool Coperto { get; set; }
        public DateTime DataInizio { get; set; }
    }
}
