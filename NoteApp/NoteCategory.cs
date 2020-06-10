namespace NoteApp
{   
    /// <summary>
    /// Перечисление. Категория заметки.
    /// </summary>
    public enum NoteCategory
    {
        //TODO: Этого значения в перечислении быть не должно. Заметка может быть только конкретного типа, и не может быть "All".
        ////Но в интерфейсе главного окна в комбобоксе должен быть пункт All, чтобы пользователь мог просмотреть заметки ЛЮБОЙ категории
        Work,
        Home,
        HealthAndSport,
        People,
        Documents,
        Finance,
        Other
    }
}
    
