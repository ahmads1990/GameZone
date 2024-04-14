namespace GameZone.ViewModels;

public class CreateGameFormViewModel : GameFormViewModel
{
    public IFormFile Cover { get; set; } = default!;
}
