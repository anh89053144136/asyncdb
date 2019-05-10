namespace Transcrypt.Domain.Entities
{
    public class Setting
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Value { get; set; }
    }
}