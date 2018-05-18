namespace ExampleWpfLibrary
{
    /// <summary>
    /// The simplest inheritdoc use-case I could come up with.
    /// </summary>
    public class BasicObject {
        /// <inheritdoc cref="System.Object.ToString" />
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
