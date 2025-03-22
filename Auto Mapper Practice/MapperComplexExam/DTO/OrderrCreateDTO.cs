using System.ComponentModel.DataAnnotations;

namespace Auto_Mapper_Practice.MapperComplexExam.DTO
{
    public class OrderrCreateDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public List<OrderItemCreateDTO> Items { get; set; }
    }
}
