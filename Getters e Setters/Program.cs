using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //CON GETTERS E SETTERS POSSO FARE CONTROLLI AGGIUNTIVI
            Persona persona1 = new Persona("Angelo", "Dalo", 23);

            //SENZA GETTERS E SETTERS CON PUBLIC
            //Console.WriteLine(persona1.nome); //GET
            //persona1.nome = "io"; con public posso farlo

            //PRIMO METODO
            //persona1.SetNome("Luca"); //SET
            //Console.WriteLine(persona1.GetNome());

            //SECONDO METODO E TERZO METODO
            persona1.Nome = "Anna";
            Console.WriteLine(persona1.Nome);
        }
    }

    class Persona
    {
        private string nome; //proprietà
        public string cognome;
        public int eta;

        //3 METODO
        public string Nome { get; set; }

        //2 METODO
        //public string Nome
        //{
        //    get => this.nome;
        //    set => this.nome = value;
        //}

        //PRIMO METODO
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        //COSTRUTTORE
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }
    }
}

