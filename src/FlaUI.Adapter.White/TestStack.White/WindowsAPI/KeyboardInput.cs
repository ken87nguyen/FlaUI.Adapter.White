using FlaUI.Core.WindowsAPI;

namespace TestStack.White.WindowsAPI
{
    public static class KeyboardInput
    {
        public enum SpecialKeys
        {
            END = VirtualKeyShort.END,
            HOME = VirtualKeyShort.HOME,
            DELETE = VirtualKeyShort.DELETE,
            BACKSPACE = VirtualKeyShort.BACK,
            TAB = VirtualKeyShort.TAB,
            DOWN = VirtualKeyShort.DOWN,
            RETURN = VirtualKeyShort.RETURN,
            RIGHT = VirtualKeyShort.RIGHT,
            ESCAPE = VirtualKeyShort.ESCAPE,
            CONTROL = VirtualKeyShort.CONTROL,
            SHIFT = VirtualKeyShort.SHIFT,
            UP = VirtualKeyShort.UP
        }
    }
}
