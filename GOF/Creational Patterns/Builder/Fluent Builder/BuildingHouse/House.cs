namespace BuildingHouse
{
    public class House
    {
        public string Foundation { get; private set; }
        public string Structure { get; private set; }
        public string Roof { get; private set; }
        public bool IsPainted { get; private set; }

        public void SetFoundation(string foundation)
        {
            this.Foundation = foundation;
        }

        public void SetStructure(string structure)
        {
            this.Structure = structure;
        }

        public void SetRoof(string roof)
        {
            this.Roof = roof;
        }

        public void SetPaintedTo(bool isPainted)
        {
            this.IsPainted = isPainted;
        }
    }
}