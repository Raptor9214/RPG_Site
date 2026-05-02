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

<<<<<<< HEAD
        // História
        public string Descricao { get; set; }
=======
        // Características físicas
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string Olhos { get; set; }
        public string Cabelo { get; set; }
        public string Pele { get; set; }

        // História
        public string Historia { get; set; }
>>>>>>> a59d502b9c745141785b856f3c97f11d1f6c2637

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
<<<<<<< HEAD
        public string Itens { get; set; }
        public string Feiticos { get; set; }
=======
        public string Inventario { get; set; }
>>>>>>> a59d502b9c745141785b856f3c97f11d1f6c2637
    }
}
