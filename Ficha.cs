namespace RPG_Site
{
    public class Ficha
    {
        // CAPA
        public string NomeJogador { get; set; }
        public string Nome { get; set; }
        public string FotoBase64 { get; set; } // Foto opcional

        public string Classe { get; set; } = "";
        public string Subclasse { get; set; } = "";
        public int Nivel { get; set; }
        public string Raca { get; set; } = "";
        public string Antecedente { get; set; } = "";
        public string Tendencia { get; set; } = "";

        // História
        public string Descricao { get; set; }

        // Atributos
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }

        // Perícias / Idiomas / Inventário
        public string Pericias { get; set; }
        public string Idiomas { get; set; }
        public string Itens { get; set; }
        public string Feiticos { get; set; }
    }
}
