using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class EditorState
    {
        public string Content { get; }
        public string Title { get; }
        public EditorState(string content, string title)
        {
            Content = content;
            Title = title;
        }
    }
}
