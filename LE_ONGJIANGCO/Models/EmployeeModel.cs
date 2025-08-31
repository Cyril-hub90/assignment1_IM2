using System.ComponentModel.DataAnnotations;

public class EmployeeModel
{
    public int EmpId { get; set; }

    [Required(ErrorMessage = "Full Name is required.")]
    [MinLength(8, ErrorMessage = "Full Name must be at least 8 characters.")]
    public string EmpFullname { get; set; }

    [Required(ErrorMessage = "Address is required.")]
    [MaxLength(30, ErrorMessage = "Address cannot exceed 30 characters.")]
    public string EmpAddr { get; set; }

    [Required(ErrorMessage = "Contact Number is required.")]
    [MinLength(11, ErrorMessage = "Contact Number cannot exceed 11 characters.")]
    public string EmpContact { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [DataType(DataType.EmailAddress)]
    public string EmpEmail { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string EmpPwd { get; set; }
}
