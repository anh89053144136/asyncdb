namespace Transcrypt.Domain.Entities
{
    public class Configuration
    {
        public virtual string Name { get; set; }
        
        public virtual string Value { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Configuration;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return this.Name == other.Name &&
                this.Value == other.Value;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ Name.GetHashCode();
                hash = (hash * 31) ^ Value.GetHashCode();

                return hash;
            }
        }
    }
}
