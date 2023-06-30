using System;

namespace Haas.Token
{
    enum TokenType
    {
        /// Single-char tokens
        LEFT_PAREN, RIGHT_PAREN, LEFT_BRACE, RIGHT_BRACE,
        COMMA, DOT, MINUS, PLUS, SEMICOLON, SLASH, STAR,
        COLON, DOUBLE_COLON,


        /// One or two chars tokens
        BANG, BANG_EQUAL, EQUAL, DOUBLE_EQUAL, GREATER,
        GREATER_EQUAL, LESS, LESS_EQUAL,

        /// Literals
        IDENTIFIER, STRING, NUMBER,

        /// Keywords
        AND, CLASS, ELSE, FALSE, FUN, FOR, IF, NIL, OR,
        PRINT, RETURN, SELF, PARENT, TRUE, VAL, VAR, WHILE,

        EOF
    }
}