using System.Drawing;

namespace ConsoleButton
{
    internal class Button
    {
        public string Text { get; internal set; }
        public Point Location { get; internal set; }
        public Size Size { get; internal set; }
        public EventMandler Click { get; internal set; }
    }
}