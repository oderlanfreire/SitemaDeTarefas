using System.ComponentModel;

namespace SitemaDeTarefas.Enums
{
    public enum StatusTask
    {
        [Description ("To Do")]
        ToDo = 1,
        [Description ("Doing")]
        Doing = 2,
        [Description ("Finished")]
        Finished = 3
    }
}
