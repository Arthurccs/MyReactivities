
namespace Domain
{

    /// <summary>
    /// Class for entity Activity
    /// </summary>
    public  class Activity
    {
        /// <summary>
        /// unique Id of the activity
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Title of the activity
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Date of the activity
        /// </summary>
        public DateTime DAte { get; set; }

        /// <summary>
        /// Description of the activity
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Category of the activity
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// City of the activity
        /// </summary>
        public string City { get; set; }


        /// <summary>
        /// Venue of the activity
        /// </summary>
        public string Venue { get; set; }
    }
}
