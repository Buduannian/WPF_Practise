using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Study
{
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// 命令是否能够执行
        /// </summary>
        readonly Func<bool> _canExecute;

        /// <summary>
        /// 命令需要执行的方法
        /// </summary>
        readonly Action _execute;

        public RelayCommand(Action action, Func<bool> canExecute)
        {
            _execute = action;
            _canExecute = canExecute;
        }

        // =========== 接着你截图里的代码继续补充 ===========

        /// <summary>
        /// 判断命令是否可以执行
        /// </summary>
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }

            // 补充截图里没写完的部分：调用委托并返回结果
            return _canExecute();
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        public void Execute(object parameter)
        {
            // 直接执行传入的委托
            _execute();
        }

        /// <summary>
        /// 命令状态改变事件
        /// 使用 CommandManager.RequerySuggested 可以借助 WPF 框架自动刷新按钮状态
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }

}
