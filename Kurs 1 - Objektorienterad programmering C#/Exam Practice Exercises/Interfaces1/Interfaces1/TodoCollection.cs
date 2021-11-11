using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class TodoCollection : Interface1, Interface2
    {
        private List<Todo> _todos;

        public TodoCollection()
        {
            _todos = new List<Todo>();
        }

        public void CreateTodo(string text)
        {
            Todo todo = new Todo()
            {
                Text = text
            };
            _todos.Add(todo);
        }

        public List<Todo> ListTodos(bool isDone)
        {
            List<Todo> result = new List<Todo>();
            foreach (Todo todo in _todos)
            {
                if (todo.IsDone == isDone)
                {
                    result.Add(todo);
                }
            }
            return result;
        }
    }
}
