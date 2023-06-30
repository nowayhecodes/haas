using System;

namespace Haas.Token
{
    class Token
    {
        private TokenType tokenType;
        private string? lexeme;
        private object? literal;
        private int line;

        Token(TokenType tokenType, string lexeme, object literal, int line)
        {
            this.tokenType = tokenType;
            this.lexeme = lexeme;
            this.literal = literal;
            this.line = line;
        }

        public string toString()
        {
            return $"{tokenType} {lexeme} {literal}";
        }

    }
}