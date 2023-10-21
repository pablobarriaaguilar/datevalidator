using System.ComponentModel.DataAnnotations;
public class Rent{
    public string Name { get; set; }

    [DateValid]
    public DateTime Dt { get; set; }


public class DateValid : ValidationAttribute
{    
    // Call upon the protected IsValid method
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)    
    {   
      
        DateTime dat1 = new DateTime();
        dat1 = DateTime.Today;
        if (DateTime.Parse(value.ToString()) > dat1)
        {        
            // we return an error message in ValidationResult we want to render    
            return new ValidationResult("La fecha no puede ser mayor al día de hoy ");   
        } else {   
            // Otherwise, we were successful and can report our success  
            return ValidationResult.Success;  
        }  
    }
}

}
