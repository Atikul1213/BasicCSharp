using System.ComponentModel.DataAnnotations;

namespace Auto_Mapper_Practice.MapperComplexExam.DTO
{
    public class OrderItemCreateDTO
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
