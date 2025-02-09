namespace CoreEntities.Concrete
{
    public class Reaction : BaseEntity
    {
        public int Views { get; set; } //görüntülenme
        public string Comment { get; set; } // aslında burda yorum değil geri dönüş şekli. 
        public string CommentType  { get; set; } //resim,yazı,video,görsel? bu enum olsun. 
        public int PlatformId { get; set; } //aslında platformda enum olsa olur.
        public Platform Platform { get; set; }
    }
}
