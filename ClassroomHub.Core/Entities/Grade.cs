namespace ClassroomHub.Core.Entities
{
    public class Grade : EntityBase
    {
        public Delivery DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        public int GradeValue { get; set; }
    }
}
