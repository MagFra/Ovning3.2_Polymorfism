namespace Ovning3._2_Polymorfism
{
    internal class TextInputError : UserError
    {
        public TextInputError()
        {
        }

        internal override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}