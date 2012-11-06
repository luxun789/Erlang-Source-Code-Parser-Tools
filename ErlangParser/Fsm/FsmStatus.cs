namespace ErlangParserLib.Fsm
{
    /// <summary>
    /// Erlang语法解析FSM状态
    /// </summary>
    public enum FsmStatus
    {
        /// <summary>
        /// 初始值, 或无状态(仅在包模式下可用)
        /// </summary>
        FSM_PACKAGE = 0,

        /// <summary>
        /// 在文件中(解析文件时的初始值)
        /// </summary>
        FSM_FILE = 1,

        /// <summary>
        /// 在注释中
        /// </summary>
        FSM_COMMENT = 2,

        /// <summary>
        /// 在声明中
        /// </summary>
        FSM_STATEMENT = 3,

        /// <summary>
        /// 在字符串中
        /// </summary>
        FSM_STRING = 4,

        /// <summary>
        /// 在列表中
        /// </summary>
        FSM_LIST = 5,

        /// <summary>
        /// 在元子中
        /// </summary>
        FSM_Atom = 6,

        /// <summary>
        /// 在元组中
        /// </summary>
        FSM_TUPLE = 7,

        /// <summary>
        /// 宏定义
        /// </summary>
        FSM_MACRO = 8,

        /// <summary>
        /// 在宏变量中
        /// </summary>
        FSM_MACROVARIABLES = 9,

        /// <summary>
        /// 在函数中
        /// </summary>
        FSM_FUNCTION = 10,

        /// <summary>
        /// 函数调用
        /// </summary>
        FSM_FUNCTION_CALL= 11,

        /// <summary>
        /// 末定义段.(暂时没有用)
        /// </summary>
        FSM_UNDEFINE = 32768
    }
}
