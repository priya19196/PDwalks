namespace PDwalks.API.Domain
{
    public class Region
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public long Population { get; set; }

        //navition property
        public IEnumerable<Walk> Walks { get; set; }


    }
}
