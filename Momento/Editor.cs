using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class Editor
    {
        public string Content { get; set; }
        public string Title { get; set; }
        public EditorState CreateState()
        {
            return new EditorState(Content, Title);
        }
        public void Do()
        {
            EditorState state = CreateState();
        }
        public void Restore(EditorState state)
        {
            //TODO
        }
        public void ShowContent()
        {
            //TODO
        }
        public void Undo()
        {
            //TODO
        }
    }
}
