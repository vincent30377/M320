using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class History
    {
        Stack<EditorState> HistoryStack = new Stack<EditorState>();

        public EditorState Pop()
        {
            return HistoryStack.Pop();
        }
        public void Push(EditorState state)
        {
            HistoryStack.Push(state);
        }
    }
}
