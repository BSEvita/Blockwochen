namespace BookStore.Data.Models {
    /// <summary>
    /// Stellt ein Buch in der Datenbank dar.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Die eindeutige ID des Buches.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Der Autor des Buches.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Der Titel des Buches.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Das Jahr der Veröffentlichung des Buches.
        /// </summary>
        public int PublicationYear { get; set; }
        /// <summary>
        /// Gibt an, ob das Buch verfügbar ist.
        /// </summary>
        public bool IsAvailable { get; set; }
        /// <summary>
        /// Die Signatur des Buches.
        /// </summary>
        public string CallNumber { get; set; }
    }
}
/*
   █████████  █████                                              █████████  █████               
  ███░░░░░███░░███                                              ███░░░░░███░░███                
 ░███    ░███ ░███ █████  ██████  █████████████    ██████      ░███    ░███ ░███ █████  ██████  
 ░███████████ ░███░░███  ░░░░░███░░███░░███░░███  ░░░░░███     ░███████████ ░███░░███  ░░░░░███ 
 ░███░░░░░███ ░██████░    ███████ ░███ ░███ ░███   ███████     ░███░░░░░███ ░██████░    ███████ 
 ░███    ░███ ░███░░███  ███░░███ ░███ ░███ ░███  ███░░███     ░███    ░███ ░███░░███  ███░░███ 
 █████   █████████ █████░░█████████████░███ █████░░████████    █████   █████████ █████░░████████
░░░░░   ░░░░░░░░░ ░░░░░  ░░░░░░░░░░░░░ ░░░ ░░░░░  ░░░░░░░░    ░░░░░   ░░░░░░░░░ ░░░░░  ░░░░░░░░ 
                                                                                               
*/